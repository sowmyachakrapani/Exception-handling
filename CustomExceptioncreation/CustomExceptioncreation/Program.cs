using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace CustomExceptioncreation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("user already logged in- no duplicate session allowed");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
              
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {
        }

        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
        {
        }
    }
}
