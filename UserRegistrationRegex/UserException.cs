using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationRegex
{
   public class UserException : Exception  
    {

        public enum ExceptionType
        {
            UserMessage,
        }
        public ExceptionType type;
        public UserException(ExceptionType ex1, string message) : base(message)
        {
            this.type = ex1;
        }
    }
}
