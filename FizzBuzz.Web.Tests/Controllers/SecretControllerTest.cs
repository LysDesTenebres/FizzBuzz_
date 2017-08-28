using System.Web.Mvc;
using ExerciseHelpers;
using FizzBuzz.Web.Controllers;
using NUnit.Framework;

namespace FizzBuzz.Web.Tests.Controllers
{
    [TestFixture]
    public class SecretControllerTest: ExerciseBase
    {
        [Test]
        public void Secret1_Get_ReturnsTheLiteralSecret()
        {
            //Arrange
            var controller = new SecretController();

            // Act
            var result = controller.Secret1();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo("Top secret 1"));
        }

        [Test]
        public void Secret2_Get_ReturnsTheLiteralSecret()
        {
            // Arrange
            var controller = new SecretController();

            // Act
            var result = controller.Secret2();

            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo("Top secret 2"));
        }

        [Test]
        public void Gossip_Get_ReturnsRandomText()
        {
            // Arrange
            var controller = new SecretController();

            // Act
            var result = controller.Gossip();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(____);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void Gossip_Get_ReturnsDifferentTextEachTime()
        {
            // Arrange
            var controller = new SecretController();

            // Act
            string result1= controller.Gossip();
            string result2 = controller.Gossip();
            
            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.That(result1, Is.Not.EqualTo(result2));
        }
    }
}
