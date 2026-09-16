namespace HelloWorld
{
    // INTERFACES (Polymorphism)
    public interface IFigura
    {
        double Radio { get; set; }
        double Area();
        double Perimetro();
    }

    public interface IExtraCalculations
    {
        double Add();
    }

    // CLASS IMPLEMENTATION
    public class Circle : IFigura, IExtraCalculations
    {
        public double Radio { get; set; }

        public double Area() => Math.PI * Math.Pow(Radio, 2);
        public double Perimetro() => 2 * Math.PI * Radio;

        public double Add() => Radio + 10;
    }

    class Program
    {
        static void Main()
        {
            // 1. POLYMORPHISM AND INTERFACES EXAMPLE
            Console.WriteLine(" 1. INTERFACES AND POLYMORPHISM ");
            var circle = new Circle { Radio = 20 };

            Console.WriteLine($"Circle Area: {circle.Area():F2}");
            Console.WriteLine($"Circle Perimeter: {circle.Perimetro():F2}");
            Console.WriteLine($"Radio + 10 (Extra calculation): {circle.Add()}");

            // 2. FOR LOOP (FIBONACCI SERIES EXAMPLE)
            Console.WriteLine(" 2. FOR LOOP (FIBONACCI SERIES) ");
            int a = 0, b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Fibonacci step {i}: {a}");
                int temp = a;
                a = b;
                b = temp + b;
            }

            // 3. EXCEPTION HANDLING (TRY / CATCH)
            Console.WriteLine(" 3. EXCEPTION HANDLING ");
            try
            {
                Console.Write("Enter dividend number: ");
                int dividend = int.Parse(Console.ReadLine());

                Console.Write("Enter divisor number: ");
                int divisor = int.Parse(Console.ReadLine());

                if (divisor == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                int result = dividend / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Specific Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: Unknown input or failure. {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}