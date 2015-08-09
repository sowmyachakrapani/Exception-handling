using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customexception_exp
{
    #region Custom Error class
    class AgeException : System.Exception
    {
        private string message;
        public AgeException(string msg)
        {
            message = msg;
        }
        public string GetMessage()
        {
            return message;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region This section developed to read N value
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter persons count");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("No. of persons should be only number");
                }
            }
            #endregion

            #region Read age from the user and find sum
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Enter age of person - {0}", i + 1);
                    int age = int.Parse(Console.ReadLine());
                    if (age < 0) throw new AgeException("Negative not allowed");
                    s = s + age;
                }
                catch (AgeException e)
                {
                    Console.WriteLine(e.GetMessage());
                    --i;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Age can be only numbers");
                    --i;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Please input proper age");
                    --i;
                }
            }
            #endregion

            #region Print result
            double avg = s / n;
            Console.WriteLine("Average = {0:f2}", avg);
            #endregion
        }
    }
 }
    


