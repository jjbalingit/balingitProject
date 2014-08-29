using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2
{
    public static class Allowances2
    {
        public static double GetTotalAllowances2(double grossPay)
        {
            double totalallowances = GetClothing(grossPay) + GetQuarter(grossPay) + GetLaundry(grossPay) + GetPera(grossPay) + GetHazardPay(grossPay);

            return totalallowances;
        }
        public static double GetClothing(double grossPay)
        {
            return 200.00;
        }

        public static double GetQuarter(double grossPay)
        {
            double quarter = 0;
            {
                if (grossPay >= 14834 && grossPay < 16934)
                {
                    quarter = 400.00;
                }
                else if (grossPay >= 18665 && grossPay < 21711)
                {
                    quarter = 450.00;
                }
            }

            return quarter;

        }

        public static double GetLaundry(double grossPay)
        {
            return 30.00;
        }

        public static double GetPera(double grossPay)
        {
            return 2000.00;
        }

        public static double GetHazardPay(double grossPay)
        {
            return 240.00;
        }

    }
}
