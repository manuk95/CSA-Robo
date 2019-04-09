﻿namespace RobotView
{
    partial class MotorCtrlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCurrentSpeed = new System.Windows.Forms.Label();
            this.buttonResetTicks = new System.Windows.Forms.Button();
            this.labelMotorStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTicks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxMotorSpeed = new System.Windows.Forms.TextBox();
            this.textBoxAcceleration = new System.Windows.Forms.TextBox();
            this.trackBarAcceleration = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarMotorSpeed = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMotorCtrlStart = new System.Windows.Forms.Button();
            this.buttonMotorCtrlStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonResetMotorCtrl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDriveCtrlMotorStatus = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // labelCurrentSpeed
            // 
            this.labelCurrentSpeed.Location = new System.Drawing.Point(368, 138);
            this.labelCurrentSpeed.Name = "labelCurrentSpeed";
            this.labelCurrentSpeed.Size = new System.Drawing.Size(96, 20);
            this.labelCurrentSpeed.Text = "0.000 [m/s]";
            this.labelCurrentSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonResetTicks
            // 
            this.buttonResetTicks.Location = new System.Drawing.Point(314, 98);
            this.buttonResetTicks.Name = "buttonResetTicks";
            this.buttonResetTicks.Size = new System.Drawing.Size(72, 20);
            this.buttonResetTicks.TabIndex = 49;
            this.buttonResetTicks.Text = "Reset";
            this.buttonResetTicks.Click += new System.EventHandler(this.buttonResetTicks_Click);
            // 
            // labelMotorStatus
            // 
            this.labelMotorStatus.Location = new System.Drawing.Point(314, 41);
            this.labelMotorStatus.Name = "labelMotorStatus";
            this.labelMotorStatus.Size = new System.Drawing.Size(72, 20);
            this.labelMotorStatus.Text = "stopped";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(15, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.Text = "Ticks";
            // 
            // textBoxTicks
            // 
            this.textBoxTicks.Location = new System.Drawing.Point(392, 96);
            this.textBoxTicks.Name = "textBoxTicks";
            this.textBoxTicks.Size = new System.Drawing.Size(72, 31);
            this.textBoxTicks.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(15, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.Text = "Distance [m]";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(392, 67);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(72, 31);
            this.textBoxDistance.TabIndex = 35;
            // 
            // textBoxMotorSpeed
            // 
            this.textBoxMotorSpeed.Location = new System.Drawing.Point(392, 174);
            this.textBoxMotorSpeed.Name = "textBoxMotorSpeed";
            this.textBoxMotorSpeed.Size = new System.Drawing.Size(72, 31);
            this.textBoxMotorSpeed.TabIndex = 29;
            // 
            // textBoxAcceleration
            // 
            this.textBoxAcceleration.Location = new System.Drawing.Point(392, 228);
            this.textBoxAcceleration.Name = "textBoxAcceleration";
            this.textBoxAcceleration.Size = new System.Drawing.Size(72, 31);
            this.textBoxAcceleration.TabIndex = 11;
            // 
            // trackBarAcceleration
            // 
            this.trackBarAcceleration.Location = new System.Drawing.Point(161, 217);
            this.trackBarAcceleration.Maximum = 5000;
            this.trackBarAcceleration.Name = "trackBarAcceleration";
            this.trackBarAcceleration.Size = new System.Drawing.Size(213, 45);
            this.trackBarAcceleration.SmallChange = 100;
            this.trackBarAcceleration.TabIndex = 23;
            this.trackBarAcceleration.TickFrequency = 500;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(15, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.Text = "Acceleration [m/s^2]";
            // 
            // trackBarMotorSpeed
            // 
            this.trackBarMotorSpeed.Location = new System.Drawing.Point(161, 163);
            this.trackBarMotorSpeed.Maximum = 2000;
            this.trackBarMotorSpeed.Minimum = -2000;
            this.trackBarMotorSpeed.Name = "trackBarMotorSpeed";
            this.trackBarMotorSpeed.Size = new System.Drawing.Size(213, 45);
            this.trackBarMotorSpeed.SmallChange = 100;
            this.trackBarMotorSpeed.TabIndex = 18;
            this.trackBarMotorSpeed.TickFrequency = 500;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(15, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.Text = "Motor speed [m/s]";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(15, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "Motor control";
            // 
            // buttonMotorCtrlStart
            // 
            this.buttonMotorCtrlStart.Location = new System.Drawing.Point(174, 138);
            this.buttonMotorCtrlStart.Name = "buttonMotorCtrlStart";
            this.buttonMotorCtrlStart.Size = new System.Drawing.Size(72, 20);
            this.buttonMotorCtrlStart.TabIndex = 12;
            this.buttonMotorCtrlStart.Text = "Start";
            this.buttonMotorCtrlStart.Click += new System.EventHandler(this.buttonMotorCtrlStart_Click);
            // 
            // buttonMotorCtrlStop
            // 
            this.buttonMotorCtrlStop.Location = new System.Drawing.Point(290, 138);
            this.buttonMotorCtrlStop.Name = "buttonMotorCtrlStop";
            this.buttonMotorCtrlStop.Size = new System.Drawing.Size(72, 20);
            this.buttonMotorCtrlStop.TabIndex = 13;
            this.buttonMotorCtrlStop.Text = "Stop";
            this.buttonMotorCtrlStop.Click += new System.EventHandler(this.buttonMotorCtrlStop_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Reset MotorCtrl";
            // 
            // buttonResetMotorCtrl
            // 
            this.buttonResetMotorCtrl.Location = new System.Drawing.Point(392, 12);
            this.buttonResetMotorCtrl.Name = "buttonResetMotorCtrl";
            this.buttonResetMotorCtrl.Size = new System.Drawing.Size(72, 20);
            this.buttonResetMotorCtrl.TabIndex = 11;
            this.buttonResetMotorCtrl.Text = "Reset";
            this.buttonResetMotorCtrl.Click += new System.EventHandler(this.buttonResetMotorCtrl_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Motor status";
            // 
            // textBoxDriveCtrlMotorStatus
            // 
            this.textBoxDriveCtrlMotorStatus.Location = new System.Drawing.Point(392, 38);
            this.textBoxDriveCtrlMotorStatus.Name = "textBoxDriveCtrlMotorStatus";
            this.textBoxDriveCtrlMotorStatus.Size = new System.Drawing.Size(72, 31);
            this.textBoxDriveCtrlMotorStatus.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MotorCtrlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.labelCurrentSpeed);
            this.Controls.Add(this.buttonResetTicks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMotorStatus);
            this.Controls.Add(this.textBoxDriveCtrlMotorStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTicks);
            this.Controls.Add(this.buttonResetMotorCtrl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonMotorCtrlStop);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.buttonMotorCtrlStart);
            this.Controls.Add(this.textBoxMotorSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAcceleration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBarAcceleration);
            this.Controls.Add(this.trackBarMotorSpeed);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.Name = "MotorCtrlView";
            this.Size = new System.Drawing.Size(480, 270);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentSpeed;
        private System.Windows.Forms.Button buttonResetTicks;
        private System.Windows.Forms.Label labelMotorStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTicks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxMotorSpeed;
        private System.Windows.Forms.TextBox textBoxAcceleration;
        private System.Windows.Forms.TrackBar trackBarAcceleration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarMotorSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMotorCtrlStart;
        private System.Windows.Forms.Button buttonMotorCtrlStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResetMotorCtrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDriveCtrlMotorStatus;
        private System.Windows.Forms.Timer timer;
    }
}
