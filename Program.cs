using Ejercicios_del_libro.Tarea_I;
using Ejercicios_del_libro.Tarea_II;
using System;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios_del_libro
{
    class Program
    {
        public static void menuTareaI()
        {
            Console.Clear();
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
            Console.WriteLine("11. Determinar mayor, menor y promedio de 10 edades");
            Console.WriteLine("12. Salir");
        }

        public static void menuTareaII()
        {
            Console.Clear();
            Console.WriteLine("Digite el numero de la opcion que desea: ");
            Console.WriteLine("1. Factorial de un numero");
            Console.WriteLine("2. Convertir numero a letras");
            Console.WriteLine("3. Calcular el promedio, calificación máxima y mínima");
            Console.WriteLine("4. Diccionario");
            Console.WriteLine("5. Agenda");
            Console.WriteLine("6. Fecha");
            Console.WriteLine("7. Cadenas Ordenadas");
            Console.WriteLine("8. Salir");
        }

        [STAThread]
        static void Main(string[] args)
        {

            /*int opcion;
            Conversor conversor;
            AreaPerimetro ap;

            do
            {
                //menuTareaI();
                menuTareaII();

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Factorial factorial = new Factorial();
                        factorial.pedirValor();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        ConversorDeNumeros conversorDeNumeros = new ConversorDeNumeros();
                        conversorDeNumeros.pedirNumero();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Calificaciones calificaciones = new Calificaciones();
                        calificaciones.calcularNotas();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        HashTable diccionario = new HashTable();
                        diccionario.definicion();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        HashTable agenda = new HashTable();
                        agenda.datos();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Fecha fecha = new Fecha();
                        fecha.mostrarFecha();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Cadena cadena = new Cadena();
                        cadena.pedirCadenas();
                        Console.ReadKey();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("***Opcion incorrecta***");
                        Console.ReadKey();
                        break;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Nombre nombre = new Nombre();
                        nombre.imprimirNombre();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.dolarAEuro();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.gradosARad();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        conversor = new Conversor();
                        conversor.celsiusAFarenheit();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        PareseImpares par = new PareseImpares();
                        par.determina();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        TablaDeMultiplicar tb = new TablaDeMultiplicar();
                        tb.imprimirTabla();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Potencia potencia = new Potencia();
                        potencia.calcularPotencia();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        ap = new AreaPerimetro();
                        ap.calcularArea();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        ap = new AreaPerimetro();
                        ap.calcularPerimetro();
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        DiasSemana dias = new DiasSemana();
                        dias.imprimirDias();
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        PromedioPersonas promedio = new PromedioPersonas();
                        promedio.pedirEdades();
                        Console.ReadKey();
                        break;
                    case 12:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("***Opcion incorrecta***");
                        Console.ReadKey();
                        break;
                }
        } while (opcion != 8);*/
                
        }
    }
}