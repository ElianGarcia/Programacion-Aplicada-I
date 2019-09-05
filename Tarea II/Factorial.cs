using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_II
{
    public class Factorial
    {
        public void pedirValor()
        {
            double numero = Convert.ToDouble(Console.ReadLine());
            double resultado = calcularFactorial(numero);

            Console.WriteLine("El factorial del numero {0} es igual a: {1} ", numero, resultado);
        }
        private double calcularFactorial(double numero)
        {
            double factorial = 0;

            while(numero != 0)
            {
                factorial *= numero;
                numero--;
            }

            return factorial;
        }
    }
}
