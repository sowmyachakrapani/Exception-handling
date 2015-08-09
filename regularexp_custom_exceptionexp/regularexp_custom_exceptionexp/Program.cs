using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace regularexp_custom_exceptionexp
{
  #region Custom Error class
    class MailidException : System.Exception
    {
        private string message;
        public MailidException(string msg)
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
            try
            {
                Console.WriteLine("Enter customer id");
                int custid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter mailid");
                string id = Console.ReadLine();

                if (Regex.IsMatch(id, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*") == false)
            
                    throw new MailidException("Invalid format");

                Console.WriteLine("Registered successfully !!!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Customer id should be only numbers");
            }
            catch (MailidException e)
            {
                Console.WriteLine(e.GetMessage());
            }

        }
    }
}


