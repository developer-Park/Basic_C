using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Calculator
    {
        public void addCal(int num1, int num2) {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        }
        public void subCal(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        }

    }


}
