using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public static class Allowances
    {
        public static double GetTotalAllowances(double grossPay)
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
            if (grossPay >= 14834 && grossPay <= 16934 )
            {
                quarter = 400;
            }
            else if (grossPay >= 18665 && grossPay <= 21711)
            {
                quarter = 450;
            }
            else if (grossPay >= 23513 && grossPay <= 27425)
            {
                quarter = 500;  
            }
            else if (grossPay >= 32341 && grossPay < 35312)
            {
                quarter = 600;
            }
            else if (grossPay >= 35312 && grossPay < 37313)
            {
                quarter = 650;
            }
            else if (grossPay >= 37313 && grossPay < 40298)
            {
                quarter = 700;
            }
            else if (grossPay >= 40298 && grossPay < 47002)
            {
                quarter = 800;
            }

            return quarter;
              
            }
        }
        public static double GetLaundry(double grossPay)
        {
        double laundry = 0;
        {
            if (grossPay >= 14834 && grossPay <=27425 )
            {
                laundry = 30.00;
            }
            else if (grossPay >= 32341 && grossPay <= 40298)
            {
                laundry = 60.00;   
            }

            return laundry;
        }
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
