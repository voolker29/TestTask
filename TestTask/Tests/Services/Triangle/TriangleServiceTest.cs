using NUnit.Framework;
using TestTask.Models;
using TestTask.Services.Triangle;

namespace Tests.Services.Triangle
{
    public class TriangleServiceTes
    {
        [Test]
        [TestCase(23, 45, 3)]
        [TestCase(345, 45, 3)]
        [TestCase(45, 45, 45)]
        public void isRectangular_EqualTest(double a, double b, double c)
        {

            var triangle = new TriangleModel(a, b, c);

            var isRectangular = new TriangleService().isRectangular(triangle);

            var isRectangular_test = Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);

            Assert.AreEqual(isRectangular, isRectangular_test);


        }
        [Test]
        [TestCase(23, 45, 3)]
        [TestCase(345, 45, 3)]
        [TestCase(45, 45, 45)]
        public void  СalculateArea_EqualTest(double a, double b, double c)
        {
            var triangle = new TriangleModel(a, b, c);

            var triangleArea = new TriangleService().СalculateArea(triangle);

            var testArea = GetTestArea(a, b, c);

            Assert.AreEqual(testArea, triangleArea);

        }

        private double GetTestArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }



    }
}
