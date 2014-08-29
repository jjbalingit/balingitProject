using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Try - Catch*************************************************************************************
            //    //Create a list of Employees
            //    List<Employee>pnpEmployees = new List<Employee>();

            //    //Insert 3 Employees
            //    for (int index = 0; index < 3; index++)
            //    {
            //        string name, position = "";

            //        Console.Write("Enter the Name: ");
            //        name = Console.ReadLine();

            //        Console.Write("Enter the Position: ");
            //        position = Console.ReadLine();

            //        Employee newEmployee = new Employee(name, position);

            //        try
            //        {
            //            //Handles the Error if the Hire Date is Invalid
            //            Console.WriteLine("Enter the Hire Date: ");
            //            newEmployee.HireDate = Convert.ToDateTime(Console.ReadLine());

            //            //Add Employee to the List
            //            pnpEmployees.Add(newEmployee);

            //            //Promt the user, Employee was added
            //            Console.WriteLine("Employee successfuly added! :)");
            //        }

            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error Message: " + ex.Message);
            //            Console.WriteLine("Employee not added! :(");
            //        }

            //    }

            //    Console.WriteLine("PNP Employees");
            //    //Print All the Employees
            //    foreach(var employee in pnpEmployees)
            //    {
            //        Console.WriteLine("\t Name: " + employee.Name);
            //        Console.WriteLine("\t Position: " + employee.Position);
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Press any key to continue....");
            //    Console.ReadLine();



            //        }

            //    }
            //}



            ////LINQ(language Integrated Query)****************************************************************************
            ////Create a List of Employees
                List<Employee> pnpEmployees = new  List<Employee>();

                Employee myEmployee1 = new Employee("jose balingit", "po2");
                Employee myEmployee2 = new Employee("jefferson balingit", "po1");
                Employee myEmployee3 = new Employee("eric cire", "po2");
                Employee myEmployee4 = new Employee();

                //add those 4 employees to the list

                pnpEmployees.Add(myEmployee1);
                pnpEmployees.Add(myEmployee2);
                pnpEmployees.Add(myEmployee3);
                pnpEmployees.Add(myEmployee4);

                Console.WriteLine("pnp employee");
                //for each loop to display the name and position of the employees
                foreach (var employee in pnpEmployees)
                {
                    Console.WriteLine("\t name: " + employee.Name);
                    Console.WriteLine("\t position: " + employee.Position);
                    Console.WriteLine();
                }

                Console.WriteLine("po2 officers");
                //linq statement to get po2 officers
                List<Employee> po2officers = pnpEmployees.Where(x => x.Position == "po2").ToList();

                foreach (var employee in po2officers)
                {
                    Console.WriteLine("\t name: " + employee.Name);
                    Console.WriteLine("\t position: " + employee.Position);
                    Console.WriteLine();
                }

                Console.WriteLine("jose the employee");
                //linq statement to find the employee named jose

                Employee joseemployee = pnpEmployees.Where(x => x.Name.Contains("jose")).FirstOrDefault();

                Console.WriteLine("\t name: " + joseemployee.Name);
                Console.WriteLine("\t position: " + joseemployee.Position);

                Console.WriteLine("press any key to continue");
                Console.Read();
            }
        }
    }



//            ///////list ***************************************************************************************
//            list<employee> pnpemployees = new list<employee>();

//            Employee myemployee1 = new employee("jose baingit", "psupt");
//            Employee myemployee2 = new employee("jefferson balingit", "pcinsp");

//            pnpemployees.add(myemployee1);
//            pnpemployees.add(myemployee2);
//            //print employee records
//            foreach (var employee in pnpemployees)
//            {

//                Console.WriteLine("name: " + employee.name);
//                Console.WriteLine("position: " + employee.position);
//                Console.WriteLine("salary: " + employee.gettotalsalary());
//                Console.WriteLine();
//            }

//            pnpemployees.remove(myemployee2);
//           Console.WriteLine("employees 2 removed");

//            //print employess record
//            foreach (var employee in pnpemployees)
//            {
//                Console.WriteLine("name: " + employee.name);
//                Console.WriteLine("position: " + employee.position);
//                Console.WriteLine("salary: " + employee.gettotalsalary());
//                Console.WriteLine();
//            }

//            Console.WriteLine("press any key to continue");
//            Console.ReadKey();
//            }
//    }
//}


            ////***************************************************************************************************
            //Employee myEmployee = new Employee("Jose Jefferson L. Balingit II");
     
            //Console.WriteLine("Employee Name: " + myEmployee.Name);
            //Console.WriteLine("Position: " + myEmployee.Position);
            //Console.WriteLine("Gross Pay: " + myEmployee.GetGrossPay());
            //Console.WriteLine();
            //Console.WriteLine("ALLOWANCES");
            //Console.WriteLine("----------");
            //Console.WriteLine("Clothing Allowance: " + myEmployee.GetClothing());
            //Console.WriteLine("Quarter Allowance: " + myEmployee.GetQuarter());
            //Console.WriteLine("Laundry Allowance: " + myEmployee.GetLaundry());
            //Console.WriteLine("PERA: " + myEmployee.GetPera());
            //Console.WriteLine("Hazard Pay: " + myEmployee.GetHazardPay());
            //Console.WriteLine("Long Pay: " + myEmployee.GetLongPay());
            //Console.WriteLine();
            //Console.WriteLine("DEDUCTIONS");
            //Console.WriteLine("----------");
            //Console.WriteLine("SGTI: " + myEmployee.GetSGTI());
            //Console.WriteLine("Phil Health: " + myEmployee.GetPhilHealth());
            //Console.WriteLine("Pag-ibig: " + myEmployee.GetPagibig());
            //Console.WriteLine("Tax: " + myEmployee.GetTax());
            //Console.WriteLine("Total Salary: " + myEmployee.GetTotalSalary());

            
            
            //Console.WriteLine();
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine();
          
        
            ////NOTICE a lot will change, just by changing the Position and HireDate

            //myEmployee.Position = "PSUPT";
            //myEmployee.HireDate = Convert.ToDateTime("01/08/2003");

            //Console.WriteLine("Employee Name: " + myEmployee.Name);
            //Console.WriteLine("Position: " + myEmployee.Position);
            //Console.WriteLine("Gross Pay: " + myEmployee.GetGrossPay());
            //Console.WriteLine();
            //Console.WriteLine("ALLOWANCES");
            //Console.WriteLine("----------");
            //Console.WriteLine("Clothing Allowance: " + myEmployee.GetClothing());
            //Console.WriteLine("Quarter Allowance: " + myEmployee.GetQuarter());
            //Console.WriteLine("Laundry Allowance: " + myEmployee.GetLaundry());
            //Console.WriteLine("PERA: " + myEmployee.GetPera());
            //Console.WriteLine("Hazard Pay: " + myEmployee.GetHazardPay());
            //Console.WriteLine("Long Pay: " + myEmployee.GetLongPay());
            //Console.WriteLine();
            //Console.WriteLine("DEDUCTIONS");
            //Console.WriteLine("----------");
            //Console.WriteLine("SGTI: " + myEmployee.GetSGTI());
            //Console.WriteLine("PhilHealth: " + myEmployee.GetPhilHealth());
            //Console.WriteLine("Pag-ibig: " + myEmployee.GetPagibig());
            //Console.WriteLine("Tax: " + myEmployee.GetTax());
            //Console.WriteLine("Total Salary: " + myEmployee.GetTotalSalary());

            //Console.WriteLine("Press enter to exit");
            //Console.Read();

        //}
 
