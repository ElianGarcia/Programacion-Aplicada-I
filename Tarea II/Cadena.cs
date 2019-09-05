using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_II
{
    public class Cadena
    {

        public void pedirCadenas()
        {
            string cad1, cad2;
            Console.WriteLine("Escriba la primera cadena: ");
            cad1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda cadena: ");
            cad2 = Console.ReadLine();

            ordenar(cad1, cad2);
        }
        public void ordenar(string cad1, string cad2)
        {
            
            int comparacion = 0;
            comparacion = String.Compare(cad1, cad2);
            if (comparacion == 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad1, cad2);
            else if (comparacion > 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad2, cad1);
            else if (comparacion < 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad1, cad2);
        }
    }
}
