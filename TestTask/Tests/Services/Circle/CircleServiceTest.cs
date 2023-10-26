using NUnit.Framework;
using TestTask.Models;
using TestTask.Services.Circle;

namespace Tests.Services.Circle
{
    public class CircleServiceTest
    {
        [Test]
        [TestCase(5)]
        [TestCase(4)]
        [TestCase(234)]
        public void СalculateArea_EqualTest(double radius) 
        {
            var circle = new CircleModel(radius);

            var area = new CircleService().СalculateArea(circle);

            var areaForEqual = Math.PI * Math.Pow(radius, 2);

            Assert.AreEqual(area, areaForEqual);


        }
    }
}
