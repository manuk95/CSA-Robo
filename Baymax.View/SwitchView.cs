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
    public partial class SwitchView : UserControl
    {
        private bool switchState;
        private Switch _switch;

        public SwitchView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return this.switchState;
            }
            set
            {
                this.switchState = value;
                this.switchImage.Image = value ? Resource.SwitchOn: Resource.SwitchOff;
            }
        }

        public Switch Switch
        {
            get
            {
                return this._switch;
            }
            set
            {
                this._switch = value;
                if (this._switch == null)
                {
                    return;
                }
                this._switch.SwitchStateChanged += this.OnSwitchStateChanged;
            }
        }

        private void OnSwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(OnSwitchStateChanged), sender, e);
            }
            else
            {
                this.State = e.SwitchEnabled;
            }
        }
    }
    
}