namespace Tuples
{
    public class teste
    {
        public record Point(int X, int Y)
        {
            public double Slope() => (double)Y / (double)X;
        }
        public static void Main()
        {
            Point pt = new Point(1, 1);
            var pt2 = pt with { Y = 10 };
            double slope = pt.Slope();
            Console.WriteLine($"The slope of {pt} is {slope}.");
        }
    }
}