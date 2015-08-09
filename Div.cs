using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication74
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter value for a and b");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                double c = a / b;
                Console.WriteLine("Sum = {0}", c);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Only numbers are allowed.......");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Please input value within range of {0} and {1}", int.MinValue, int.MaxValue);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero , try different number");
            }

            Console.WriteLine("Further part of the code...........");
        }
    }
}
