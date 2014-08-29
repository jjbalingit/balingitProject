using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2
{
    public static class Deductions2
    {
        //Static Classes, use static Methods
        public static double GetTotalDeductions(double grossPay)
        {
            double totaldeductions = GetSGTI(grossPay) + GetPhilHealth(grossPay) +
    GetTax(grossPay) + GetPagibig(grossPay);

            return totaldeductions;
        }

        public static double GetPagibig(double grossPay)
        {
            return 100;
        }

        public static double GetSGTI(double grossPay)
        {
            //EDIT
            return 6.00;
        }

        public static double GetPhilHealth(double grossPay)
        {
            //Do logic for PhilHealth
            double philHealth = 0;
            {
                if (grossPay >= 5000 && grossPay < 6000)
                {
                    philHealth = 50.00;
                }
                else if (grossPay >= 6000 && grossPay < 7000)
                {
                    philHealth = 62.50;
                }
                else if (grossPay >= 7000 && grossPay < 8000)
                {
                    philHealth = 75.00;
                }
                else if (grossPay >= 8000 && grossPay < 9000)
                {
                    philHealth = 87.50;
                }
                else if (grossPay >= 9000 && grossPay < 10000)
                {
                    philHealth = 100.00;
                }
                else if (grossPay >= 10000 && grossPay < 11000)
                {
                    philHealth = 112.50;
                }
                else if (grossPay >= 11000 && grossPay < 12000)
                {
                    philHealth = 125.00;
                }
                else if (grossPay >= 12000 && grossPay < 13000)
                {
                    philHealth = 137.50;
                }
                else if (grossPay >= 13000 && grossPay < 14000)
                {
                    philHealth = 150.00;
                }
                else if (grossPay >= 14000 && grossPay < 15000)
                {
                    philHealth = 162.50;
                }
                else if (grossPay >= 15000 && grossPay < 16000)
                {
                    philHealth = 175;
                }
                else if (grossPay >= 16000 && grossPay < 17000)
                {
                    philHealth = 187.50;
                }
                else if (grossPay >= 17000 && grossPay < 18000)
                {
                    philHealth = 200.00;
                }
                else if (grossPay >= 18000 && grossPay < 19000)
                {
                    philHealth = 212.50;
                }
                else if (grossPay >= 19000 && grossPay < 20000)
                {
                    philHealth = 225.00;
                }
                else if (grossPay >= 20000 && grossPay < 21000)
                {
                    philHealth = 237.50;
                }
                else if (grossPay >= 21000 && grossPay < 22000)
                {
                    philHealth = 250.00;
                }
                else if (grossPay >= 22000 && grossPay < 23000)
                {
                    philHealth = 262.50;
                }
                else if (grossPay >= 23000 && grossPay < 24000)
                {
                    philHealth = 275.00;
                }
                else if (grossPay >= 24000 && grossPay < 25000)
                {
                    philHealth = 287.50;
                }
                else if (grossPay >= 25000 && grossPay < 26000)
                {
                    philHealth = 300;
                }
                else if (grossPay >= 26000 && grossPay < 27000)
                {
                    philHealth = 312.50;
                }
                else if (grossPay >= 27000 && grossPay < 28000)
                {
                    philHealth = 325;
                }
                else if (grossPay >= 28000 && grossPay < 29000)
                {
                    philHealth = 337.50;
                }
                else if (grossPay >= 29000 && grossPay < 30000)
                {
                    philHealth = 350;
                }
                else if (grossPay >= 30000 && grossPay < 57700)
                {
                    philHealth = 375;
                }


            }

            return philHealth;
        }
        public static double GetTax(double grossPay)
        {
            //Do Tax computation
            return grossPay * .12;
        }

    }
}
