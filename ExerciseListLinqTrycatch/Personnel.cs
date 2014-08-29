using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseListLinqTrycatch
{
    public class Personnel
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        //public DateTime HireDate {get; set;}
        public string CityOrProvince { get; set; }


        private DateTime hireDate;

        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                hireDate = value;


            }
        }


        public Personnel(string fname = "", string lname = "", string gender = "", string province = "")
        {
            //Default HireDate is when creating an instance of the object
            FirstName = fname;
            LastName = lname;
            Gender = gender;
            CityOrProvince = province;
            HireDate = DateTime.Now;
        }

    }
}
