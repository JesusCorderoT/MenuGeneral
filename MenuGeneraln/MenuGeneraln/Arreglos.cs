using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace MenuGeneraln
{
    public class Arreglos
    {
        public static void Cadenas()
        {

            String ca;
            Console.WriteLine("Proporcina nombre completo");
            ca = Console.ReadLine();
            string[] caArray = ca.Split(' ');
            Console.WriteLine(" ");
            Console.WriteLine("Hola");
            foreach (var cas in caArray)
            {
                Console.WriteLine(cas);
            }
            Console.WriteLine("");
            Console.WriteLine("Apellido Vertical");

            Console.WriteLine(caArray[1]);

            foreach (var cas2 in caArray[1])
            {
                Console.WriteLine(cas2);
            }

        }


        public static void Enteros()
        {

            int[] numeros = new int[5];
            int v; 
            for (int i = 0; i <5; i++)
            {
                Console.Write("Ingresa el numero "+i+" ");
                v = int.Parse(Console.ReadLine());
               numeros[i] = v;
            }

            Console.Write("Numero mayor es: " + numeros.Max());
            Console.ReadKey();


        }
        public static void ConvierteATipoOracion(){
            String cadena;
            Console.WriteLine("Ingresa cadena en minusculas");
            cadena = Console.ReadLine();
            cadena = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(cadena.ToLower()));
            Console.WriteLine(cadena);
            Console.ReadKey();


        }
    }
}
