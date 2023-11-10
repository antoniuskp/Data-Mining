using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public partial class FormProximity : Form
    {
        public FormProximity()
        {
            InitializeComponent();
        }

        private void FormProximity_Load(object sender, EventArgs e)
        {

        }

        ProximityMatrix prox = new ProximityMatrix();
        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                // mengecek type file harus .csv
                if (IsCsvFile(selectedFileName))
                {
                    MessageBox.Show("Valid CSV file selected: " + selectedFileName, "Success");
                }
                else
                {
                    MessageBox.Show("Please select a valid CSV file.", "Error");
                }
                string csvFilePath = openFileDialog.FileName;   

                // masukkan inputan dalam bentuk tabel
                DataTable dataTable = LoadCsvFile(csvFilePath);
                dataGridViewData.DataSource = dataTable;
            }
        }
        private DataTable LoadCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //baris pertama adalah header tabel
                    string[] headers = reader.ReadLine().Split(',');

                    //Buat kolom di dataTable berdasarkan header
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    //Baca dan tambah data
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV file: " + ex.Message, "Error");
            }

            return dataTable;
        }
        private bool IsCsvFile(string fileName)
        {
            // mengecek type file harus .csv
            return fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase);
        }

        private void radioButtonEuclidean_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount > 0 && dataGridViewData.ColumnCount > 0)
            {
                //FormatHasil(prox.EucladeanDistance(dataGridViewData));
                double[,] hasil = prox.EucladeanDistance(dataGridViewData);

                FormatHasil(hasil);

            }
            else
            {
                MessageBox.Show("Please input the file!");
            }
        }

        private void FormatHasil(double[,] prox)
        {
            dataGridViewHasil.Rows.Clear();
            dataGridViewHasil.Columns.Clear();

            // Add column headers
            for (int i = 0; i < prox.GetLength(0); i++)
            {
                dataGridViewHasil.Columns.Add($"P{i + 1}", $"P{i + 1}");
            }

            // Add rows with row headers and data
            for (int i = 0; i < prox.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewHasil);

                // Add row header
                row.HeaderCell.Value = $"P{i + 1}";

                // Add data to the row
                for (int j = 0; j < prox.GetLength(1); j++)
                {
                    row.Cells[j].Value = prox[i, j];
                }

                dataGridViewHasil.Rows.Add(row);
            }
        }
        private void SaveToCsv(DataGridView dataGridView, string filePath)
        {
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count;

            // Create a StringBuilder to hold the CSV data
            StringBuilder csvData = new StringBuilder();

            // Append header row
            for (int i = 0; i < columnCount; i++)
            {
                csvData.Append(dataGridView.Columns[i].HeaderText);
                if (i < columnCount - 1)
                    csvData.Append(",");
            }
            csvData.AppendLine();

            // Append data rows
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    csvData.Append(dataGridView.Rows[i].Cells[j].Value);
                    if (j < columnCount - 1)
                        csvData.Append(",");
                }
                csvData.AppendLine();
            }

            // Write the CSV data to the specified file
            File.WriteAllText(filePath, csvData.ToString());
        }

        private void radioButtonSupremum_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount > 0 && dataGridViewData.ColumnCount > 0)
            {
                //FormatHasil(prox.EucladeanDistance(dataGridViewData));
                double[,] hasil = prox.SupremumDistance(dataGridViewData);

                FormatHasil(hasil);

            }
            else
            {
                MessageBox.Show("Please input the file!");
            }
        }

        private void radioButtonCityBlok_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount > 0 && dataGridViewData.ColumnCount > 0)
            {
                //FormatHasil(prox.EucladeanDistance(dataGridViewData));
                double[,] hasil = prox.CityBlokDistance(dataGridViewData);

                FormatHasil(hasil);

            }
            else
            {
                MessageBox.Show("Please input the file!");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save CSV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToCsv(dataGridViewHasil, saveFileDialog.FileName);
            }
        }
    }
}
