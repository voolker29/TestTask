using TestTask.Models;

namespace TestTask.Services.Triangle
{
    public interface ITriangleService : IBaseFigureService<TriangleModel>
    {
        bool isRectangular(TriangleModel triangle);
    }
}
