using System;

namespace ManejoExcepciones
{
    // Clase para el manejo de múltiples excepciones
    public class EjemploMultiplesExcepciones
    {
        public void Ejecutar()
        {
            try
            {
                // Probar una división por cero
                int a = 5;
                int b = 0;
                int resultado = a / b;
            }
            catch (DivideByZeroException ex)
            {
                // Manejo de una excepción específica de división por cero
                Console.WriteLine($"Error: No se puede dividir por cero. {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                // Captura de otro tipo de excepción
                Console.WriteLine($"Operación inválida: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizando ejemplo de múltiples excepciones.");
            }
        }
    }
}
