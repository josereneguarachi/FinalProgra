using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class final
    {
        public string operacion(int numero)
        {
            string texto = "";
            if (numero < 0)
            {
                texto = "ERROOOR";
            }
            if (numero == 0)
            {
                texto = "Realizado por Jose Rene Guarachi";
            }
            if (numero > 0)
            {
                texto = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
            }
            return texto;
        }
    }
}