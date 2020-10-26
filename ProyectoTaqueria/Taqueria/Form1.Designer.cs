namespace Taqueria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu1 = new MenuLibreria.Menu();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.AutoSize = true;
            this.menu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu1.BackColor = System.Drawing.Color.Black;
            this.menu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu1.BackgroundImage")));
            this.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu1.Location = new System.Drawing.Point(25, 12);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(734, 388);
            this.menu1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuLibreria.Menu menu1;
    }
}

