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
            
        }

        private void proxymityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kmeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void buttonProxMat_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormProximity"];
            if (form == null)
            {
                FormProximity formProx = new FormProximity();
                formProx.MdiParent = this;
                formProx.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        //gini
        private void button1_Click(object sender, EventArgs e)
        {
            FormGini form = new FormGini();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonKMeans_Click(object sender, EventArgs e)
        {
            FormKmeans form = new FormKmeans();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
