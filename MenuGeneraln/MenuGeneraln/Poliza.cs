using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneraln
{
    public class Poliza
    {
        
       public static PolizaResultado Calcular(DateTime FechaI, string tipoP,int cantidadP ,decimal sumaA, DateTime FechaN, int genero,string tipoPeriodoPoli)
        {

            decimal _factor = 0;
            PolizaResultado pol = new PolizaResultado();

            decimal[,] arreglo = new decimal[12,4]

                 { 
                 { 0,20,2,0.5m } ,
                 {21,30,2,0.1m },
                 {31,40,2,0.4m },
                 {41,50,2,0.5m },
                 {51,60,2,0.65m },
                 {61,100,2,0.85m },
                    //Masculino
                 { 0,20,1,0.5m } ,
                 {21,30,1,0.1m },
                 {31,40,1,0.4m },
                 {41,50,1,0.55m },
                 {51,60,1,0.7m },
                 {61,100,1,0.9m },};


            int edad = DateTime.Now.Year - FechaN.Year;


            for (int i = 0; i< arreglo.Length;i++) {

                if (arreglo[i,0] <= edad && arreglo[i, 1] >= edad && arreglo[i, 2] == genero) 
                {
                    _factor = arreglo[i, 3];
                    break;
                }


                switch (tipoPeriodoPoli) {

                    case "dias":
                        pol.FT = FechaI.AddDays(cantidadP);
                        break;
                    case "meses":
                        pol.FT = FechaI.AddMonths(cantidadP);
                        break;
                    case "años":
                        pol.FT = FechaI.AddYears(cantidadP);
                        break;
                    default:

                        break;
                }

            }

            Console.WriteLine(_factor);
            TimeSpan diffmeses = pol.FT - FechaI;
            pol.PR = sumaA * _factor * diffmeses.Days / 360;

            

            return pol;



        }

        public static void Presentacion() {


            Console.WriteLine("Proporciona la fecha de inicio de Vigencia:");
            DateTime FechaI = Convert.ToDateTime(Console.ReadLine());

            
            Console.WriteLine("Proporciona para cuanto tiempo requieres la póliza (ejemplo 2 años):");
            Console.WriteLine("Ejemplo 100 dias");
            Console.WriteLine("Ejemplo 24 meses");
            Console.WriteLine("Ejemplo 2 años");
            Console.WriteLine(" ");
            String tipoP = (Console.ReadLine());
            string[] tipoArray = tipoP.Split(' ');
            int CantPeriodoPoli = Convert.ToInt32(tipoArray[0]);
            String tipoPeriodoPoli = tipoArray[1];

            Console.WriteLine("Proporciona la suma asegurada:");
            decimal sumaA = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado:");
            DateTime FechaN = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona el género del asegurado:");
            Console.WriteLine("MASCULINO");
            Console.WriteLine("FEMENINO");
            String genero = Console.ReadLine().ToUpper();

            Console.WriteLine("Genero: "+genero);

            int generoAsegura = (genero == "MASCULINO" ? 1 : 2);

            //PolizaResultado polR = new PolizaResultado();

            PolizaResultado polR = Calcular(FechaI, tipoP, CantPeriodoPoli, sumaA, FechaN, generoAsegura, tipoPeriodoPoli);

            Console.WriteLine($"La Póliza vencerá el: {polR.FT.ToString("D")}");
            Console.WriteLine($"La prima a pagar es de:{decimal.Round(polR.PR,2)}");
            Console.ReadKey();

        }
    }
}
