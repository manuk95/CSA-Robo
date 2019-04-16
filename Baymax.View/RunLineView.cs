using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunLine : UserControl
    {
        #region events
        public event EventHandler<EventArgs> LengthChanged;
        public event EventHandler<EventArgs> StartClicked;
        #endregion

        public RunLine()
        {
            InitializeComponent();
            upDownLength.ValueChanged += new EventHandler(upDownLength_ValueChanged);
        }

        #region properties
        public float Length
        {
            get { return (float)upDownLength.Value / 1000; }
            set { upDownLength.Value = (decimal)value * 1000; }
        }
        #endregion

        #region methods
        void upDownLength_ValueChanged(object sender, EventArgs e)
        {
            if (LengthChanged != null)
            {
                LengthChanged(this, e);
            }
        }
        #endregion

        private void buttonEditLength_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownLength.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownLength.Value = (int)nk.Number;
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            StartClicked(this, e);

        }
    }
}