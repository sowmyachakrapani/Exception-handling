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
            int a, b;
            try
            {
                Console.WriteLine("Enter value for a");
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Only numbers are allowed , please input value");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch( Exception err )
                {
                    Console.WriteLine("OOPS !! , failed to input number. Apps terminated");
                    return;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Please input value within range of {0} and {1}", int.MinValue, int.MaxValue);
                return;
            }


            try
            {
                Console.WriteLine("Enter value for b");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Only numbers are allowed , please input value");
                try
                {
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception err)
                {
                    Console.WriteLine("OOPS !! , failed to input number. Apps terminated");
                    return;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Please input value within range of {0} and {1}", int.MinValue, int.MaxValue);
                return;
            }

            try
            {
                double c = a / b;
                Console.WriteLine("Result = {0}", c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero , please input different value for b and try again");
            }
       
            Console.WriteLine("Further part of the code...........");
        }
    }
}
