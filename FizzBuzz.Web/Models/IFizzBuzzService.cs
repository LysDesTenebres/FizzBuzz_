namespace FizzBuzz.Web.Models
{
    public interface IFizzBuzzService
    {
        string GenerateFizzBuzzText(int fizzFactor, int buzzFactor, int lastNumber);
    }
}