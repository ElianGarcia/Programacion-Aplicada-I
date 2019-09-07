using System;
using System.Collections;

namespace Ejercicios_del_libro.Tarea_II
{
    public class HashTable
    {
        public void definicion()
        {
            Hashtable miTabla = new Hashtable();
            miTabla.Add("Adjudicar", "Declarar que determinada cosa corresponde a una persona o conferírsela en satisfacción de un derecho.");
            miTabla.Add("Repeler", "Rechazar o contradecir una idea o una proposición.");
            miTabla.Add("Hedonismo", "Doctrina ética que identifica el bien con el placer, especialmente con el placer sensorial e inmediato.");
            miTabla.Add("Extremismo", "Tendencia a adoptar ideas o actitudes extremas, especialmente en política.");
            
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
