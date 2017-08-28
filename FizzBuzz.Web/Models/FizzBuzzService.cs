using System.Text;

namespace FizzBuzz.Web.Models
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GenerateFizzBuzzText(int fizzFactor, int buzzFactor, int lastNumber)
        {
            IFizzBuzzValidator validator = new FizzBuzzValidator();
            validator.Validate(fizzFactor, buzzFactor, lastNumber);

            string result = "";

            for (int i = 1; i <= lastNumber; i++)
            {
                if (i % fizzFactor == 0 && i % buzzFactor == 0)
                {
                    result += "FizzBuzz ";
                }
                else if (i % buzzFactor == 0)
                {
                    result += "Buzz ";
                }
                else if (i % fizzFactor == 0)
                {
                    result += "Fizz ";
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }
            result = result.Trim();
            return result;
        }
    }
}