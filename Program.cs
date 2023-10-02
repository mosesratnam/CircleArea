namespace CircleArea;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        Console.WriteLine("Circle Area");
        double circleRadius = 2.5;
        double circleArea = Math.PI * (circleRadius * circleRadius);
        Console.Write("The area of a circle with {0}radius is {1}", circleRadius, circleArea);
    }
}
