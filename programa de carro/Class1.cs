using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_de_carro
{
    internal class Class1
    {
        internal class Carro
        {
            public string Marca { get; }
            public int Modelo { get; }

            public String Color { get; set; }

            private int Encendido = 0;
            private int velocidad_actual = 0;
            private const int MAXVELOCIDAD = 250;



            public Carro(string _marca, int _modelo, string _color)
            {
                Marca = _marca;
                Modelo = _modelo;
                Color = _color;
                Encendido = 0;
                this.velocidad_actual = 0;
            }



            public string acelerar()
            {
                if (Encendido == 0)
                {
                    return $"El carro esta apagado, asi no se puede";
                }


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual += 20;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
                }

                Console.WriteLine(mensaje);
                return mensaje;

            }



            public string acelerar(int AcekerarAkph)
            {
                if (Encendido == 0)
                {
                    return $"El carro esta apagado, asi no se puede";
                }


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual += AcekerarAkph;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
                }

                Console.WriteLine(mensaje);
                return mensaje;

            }



            public string GetVelocidadActual()
            {
                return $"VAmos a {velocidad_actual}KPH";
            }


            public void EncenderMotor()
            {
                if (Encendido == 0)
                {
                    Encendido = 1;
                    Console.WriteLine("Encendiendo el auto !!");
                    Console.WriteLine("Empezando a acelerar !!");
                    velocidad_actual = 0;

                }
                else
                {
                    Console.WriteLine("ups el carro ya estaba encendido");
                }
            }






            public void DameInformacion()
            {
                Console.WriteLine($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
            }


            public string disminuir()
            {
                

                string mensaje = "";
               
                
                    velocidad_actual -= 15;
                    mensaje = $"vas a {velocidad_actual} KPH";
                
                
                
                
                

                Console.WriteLine(mensaje);
                return mensaje;



            }

            public string Frenado()
            {


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual = 0;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Frenando Auto";
                }

                Console.WriteLine(mensaje);
                return mensaje;

                         
            
            }





            public string Bocina()
            {


                string mensaje = "";
               
                
             
                    mensaje = "Toco la bocina \nbeep beeeeeeep";
                

                Console.WriteLine(mensaje);
                return mensaje;



            }

            public string apagado()
            {


                string mensaje = "";


                if (Encendido == 1)
                {
                    Encendido = 0;
                    mensaje= $"Has apagdo el motor del auto";
                }

                
                Console.WriteLine(mensaje);
                return mensaje;

            }


            public string marcamodelo()//caracteristicas
            {


                string mensaje = "";

                mensaje = "Caracateristicas del Automovil: \nMarca: BMW M2 \nModelo: 2022 \nColor: Rojo \nVelocidad Maxima: 250 KP/H";

                Console.WriteLine(mensaje);
                return mensaje;



            }
        }


    }
}
