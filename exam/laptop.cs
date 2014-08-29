using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }

        private string model;
        private double price;
        private string brand;

        public string Getmodel()
        {
            model = "Surface Pro 3";
            return model;
        }

        public double Getprice()
        {
            price = 4500.00;
            return price;
        }

        public string Getbrand()
        {
            brand = "Microsoft";
            return brand;
        }


    }


    
}
