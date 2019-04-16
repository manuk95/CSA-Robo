namespace Baymax.View
{
    partial class SwitchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchView));
            this.switchImage = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // switchImage
            // 
            this.switchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchImage.Image = ((System.Drawing.Image)(resources.GetObject("switchImage.Image")));
            this.switchImage.Location = new System.Drawing.Point(0, 0);
            this.switchImage.Name = "switchImage";
            this.switchImage.Size = new System.Drawing.Size(37, 64);
            // 
            // SwitchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.switchImage);
            this.Name = "SwitchView";
            this.Size = new System.Drawing.Size(37, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox switchImage;
    }
}
