using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Baymax.Control;

namespace Baymax.View
{
    public partial class LedView : UserControl
    {
        private bool state;
        private Led led;

        public LedView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                this.ledImage.Image = value ? Resource.LedOn : Resource.LedOff;
            }
        }

        public Led Led
        {
            get
            {
                return this.led;
            }
            set
            {
                if (this.led != null)
                {
                    this.led.LedStateChanged -= this.LedsStateChanged;
                }

                this.led = value;

                if (this.led == null)
                {
                    return;
                }

                this.led.LedStateChanged += this.LedsStateChanged;
            }
        }

        private void LedsStateChanged(object sender, LedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new EventHandler<LedEventArgs>(LedsStateChanged), sender, e);
            }
            else
            {
                this.State = e.LedEnabled;
            }
        }
    }
}