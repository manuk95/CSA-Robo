namespace Baymax.View
{
    partial class LedView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedView));
            this.ledImage = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // ledImage
            // 
            this.ledImage.Image = ((System.Drawing.Image)(resources.GetObject("ledImage.Image")));
            this.ledImage.Location = new System.Drawing.Point(0, 0);
            this.ledImage.Name = "ledImage";
            this.ledImage.Size = new System.Drawing.Size(16, 16);
            // 
            // LedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledImage);
            this.Name = "LedView";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ledImage;
    }
}
