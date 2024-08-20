using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    internal class MyMath
    {
        public static int Calc_ggT (int a, int b)
        {
            int z = 0;
            while (b != 0) {
                z = a % b;
                a = b;
                b = z; 
            }
            return a;
        }
        public static int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
                
        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Calc_ggT_r(b, a%b);

        }
    }
}
