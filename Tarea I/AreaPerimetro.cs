using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    public class AreaPerimetro
    {
        int lados;
        double perim, area;
        float longitud, apotema;

        void calcularArea()
        {
            Console.WriteLine("Digite el numero de lados: ");
            lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la longitud de los lados: ");
            longitud = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite la apotema del poligono: ");
            apotema = Convert.ToSingle(Console.ReadLine());

            perim = lados * longitud;
            area = perim * apotema / 2;

            Console.WriteLine("El area del poligono es: {0}", area);
        }

        void calcularPerimetro()
        {
            float longitud, perimetro;

            Console.WriteLine("Digite el numero de lados del poligono: ");
            lados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la longitud de uno de los lados del poligono: ");
            longitud = Convert.ToSingle(Console.ReadLine());

            perimetro = lados * longitud;
            Console.WriteLine("El perimetro de este poligono es: {0}", perimetro);
        }
    }
}
