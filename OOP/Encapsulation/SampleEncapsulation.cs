using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class SampleEncapsulation
    {
        public int Compute(string operatorValue, int numA, int numB)
        {
            int result = 0;
            switch (operatorValue)
            {
                case "+":
                    result = Addition(numA, numB);
                    break;
                case "-":
                    result = Subtraction(numA, numB);
                    break;
                case "/":
                    result = Division(numA, numB);
                    break;
                case "*":
                    result = Multiplication(numA, numB);
                    break;
                default:
                    break;
            }
            return result;
        }

        private int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Subtraction(int num1, int num2)
        {

            return num1 - num2;
        }
        private int Division(int num1, int num2)
        {

            return num1 / num2;
        }
        private int Multiplication(int num1, int num2)
        {

            return num1 * num2;
        }
    }
}
