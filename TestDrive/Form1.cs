using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class Form1 : Form
    {
        private Drive drive;

        public Form1()
        {
            InitializeComponent();

            drive = new Drive();
            drive.Power = true;
            driveview1.Drive = drive;

            commonRunParameters1.SpeedChanged += CommonRunParameters1_SpeedChanged;
            commonRunParameters1.AccelerationChanged += CommonRunParameters1_AccelerationChanged;
           
        }

        private void CommonRunParameters1_AccelerationChanged(object sender, EventArgs e)
        {
        }

        private void CommonRunParameters1_SpeedChanged(object sender, EventArgs e)
        {
        }
    }
}
