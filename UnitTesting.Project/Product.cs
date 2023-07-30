using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Project
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ReturnProductClassBasedOnPrice(int Price)
        {
            return Price > 1000 ? 
                ProductClassEnum.FirstClass.ToString() :
                ProductClassEnum.SecondClass.ToString();  
        }
    }
}
