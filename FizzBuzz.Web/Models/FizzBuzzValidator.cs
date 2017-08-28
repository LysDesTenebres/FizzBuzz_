namespace FizzBuzz.Web.Models
{
    public class FizzBuzzValidator : IFizzBuzzValidator
    {
        public const int MinimumFactor = 2;
        public const int MaximumFactor = 10;
        public const int MinimumLastNumber = 1;
        public const int MaximumLastNumber = 250;

        public void Validate(int fizzFactor, int buzzFactor, int lastNumber)
        {
            if (fizzFactor < MinimumFactor || fizzFactor > MaximumFactor)
            {
                throw new FizzBuzzValidationException($"Fizz factor ({fizzFactor}) not in range.");
            }

            if (buzzFactor < MinimumFactor || buzzFactor > MaximumFactor)
            {
                throw new FizzBuzzValidationException($"Buzz factor ({buzzFactor}) not in range.");
            }

            if (lastNumber < MinimumLastNumber || lastNumber > MaximumLastNumber)
            {
                throw new FizzBuzzValidationException($"Last number ({lastNumber}) not in range.");
            }
        }
    }
}