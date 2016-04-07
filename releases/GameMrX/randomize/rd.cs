using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomize
{
    public class rd
    {
        public static int Rand(int ghduoi, int ghtren)
        {
            Random rrd = new Random();
            return rrd.Next(ghduoi, ghtren);
        }

        public static string Rdcolor()
        {
            string[] a = new string[100];
            a[1] = "#00e5ee";
            a[2] = "#50c878";
            a[3] = "#3498db";
            a[4] = "#9966cc";
            a[5] = "#34495e";

            a[6] = "#4E8975";
            a[7] = "#27ae60";
            a[8] = "#2980b9";
            a[9] = "#8e44ad";
            a[10] = "#2c3e50";

            a[11] = "#f1c40f";
            a[12] = "#e67e22";
            a[13] = "#e74c3c";
            a[14] = "#ecf0f1";
            a[15] = "#95a5a6";

            a[16] = "#f39c12";
            a[17] = "#d35400";
            a[18] = "#c0392b";
            a[19] = "#bdc3c7";
            a[20] = "#7f8c8d";
            return a[Rand(1, 20)];
        }

    }
}
