using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Patterns
    {
       public static string reg_pattern = "^[A-Z][a-z]{3,}";
        public bool firstName( string fName)
        {
            return Regex.IsMatch(fName, reg_pattern);
        }
    }
}
