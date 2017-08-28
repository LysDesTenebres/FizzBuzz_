using System.ComponentModel;

namespace FizzBuzz.Web.Models.FizzBuzzViewModels
{
    public class FizzBuzzViewModel
    {
        [DisplayName("Fizz factor")]
        public int FizzFactor { get; set; }

        [DisplayName("Buzz factor")]
        public int BuzzFactor { get; set; }

        [DisplayName("Last number")]
        public int? LastNumber { get; set; }

        public static FizzBuzzViewModel CreateDefault()
        {
            return new FizzBuzzViewModel()
            {
                FizzFactor = 3,
                BuzzFactor = 5,
                LastNumber = null
            };
        }
    }
}