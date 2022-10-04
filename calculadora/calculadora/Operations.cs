using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Operations
    {
        public static decimal multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static decimal minus(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal sum(decimal num1, decimal num2)
        {
            return num1+num2;
        }

        public static decimal division(decimal num1, decimal num2)
        {
            return num1/num2;
        }

        public static decimal factorial(decimal num1)
        {
            if (num1 == 1)
                return 1;
            return num1 * factorial(num1 - 1); 
        }

    }
}
