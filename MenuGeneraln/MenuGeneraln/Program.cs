using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneraln
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadKey();
            
            string opci;
            do
            {
                Console.WriteLine("Menu de opciones, seleccione una");
                Console.WriteLine("1.- Hola mundo ");
                Console.WriteLine("2.- Enteros");
                Console.WriteLine("3.- Conversion de tipos");
                Console.WriteLine("4.- Poliza");
                Console.WriteLine("5.- Archivos");
                Console.WriteLine("6.- Manejo de fechas");
                Console.WriteLine("7.- ISR");

                Console.WriteLine("F Termina ");
                opci = Console.ReadLine();
                Console.WriteLine("Usted seleccionó la opcion: " + opci);

                switch (opci)
                {

                    case "1":
                        Console.WriteLine("1.- Hola mundo ");
                        Arreglos.Cadenas();
                        break;

                    case "2":
                        Console.WriteLine("2.- Enteros");
                        Arreglos.Enteros();
                        break;

                    case "3":
                        Console.WriteLine("3.- Conversion de tipos");
                        Arreglos.ConvierteATipoOracion();
                        break;
                    case "4":
                        Console.WriteLine("4.- Poliza");
                        Poliza.Presentacion();
                        break;

                    case "5":
                        Console.WriteLine("5.- Archivos");
                        Archivotxt.Presentar();
                        break;

                    case "6":
                        Console.WriteLine("6.- Declaracion");
                        break;

                    case "7":
                        Console.WriteLine("7.- ISR");

                        ISR.Presentacion();
                        break;

                    case "F":
                        Environment.Exit(0);
                        return;

                    case "f":

                        return;


                    default:
                        Console.WriteLine("No valido");

                        break;

                }
                //paso por referencia mismos espacio en mempria / struct
                //paso por valor crea variable temporal / clases
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Presiona una tecla para repetir ");
                Console.WriteLine("Presiona una 0 para cerrar ");
                string opci2;
                Char opci3 = ' ';
                opci3 = Console.ReadKey().KeyChar;
                if (opci3 == '0')
                {
                    Environment.Exit(0);
                }
                else
                    Console.Clear();
            }
            while (opci != "f");

            Console.ReadKey();
            
        }
    }
}
