using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    public class Conversor
    {
        public void gradosARad()
        {
            string valor;
            float grados;
            double radianes;

            Console.WriteLine("Digite el grado a convertir: ");
            valor = Console.ReadLine();
            grados = Convert.ToSingle(valor);

            radianes = (double)grados * Math.PI / 180;

            Console.WriteLine("{0} convertido a radianes es: {1}", grados, radianes);
        }

        public void celsiusAFarenheit()
        {
            string valor;
            float celsius;
            double faren;

            Console.WriteLine("Digite la temperatura: ");
            valor = Console.ReadLine();
            celsius = Convert.ToSingle(valor);

            faren = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0} celsius convertidos a farenheit son: {1}", celsius, faren);
        }

        public void dolarAEuro()
        {
            float usd;
            double eur;
            string valor;

            Console.WriteLine("Digite la cantidad en USD: ");
            valor = Console.ReadLine();
            usd = Convert.ToSingle(valor);

            eur = usd * 0.90;

            Console.WriteLine("Cantidad Convertida: {0}", eur);
        }
    }
}
