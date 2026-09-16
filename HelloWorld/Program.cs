namespace HelloWorld{
    class Program
    {
        static void Main()
        {
            string name = "John";
            name = "John Doe";

            const string greeting = "Hola";

            Console.WriteLine($"{greeting} {name}");
            Console.ReadLine();
        }
    }
}