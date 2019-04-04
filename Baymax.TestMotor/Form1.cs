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

            // Referenzen Zuweisen
            this.motorCtrlViewLeft.MotorCtrl = new RobotCtrl.MotorCtrl(Constants.IOMotorCtrlLeft);
            this.motorCtrlViewRight.MotorCtrl = new RobotCtrl.MotorCtrl(Constants.IOMotorCtrlRight);
            this.driveCtrlView1.DriveCtrl = new RobotCtrl.DriveCtrl(Constants.IODriveCtrl);

        }
    }
}
