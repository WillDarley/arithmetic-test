using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the arithmetic test");

            // creates a random operator

            var rnd = new Random();

            var operation = rnd.Next(1, 5);
            var number1 = rnd.Next(1, 100);
            var number2 = rnd.Next(1, 100);
            int answer;
            string operatorString;

            switch (operation)
            {
                case 1:
                    answer = number1 + number2;
                    operatorString = "+";
                    break;
                case 2:
                    answer = number1 - number2;
                    operatorString = "-";
                    break;
                case 3:
                    answer = number1 * number2;
                    operatorString = "*";
                    break;
                case 4:
                    answer = number1 / number2;
                    operatorString = "/";
                    break;
                default:
                    answer = 0;
                    operatorString = "?";
                    break;
            }
            
    }
}
