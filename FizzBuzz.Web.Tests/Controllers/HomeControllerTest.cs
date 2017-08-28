using System;
using System.Web.Mvc;
using ExerciseHelpers;
using FizzBuzz.Web.Controllers;
using FizzBuzz.Web.Models.FizzBuzzViewModels;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace FizzBuzz.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest : ExerciseBase
    {

        [Test]
        public void Index_Get_ReturnsViewWithDefaultModel()
        {
            // Arrange
            FizzBuzzViewModel expectedViewModel = FizzBuzzViewModel.CreateDefault();

            HomeController controller = new HomeController();

            // Act
            //TODO: invoke the Index() action
            var result = controller.Index() as ViewResult;

            // Assert
            //TODO: assert that the correct ActionResult is returned
            //TODO: assert that the correct ViewModel is used
            Assert.IsNotNull(result);
            Assert.That(result.Model, Is.EqualTo(expectedViewModel));
        }

        [Test]
        public void Index_Post_ValidModel_ReturnsViewWithPostedModel()
        {
            // Arrange
            //TODO: create the model that is posted

            // Act
            //TODO: invoke the Index(FizzBuzzViewModel model) action
            var result = ____;

            // Assert
            //TODO: assert that the correct ActionResult is returned
            //TODO: assert that the posted ViewModel is used again in the View
        }
    }
}
