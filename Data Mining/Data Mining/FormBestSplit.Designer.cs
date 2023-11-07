
namespace Data_Mining
{
    partial class FormBestSplit
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
            this.comboBoxDistance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxBest = new System.Windows.Forms.ListBox();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.dataGridViewBest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDistance
            // 
            this.comboBoxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDistance.FormattingEnabled = true;
            this.comboBoxDistance.Items.AddRange(new object[] {
            "Best Split dengan GINI",
            "Best Split dengan Entropy"});
            this.comboBoxDistance.Location = new System.Drawing.Point(536, 15);
            this.comboBoxDistance.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDistance.Name = "comboBoxDistance";
            this.comboBoxDistance.Size = new System.Drawing.Size(294, 30);
            this.comboBoxDistance.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasil :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data";
            // 
            // listBoxBest
            // 
            this.listBoxBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBest.FormattingEnabled = true;
            this.listBoxBest.ItemHeight = 18;
            this.listBoxBest.Location = new System.Drawing.Point(472, 53);
            this.listBoxBest.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBest.Name = "listBoxBest";
            this.listBoxBest.Size = new System.Drawing.Size(470, 418);
            this.listBoxBest.TabIndex = 16;
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(10, 477);
            this.buttonBuka.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(138, 51);
            this.buttonBuka.TabIndex = 15;
            this.buttonBuka.Text = "&BUKA FILE";
            this.buttonBuka.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBest
            // 
            this.dataGridViewBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBest.Location = new System.Drawing.Point(10, 53);
            this.dataGridViewBest.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBest.Name = "dataGridViewBest";
            this.dataGridViewBest.RowHeadersWidth = 51;
            this.dataGridViewBest.RowTemplate.Height = 24;
            this.dataGridViewBest.Size = new System.Drawing.Size(458, 419);
            this.dataGridViewBest.TabIndex = 14;
            // 
            // FormBestSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(956, 535);
            this.Controls.Add(this.comboBoxDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBest);
            this.Controls.Add(this.buttonBuka);
            this.Controls.Add(this.dataGridViewBest);
            this.Name = "FormBestSplit";
            this.Text = "FormBestSplit";
            this.Load += new System.EventHandler(this.FormGini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBest;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.DataGridView dataGridViewBest;
    }
}