using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoAvanzado
{
    internal class Program
    {
        static string palabra;
        static string nombre;
        static void Main(string[] args)
        {
            datosNombres();
            inicioJuego();
            Console.Read();
        }


        public static void datosNombres()
        {
            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();

        }

        public static void inicioJuego()
        {
            string[] palabras = new string[17] { "camion", "computador", "leche", "vino","vaca", 
                "mula", "lis", "quiero", "hermoza", "novia", "tarro", "perro", "uva", "internet", 
                "codigo", "programacion","automovil"};
            Random nroaleatorio = new Random(); 
            palabra = palabras[nroaleatorio.Next(10)];


            StringBuilder palabrasMostradas = new StringBuilder();
            foreach (char letra in palabra)
            {
                if (letra == ' ')
                {
                    palabrasMostradas.Append(" ");
                }
                else
                {
                    palabrasMostradas.Append("-");
                }
            }

            double numeroDeIntentos = palabra.Length /2 ;
            char ingresoDeLetra;
            bool juegoTerminado = false;


            do
            {



                Console.WriteLine("Inicia el juego de AHORCADO HELIO");
                Console.WriteLine("El juego del ahorcado tiene palabras aleatorias");
                Console.WriteLine("Por lo que sera necesario que adivines!!!!");
                Console.WriteLine("Palabra por descubrir: {0} ", palabrasMostradas);
                Console.WriteLine("Numero de intento: {0}", numeroDeIntentos);


                Console.WriteLine("Ingrese su letra .. para adivinar: ");
                ingresoDeLetra = Convert.ToChar(Console.ReadLine());

                if (palabra.IndexOf(ingresoDeLetra) == -1)
                {
                    numeroDeIntentos--;
                }

                for (int i = 0; i < palabra.Length ; i++)
                {
                    if(ingresoDeLetra == palabra[i])
                    {
                        palabrasMostradas[i] = ingresoDeLetra;
                    }
                }



                if (palabrasMostradas.ToString().IndexOf("-") < 0)
                {
                    Console.WriteLine("Felicidades, {0} " , nombre  , "acertaste!  ({0})",
                       ingresoDeLetra);
                    juegoTerminado = true;
                    if (numeroDeIntentos == 0)
                    {
                        Console.WriteLine("Lo siento. TONTO JAJA ... Era {0}", ingresoDeLetra);
                        juegoTerminado = true;
                    }

                }


                Console.WriteLine();
                

            } while (!juegoTerminado);

            

        }
        
    }
}
