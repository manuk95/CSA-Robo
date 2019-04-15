using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunTurnView : UserControl
    {
        #region events
        public event EventHandler<EventArgs> AngleChanged;
        #endregion

        public RunTurnView()
        {
            InitializeComponent();
            upDownAngle.ValueChanged += new EventHandler(upDownAngle_ValueChanged);
        }

        #region properties
        public int Angle
        {
            get { return (int)upDownAngle.Value; }
            set { upDownAngle.Value = (decimal)value; }
        }
        #endregion

        #region methods
        void upDownAngle_ValueChanged(object sender, EventArgs e)
        {
            if (AngleChanged != null)
            {
                AngleChanged(this, e);
            }
        }

        private void RunTurnView_Click(object sender, EventArgs e)
        {
            // Was machen??
        }

        private void buttonEditAngle_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownAngle.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownAngle.Value = (int)nk.Number;
            }
        }
        #endregion
    }
}