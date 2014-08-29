using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public class test
    {
        public string Name { get; set; }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
            }
        }

        public test(string name = "Jose" , string surname = "Balingit")
        {
            Name = name;
            Surname = surname;
        }


    }
}
