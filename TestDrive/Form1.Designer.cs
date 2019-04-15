namespace TestDrive
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
            this.driveview1 = new RobotView.DriveView();
            this.commonRunParameters1 = new RobotView.CommonRunParameters();
            this.runLine1 = new RobotView.RunLine();
            this.runTurnView1 = new RobotView.RunTurnView();
            this.runArc1 = new RobotView.RunArc();
            this.SuspendLayout();
            // 
            // driveview1
            // 
            this.driveview1.Drive = null;
            this.driveview1.Location = new System.Drawing.Point(4, 4);
            this.driveview1.Name = "driveview1";
            this.driveview1.Size = new System.Drawing.Size(466, 434);
            this.driveview1.TabIndex = 0;
            // 
            // commonRunParameters1
            // 
            this.commonRunParameters1.Acceleration = 0.3F;
            this.commonRunParameters1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.commonRunParameters1.Location = new System.Drawing.Point(474, 4);
            this.commonRunParameters1.Name = "commonRunParameters1";
            this.commonRunParameters1.Size = new System.Drawing.Size(553, 126);
            this.commonRunParameters1.Speed = 0.5F;
            this.commonRunParameters1.TabIndex = 1;
            // 
            // runLine1
            // 
            this.runLine1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.runLine1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runLine1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.runLine1.Length = 0.3F;
            this.runLine1.Location = new System.Drawing.Point(474, 137);
            this.runLine1.Name = "runLine1";
            this.runLine1.Size = new System.Drawing.Size(553, 82);
            this.runLine1.TabIndex = 1;
            // 
            // runTurnView1
            // 
            this.runTurnView1.Angle = 90;
            this.runTurnView1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.runTurnView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runTurnView1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.runTurnView1.Location = new System.Drawing.Point(474, 225);
            this.runTurnView1.Name = "runTurnView1";
            this.runTurnView1.Size = new System.Drawing.Size(553, 82);
            this.runTurnView1.TabIndex = 1;
            // 
            // runArc1
            // 
            this.runArc1.Acceleration = 0.3F;
            this.runArc1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.runArc1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runArc1.Drive = null;
            this.runArc1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.runArc1.Location = new System.Drawing.Point(477, 313);
            this.runArc1.Name = "runArc1";
            this.runArc1.Size = new System.Drawing.Size(553, 109);
            this.runArc1.Speed = 0F;
            this.runArc1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 455);
            this.Controls.Add(this.driveview1);
            this.Controls.Add(this.commonRunParameters1);
            this.Controls.Add(this.runLine1);
            this.Controls.Add(this.runTurnView1);
            this.Controls.Add(this.runArc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveView driveview1;
        private RobotView.CommonRunParameters commonRunParameters1;
        private RobotView.RunLine runLine1;
        private RobotView.RunTurnView runTurnView1;
        private RobotView.RunArc runArc1;
    }
}

