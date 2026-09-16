namespace HelloWorld
{
    // 1. Creación de la clase Person con sus propiedades
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Mensaje de bienvenida
            Console.WriteLine("Hola bienvenido a el calculador de años");
            Console.WriteLine("Escribe tu nombre: ");

            // Leer nombre desde la consola
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");

            // Solicitar fecha de nacimiento
            Console.WriteLine("Escribe tu fecha de nacimiento en formato (dd/MM/yyyy): ");
            string dateInput = Console.ReadLine();

            DateOnly dateConverted;

            // Validación de la fecha usando DateOnly.TryParse
            bool isConverted = DateOnly.TryParse(dateInput, out dateConverted);

            if (!isConverted)
            {
                Console.WriteLine($"La fecha de nacimiento es inválida, usted nos envió este dato: {dateInput} y es erróneo.");
                return;
            }

            // Instancia de la clase Person e inicialización de propiedades
            var person = new Person
            {
                Name = nameInput,
                BirthDate = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            // Imprimir la información de la persona
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.BirthDate.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"Tu edad es: {person.Age} años");

            // Pausa para mantener la ventana abierta
            Console.ReadLine();
        }
    }
}