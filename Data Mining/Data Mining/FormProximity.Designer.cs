
namespace Data_Mining
{
    partial class FormProximity
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.radioButtonManhattan = new System.Windows.Forms.RadioButton();
            this.radioButtonEuclidean = new System.Windows.Forms.RadioButton();
            this.radioButtonSupremum = new System.Windows.Forms.RadioButton();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonImport.Location = new System.Drawing.Point(24, 75);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(153, 39);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import File";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(182, 75);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(917, 264);
            this.dataGridViewData.TabIndex = 3;
            // 
            // radioButtonManhattan
            // 
            this.radioButtonManhattan.AutoSize = true;
            this.radioButtonManhattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManhattan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonManhattan.Location = new System.Drawing.Point(26, 30);
            this.radioButtonManhattan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonManhattan.Name = "radioButtonManhattan";
            this.radioButtonManhattan.Size = new System.Drawing.Size(292, 29);
            this.radioButtonManhattan.TabIndex = 5;
            this.radioButtonManhattan.TabStop = true;
            this.radioButtonManhattan.Text = "Manhattan Distance (r = 1)";
            this.radioButtonManhattan.UseVisualStyleBackColor = true;
            this.radioButtonManhattan.CheckedChanged += new System.EventHandler(this.radioButtonManhattan_CheckedChanged);
            // 
            // radioButtonEuclidean
            // 
            this.radioButtonEuclidean.AutoSize = true;
            this.radioButtonEuclidean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEuclidean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonEuclidean.Location = new System.Drawing.Point(425, 32);
            this.radioButtonEuclidean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonEuclidean.Name = "radioButtonEuclidean";
            this.radioButtonEuclidean.Size = new System.Drawing.Size(285, 29);
            this.radioButtonEuclidean.TabIndex = 6;
            this.radioButtonEuclidean.TabStop = true;
            this.radioButtonEuclidean.Text = "Euclidean Distance (r = 2)";
            this.radioButtonEuclidean.UseVisualStyleBackColor = true;
            this.radioButtonEuclidean.CheckedChanged += new System.EventHandler(this.radioButtonEuclidean_CheckedChanged);
            // 
            // radioButtonSupremum
            // 
            this.radioButtonSupremum.AutoSize = true;
            this.radioButtonSupremum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSupremum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonSupremum.Location = new System.Drawing.Point(795, 30);
            this.radioButtonSupremum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSupremum.Name = "radioButtonSupremum";
            this.radioButtonSupremum.Size = new System.Drawing.Size(293, 29);
            this.radioButtonSupremum.TabIndex = 7;
            this.radioButtonSupremum.TabStop = true;
            this.radioButtonSupremum.Text = "Supremum Distance (r = ∞)";
            this.radioButtonSupremum.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(24, 508);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(917, 252);
            this.dataGridViewHasil.TabIndex = 8;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExport.Location = new System.Drawing.Point(958, 711);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(141, 49);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Export File";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSupremum);
            this.groupBox1.Controls.Add(this.radioButtonEuclidean);
            this.groupBox1.Controls.Add(this.radioButtonManhattan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 355);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1120, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Similarity and Dissimilarity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(565, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(414, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasil";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(1002, 486);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(51, 20);
            this.labelText.TabIndex = 13;
            this.labelText.Text = "label3";
            // 
            // FormProximity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1400, 909);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonImport);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProximity";
            this.Text = "Proximity Matrix";
            this.Load += new System.EventHandler(this.FormProximity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.RadioButton radioButtonManhattan;
        private System.Windows.Forms.RadioButton radioButtonEuclidean;
        private System.Windows.Forms.RadioButton radioButtonSupremum;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelText;
    }
}