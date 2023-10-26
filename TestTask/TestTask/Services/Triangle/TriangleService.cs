using TestTask.Models;

namespace TestTask.Services.Triangle
{
    public class TriangleService : ITriangleService
    {
        public bool isRectangular(TriangleModel triangle)
        => Math.Pow(triangle.C,2) == Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2);

        /// <summary>
        /// Формула площади треугольника. Расчет площади с помощью формулы Герона.
        /// p = (a+b+c)/2
        /// S = √p(p-a)(p-b)(p-c)
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public double СalculateArea(TriangleModel figure)
        {
            var p = (figure.A + figure.B + figure.C) / 2;

            return Math.Sqrt(p * (p - figure.A) * (p - figure.B) * (p - figure.C));

        }

    }
}
