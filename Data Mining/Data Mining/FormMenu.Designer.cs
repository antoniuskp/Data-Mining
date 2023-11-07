
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
            this.buttonProxMat = new System.Windows.Forms.Button();
            this.buttonGini = new System.Windows.Forms.Button();
            this.buttonKMeans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProxMat
            // 
            this.buttonProxMat.Font = new System.Drawing.Font("Gotham Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProxMat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProxMat.Location = new System.Drawing.Point(177, 105);
            this.buttonProxMat.Name = "buttonProxMat";
            this.buttonProxMat.Size = new System.Drawing.Size(192, 94);
            this.buttonProxMat.TabIndex = 1;
            this.buttonProxMat.Text = "Proximity Matrix";
            this.buttonProxMat.UseVisualStyleBackColor = true;
            this.buttonProxMat.Click += new System.EventHandler(this.buttonProxMat_Click);
            // 
            // buttonGini
            // 
            this.buttonGini.Font = new System.Drawing.Font("Gotham Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGini.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGini.Location = new System.Drawing.Point(390, 105);
            this.buttonGini.Name = "buttonGini";
            this.buttonGini.Size = new System.Drawing.Size(192, 94);
            this.buttonGini.TabIndex = 2;
            this.buttonGini.Text = "Gini";
            this.buttonGini.UseVisualStyleBackColor = true;
            this.buttonGini.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKMeans
            // 
            this.buttonKMeans.Font = new System.Drawing.Font("Gotham Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKMeans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKMeans.Location = new System.Drawing.Point(288, 225);
            this.buttonKMeans.Name = "buttonKMeans";
            this.buttonKMeans.Size = new System.Drawing.Size(192, 94);
            this.buttonKMeans.TabIndex = 3;
            this.buttonKMeans.Text = "K-Means";
            this.buttonKMeans.UseVisualStyleBackColor = true;
            this.buttonKMeans.Click += new System.EventHandler(this.buttonKMeans_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKMeans);
            this.Controls.Add(this.buttonGini);
            this.Controls.Add(this.buttonProxMat);
            this.Name = "FormMenu";
            this.Text = "Compute Dataset";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonProxMat;
        private System.Windows.Forms.Button buttonGini;
        private System.Windows.Forms.Button buttonKMeans;
    }
}

