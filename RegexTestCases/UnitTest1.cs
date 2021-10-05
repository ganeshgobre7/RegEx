using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;
using System.Text.RegularExpressions;
using System;

namespace RegexTestCases
{
    [TestClass]
    public class UnitTest1
    {
        Patterns patterns = new Patterns();//creating object of pattern class
        /// <summary>
        /// Method to Test the First Name
        /// </summary>
        [TestMethod]

        public void TestFirstName()
        {
            bool fName = patterns.FirstName("Ganesh");//Act
               if(!fName)
               { 
                    try
                    {
                         throw new UserException(UserException.ExceptionType.UserMessage, "Invalid First Name");
                    }
                    catch(Exception ex1)
                    {
                         Console.WriteLine(ex1.Message);
                    }
               }
            Assert.AreEqual(true, fName);//Assert 
        }
       
        /// <summary>
        /// Method to Test the Last name
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            bool lName = patterns.LastName("Gobre");//Act
            if(!lName)
            {
                try
                {
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Last Name");
                }
                catch(Exception  ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
            }
            Assert.AreEqual(true, lName);//Assert
        }
        /// <summary>
        /// Method to Test the Email
        /// </summary>
        [TestMethod]
        public void eMail() 
        {
            bool email = patterns.eMail("ganesh7@gmail.com");//Act
            if(!email)
            {
                try
                {
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Mail ID");
                }
                catch(Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
            }
            Assert.AreEqual(true, email);//Assert
        }
        /// <summary>
        /// Method to Test the Mobile Number
        /// </summary>
        [TestMethod]
        public void mobNumber()
        {
            bool mobnumber = patterns.mobNumber("+91 9604877021");//Act
            if(!mobnumber
            {
                try
                {
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Mobile Number");
                }
                catch(Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
            }
            Assert.AreEqual(true, mobnumber);//Assert
            
        }
        /// <summary>
        /// Method to Test the Password
        /// </summary>
        [TestMethod]
        public void Password()
        {
            bool pass = patterns.password("Ganesh7@");//Act
            if(!pass)
            {
                try
                {
                    throw new UserException(UserException.ExceptionType.UserMessage, "Invalid Password");
                }
                catch(Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
            }
            Assert.AreEqual(true, pass);//Assert
        }
    } 
}
