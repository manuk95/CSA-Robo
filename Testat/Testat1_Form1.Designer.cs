﻿namespace Testat
{
    partial class Testat1_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.switch1 = new Baymax.View.SwitchView();
            this.SuspendLayout();
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(45, 19);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(21, 41);
            this.switch1.State = false;
            this.switch1.Switch = null;
            this.switch1.TabIndex = 0;
            // 
            // Testat1_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 353);
            this.Controls.Add(this.switch1);
            this.Menu = this.mainMenu1;
            this.Name = "Testat1_Form1";
            this.Text = "Testat";
            this.ResumeLayout(false);

        }

        #endregion

        private Baymax.View.SwitchView switch1;
    }
}

