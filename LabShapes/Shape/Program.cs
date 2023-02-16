namespace ShapelabD6
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine("Perimeter of rectangle: " + rect.CalculatePerimeter());
            Console.WriteLine("Area of rectangle: " + rect.CalculateArea());
            Console.WriteLine(rect.Draw());

            Circle circle = new Circle(5);
            Console.WriteLine("Perimeter of circle: " + circle.CalculatePerimeter());
            Console.WriteLine("Area of circle: " + circle.CalculateArea());
            Console.WriteLine(circle.Draw());

            Console.ReadLine();
        }
    }
}