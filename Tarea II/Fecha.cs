using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_II
{
    public class Fecha
    {
        public void mostrarFecha()
        {
            DateTime miTiempo = DateTime.Now;
            String format;
            format = String.Format("La hora es: {0:h:mm:ss tt}", miTiempo);
            String formato;
            formato = String.Format("La fecha es: {0:dddd yyyy M}", DateTime.Now);
            Console.WriteLine(format);
            Console.WriteLine(formato);
        }
    }
}
