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
            double[,] hasil = new double[datagrid.Rows.Count - 1, datagrid.Rows.Count - 1];

            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datagrid.Rows.Count - 1; j++)
                {
                    double total = 0;
                    double jarak;
                    for (int k = 0; k < datagrid.Columns.Count; k++)
                    {
                        double titik1 = Convert.ToDouble(datagrid.Rows[i].Cells[k].Value);
                        double titik2 = Convert.ToDouble(datagrid.Rows[j].Cells[k].Value);

                        double sum = Math.Pow(Math.Abs(titik2 - titik1), 2);
                        total += sum;
                    }

                    jarak = Math.Round(Math.Sqrt(total), 4); //hasil pertambahan diakar

                    hasil[i, j] = jarak;

                }
            }
            return hasil;
        }
        public double[,] SupremumDistance(DataGridView datagrid)
        {
            double[,] hasil = new double[datagrid.Rows.Count - 1, datagrid.Rows.Count - 1];

            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datagrid.Rows.Count - 1; j++)
                {

                    double jarak = 0.0;
                    for (int k = 0; k < datagrid.Columns.Count; k++)
                    {
                        double titik1 = Convert.ToDouble(datagrid.Rows[i].Cells[k].Value);
                        double titik2 = Convert.ToDouble(datagrid.Rows[j].Cells[k].Value);

                        double dot = Math.Abs(titik2 - titik1);

                        //mencari nilai tertinggi
                        if (dot > jarak)
                        {
                            jarak = dot;
                        }

                    }

                    hasil[i, j] = jarak;

                }
            }
            return hasil;
        }
        public double[,] CityBlokDistance(DataGridView datagrid)
        {
            double[,] hasil = new double[datagrid.Rows.Count - 1, datagrid.Rows.Count - 1];

            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datagrid.Rows.Count - 1; j++)
                {

                    double jarak = 0.0;
                    for (int k = 0; k < datagrid.Columns.Count; k++)
                    {
                        double titik1 = Convert.ToDouble(datagrid.Rows[i].Cells[k].Value);
                        double titik2 = Convert.ToDouble(datagrid.Rows[j].Cells[k].Value);

                        double dot = Math.Abs(titik2 - titik1);
                        jarak += dot;

                    }

                    hasil[i, j] = jarak;

                }
            }
            return hasil;
        }
    }
}
