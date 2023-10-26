namespace TestTask.Models
{
    public class TriangleModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TriangleModel(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
