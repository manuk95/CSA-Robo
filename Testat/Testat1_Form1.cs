using Baymax.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testat
{
    public partial class Testat1_Form1 : Form
    {
        parcour par; 
        public Testat1_Form1()
        {
            InitializeComponent();

            Robot R = new Robot();
            this.switch1.Switch = R.RobotConsole[Switches.Switch1];
            R.RobotConsole[Switches.Switch1].SwitchStateChanged += Testat1_Form1_SwitchStateChanged;
            par = new parcour();

        }

        private void Testat1_Form1_SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if(e.SwitchEnabled == true)
            {
                par.driveParcour();
            }
            else
            {
                // ev stop.
            }
        }
    }
}
