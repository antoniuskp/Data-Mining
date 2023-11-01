
namespace Data_Mining
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxymityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giniToolStripMenuItem,
            this.proxymityToolStripMenuItem,
            this.kmeansToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giniToolStripMenuItem
            // 
            this.giniToolStripMenuItem.Name = "giniToolStripMenuItem";
            this.giniToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.giniToolStripMenuItem.Text = "Gini";
            this.giniToolStripMenuItem.Click += new System.EventHandler(this.giniToolStripMenuItem_Click);
            // 
            // proxymityToolStripMenuItem
            // 
            this.proxymityToolStripMenuItem.Name = "proxymityToolStripMenuItem";
            this.proxymityToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.proxymityToolStripMenuItem.Text = "Proxymity";
            this.proxymityToolStripMenuItem.Click += new System.EventHandler(this.proxymityToolStripMenuItem_Click);
            // 
            // kmeansToolStripMenuItem
            // 
            this.kmeansToolStripMenuItem.Name = "kmeansToolStripMenuItem";
            this.kmeansToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.kmeansToolStripMenuItem.Text = "K-means";
            this.kmeansToolStripMenuItem.Click += new System.EventHandler(this.kmeansToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxymityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmeansToolStripMenuItem;
    }
}

