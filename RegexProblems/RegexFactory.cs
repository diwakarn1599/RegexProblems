using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    public class RegexFactory
    {
        public Object CreateRegexObject(string className, string constructorName)
        {
            //check class name and constructor name are same
            string pattern = constructorName + "$";
            Match res = Regex.Match(className, pattern);

            if (res.Success)
            {
                try
                {
                    //create assemblt object
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type classType = assembly.GetType(className);
                    //create object
                    var obj = Activator.CreateInstance(classType);
                    return obj;
                }
                catch (RegexProblemsCustomExceptions ex)
                {
                    //exception if class not found
                    throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.CLASS_NOT_FOUND, "Class Not found");
                }
            }
            else
            {
                //exception if constructor not found
                throw new RegexProblemsCustomExceptions(RegexProblemsCustomExceptions.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor Not found");
            }

        }

    }
}
