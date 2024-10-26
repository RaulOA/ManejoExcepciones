using System;

namespace ManejoExcepciones
{
    // Clase para el manejo de excepciones anidadas
    public class EjemploExcepcionesAnidadas
    {
        public void Ejecutar()
        {
            try
            {
                try
                {
                    // Intento de convertir una cadena no válida a entero
                    string numeroInvalido = "abc";
                    int numero = int.Parse(numeroInvalido);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Formato inválido: {ex.Message}");
                    // Relanzar la excepción como parte de una excepción anidada
                    throw new InvalidOperationException("Error al convertir un número", ex);
                }
            }
            catch (InvalidOperationException ex)
            {
                // Captura de excepción anidada
                Console.WriteLine($"Excepción anidada capturada: {ex.Message}");
                Console.WriteLine($"Excepción original: {ex.InnerException.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizando ejemplo de excepciones anidadas.");
            }
        }
    }
}
