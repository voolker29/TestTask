namespace TestTask.Services
{
    public interface IBaseFigureService<T>
    {
        double СalculateArea(T figure);
    }
}
