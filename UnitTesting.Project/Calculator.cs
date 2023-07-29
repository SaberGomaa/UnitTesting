using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Project
{
    public class Calculator
    {
        public int Add_Int(int n1 , int n2)
        {
            return n1 + n2;
        }

        public int Sub_Int(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Div_Int(int n1, int n2)
        {
            return n1 / n2;
        }
        public double Div_Double(double n1, double n2)
        {
            if (n2 == 0) throw new DivideByZeroException();
            return n1 / n2;
        }
    }
}
