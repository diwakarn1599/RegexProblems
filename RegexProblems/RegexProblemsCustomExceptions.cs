using System;
using System.Collections.Generic;
using System.Text;

namespace RegexProblems
{
    public class RegexProblemsCustomExceptions:Exception
    {
        ExceptionType exceptiontype;
        public enum ExceptionType
        {
            INVALID_PHONE, INVALID_NAME,EMPTY_MESSAGE, NULL_MESSAGE, INVALID_EMAIL, INVALID_PASSWORD, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND, METHOD_NOT_FOUND
        }
        
        public RegexProblemsCustomExceptions(ExceptionType exception, string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
