using Baymax.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baymax.TestMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            motorCtrlViewLeft.MotorCtrl = new RobotCtrl.MotorCtrl(Constants.IOMotorCtrlLeft);
        }
    }
}
