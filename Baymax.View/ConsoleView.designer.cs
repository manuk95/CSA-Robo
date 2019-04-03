namespace Baymax.View
{
    partial class ConsoleView
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
            this.ledView4 = new Baymax.View.LedView();
            this.ledView3 = new Baymax.View.LedView();
            this.ledView2 = new Baymax.View.LedView();
            this.ledView1 = new Baymax.View.LedView();
            this.switchView1 = new Baymax.View.SwitchView();
            this.switchView2 = new Baymax.View.SwitchView();
            this.switchView3 = new Baymax.View.SwitchView();
            this.switchView4 = new Baymax.View.SwitchView();
            this.SuspendLayout();
            // 
            // ledView4
            // 
            this.ledView4.Led = null;
            this.ledView4.Location = new System.Drawing.Point(189, 16);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.State = false;
            this.ledView4.TabIndex = 4;
            // 
            // ledView3
            // 
            this.ledView3.Led = null;
            this.ledView3.Location = new System.Drawing.Point(131, 16);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 3;
            // 
            // ledView2
            // 
            this.ledView2.Led = null;
            this.ledView2.Location = new System.Drawing.Point(73, 16);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 2;
            // 
            // ledView1
            // 
            this.ledView1.Led = null;
            this.ledView1.Location = new System.Drawing.Point(18, 16);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 1;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(244, 16);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(53, 67);
            this.switchView1.State = false;
            this.switchView1.TabIndex = 5;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(303, 16);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(53, 67);
            this.switchView2.State = false;
            this.switchView2.TabIndex = 6;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(362, 16);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(53, 67);
            this.switchView3.State = false;
            this.switchView3.TabIndex = 7;
            // 
            // switchView4
            // 
            this.switchView4.Location = new System.Drawing.Point(421, 16);
            this.switchView4.Name = "switchView4";
            this.switchView4.Size = new System.Drawing.Size(53, 67);
            this.switchView4.State = false;
            this.switchView4.TabIndex = 8;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.switchView4);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Controls.Add(this.switchView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(750, 192);
            this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;
        private SwitchView switchView1;
        private SwitchView switchView2;
        private SwitchView switchView3;
        private SwitchView switchView4;
    }
}
