using System;
using System.Web.Http;
using System.Web.Http.Results;
using ExerciseHelpers;
using FizzBuzz.Web.Controllers.Api;
using FizzBuzz.Web.Models;
using FizzBuzz.Web.Models.FizzBuzzViewModels;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Web.Tests.Controllers.Api
{
    [TestFixture]
    public class FizzBuzzControllerTests : ExerciseBase
    {
        [Test]
        public void GetFizzBuzzText_ReturnsFizzBuzzTextGeneratedFromService()
        {
            //Arrange
            var serviceMock = new Mock<IFizzBuzzService>();

            var random = new Random();
            var afizzbuzz = new FizzBuzzViewModel()
            {
                FizzFactor = random.Next(1, int.MaxValue),
                BuzzFactor = random.Next(1, int.MaxValue),
                LastNumber = random.Next(1, int.MaxValue),
            };

            //serviceMock.___("Mock the service so that it always returns some (randomly generated) string");
            serviceMock.Setup(
                u =>
                    u.GenerateFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                        Convert.ToInt32(afizzbuzz.LastNumber))).Returns(afizzbuzz.ToString);

            var controller = new FizzBuzzController();
            //Act
            var result = controller.GetFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                Convert.ToInt32(afizzbuzz.LastNumber)) as IHttpActionResult;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(afizzbuzz));
            //TODO: assert that the correct IHttpActionResult is returned
            //TODO: assert that the FizzBuzzService was used correctly
            serviceMock.Verify(u => u.GenerateFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                        Convert.ToInt32(afizzbuzz.LastNumber)), Times.Once);
        }

        [Test]
        public void GetFizzBuzzText_ReturnsBadRequestIfServiceCannotGenerateText()
        {
            var random = new Random();
            var afizzbuzz = new FizzBuzzViewModel()
            {
                FizzFactor = random.Next(1, int.MaxValue),
                BuzzFactor = random.Next(1, int.MaxValue),
                LastNumber = random.Next(1, int.MaxValue),
            };
            //Arrange
            var serviceMock = new Mock<IFizzBuzzService>();
            //serviceMock.___("Mock the service so that it always throws a FizzBuzzValidationException (Use 'Throws' method instead of 'Returns')");
            serviceMock.Setup(u => u.GenerateFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                Convert.ToInt32(afizzbuzz.LastNumber))).Throws<FizzBuzzValidationException>();
            //Act

            var controller = new FizzBuzzController();
            var result = controller.GetFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                Convert.ToInt32(afizzbuzz.LastNumber)) as IHttpActionResult;

            //Assert
            //TODO: assert that the correct IHttpActionResult is returned
            //TODO: assert that the FizzBuzzService was used correctly
            Assert.That(result, Is.InstanceOf<IHttpActionResult>());
           serviceMock.Verify(m => m.GenerateFizzBuzzText(afizzbuzz.FizzFactor, afizzbuzz.BuzzFactor,
                Convert.ToInt32(afizzbuzz.LastNumber)), Moq.Times.Once());
        }
    }
}
