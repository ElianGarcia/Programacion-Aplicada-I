using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    public class PareseImpares
    {
        public void determina()
        {
            int num;

            Console.WriteLine("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es Impar");

        }
    }
}
