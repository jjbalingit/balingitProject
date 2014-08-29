using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("Jose Jefferson");

            Console.WriteLine("Employee Name: " + myEmployee.Name);
            Console.WriteLine("Position: " + myEmployee.Position);
            Console.WriteLine("Gross Pay: " + myEmployee.GetGrossPay());
            //Console.WriteLine("Clothing Allowance: " + myEmployee.GetClothing());
            //Console.WriteLine("Quarter Allowance: " + myEmployee.GetQuarter());
            //Console.WriteLine("Laundry Allowance: " + myEmployee.GetLaundry());
            //Console.WriteLine("PERA: " + myEmployee.GetPera());
            //Console.WriteLine("Hazard Pay: " + myEmployee.GetHazardPay());
            Console.WriteLine("Long Pay: " + myEmployee.GetLongPay());
            Console.WriteLine("SGTI: " + myEmployee.GetSGTI());
            Console.WriteLine("Phil Health: " + myEmployee.GetPhilHealth());
            Console.WriteLine("Pag-ibig: " + myEmployee.GetPagibig());
            Console.WriteLine("Tax: " + myEmployee.GetTax());
            Console.WriteLine("Total Salary: " + myEmployee.GetTotalSalary());



            Console.WriteLine();


            //NOTICE a lot will change, just by changing the Position and HireDate

            myEmployee.Position = "SPO2";
            myEmployee.HireDate = Convert.ToDateTime("01/08/2003");

            Console.WriteLine("Employee Name: " + myEmployee.Name);
            Console.WriteLine("Position: " + myEmployee.Position);
            Console.WriteLine("Gross Pay: " + myEmployee.GetGrossPay());
            //Console.WriteLine("Clothing Allowance: " + myEmployee.GetClothing());
            //Console.WriteLine("Quarter Allowance: " + myEmployee.GetQuarter());
            //Console.WriteLine("Laundry Allowance: " + myEmployee.GetLaundry());
            //Console.WriteLine("PERA: " + myEmployee.GetPera());
            //Console.WriteLine("Hazard Pay: " + myEmployee.GetHazardPay());
            Console.WriteLine("Long Pay: " + myEmployee.GetLongPay());
            Console.WriteLine("SGTI: " + myEmployee.GetSGTI());
            Console.WriteLine("PhilHealth: " + myEmployee.GetPhilHealth());
            Console.WriteLine("Pag-ibig: " + myEmployee.GetPagibig());
            Console.WriteLine("Tax: " + myEmployee.GetTax());
            Console.WriteLine("Total Salary: " + myEmployee.GetTotalSalary());

            Console.WriteLine("Press Any Key to exit");
            Console.Read();
        }
    }
}
