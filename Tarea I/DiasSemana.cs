using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_I
{
    public class DiasSemana
    {
        public void imprimirDias()
        {
            string valor;
            int num;

            Console.WriteLine("Digite un numero (1 - 7): ");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    break;
            }
        }
    }
}
