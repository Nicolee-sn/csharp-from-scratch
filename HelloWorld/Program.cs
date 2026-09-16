namespace HelloWorld
{
    
    // BASE CLASS: Rectangle
    public class Rectangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        // Expression-bodied methods (lambda) for calculation
        public double GetArea() => Base * Height;
        public double GetPerimeter() => 2 * (Base + Height);
    }

    // DERIVED CLASS: Square (Inherits from Rectangle)
    public class Square : Rectangle
    {
        // Custom Property with getter/setter overriding side values
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
            Console.WriteLine("=== RECTANGLE EXAMPLE ===");
            var rectangle = new Rectangle
            {
                Base = 20,
                Height = 40
            };

            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

            Console.WriteLine("\n===========================\n");

            // 2. SQUARE (INHERITANCE) EXAMPLE
            Console.WriteLine("=== SQUARE EXAMPLE (INHERITANCE) ===");
            var square = new Square
            {
                Side = 20 // Sets both Base and Height to 20 automatically
            };

            Console.WriteLine($"Side: {square.Side}");
            Console.WriteLine($"Area: {square.GetArea()}");
            Console.WriteLine($"Perimeter: {square.GetPerimeter()}");

            Console.ReadLine();
        }
    }
}