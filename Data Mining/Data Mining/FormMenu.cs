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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void giniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGini form = new FormGini();
            form.Owner = this;
            form.ShowDialog();
        }

        private void proxymityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProximity form = new FormProximity();
            form.Owner = this;
            form.ShowDialog();
        }

        private void kmeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKmeans form = new FormKmeans();
            form.Owner = this;
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
