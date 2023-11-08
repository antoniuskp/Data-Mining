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
        public double EucladeanDistance(double x1, double x2, double y1, double y2)
        {
            //menghitung hasil
            double hasil = (double) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return hasil;

        }

    }
}
