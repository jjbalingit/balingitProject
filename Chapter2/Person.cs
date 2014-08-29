using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class Person
    {
        private double deductions;

        public double Deductions
        {
            get
            {
                return deductions;
            }
            set
            {
                if (value >= 0)
                {
                    deductions = value;  
                }
                else
                {
                    deductions = 0;
                }
            }
            
        }
        public double Basepay { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        private const double Tax = 0.12;

        public Person(string name = "Juan Dela Cruz"
            , string position = "SPO1"
            , double basepay = 15000
            , double deductions = 3000)
        {
            Name = name;
            Position = position;
            Basepay = basepay;
            Deductions = deductions;
        }
            
        
        //public Person(string name)
        //{
        //    Name = name;
        //    Position = "SPO1";
        //    Basepay = 15000;
        //    Deductions = 3000;
        //}

        //public Person()
        //{
        //    Name = "Juan Dela Cruz";
        //    Position = "SPO1";
        //    Basepay = 15000;
        //    Deductions = 3000;

        //}

        //public Person(double Basepay)
        //{
        //    Name = "Juan Dela Cruz";
        //    Position = "SPO1";
        //    Basepay = 15000;
        //    Deductions = 3000;
        //}

        public double GetNetPay()
        {
            double netPay = Basepay - Deductions - (Basepay * Tax);
            return netPay;
        }

        //public void RefreshData()
        //{
        //    Name = "";
        //    Basepay = 15000;
        //    Deductions = 2000;
        //}

        //public void AdjustbasePay(double adjustment, bool positive)
        //{
        //    if(positive)
        //    {
        //       Basepay = Basepay + adjustment; 
        //    }
        //    else
        //    {
        //        Basepay = Basepay - adjustment;
        //    }

        //    if(Basepay < 0)
        //    {
        //        Basepay = 0;
        //    }


        }

    }
        

 

