using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
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
            runLine1.LengthChanged += RunLine1_LengthChanged;
            runLine1.StartPressed += RunLine1_StartPressed;
            runTurnView1.AngleChanged += RunTurnView1_AngleChanged;
            runArc1.ArcAngleChanged += RunArc1_ArcAngleChanged;
            runArc1.ArcRadiusChanged += RunArc1_ArcRadiusChanged;
           
        }

        private void CommonRunParameters1_AccelerationChanged(object sender, EventArgs e)
        {
            // Was machen?
        }

        private void CommonRunParameters1_SpeedChanged(object sender, EventArgs e)
        {
            // Was machen?
        }

        private void RunLine1_LengthChanged(object sender, EventArgs e)
        {
            // Was machen?
        }

        private void RunLine1_StartPressed(object sender, EventArgs e)
        {
            drive.RunLine(1000, 500, 100);
        }

        private void RunTurnView1_AngleChanged(object sender, EventArgs e)
        {
            // Was machen?
        }

        private void RunArc1_ArcAngleChanged(object sender, EventArgs e)
        {
            // Was machen?
        }

        private void RunArc1_ArcRadiusChanged(object sender, EventArgs e)
        {
            // Was machen?
        }
    }
}
