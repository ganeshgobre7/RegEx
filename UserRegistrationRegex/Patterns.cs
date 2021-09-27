using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Patterns
    {
        public static string reg_pattern = "^[A-Z][a-z]{3,}";
            /// <summary>
            /// Method to Validate the First Name
            /// </summary>
            /// <param name="fName"></param>
            /// <returns></returns>
        public bool firstName( string fName)
        {
            return Regex.IsMatch(fName, reg_pattern);
        }

        public static string reg_pattern1 = "^[A-Z][a-z]{3,}";
        /// <summary>
        /// Method to Validate the Last Name
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public bool lastName(string lName)
        {
            return Regex.IsMatch(lName, reg_pattern1);
        }
    }
}
