using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
   public class Patterns
    {
        public static string reg_pattern = "^[A-Z]{1}[a-z]{3,}";
            /// <summary>
            /// Method to Validate the First Name
            /// </summary>
            /// <param name="fName"></param>
            /// <returns></returns>      
       public bool FirstName(string firstName)
        {
            try
            {
                if (!Regex.IsMatch(firstName, reg_pattern))                 
                throw new UserException(UserException.ExceptionType.UserMessage, "Invalid First Name");               
            }
            catch(UserException ex1 )
            {
                Console.WriteLine(ex1.Message);
            }
            return Regex.IsMatch(firstName, reg_pattern);
        }

        public static string reg_pattern1 = "^[A-Z]{1}[a-z]{3,}";
        /// <summary>
        /// Method to Validate the Last Name
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        /*public bool lastName(string lName)
        {
            return Regex.IsMatch(lName, reg_pattern1);
        }*/
        public bool LastName(string lastName)
        {
            try
            {
                if (!Regex.IsMatch(lastName, reg_pattern1))
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Last Name");
            }
            catch (UserException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            return Regex.IsMatch(lastName, reg_pattern1);
        }

        public static string reg_pattern2= @"^[a-z0-9]+[@]+[a-z]+[.][a-z]{2,3}$";
        /// <summary>
        /// Method to Validate the Email Id
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool eMail(string email)
        {
            try
            {
                if (!Regex.IsMatch(email, reg_pattern2))
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Email ID");
            }
            catch (UserException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            return Regex.IsMatch(email, reg_pattern2);
        }

        public static string reg_pattern3= @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}$";
        /// <summary>
        /// Method to validate the Mobile Number
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool mobNumber(string mobileNo)
        {
            try
            {
                if (!Regex.IsMatch(mobileNo, reg_pattern3))
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Mobile Nummber");
            }
            catch (UserException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            return Regex.IsMatch(mobileNo, reg_pattern3);
        }

        public static string reg_pattern4 = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d@$!%*?&]{8}$";
        /// <summary>
        /// Method to validate the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool password(string password)
        {
            try
            {
                if (!Regex.IsMatch(password, reg_pattern4))
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Password");
            }
            catch (UserException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            return Regex.IsMatch(password, reg_pattern4);
        }
    }
}
