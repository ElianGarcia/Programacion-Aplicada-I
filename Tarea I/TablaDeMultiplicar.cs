using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    class TablaDeMultiplicar
    {
        void imprimirTabla()
        {
            int num, result;

            Console.WriteLine("Digite la tabla a calcular: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(" " + num + " * " + i + " = " + result + "\n");
            }
        }
    }
}
