using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration_Reflection
{
   public class Validation
    {
        public string RegexName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexLastName = "^[A-Z][a-z]{2,}$";
        public void FirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, RegexName) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");
        }
        public void LastName(string lastName)
        {
            if (Regex.IsMatch(lastName, RegexLastName) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");
        }
    }
}
