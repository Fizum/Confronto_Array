using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Array
{
    public class Confronto_Array
    {
        public static int [] Confronto(int[] a)
        {
            int[] b = new int [3];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i] + 10;
            }

            return b;
        }
    }
}
