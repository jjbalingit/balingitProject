using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            test mytest = new test("Jose Jefferson");

            Console.WriteLine("Employees Name: " + mytest.Name );
            Console.WriteLine("Employess Surname: " + mytest.Surname);
            Console.WriteLine();

            
           

            Console.WriteLine("Press any key to continue");
            Console.Read();

        }
    }
}



 //ARRAYS
            //int[] magicNumbers = {77, 25, 24, 56, 78, 68, 24, 55, 33 };

            //for (int index = 0; index < magicNumbers.Length; index++)
            //{
            //    //Even Numbers
            //    if (magicNumbers[index] % 2 == 0)
            //    {
            //        Console.WriteLine(magicNumbers[index]);                   
            //    }
              
            //}





//ARRAYS
//int[] magicNumbers = new int[7];
//magicNumbers[0] = 67;
//magicNumbers[1] = 77;

//for (int index = 0; index < magicNumbers.Length; index++)
//{
//    Console.WriteLine(magicNumbers[index]);
//}

//string[] commonNames = new string[8];
//commonNames[5] = "Jose";
//commonNames[7] = "Jefferson";
//commonNames[3] = "Eric";

//for (int index = 0; index < commonNames.Length; index++)
//{
//    Console.WriteLine(commonNames[index]);
//}

//Console.WriteLine("Press any key to continue");
//Console.Read();