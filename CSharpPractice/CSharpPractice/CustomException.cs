using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CSharpPractice
{
    class CustomException
    {
        public static void CustomExceptionMain()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Attribute
        [Serializable]
        public class UserAlreadyLoggedInException : Exception
        {
            // Overload the Constructors from base Exception Class to handle different scenario
            // Normal Exception
            public UserAlreadyLoggedInException(string message)
                : base(message)
            {
            }

            // To Handle Inner Excpetion
            public UserAlreadyLoggedInException(string message, Exception innerException)
                : base(message, innerException)
            {
            }

            // To Handle Application domain/ Enable Communication with outside Application
            public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
}
