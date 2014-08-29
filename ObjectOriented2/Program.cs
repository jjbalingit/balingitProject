using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee2 myEmployee2 = new Employee2("Jose Jefferson");

            Console.WriteLine("Employee Name: " + myEmployee2.Name);
            Console.WriteLine("Position: " + myEmployee2.Position);
            Console.WriteLine("Gross Pay: " + myEmployee2.GetGrossPay());
            Console.WriteLine("Clothing Allowance: " + myEmployee2.GetClothing());
            Console.WriteLine("Quarter Allowance: " + myEmployee2.GetQuarter());
            Console.WriteLine("Laundry Allowance: " + myEmployee2.GetLaundry());
            Console.WriteLine("PERA: " + myEmployee2.GetPera());
            Console.WriteLine("Hazard Pay: " + myEmployee2.GetHazardPay());
            Console.WriteLine("Long Pay: " + myEmployee2.GetLongPay());
            Console.WriteLine("SGTI: " + myEmployee2.GetSGTI());
            Console.WriteLine("Phil Health: " + myEmployee2.GetPhilHealth());
            Console.WriteLine("Pag-ibig: " + myEmployee2.GetPagibig());
            Console.WriteLine("Tax: " + myEmployee2.GetTax());
            Console.WriteLine("Total Salary: " + myEmployee2.GetTotalSalary());



            Console.WriteLine();


            //NOTICE a lot will change, just by changing the Position and HireDate

            myEmployee2.Position = "INSP";
            myEmployee2.HireDate = Convert.ToDateTime("01/08/1990");

            Console.WriteLine("Employee Name: " + myEmployee2.Name);
            Console.WriteLine("Position: " + myEmployee2.Position);
            Console.WriteLine("Gross Pay: " + myEmployee2.GetGrossPay());
            Console.WriteLine("Clothing Allowance: " + myEmployee2.GetClothing());
            Console.WriteLine("Quarter Allowance: " + myEmployee2.GetQuarter());
            Console.WriteLine("Laundry Allowance: " + myEmployee2.GetLaundry());
            Console.WriteLine("PERA: " + myEmployee2.GetPera());
            Console.WriteLine("Hazard Pay: " + myEmployee2.GetHazardPay());
            Console.WriteLine("Long Pay: " + myEmployee2.GetLongPay());
            Console.WriteLine("SGTI: " + myEmployee2.GetSGTI());
            Console.WriteLine("PhilHealth: " + myEmployee2.GetPhilHealth());
            Console.WriteLine("Pag-ibig: " + myEmployee2.GetPagibig());
            Console.WriteLine("Tax: " + myEmployee2.GetTax());
            Console.WriteLine("Total Salary: " + myEmployee2.GetTotalSalary());

            Console.WriteLine("Press Any Key to exit");
            Console.Read();
        }
    }
}
