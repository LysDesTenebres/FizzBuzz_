using System;
using ExerciseHelpers;
using FizzBuzz.Web.Models;
using FizzBuzz.Web.Models.FizzBuzzViewModels;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Web.Tests.Models
{
    public class FizzBuzzServiceTests : ExerciseBase
    {
        [Test]
        public void ThrowsFizzBuzzValidationExceptionWhenOneOfTheArgumentsIsInvalid()
        {
            //Arrange
            var fizzBuzzValidatorMock = new Mock<IFizzBuzzValidator>();
            //fizzBuzzValidatorMock.___("Mock the validator so that it always throws a FizzBuzzValidationException (Use 'Throws' method instead of 'Returns')");
            fizzBuzzValidatorMock.Setup(u => u.Validate(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
                .Throws<FizzBuzzValidationException>();

            //Act + Assert
            //TODO: call GenerateFizzBuzzText and assert that it (re)throws the exception thrown by de IFizzBuzzValidator
            var service = new Mock<FizzBuzzService>();
            service.Setup(u => u.GenerateFizzBuzzText(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
                .Throws<FizzBuzzValidationException>();

            Assert.That(fizzBuzzValidatorMock, Is.InstanceOf<FizzBuzzValidationException>());
            Assert.That(service, Is.InstanceOf<FizzBuzzValidationException>());
        }

        [Test]
        [TestCase(2, 3, 1, "1")]
        [TestCase(4, 5, 4, "1 2 3 Fizz")]
        [TestCase(5, 4, 4, "1 2 3 Buzz")]
        [TestCase(2, 3, 15, "1 Fizz Buzz Fizz 5 FizzBuzz 7 Fizz Buzz Fizz 11 FizzBuzz 13 Fizz Buzz")]
        [TestCase(2, 2, 4, "1 FizzBuzz 3 FizzBuzz")]
        public void ReturnsCorrectFizzBuzzTextWhenParametersAreValid(int fizzFactor, int buzzFactor, int lastNumber, string expected)
        {
            //Arrange


            var fizzBuzzValidatorMock = new Mock<IFizzBuzzValidator>();
            fizzBuzzValidatorMock.Setup(u => u.Validate(fizzFactor, buzzFactor, lastNumber));

            //Act
            var result = new FizzBuzzService().GenerateFizzBuzzText(fizzFactor, buzzFactor, lastNumber);


            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
