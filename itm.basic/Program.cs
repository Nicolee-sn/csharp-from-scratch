using System;
using System.Collections.Generic;
using System.Linq;

namespace ITM.Basic
{

    // 1. CLASE AUXILIAR DE FRACCIONES (Para el Ejercicio 9)
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Método para calcular la diferencia de dos fracciones: (a/b) - (c/d)
        public Fraction Subtract(Fraction f)
        {
            int num = (Numerator * f.Denominator) - (f.Numerator * Denominator);
            int den = Denominator * f.Denominator;
            return new Fraction(num, den);
        }

        public override string ToString() => Denominator == 1 ? $"{Numerator}" : $"{Numerator}/{Denominator}";
    }

    // 2. CLASE CON LOS 15 EJERCICIOS DEL PDF
    public class HomeworkChallenges
    {
        // Challenge 1: Positive Power
        public void Challenge1()
        {
            Console.Write("Enter a number: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num > 0) Console.WriteLine($"Result: {Math.Pow(num, 2)}");
                else if (num < 0) Console.WriteLine("Result: Negative number.");
                else Console.WriteLine("Result: 0");
            }
        }

        // Challenge 2: Double or Triple
        public void Challenge2()
        {
            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Enter second number: ");
            double.TryParse(Console.ReadLine(), out double b);

            if (a > b) Console.WriteLine($"Result: {a * 2}");
            else Console.WriteLine($"Result: {b * 3}");
        }

        // Challenge 3: Root or Square
        public void Challenge3()
        {
            Console.Write("Enter a number: ");
            double.TryParse(Console.ReadLine(), out double num);

            if (num > 0) Console.WriteLine($"Result: {Math.Sqrt(num)}");
            else if (num < 0) Console.WriteLine($"Result: {Math.Pow(num, 2)}");
            else Console.WriteLine("Result: 0");
        }

        // Challenge 4: Circle Perimeter
        public void Challenge4()
        {
            Console.Write("Enter circle radius: ");
            double.TryParse(Console.ReadLine(), out double r);
            Console.WriteLine($"Result: {2 * Math.PI * r:F2}");
        }

        // Challenge 5: Midweek Day (Working Days Only: 1-5)
        public void Challenge5()
        {
            Console.Write("Enter a day number (1-7): ");
            int.TryParse(Console.ReadLine(), out int day);

            string result = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 or 7 => "Out of working days range.",
                _ => "Invalid day number."
            };
            Console.WriteLine($"Result: {result}");
        }

        // Challenge 6: Tax Calculator (>12000 => 15% of excess)
        public void Challenge6()
        {
            Console.Write("Enter annual salary: ");
            double.TryParse(Console.ReadLine(), out double salary);

            if (salary > 12000)
            {
                double tax = (salary - 12000) * 0.15;
                Console.WriteLine($"Result: {tax}");
            }
            else
            {
                Console.WriteLine("Result: No tax owed.");
            }
        }

        // Challenge 7: Remainder Finder (%)
        public void Challenge7()
        {
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out int b);

            if (b != 0) Console.WriteLine($"Result: {a % b}");
            else Console.WriteLine("Result: Cannot calculate remainder with zero divisor.");
        }

        // Challenge 8: Sum of Evens (1 to 50)
        public void Challenge8()
        {
            int sum = 0;
            for (int i = 2; i <= 50; i += 2) sum += i;
            Console.WriteLine($"Result: {sum}");
        }

        // Challenge 9: Fraction Difference
        public void Challenge9()
        {
            Console.Write("Enter Fraction 1 Numerator: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fraction 1 Denominator: ");
            int d1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Fraction 2 Numerator: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fraction 2 Denominator: ");
            int d2 = int.Parse(Console.ReadLine());

            var f1 = new Fraction(n1, d1);
            var f2 = new Fraction(n2, d2);
            var diff = f1.Subtract(f2);

            if (diff.Numerator == 0) Console.WriteLine("Result: 0");
            else Console.WriteLine($"Result: {diff}");
        }

        // Challenge 10: String Length
        public void Challenge10()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine() ?? "";
            Console.WriteLine($"Result: {word.Length}");
        }

        // Challenge 11: Average of Four
        public void Challenge11()
        {
            Console.Write("Enter 1st number: "); double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Enter 2nd number: "); double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Enter 3rd number: "); double.TryParse(Console.ReadLine(), out double c);
            Console.Write("Enter 4th number: "); double.TryParse(Console.ReadLine(), out double d);
            Console.WriteLine($"Result: {(a + b + c + d) / 4}");
        }

        // Challenge 12: Smallest of Five
        public void Challenge12()
        {
            List<double> numbers = new List<double>();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter number {i}: ");
                double.TryParse(Console.ReadLine(), out double val);
                numbers.Add(val);
            }
            Console.WriteLine($"Result: {numbers.Min()}");
        }

        // Challenge 13: Vowel Counter
        public void Challenge13()
        {
            Console.Write("Enter a word: ");
            string word = (Console.ReadLine() ?? "").ToLower();
            int count = 0;
            foreach (char c in word)
            {
                if ("aeiouáéíóú".Contains(c)) count++;
            }
            Console.WriteLine($"Result: {count}");
        }

        // Challenge 14: Factorial Finder
        public void Challenge14()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                long factorial = 1;
                for (int i = 1; i <= num; i++) factorial *= i;
                Console.WriteLine($"Result: {factorial}");
            }
            else
            {
                Console.WriteLine("Result: Invalid input for factorial.");
            }
        }

        // Challenge 15: InRange Validator (10 to 20)
        public void Challenge15()
        {
            Console.Write("Enter a number: ");
            double.TryParse(Console.ReadLine(), out double num);
            if (num >= 10 && num <= 20) Console.WriteLine("Result: Within range.");
            else Console.WriteLine("Result: Out of range.");
        }
    }

    // 3. CLASE MENÚ INTERACTIVO
    public static class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("\n--HOMEWORK: C# LOGIC CHALLENGES--");
            Console.WriteLine("1.  Positive Power");
            Console.WriteLine("2.  Double or Triple");
            Console.WriteLine("3.  Root or Square");
            Console.WriteLine("4.  Circle Perimeter");
            Console.WriteLine("5.  Midweek Day (Working Days Only)");
            Console.WriteLine("6.  Tax Calculator (>12000 => 15% of Excess)");
            Console.WriteLine("7.  Remainder Finder");
            Console.WriteLine("8.  Sum of Evens (1 to 50)");
            Console.WriteLine("9.  Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator (10 to 20)");
            Console.WriteLine("Q.  Exit Application");
            Console.WriteLine(" ");
            Console.Write("Select an option (1-15 or Q): ");
        }
    }

    // 4. PROGRAMA PRINCIPAL CON MAIN()
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName} to the C# Homework Assignment!");

            var challenges = new HomeworkChallenges();

            while (true)
            {
                Menu.DisplayMenu();
                string option = Console.ReadLine()?.Trim().ToUpper();

                if (option == "Q")
                {
                    Console.WriteLine($"Goodbye {userName}!");
                    break;
                }

                Console.WriteLine("\n-------------------------------------------------------------");
                switch (option)
                {
                    case "1": challenges.Challenge1(); break;
                    case "2": challenges.Challenge2(); break;
                    case "3": challenges.Challenge3(); break;
                    case "4": challenges.Challenge4(); break;
                    case "5": challenges.Challenge5(); break;
                    case "6": challenges.Challenge6(); break;
                    case "7": challenges.Challenge7(); break;
                    case "8": challenges.Challenge8(); break;
                    case "9": challenges.Challenge9(); break;
                    case "10": challenges.Challenge10(); break;
                    case "11": challenges.Challenge11(); break;
                    case "12": challenges.Challenge12(); break;
                    case "13": challenges.Challenge13(); break;
                    case "14": challenges.Challenge14(); break;
                    case "15": challenges.Challenge15(); break;
                    default:
                        Console.WriteLine("Invalid option. Choose a number between 1 and 15 or 'Q' to quit.");
                        break;
                }
            }
        }
    }
}