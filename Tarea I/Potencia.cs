using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    class Potencia
    {
        void calcularPotencia()
        {
            int num, exponente;
            double result;

            Console.WriteLine("Digite la base");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el exponente");
            exponente = Convert.ToInt32(Console.ReadLine());

            result = Math.Pow(num, exponente);

            Console.WriteLine("La Potencia es: {0}", result);
        }
    }
}
