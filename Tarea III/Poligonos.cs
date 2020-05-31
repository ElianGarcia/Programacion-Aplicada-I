using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_III.Tarea_III
{
    class Poligonos
    {
        public class Poligono
        {
            private float Ancho;
            private float Largo;
            private float Alto;
            private float Radio;
            private float Lado;

            //Ejercicio 3
            public Poligono(float ancho, float largo, float alto, float radio, float lado) : this(ancho, largo, alto)
            {
                Radio = radio;
                Lado = lado;
            }

            public Poligono(float ancho, float largo)
            {
                this.Ancho = ancho;
                this.Largo = largo;
            }

            public Poligono(float ancho, float largo, float alto)
            {
                this.Ancho = ancho;
                this.Largo = largo;
                this.Alto = alto;
            }

            public Poligono(float radio)
            {
                this.Radio = radio;
            }

            //Ejercicio 4
            public float GetAncho()
            {
                return Ancho;
            }
            public void SetAncho(int ancho)
            {
                if (ancho <= 0)
                    Ancho = 1;
                else
                    this.Ancho = ancho;
            }

            public float GetLargo()
            {
                return Largo;
            }
            public void SetLargo(int largo)
            {
                if (largo <= 0)
                    Largo = 1;
                else
                    this.Largo = largo;
            }

            public float GetAlto()
            {
                return Alto;
            }
            public void SetAlto(int alto)
            {
                if (alto <= 0)
                    Alto = 1;
                else
                    this.Alto = alto;
            }

            public float GetRadio()
            {
                return Radio;
            }
            public void SetRadio(int radio)
            {
                if (radio <= 0)
                    Radio = 1;
                else
                    this.Radio = radio;
            }

            public float GetLado()
            {
                return Lado;
            }
            public void SetLado(int lado)
            {
                if (lado <= 0)
                    Lado = 1;
                else
                    this.Lado = lado;
            }

            //Ejercicio 5
            public override string ToString()
            {
                String mensaje = "";
                mensaje += "Ancho: " + Ancho.ToString() + "Largo" + Largo.ToString()
                + " Alto: " + Alto.ToString() + "Radio: " + Radio.ToString() + "Lado : " + Lado.ToString();
                return mensaje;
            }
        }
    }
}
