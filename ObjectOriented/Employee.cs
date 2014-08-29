using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public class Employee
    {
        public string Name { get; set; }

        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;

                SetGrossPay(position);

                //At this Point the Gross Pay has been updated

                SetLongPay(HireDate);
                SetDeductions();
            }
        }

        private double grossPay;
        private DateTime hireDate;
        public DateTime HireDate
        {
            get {   return hireDate; }
            set
                {
                    hireDate = value;

                    SetLongPay(hireDate);

                }
        }
        
        private double longPay;
        
        private double sGTI;
        private double philHealth;
        private double tax;
        private double pagibig;
        private double hazardPay;
        private double clothing;
        private double quarter;
        private double laundry;
        private double pera;


        public Employee(string name = "Juan Dela Cruz", string position = "PO1")

        {
            //Default HireDate is when creating an instance of the object
            HireDate = DateTime.Now;
            Name = name;
            Position = position;

        }

        //Methods

        private void SetLongPay(DateTime hireDate)
        {
            int YearsOfService = DateTime.Now.Year - hireDate.Year;

            switch (Position)
            {

              case "PO1":
                {
                    if (YearsOfService >= 5 && YearsOfService < 10)
                    {
                        longPay = 1483.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 15)
                    {
                         longPay = 3115.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 20)
                    {
                        longPay = 4910.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 25 )
                    {
                        longPay = 6884.00;
                    }
                    else if (YearsOfService >= 10 &&YearsOfService < 30 )
                    {
                        longPay = 7417.00;
                    }
	


                    break;



                }

               case "PO2":
                {
                    if (YearsOfService >= 5 &&YearsOfService < 10)
                    {
                        longPay = 1693.00; 
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 15)
                    {
                        longPay = 3556.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 20)
                    {
                        longPay = 5605.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 25)
                    {
                        longPay = 7859.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 30)
                    {
                        longPay = 8467.00;
                    }


                    break;            

                }

              case "PO3":
               {
                    if (YearsOfService >= 10 && YearsOfService < 10)
                    {
                        longPay = 1867.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 15)
                    {
                        longPay = 3920;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 20 )
                    {
                        longPay = 6178.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 25 )
                    {
                        longPay = 8662.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 30)
                    {
                        longPay = 9333.00;
                    }


                   break;
               }

             case "SPO1":
                 {
                    if (YearsOfService >= 10 && YearsOfService < 10)
                    {
                        longPay = 2171.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 15 )
                    {
                        longPay = 4559.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 20)
                    {
                        longPay = 7186.00;
                    }
                    else if (YearsOfService >= 10 &&YearsOfService < 25 )
                    {
                        longPay = 1076.00;
                    }
                    else if (YearsOfService >= 10 && YearsOfService < 30)
                    {
                        longPay = 10856.00;
                    }

                     break;
                     
    
                 }

             case "SPO2":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 2351.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 4938.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 7783.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 10912.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 11757.00;
                     }

                     break;


                 }

             case "SPO3":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 2539.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 5333.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 8405.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 11785.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 12697.00;
                     }

                     break;


                 }

             case "SPO4":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 2743.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 5759.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 9078.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 12728.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 13713.00;
                     }

                     break;


                 }

             case "PINSP":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 3234.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 6792.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 10705.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 15009.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 16171.00;
                     }

                     break;


                 }

             case "PSINSP":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 3531.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 7416.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 11688.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 16388.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 17656.00;
                     }

                     break;
                 }

             case "PCINSP":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 3731.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 7836.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 12351.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 17317.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 18657.00;
                     }

                     break;


                 }

             case "PSUPT":
                 {
                     if (YearsOfService >= 10 && YearsOfService < 10)
                     {
                         longPay = 4030.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 15)
                     {
                         longPay = 8463.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 20)
                     {
                         longPay = 13339.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 25)
                     {
                         longPay = 18702.00;
                     }
                     else if (YearsOfService >= 10 && YearsOfService < 30)
                     {
                         longPay = 20149.00;
                     }

                     break;


                 }
            default:
                break;

        }
     }

     private void SetGrossPay(string position)
     {

         switch (position)
         {
            case "PO1":
                {
                    grossPay = 14834.00;
                    break;
                }
                    
            case "PO2":
                {
                    grossPay = 16934.00;
                    break;
                }
            case "PO3":
                {
                    grossPay = 18665.00;
                    break;
                }
            case "SPO1":
                {
                    grossPay = 21711.00;
                    break;
                }
            case "SPO2":
                {
                    grossPay = 23513.00;
                    break;
                }
            case "SPO3":
                {
                    grossPay = 25394.00;
                    break;
                }
            case "SPO4":
                {
                    grossPay = 27425.00;
                    break;
                }
            case "PINSP":
                {
                    grossPay = 32341.00;
                    break;
                }
            case "PSINSP":
                {
                    grossPay = 35312.00;
                    break;
                }
            case "PCINSP":
                {
                    grossPay = 37313.00;
                    break;
                }
            case "PSUPT":
                {
                    grossPay = 40298.00;
                    break;
                }
            default:
                 break;
                    
         }            

     }


      //Getting the LongPay where LongPay is not a property, a user can set
        
      public double GetLongPay()
            {
                return longPay;
            } 
      
      //Getting the GrossPay where GrossPay is not a property, a user can set
        public double GetGrossPay()
            {
                return grossPay;
            }
       
      //private void SetAllownaces()
      //{
      //    clothing = Allowances.GetClothing(grossPay);
      //    quarter = Allowances.GetQuarter(grossPay);
      //    laundry = Allowances.GetLaundry(grossPay);
      //    pera = Allowances.GetPera(grossPay);
      //}
      
      public double GetClothing()
      {
          clothing = Allowances.GetClothing(grossPay);
          return clothing;
      }
      public double GetQuarter()
      {
          quarter = Allowances.GetQuarter(grossPay);
          return quarter;
      }
      public double GetLaundry()
      {
          laundry = Allowances.GetLaundry(grossPay);
          return laundry;
      }
      public double GetPera()
      {
          pera = Allowances.GetPera(grossPay);
          return pera;
      }
      public double GetHazardPay()
      {
          hazardPay = Allowances.GetHazardPay(grossPay);
          return hazardPay;
      }
      private void SetDeductions()
      {
          sGTI = Deductions.GetSGTI(grossPay);
          tax = Deductions.GetTax(grossPay);
          philHealth = Deductions.GetPhilHealth(grossPay);
          pagibig = Deductions.GetPagibig(grossPay);
      }
      public double GetSGTI()
      {
          return sGTI;
      }

      public double GetTax()
      {
          return tax;
      }
      public double GetPhilHealth()
      {
          return philHealth;
      }
      public double GetPagibig()
      {
          return pagibig;
      }
      public double GetTotalSalary()
      {
          double totalSalary = 0;
          totalSalary = grossPay + longPay + Allowances.GetTotalAllowances(grossPay) -
    Deductions.GetTotalDeductions(grossPay);

          return totalSalary;
      }
                                
    }
}
