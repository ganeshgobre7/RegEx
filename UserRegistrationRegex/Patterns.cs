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

        public static string reg_pattern2= @"^[a-z0-9]+[@]+[a-z]+[.][a-z]{2,3}";
        /// <summary>
        /// Method to Validate the Email Id
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool eMail(string email)
        {
            return Regex.IsMatch(email, reg_pattern2);
        }
        public static string reg_pattern3= @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}";
        /// <summary>
        /// Method to validate the Mobile Number
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool mobNumber(string mobileNo)
        {
            return Regex.IsMatch(mobileNo, reg_pattern3);
        }

        public static string reg_pattern_4 = @"(?=.*[A-Z])[a-zA-Z]{8,}";
        /// <summary>
        /// Method to validate the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool password(string password)
        {
            return Regex.IsMatch(password, reg_pattern_4);
        }
    }
}
