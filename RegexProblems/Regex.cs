using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    public class RegexProblem
    {
        public static void Validation()
        {
            //ValidateFirstName();
            //ValidateLastName();
            //ValidateEmail();
            //ValidatePhoneNumber();
            //ValidatePassword();
        }
        public static string ValidateFirstName(string fName)
        {
           
            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);
            string check = string.Empty;
            if (fName != null)
            {
                Match res = regex.Match(fName);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {fName}");
                    check = "valid";
                }
                else
                {
                    Console.WriteLine($"InValid --> {fName}");
                    check = "invalid";
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.INVALID_NAME, "FirstName is Invalid");
                }

            }
            else
            {
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.EMPTY_MESSAGE, "FirstName is Empty");
            }

            return check;
        }
        public static string ValidateLastName(string lName)
        {

            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);
            string check = string.Empty;
            if (lName != null)
            {
                Match res = regex.Match(lName);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {lName}");
                    check = "valid";
                }
                else
                {
                    Console.WriteLine($"InValid --> {lName}");
                    check = "invalid";
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.INVALID_NAME, "lastName is Invalid");
                }

            }
            else
            {
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.EMPTY_MESSAGE, "lastName is Empty");
            }

            return check;
        }
        public static string ValidateEmail(string Email)
        {
          
            //regex pattern for email
            string s = @"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2})?$";
            Regex regex = new Regex(s);
            string check = string.Empty;
            if (Email != null)
            {
                Match res = regex.Match(Email);

                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {Email}");
                    check = "valid";
                }
                else
                {
                    Console.WriteLine($"InValid --> {Email}");
                    check = "invalid";
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.INVALID_EMAIL, "Email is Invalid");
                }
            }
            else
            {
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.NULL_MESSAGE, "Email is Empty");
            }


            return check;
        }

        public static string ValidatePhoneNumber(string phoneNumber)
        {
            
            //regex pattern for Number
            string s = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(s);
            string check = string.Empty;
            if (phoneNumber != null)
            {
                Match res = regex.Match(phoneNumber);

                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {phoneNumber}");
                    check = "valid";
                }
                else
                {
                    Console.WriteLine($"InValid --> {phoneNumber}");
                    check = "invalid";
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.INVALID_PHONE, "Phone number is Invalid");
                }
            }
            else
            {
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.NULL_MESSAGE, "Phone number is Empty");
            }
            return check;

        }
        public static string ValidatePassword(string password)
        {
            //regex pattern for Password
            string s = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            Regex regex = new Regex(s);
            string check = string.Empty;
            if (password != null)
            {
                Match res = regex.Match(password);

                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {password}");
                    check = "valid";
                }
                else
                {
                    Console.WriteLine($"InValid --> {password}");
                    check = "invalid";
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
                }
            }
            else
            {
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.NULL_MESSAGE, "password is Empty");
            }
            return check;

        }



    }
}
