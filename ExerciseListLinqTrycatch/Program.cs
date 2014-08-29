using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseListLinqTrycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personnel> pnpPersonnel = new List<Personnel>();


            for (int index = 0; index < 5; )
            {
                string fname; string lname; string gender; string province; index++;

                Console.Write("Enter First Name: ");
                fname = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                lname = Console.ReadLine();

                Console.Write("Enter City or Province: ");
                province = Console.ReadLine();

                

                try
                {
                    Console.Write("Enter Gender: ");
                    gender = Console.ReadLine();

                    if (gender.ToLower() != "male" && gender.ToLower() != "female")
                    {
                        Console.WriteLine("Invalid Gender");
                        continue;
                    }


                    //error if date is invalid
                    Console.Write("Enter the Hire Date: ");
                    Personnel newPersonnel = new Personnel(fname, lname, gender, province);
                    newPersonnel.HireDate = Convert.ToDateTime(Console.ReadLine());

                    pnpPersonnel.Add(newPersonnel);

                    //Employee was added
                    Console.WriteLine("Employee successfully added!");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error Message: " + ex.Message);
                    index--;
                    Console.WriteLine("Employee not added!");
                }

            }

            Console.WriteLine("PNP Personnel************************************");

            foreach (var personnel in pnpPersonnel)
            {
                Console.WriteLine("\t First Name: " + personnel.FirstName);
                Console.WriteLine("\t Last Name: " + personnel.LastName);
                Console.WriteLine("\t Gender: " + personnel.Gender);
                Console.WriteLine("\t Hire Date: " + personnel.HireDate);
                Console.WriteLine("\t City/Province: " + personnel.CityOrProvince);
                Console.WriteLine();
            }

            Console.WriteLine("Personnel in Cavite******************************");

            List<Personnel> CaviteP = pnpPersonnel.Where(x => x.CityOrProvince == "Cavite").ToList();

            foreach (var personnel in CaviteP)
            {
                Console.WriteLine("First Name: " + personnel.FirstName);
                Console.WriteLine("Last Name: " + personnel.LastName);
                Console.WriteLine("Gender: " + personnel.Gender);
                Console.WriteLine("Hire Date: " + personnel.HireDate);
                Console.WriteLine("City/Province: " + personnel.CityOrProvince);
                Console.WriteLine();
            }

            Console.WriteLine("Female Employees*********************************");
            Console.WriteLine();
            List<Personnel> GenderF = pnpPersonnel.Where(y => y.Gender == "female").ToList();

            foreach (var personnel in GenderF)
            {
                Console.WriteLine("First Name: " + personnel.FirstName);
                Console.WriteLine("Last Name: " + personnel.LastName);
                Console.WriteLine("Gender: " + personnel.Gender);
                Console.WriteLine("Hire Date: " + personnel.HireDate);
                Console.WriteLine("City/Province: " + personnel.CityOrProvince);
                Console.WriteLine();
            }

            Console.WriteLine("Hired Date From 1990 to 1999********************");
            Console.WriteLine();
            List<Personnel> hiredate2 = pnpPersonnel.Where(x => x.HireDate.Year >= 1990 && x.HireDate.Year <= 1999).ToList();

            foreach (var personnel in hiredate2)
            {
                Console.WriteLine("First Name: " + personnel.FirstName);
                Console.WriteLine("Last Name: " + personnel.LastName);
                Console.WriteLine("Gender: " + personnel.Gender);
                Console.WriteLine("Hire Date: " + personnel.HireDate);
                Console.WriteLine("City/Province: " + personnel.CityOrProvince);
                Console.WriteLine();
            }

            Console.WriteLine("Last Name Starts With A*************************");
            Console.WriteLine();
            List<Personnel> lastnameA = pnpPersonnel.Where(a => a.LastName.StartsWith("A")).ToList();

            foreach (var personnel in lastnameA)
            {
                Console.WriteLine("First Name: " + personnel.FirstName);
                Console.WriteLine("Last Name: " + personnel.LastName);
                Console.WriteLine("Gender: " + personnel.Gender);
                Console.WriteLine("Hire Date: " + personnel.HireDate);
                Console.WriteLine("City/Province: " + personnel.CityOrProvince);
                Console.WriteLine();
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();

        }
       
    }
}

