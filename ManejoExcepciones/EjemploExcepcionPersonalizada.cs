using System;

namespace ManejoExcepciones
{
    // Clase para el manejo de excepciones personalizadas
    public class EjemploExcepcionPersonalizada
    {
        public void Ejecutar()
        {
            try
            {
                // Este método lanza una excepción personalizada
                throw new MiExcepcionPersonalizada("Esta es una excepción personalizada lanzada manualmente.");
            }
            catch (MiExcepcionPersonalizada ex)
            {
                // Captura de una excepción personalizada
                Console.WriteLine($"Excepción personalizada capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizando ejemplo de excepción personalizada.");
            }
        }
    }
}
