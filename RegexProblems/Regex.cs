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
            string[] lastName = { "Diwa", "Raju", "Manu", "Jack", "ma", "arun", "Ja", "1sa", "RRaj", "Diwakaaaar" };
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
    }
}
