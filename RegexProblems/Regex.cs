using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    class RegexProblem
    {
        public static void ValidateFirstName()
        {
            string[] firstName = { "Diwa", "Raju", "Manu", "Jack", "ma", "arun","Ja","1sa","RRaj","Diwakaaaar" };
            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);

            foreach( string i in firstName)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }
        }
        public static void ValidateLastName()
        {
            //array for list of mails
            string[] lastName = { "Diwa", "Raju", "Manu", "Jack", "ma", "arun", "Ja", "1sa", "RRaj", "Diwakaaaar" };
            //regex for name
            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);

            foreach (string i in lastName)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }
        }
        public static void ValidateEmail()
        {
            //array for list of emails
            string[] email = { "abc@gmail.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@.com", "abc123@.com.com", "abc()*@gmail.com", ".abc@abc.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            //regex pattern for email
            string s = @"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2})?$";
            Regex regex = new Regex(s);
            foreach (string i in email)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }

        }

        public static void ValidatePhoneNumber()
        {
            //array for list of Numbers
            string[] email = { "91 1234567890", "21 9807654321","3 9076543212","07 9876543219","5 908765543","67 3234545" };
            //regex pattern for Number
            string s = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(s);
            foreach (string i in email)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }

        }
        public static void ValidatePassword()
        {
            //array for list of Passwords
            string[] email = { "as@A5d","i9asDdf@gh","sdsg","as@3jhfA","jdfgW@gcgh","gygyugyhA2" };
            //regex pattern for Password
            string s = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            Regex regex = new Regex(s);
            foreach (string i in email)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }

        }



    }
}
