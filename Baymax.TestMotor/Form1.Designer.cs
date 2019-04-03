namespace Baymax.TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.motorCtrlViewLeft = new RobotView.MotorCtrlView();
            this.Links = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.motorCtrlViewRight = new RobotView.MotorCtrlView();
            this.Links.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorCtrlViewLeft
            // 
            this.motorCtrlViewLeft.Location = new System.Drawing.Point(3, 3);
            this.motorCtrlViewLeft.MotorCtrl = null;
            this.motorCtrlViewLeft.Name = "motorCtrlViewLeft";
            this.motorCtrlViewLeft.Size = new System.Drawing.Size(525, 326);
            this.motorCtrlViewLeft.TabIndex = 0;
            // 
            // Links
            // 
            this.Links.Controls.Add(this.tabPage1);
            this.Links.Controls.Add(this.tabPage2);
            this.Links.Location = new System.Drawing.Point(25, 16);
            this.Links.Name = "Links";
            this.Links.SelectedIndex = 0;
            this.Links.Size = new System.Drawing.Size(568, 423);
            this.Links.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.motorCtrlViewLeft);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(560, 394);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.motorCtrlViewRight);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(560, 394);
            this.tabPage2.Text = "tabPage2";
            // 
            // motorCtrlViewRight
            // 
            this.motorCtrlViewRight.Location = new System.Drawing.Point(3, 3);
            this.motorCtrlViewRight.MotorCtrl = null;
            this.motorCtrlViewRight.Name = "motorCtrlViewRight";
            this.motorCtrlViewRight.Size = new System.Drawing.Size(525, 326);
            this.motorCtrlViewRight.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.Links);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Links.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RobotView.MotorCtrlView motorCtrlViewLeft;
        private System.Windows.Forms.TabControl Links;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private RobotView.MotorCtrlView motorCtrlViewRight;
    }
}

