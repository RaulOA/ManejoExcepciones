using System;

namespace ManejoExcepciones
{
    // Excepción personalizada que hereda de Exception
    public class MiExcepcionPersonalizada : Exception
    {
        public MiExcepcionPersonalizada(string mensaje) : base(mensaje)
        {
        }
    }
}
