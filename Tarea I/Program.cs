using Ejercicios_del_libro.Tarea_I;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios_del_libro
{
    class Program
    {
        public static void menu()
        {
            Console.WriteLine("Digite el numero de la opcion que desea: ");
            Console.WriteLine("1. Escribir nombre y mensaje en pantalla");
            Console.WriteLine("2. Convertir USD a EUR");
            Console.WriteLine("3. Convertir Grados a Radianes");
            Console.WriteLine("4. Convertir Celsius a Farenheit");
            Console.WriteLine("5. Determinar si un numero es par o impar");
            Console.WriteLine("6. Imprimir la tabla de multiplicar de un numero");
            Console.WriteLine("7. Sacar la potencia a un numero");
            Console.WriteLine("8. Determinar el area de un poligono regular");
            Console.WriteLine("9. Determinar el perimetro de un poligono regular");
            Console.WriteLine("10. Imprimir el dia de la semana");
            Console.WriteLine("11. Salir");
        }
        static void Main(string[] args)
        {
            int opcion;
            Conversor conversor;
            AreaPerimetro ap;

            do
            {
                menu();

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Nombre nombre = new Nombre();
                        nombre.imprimirNombre();
                        break;
                    case 2:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.dolarAEuro();
                        break;
                    case 3:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.gradosARad();
                        break;
                    case 4:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.celsiusAFarenheit();
                        break;
                    case 5:
                        Console.Clear();
                        PareseImpares par = new PareseImpares();
                        par.determina();
                        break;
                    case 6:
                        Console.Clear();
                        TablaDeMultiplicar tb = new TablaDeMultiplicar();
                        tb.imprimirTabla();
                        break;
                    case 7:
                        Console.Clear();
                        Potencia potencia = new Potencia();
                        potencia.calcularPotencia();
                        break;
                    case 8:
                        Console.Clear();
                        ap = new AreaPerimetro();
                        ap.calcularArea();
                        break;
                    case 9:
                        Console.Clear();
                        ap = new AreaPerimetro();
                        ap.calcularPerimetro();
                        break;
                    case 10:
                        Console.Clear();
                        DiasSemana dias = new DiasSemana();
                        dias.imprimirDias();
                        break;
                    case 11:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("***Opcion incorrecta***");
                        break;
                }
            } while (opcion != 11);
            
        }
    }
}
