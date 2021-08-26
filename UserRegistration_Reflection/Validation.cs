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
        public string RegexEmail = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public string RegexMobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public string RegexPasswordRule1 = "^[a-zA-Z]{8,}$";
        public string RegexPasswordRule2 = "^[A-Z]+[a-zA-Z]{8,}$";
        public string RegexPasswordRule3 = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
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
        public void Email(string email)
        {
            if (Regex.IsMatch(email, RegexEmail) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Ivalid EmailId");
        }
        public void MobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, RegexMobileNumber) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Ivalid MobileNumber");
        }
        public void PasswordRule1(string passwordRule1)
        {
            if (Regex.IsMatch(passwordRule1, RegexPasswordRule1) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Ivalid PasswordRule1");
        }
        public void PasswordRule2(string passwordRule2)
        {
            if (Regex.IsMatch(passwordRule2, RegexPasswordRule2) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Ivalid PasswordRule2");
        }
        public void PasswordRule3(string passwordRule3)
        {
            if (Regex.IsMatch(passwordRule3, RegexPasswordRule3) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Ivalid PasswordRule3");
        }
    }
}
