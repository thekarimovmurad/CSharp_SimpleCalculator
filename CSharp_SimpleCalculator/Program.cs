using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please enter operation");
                Console.WriteLine("Addition-1 // Subtraction-2 // Multiplication-3 // Division-4 // Exit-5 ");
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 5)
                {
                    break;
                }

                Console.WriteLine("number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine(num1 + num2);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(num1 - num2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(num1 * num2);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(num1 / num2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Again");
                            break;
                        }
                }
            }
        }
    }
}
