using System;
using System.Collections;

namespace Ejercicios_del_libro.Tarea_II
{
    public class Calificaciones
    {
        public void calcularNotas()
        {
            int calificacion, cantidad = 0;
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 0.0f;
            float maxima = 0.0f;

            Console.Write("Digite la cantidad de alumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            ArrayList alCalif = new ArrayList(cantidad);

            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Digite la calificación: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
                alCalif.Add(calificacion);
                suma += calificacion;
                if(n == 0)
                {
                    maxima = calificacion;
                    minima = calificacion;
                }
                if (calificacion < minima)
                    minima = calificacion;
                if (calificacion > maxima)
                    maxima = calificacion;
            }
            promedio = suma / cantidad;

            Console.WriteLine("\n\nEl promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
        }


    }
}
