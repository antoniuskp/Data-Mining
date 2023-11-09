using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public class ProximityMatrix
    {
        public double[,] EucladeanDistance(DataGridView datagrid)
        {
            double[,] hasil = new double[datagrid.RowCount,datagrid.RowCount];

            for (int i = 1; i <= datagrid.RowCount; i++) 
            {
                double total = 0;
                double jarak;
                for(int j = 1; j <= datagrid.RowCount; j++)
                {
                    for (int k = 0; k < datagrid.ColumnCount; k++)
                    {
                        double titik2 = double.Parse(datagrid.Rows[j].Cells[k].Value.ToString());
                        double titik1 = double.Parse(datagrid.Rows[i].Cells[k].Value.ToString());

                        double sum = Math.Pow(Math.Abs(titik2 - titik1), 2);
                        total += sum;
                    }

                    jarak = Math.Round(Math.Sqrt(total), 3); //hasil pertambahan diakar

                    hasil[i, j] = jarak;

                }
            }
            return hasil;
        }

    }
}
