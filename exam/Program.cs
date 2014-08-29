using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            laptop myLaptop = new laptop();

            Console.WriteLine("Model: " + myLaptop.Getmodel());
            Console.WriteLine("Price: " + myLaptop.Getprice());
            Console.WriteLine("Brand: " + myLaptop.Getbrand());
            Console.WriteLine("Press any key to exit");
            Console.Read();

        }
    }
}
