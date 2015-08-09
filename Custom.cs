using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication74
{
    class MyError : Exception
    {
        private string msg;
        public MyError(string _msg)
        {
            msg = _msg;
        }
        public override string ToString()
        {
            return msg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Year of birth");
                int yob = int.Parse(Console.ReadLine());
                if (yob < 0 || yob > DateTime.Now.Year)
                {
                    throw new MyError("Invalid year input ,try again");
                }

                int age = DateTime.Now.Year - yob;
                Console.WriteLine("Age = {0}", age);

                if (age >= 18)
                    Console.WriteLine("U can vote");
                else
                    Console.WriteLine("U can't vote");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Year of birth can be only number");
            }
            catch (MyError e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
