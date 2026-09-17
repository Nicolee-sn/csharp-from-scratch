namespace CoditionalsAndOperators{
    class Program
    {
        static void Main()
        {
        
            // ALGORITHM 1: CONDITIONALS (Positive, Negative, or Zero)
            Console.WriteLine(" ALGORITMO 1: CONDICIONALES ");
            Console.Write("Ingrese un número: ");
            string inputNumber = Console.ReadLine();

            int number;
            if (int.TryParse(inputNumber, out number))
            {
                if (number > 0)
                {
                    Console.WriteLine("El número es POSITIVO.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("El número es NEGATIVO.");
                }
                else
                {
                    Console.WriteLine("El número es CERO.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }

            Console.WriteLine("\nPresione ENTER para continuar al segundo algoritmo...");
            Console.ReadLine();

            // ALGORITHM 2: MATHEMATICAL OPERATORS 
            Console.WriteLine(" ALGORITMO 2: OPERADORES MATEMÁTICOS ");

            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");

            // Evaluación condicional para evitar división por cero
            if (b != 0)
            {
                Console.WriteLine($"División: {(double)a / b}");
            }
            else
            {
                Console.WriteLine("División: Indeterminado (No se puede dividir por cero)");
            }

            Console.ReadLine();
        }
    }
}