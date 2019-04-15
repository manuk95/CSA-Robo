namespace RobotView
{
    partial class RunLine
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
            this.buttonEditSpeed = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.upDownAcceleration = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // buttonEditSpeed
            // 
            this.buttonEditSpeed.Location = new System.Drawing.Point(311, 31);
            this.buttonEditSpeed.Name = "buttonEditSpeed";
            this.buttonEditSpeed.Size = new System.Drawing.Size(51, 24);
            this.buttonEditSpeed.TabIndex = 41;
            this.buttonEditSpeed.Text = "...";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(13, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 24);
            this.label16.Text = "RunLine";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(16, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Length (+/- mm)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 24);
            this.button1.TabIndex = 46;
            this.button1.Text = "Start";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 24);
            this.button2.TabIndex = 47;
            this.button2.Text = "+ / -";
            // 
            // upDownAcceleration
            // 
            this.upDownAcceleration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownAcceleration.Location = new System.Drawing.Point(230, 31);
            this.upDownAcceleration.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.upDownAcceleration.Name = "upDownAcceleration";
            this.upDownAcceleration.Size = new System.Drawing.Size(75, 24);
            this.upDownAcceleration.TabIndex = 48;
            this.upDownAcceleration.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // RunLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.upDownAcceleration);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEditSpeed);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "RunLine";
            this.Size = new System.Drawing.Size(450, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSpeed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown upDownAcceleration;
    }
}
