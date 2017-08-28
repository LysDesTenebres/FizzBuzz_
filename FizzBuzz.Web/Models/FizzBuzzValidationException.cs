using System;

namespace FizzBuzz.Web.Models
{
    public class FizzBuzzValidationException : ApplicationException
    {
        public FizzBuzzValidationException()
        {

        }

        public FizzBuzzValidationException(string message) : base(message)
        {
            
        }
    }
}