namespace FizzBuzz.Web.Models
{
    public interface IFizzBuzzValidator
    {
        void Validate(int fizzFactor, int buzzFactor, int lastNumber);
    }
}