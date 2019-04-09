using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class RunLine : UserControl
    {
        public RunLine()
        {
            InitializeComponent();
        }

        #region properties
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public Drive Drive { get; set; }
        #endregion

        private void buttonEditAcceleration_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditSpeed_Click(object sender, EventArgs e)
        {

        }
    }
}