using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person("Jose Balingit","PO1");
            
            //myPerson.Name = "Jose";
            //myPerson.Position = "Technincal";
            //myPerson.Basepay = 9000;
            //myPerson.Deductions = 7000;


            //Console.WriteLine("Name: " + myPerson.Name);
            //Console.WriteLine("Position: " + myPerson.Position);
            //Console.WriteLine("BasePay: " + myPerson.Basepay);
            //Console.WriteLine("Deductions: " + myPerson.Deductions);
            //Console.WriteLine("Net Pay: " + myPerson.GetNetPay());

            //Console.WriteLine();

            //myPerson.RefreshData();
            //Console.WriteLine("Name: " + myPerson.Name);
            //Console.WriteLine("Position: " + myPerson.Position);
            //Console.WriteLine("BasePay: " + myPerson.Basepay);
            //Console.WriteLine("Deductions: " + myPerson.Deductions);
            //Console.WriteLine("Net Pay: " + myPerson.GetNetPay());

            //Console.WriteLine();

            //myPerson.AdjustbasePay(2000, true);
            Console.WriteLine("Name: " + myPerson.Name);
            Console.WriteLine("Position: " + myPerson.Position);
            Console.WriteLine("BasePay: " + myPerson.Basepay);
            Console.WriteLine("Deductions: " + myPerson.Deductions);
            Console.WriteLine("Net Pay: " + myPerson.GetNetPay());



       

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
