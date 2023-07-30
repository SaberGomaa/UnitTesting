using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Project
{
    public class Employee
    {
        public int Age { get; set; }

        public bool IsSeniorCitizen(int age)
        {
            return age >= 60 ;
        }

    }
}
