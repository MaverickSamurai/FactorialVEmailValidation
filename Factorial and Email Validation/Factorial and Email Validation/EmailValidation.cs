using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Factorial_and_Email_Validation
{
    class EmailValidation
    {
        public static string EmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static string PasswordRegex = @"^[a-zA-z0-9]{8,}";


        public  bool ValidationEmail()
        {
            return Regex.IsMatch("mirsamirba@code.edu.az", EmailRegex);
        }

        public bool ValidationPassword()
        {
            return Regex.IsMatch("Adminhjhja11", PasswordRegex);
        }
    }





}
