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

            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            int totalscore = 0;

            for (int i = 0; i < 10; i++)
            {
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

                Console.WriteLine($"what is the answer to {number1} {operatorString} {number2}?");
                int answerGiven = int.Parse(Console.ReadLine());

                if (answerGiven == answer)
                {
                    Console.WriteLine("correct");
                    totalscore++;
                }
                else
                {
                    Console.WriteLine("incorrect");
                }  
            }
            Console.WriteLine( );
            Console.WriteLine("your total score out of 10 is " + totalscore);


            Console.ReadLine();
        }    
    }
}
