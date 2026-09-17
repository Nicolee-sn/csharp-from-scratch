namespace ClasesYHerencia
{
    // Base Class: Rectangle
    public class Rectangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area() => Base * Height;
        public double Perimeter() => 2 * (Base + Height);
    }

    // Derived Class: Square
    public class Square : Rectangle
    {
        public double Side
        {
            get => Base;
            set
            {
                Base = value;
                Height = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. RECTANGLE EXAMPLE
            Console.WriteLine(" RECTANGLE EXAMPLE ");
            var rect = new Rectangle
            {
                Base = 20,
                Height = 40
            };

            Console.WriteLine($"Area: {rect.Area()}");
            Console.WriteLine($"Perimeter: {rect.Perimeter()}");

            // 2. SQUARE EXAMPLE (INHERITANCE)
            Console.WriteLine("SQUARE EXAMPLE (INHERITANCE)");
            var square = new Square
            {
                Side = 20
            };

            Console.WriteLine($"Side: {square.Side}");
            Console.WriteLine($"Area: {square.Area()}");
            Console.WriteLine($"Perimeter: {square.Perimeter()}");

            Console.ReadLine();
        }
    }
}