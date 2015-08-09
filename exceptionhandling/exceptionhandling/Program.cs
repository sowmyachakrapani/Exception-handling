using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number");
                    int fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second number");
                    int sn = Convert.ToInt32(Console.ReadLine());
                    int result = fn / sn;
                    Console.WriteLine("result={0}", result);
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Users\chakrapani\Documents\Visual Studio 2010\Projects\exceptionhandling\log1.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.GetType());
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.WriteLine();
                        sw.Close();
                        Console.WriteLine("there is a problem please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "is not present", ex);
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current exception = {0}", exception.GetType().Name);
                Console.WriteLine("Inner exception = {0}", exception.InnerException.GetType().Name);
            }

        }
 
    }
}
