using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public partial class FormBestSplit : Form
    {
        FormMenu formMenu;

        public FormBestSplit()
        {
            InitializeComponent();
        }

        private void FormGini_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMakeColumn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= int.Parse(numericUpDownColumn.Text); i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
            }
        }

        private void buttonGini_Click(object sender, EventArgs e)
        {
            double allGini;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                double gini = 0;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    double pembagi = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        pembagi += (double)row.Cells[j].Value;
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        gini = 1 - Math.Pow((double)row.Cells[j].Value / pembagi, 2);
                    }
                    listBox1.Items.Add("Gini item " + j + 1 + " = " + gini.ToString());
                }
            }
        }
    }
}