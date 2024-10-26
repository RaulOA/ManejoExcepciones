using System;

namespace ManejoExcepciones
{
    // Clase principal para ejecutar ejemplos
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el ejemplo que deseas ejecutar:");
            Console.WriteLine("1. Excepción Personalizada");
            Console.WriteLine("2. Múltiples Excepciones");
            Console.WriteLine("3. Excepciones Anidadas");

            string seleccion = Console.ReadLine();

            switch (seleccion)
            {
                case "1":
                    var ejemploPersonalizado = new EjemploExcepcionPersonalizada();
                    ejemploPersonalizado.Ejecutar();
                    break;

                case "2":
                    var ejemploMultiples = new EjemploMultiplesExcepciones();
                    ejemploMultiples.Ejecutar();
                    break;

                case "3":
                    var ejemploAnidadas = new EjemploExcepcionesAnidadas();
                    ejemploAnidadas.Ejecutar();
                    break;

                default:
                    Console.WriteLine("Selección inválida.");
                    break;
            }

            // Pausar la ejecución para que los mensajes se puedan leer
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}