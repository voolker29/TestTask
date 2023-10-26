using TestTask.Models;

namespace TestTask.Services.Circle
{
    public class CircleService : ICircleService
    {
        public double СalculateArea(CircleModel figure)
        => Math.PI * Math.Pow(figure.Radius, 2);

    }
}
