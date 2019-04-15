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
    public partial class RunArc : UserControl
    {

        #region events
        public event EventHandler<EventArgs> ArcRadiusChanged;
        public event EventHandler<EventArgs> ArcAngleChanged;
        #endregion

        #region constructor & destructor
        public RunArc()
        {
            InitializeComponent();
            upDownArcRadius.ValueChanged += new EventHandler(upDownArcRadius_ValueChanged);
            upDownArcAngle.ValueChanged += new EventHandler(upDownArcAngle_ValueChanged);
        }
        #endregion


        #region properties
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public Drive Drive { get; set; }
        #endregion


        #region methods
        private void buttonArcNeg_Click(object sender, EventArgs e)
        {
            upDownArcAngle.Value = -upDownArcAngle.Value;
        }


        private void buttonStartArc_Click(object sender, EventArgs e)
        {
            if (Drive != null)
            {
                if (radioButtonArcRight.Checked)
                {
                    Drive.RunArcRight((float)upDownArcRadius.Value / 1000,
                        (float)upDownArcAngle.Value, Speed, Acceleration);
                }
                else
                {
                    Drive.RunArcLeft((float)upDownArcRadius.Value / 1000,
                        (float)upDownArcAngle.Value, Speed, Acceleration);
                }
            }
        }

        public void Start()
        {
            buttonStartArc_Click(null, EventArgs.Empty);
        }

        private void buttonEditRadius_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownArcRadius.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownArcRadius.Value = (int)nk.Number;
            }
        }

        private void buttonEditAngle_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownArcAngle.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownArcAngle.Value = (int)nk.Number;
            }
        }

        void upDownArcRadius_ValueChanged(object sender, EventArgs e)
        {
            if (ArcRadiusChanged != null)
            {
                ArcRadiusChanged(this, e);
            }
        }

        void upDownArcAngle_ValueChanged(object sender, EventArgs e)
        {
            if (ArcAngleChanged != null)
            {
                ArcAngleChanged(this, e);
            }
        }
        #endregion

    }
}