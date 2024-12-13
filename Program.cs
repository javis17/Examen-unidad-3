namespace Examen_unidad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n----- MENÚ DE LA CALCULADORA -----");
                Console.WriteLine("1. Ingresar números A y B");
                Console.WriteLine("2. Sumar");
                Console.WriteLine("3. Restar");
                Console.WriteLine("4. Multiplicar");
                Console.WriteLine("5. Dividir");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número A (entero): ");
                        operaciones.NumeroA = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el número B (entero): ");
                        operaciones.NumeroB = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"Suma: {operaciones.NumeroA} + {operaciones.NumeroB} = {operaciones.Sumar()}");
                        break;

                    case 3:
                        Console.WriteLine($"Resta: {operaciones.NumeroA} - {operaciones.NumeroB} = {operaciones.Restar()}");
                        break;

                    case 4:
                        Console.WriteLine($"Multiplicación: {operaciones.NumeroA} * {operaciones.NumeroB} = {operaciones.Multiplicar()}");
                        break;

                    case 5:
                        if (operaciones.NumeroB != 0)
                        {
                            Console.WriteLine($"División: {operaciones.NumeroA} / {operaciones.NumeroB} = {operaciones.Dividir()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;

                    case 0:
                        salir = true;
                        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        break;
                }
            }
        }
    }
}