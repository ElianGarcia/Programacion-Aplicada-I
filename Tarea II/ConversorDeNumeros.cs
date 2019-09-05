using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_II
{
    public class ConversorDeNumeros
    {
        public void pedirNumero()
        {
            Console.Write("Digite el numero a convertir: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            string convertido = convertir(numero);

            Console.WriteLine("El numero {0} convertido a letras es: {1}", numero, convertido);
        }

        private string convertir(double numero)
        {
            string texto = "";

            numero = Math.Truncate(numero);

            if (numero == 0)
                texto = "CERO";
            else if (numero == 1)
                texto = "UNO";
            else if (numero == 2)
                texto = "DOS";
            else if (numero == 3)
                texto = "TRES";
            else if (numero == 4)
                texto = "CUATRO";
            else if (numero == 5)
                texto = "CINCO";
            else if (numero == 6)
                texto = "SEIS";
            else if (numero == 7)
                texto = "SIETE";
            else if (numero == 8)
                texto = "OCHO";
            else if (numero == 9)
                texto = "NUEVE";
            else if (numero == 10)
                texto = "DIEZ";
            else if (numero == 11)
                texto = "ONCE";
            else if (numero == 12)
                texto = "DOCE";
            else if (numero == 13)
                texto = "TRECE";
            else if (numero == 14)
                texto = "CATORCE";
            else if (numero == 15)
                texto = "QUINCE";
            else if (numero < 20)
                texto = "DIECI" + (numero - 10).ToString();
            else if (numero == 20)
                texto = "VEINTE";
            else if (numero < 30)
                texto = "VEINTI" + (numero - 20).ToString();
            else if (numero == 30)
                texto = "TREINTA";
            else if (numero == 40)
                texto = "CUARENTA";
            else if (numero == 50)
                texto = "CINCUENTA";
            else if (numero == 60)
                texto = "SESENTA";
            else if (numero == 70)
                texto = "SETENTA";
            else if (numero == 80)
                texto = "OCHENTA";
            else if (numero == 90)
                texto = "NOVENTA";

            else if (numero < 100)
                texto = (Math.Truncate(numero / 10) * 10).ToString() + " Y " + (numero % 10).ToString();
            else if (numero == 100)
                texto = "CIEN";
            else if (numero < 200)
                texto = "CIENTO " + (numero - 100).ToString();
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 600) || (numero == 800))
                texto = (Math.Truncate(numero / 100)).ToString() + "CIENTOS";



            else if (numero == 500) texto = "QUINIENTOS";

            else if (numero == 700) texto = "SETECIENTOS";

            else if (numero == 900) texto = "NOVECIENTOS";

            else if (numero < 1000) texto = (Math.Truncate(numero / 100) * 100).ToString() + " " + (numero % 100).ToString();

            else if (numero == 1000) texto = "MIL";

            else if (numero < 2000) texto = "MIL " + (numero % 1000).ToString();

            else if (numero < 1000000)

            {

                texto = (Math.Truncate(numero / 1000)).ToString() + " MIL";

                if ((numero % 1000) > 0) texto = texto + " " + (numero % 1000).ToString();

            }



            else if (numero == 1000000) texto = "UN MILLON";

            else if (numero < 2000000) texto = "UN MILLON " + (numero % 1000000).ToString();

            else if (numero < 1000000000000)

            {

                texto = (Math.Truncate(numero / 1000000)).ToString() + " MILLONES ";

                if ((numero - Math.Truncate(numero / 1000000) * 1000000) > 0) texto = texto + " " + (numero - Math.Truncate(numero / 1000000) * 1000000).ToString();

            }

            else if (numero == 1000000000000) texto = "UN BILLON";

            else if (numero < 2000000000000) texto = "UN BILLON " + (numero - Math.Truncate(numero / 1000000000000) * 1000000000000).ToString();

            else

            {

                texto = (Math.Truncate(numero / 1000000000000)).ToString() + " BILLONES";

                if ((numero - Math.Truncate(numero / 1000000000000) * 1000000000000) > 0) texto = texto + " " + (numero - Math.Truncate(numero / 1000000000000) * 1000000000000).ToString();

            }

            return texto;
        }
    }
}
