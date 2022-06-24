using Factorial_and_Email_Validation;
using System;
using System.Text.RegularExpressions;

namespace Factorial_and_Access
{
    class Program
    {
        

        static void Main(string[] args)
        {
            FactorialCalc n = new FactorialCalc();
            Console.WriteLine(n.Factorial(5));


            EmailValidation regex = new EmailValidation();
            bool validEmail = regex.ValidationEmail();
            bool validPassword = regex.ValidationPassword();
            
            Console.WriteLine(validEmail);
            Console.WriteLine( validPassword );




        }


       
    
    }
}