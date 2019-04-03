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
    public partial class ConsoleView : UserControl
    {
        private RobotConsole console;

        public ConsoleView()
        {
            InitializeComponent();
        }

        public RobotConsole Console
        {
            get
            {
                return this.console;
            }
            set
            {
                this.console = value;

                if (this.console == null)
                {
                    return;
                }
                this.ledView1.Led = this.console[Leds.Led1];
                this.ledView2.Led = this.console[Leds.Led2];
                this.ledView3.Led = this.console[Leds.Led3];
                this.ledView4.Led = this.console[Leds.Led4];


                this.switchView1.Switch = this.console[Switches.Switch1];
                this.switchView2.Switch = this.console[Switches.Switch2];
                this.switchView3.Switch = this.console[Switches.Switch3];
                this.switchView4.Switch = this.console[Switches.Switch4];
            }
        }
    }
}