using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    public class PromedioPersonas
    {
        int mayor = 0, menor = 0, promedio = 0, suma = 0;
        public void pedirEdades()
        {
            int edad;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Digite la edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                suma += edad;

                if(i == 1)
                {
                    mayor = edad;
                    menor = edad;
                } else
                {
                    if(edad > mayor)
                    {
                        mayor = edad;
                    }
                    if(edad < menor)
                    {
                        menor = edad;
                    }
                }
            }
            promedio = suma / 10;

            resultados();
        }

        private void resultados()
        {
            Console.Clear();
            Console.WriteLine("El mayor de los registrados tiene {0} años", mayor);
            Console.WriteLine("El menor de los registrados tiene {0} años", menor);
            Console.WriteLine("El promedio de edad de los registrados es de {0} años", promedio);
        }
    }
}
