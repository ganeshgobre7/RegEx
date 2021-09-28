using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;
using System.Text.RegularExpressions;

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
            bool fName = patterns.firstName("Ganesh");//Act
            Assert.AreEqual(true, fName);//Assert
        }
        /// <summary>
        /// Method to Test the Last name
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            bool lName = patterns.lastName("Gobre");//Act
            Assert.AreEqual(true, lName);//Assert
        }
        /// <summary>
        /// Method to Test the Email
        /// </summary>
        [TestMethod]
        public void eMail()
        {
            bool email = patterns.eMail("ganesh7@gmail.com");//Act
            Assert.AreEqual(true, email);//Assert
        }
        /// <summary>
        /// Method to Test the Mobile Number
        /// </summary>
        [TestMethod]
        public void mobNumber()
        {
            bool mobnumber = patterns.mobNumber("+91 9604877021");//Act
            Assert.AreEqual(true, mobnumber);//Assert
        }
        /// <summary>
        /// Method to Test the Password
        /// </summary>
        [TestMethod]
        public void Password()
        {
            bool pass = patterns.password("Ganesh7@");//Act
            Assert.AreEqual(true, pass);//Assert
        }
    }
}
