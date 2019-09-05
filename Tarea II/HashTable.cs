using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_del_libro.Tarea_II
{
    public class HashTable
    {
        public void definicion()
        {
            Hashtable miTabla = new Hashtable();
            miTabla.Add("Anjá", "Es una expresión que significa: 'Como!?', 'Wao!?', 'cáspita!'");
            miTabla.Add("Andá", "Es una expresión muy usada por los dominicanos, similar a 'que pena', 'es lamentable'.");
            miTabla.Add("Abombarse", "Proceso de putrefacción del agua, frutas o los alimentos.");
            miTabla.Add("Abombao", "Haber comido mucho, lleno de alimentos.");
            miTabla.Add("Abimbao", "Dícese de la persona que acaban de dar una paliza o muchos golpes, hinchada.");
            
            Console.WriteLine("*** Diccionario ***");
            foreach (DictionaryEntry datos in miTabla)
                Console.WriteLine("\n–{0}:   {1}", datos.Key, datos.Value);
        }
        
        public void datos()
        {
            Hashtable miTabla = new Hashtable();
            string nomb, num;
            int cant;
            Console.Write("Este programa guarda contactos de una Agenda...");
            Console.Write("\nDigite cantidad de personas que desea agregar a la agenda: ");
            cant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Escriba el nombre de la persona: ");
                nomb = Console.ReadLine();
                Console.WriteLine("\nDigite el numero de telefono para {0}:", nomb);
                num = Console.ReadLine();
                miTabla.Add(nomb, num);
                Console.WriteLine("Contacto Agregado...\n");
            }

            Console.WriteLine("Usted agregó: \n");
            foreach (DictionaryEntry datos in miTabla)
                Console.WriteLine("–{0}:   {1}", datos.Key, datos.Value);
        }
    }
}
