﻿//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: DigitalIn.cs 1024 2016-10-11 12:06:49Z chj-hslu $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Baymax.Control
{

    /// <summary>
    /// Mit Hilfe diese Klasse kann auf die 4 Eingänge (Schalter) des Roboters zugegeriffen werden.
    /// </summary>
    public class DigitalIn : IDisposable
    {
        #region members
        private Thread thread;
        private bool disposed;
        private bool run;
        public event EventHandler DigitalInChanged;
        #endregion


        #region constructor & destructor
        /// <summary>
        /// Initialisiert den DigitalIn.
        /// </summary>
        /// <param name="port">der IO-Port für den Zugriff auf die Eingänge</param>
        public DigitalIn(int port)
        {
            Port = port;
            disposed = false;

            this.thread = new Thread(Run);
            this.thread.IsBackground = true;
            this.thread.Start();
        }


        /// <summary>
        /// Stoppt den Polling-Thread
        /// </summary>
        public void Dispose()
        {
            if (!disposed)
            {
                run = false;
                thread.Join();
                disposed = true;
            }
        }
        #endregion


        #region properties
        /// <summary>
        /// Liefert bzw. setzt den IO-Port für den Zugriff auf die Eingänge des Roboters.
        /// </summary>
        public int Port { get; set; }


        /// <summary>
        /// Liest Daten vom IO-Port. Es können keine Daten geschrieben werden!
        /// </summary>
        public int Data
        {
            get { return IOPort.Read(this.Port); }
        }
        #endregion


        #region methods
        /// <summary>
        /// Erzeugt das DigitalInChanged Event.
        /// </summary>
        /// <param name="e"></param>
        protected void OnDigitalInChanged(EventArgs e)
        {
            if (DigitalInChanged != null)
            {
                DigitalInChanged(this, e);
            }
        }


        /// <summary>
        /// Bietet Zugriff auf die einzelnen Eingänge per Index
        /// </summary>
        /// <param name="bit">das gewünschte Bit [0..3]</param>
        /// <returns>den Zustand des entsprechenden Input-Bits.</returns>
        public virtual bool this[int bit]
        {
            get { return System.Convert.ToBoolean((this.Data & (1 << bit)) >> bit); }
        }

        /// <summary>
        /// Thread um die Eingänge periodisch abzufragen. Der Roboter kann leider keine Interrupts
        /// generieren, falls ein Schalter betätigt wird. Somit muss gepollt werden.
        /// </summary>
        private void Run()
        {
            int oldData = -1;
            int newData;
            run = true;
            while (run)
            {
                // Todo: Port des Roboters pollen.
                // Falls eine Änderung detektiert wird, das Event DigitalInChanged feuern.

                newData = this.Data;

                if (newData != oldData)
                {
                    oldData = newData;
                    
                    this.OnDigitalInChanged(EventArgs.Empty);
                }

                Thread.Sleep(50);
            }
        }
        #endregion
    }
}