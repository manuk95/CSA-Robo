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
            this.SuspendLayout();
            // 
            // driveview1
            // 
            this.driveview1.Drive = null;
            this.driveview1.Location = new System.Drawing.Point(0, 0);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 455);
            this.Controls.Add(this.driveview1);
            this.Controls.Add(this.commonRunParameters1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveView driveview1;
        private RobotView.CommonRunParameters commonRunParameters1;
    }
}

