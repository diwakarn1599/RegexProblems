using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexProblems;
namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestFirstName()
        {
            
            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateFirstName("Diwakar");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch(RegexProblemsCustomExceptions ex)
            {
                expected = "FirstName is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }
            
        }
        [TestMethod]
        public void TestInvalidFirstName()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateFirstName("Dr");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "FirstName is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestValidLastName()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateLastName("Diwakar");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Lastname is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestInvalidLastName()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateLastName("Dr");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "lastName is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestValidEmail()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateEmail("abc@gmail.com");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Email is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestInvalidEmail()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidateEmail("abcgmail.com");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Email is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestValidPhoneNumber()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidatePhoneNumber("91 9876543210");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Phone number is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestInvalidPhoneNumber()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidatePhoneNumber("1 45698");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Phone number is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestValidPassword()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidatePassword("91 9876543210");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Password is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void TestInvalidPassword()
        {

            // Valid FirstName
            //AAA methodology
            string actual, expected;
            try
            {
                actual = RegexProblem.ValidatePassword("1 45698");
                expected = "valid";
                Assert.AreEqual(actual, expected);

            }
            catch (RegexProblemsCustomExceptions ex)
            {
                expected = "Password is Invalid";
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        public void CreateObject()
        {
            object expected = new RegexProblem();
            RegexFactory rf = new RegexFactory();
            object actual = rf.CreateRegexObject("RegexProblems.RegexProblem", "RegexProblem");
            expected.Equals(actual);

        }
    }
}
