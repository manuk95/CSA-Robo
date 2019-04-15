namespace RobotView
{
    partial class RunTurnView
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
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditAngle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upDownAngle
            // 
            this.upDownAngle.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownAngle.Location = new System.Drawing.Point(239, 34);
            this.upDownAngle.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(75, 32);
            this.upDownAngle.TabIndex = 54;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 24);
            this.button2.TabIndex = 53;
            this.button2.Text = "+ / -";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 24);
            this.button1.TabIndex = 52;
            this.button1.Text = "Start";
            // 
            // buttonEditAngle
            // 
            this.buttonEditAngle.Location = new System.Drawing.Point(320, 34);
            this.buttonEditAngle.Name = "buttonEditAngle";
            this.buttonEditAngle.Size = new System.Drawing.Size(51, 24);
            this.buttonEditAngle.TabIndex = 51;
            this.buttonEditAngle.Text = "...";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(22, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 24);
            this.label16.Text = "RunTurn";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(25, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Angle (+/- degrees)";
            // 
            // RunTurnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEditAngle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Name = "RunTurnView";
            this.Size = new System.Drawing.Size(450, 72);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditAngle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
    }
}
