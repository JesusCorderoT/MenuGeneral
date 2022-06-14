using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneraln
{
    public class ISR
    {

     static decimal[,] _tablaISR = new decimal[20, 5];
       static decimal _limiteSp;
        static decimal _limiteIn;
        static decimal _CuotaF;
        static decimal _Exedente;
        static decimal _Subsidio;


        public static void CargarTabla(String nombreArchivo) {


            StreamReader archi = new StreamReader(@"D:\TICH\SEMANA 2 C#\03-06-2022\" + nombreArchivo);

            Console.WriteLine("Seleccionaste el archivo:");
            Console.WriteLine(nombreArchivo);

            Console.WriteLine(" ");
          
            int i = 0;

            String[] columnas = new String[5];
            string line;
            while ((line = archi.ReadLine()) != null)
            {
                columnas = line.Split(';');
                _tablaISR[i, 0] = Convert.ToDecimal(columnas[0]);
                _tablaISR[i, 1] = Convert.ToDecimal(columnas[1]);
                _tablaISR[i, 2] = Convert.ToDecimal(columnas[2]);
                _tablaISR[i, 3] = Convert.ToDecimal(columnas[3]);
                _tablaISR[i, 4] = Convert.ToDecimal(columnas[4]);
                i++;
            }
            archi.Close();
        }

        public static void Calcular(decimal sueldoMensual) {
            decimal sueldoqui = sueldoMensual / 2;
            Console.WriteLine("Sueldo quincenal: "+sueldoqui);

            // Console.WriteLine(_tablaISR[0, 0]);

            for (int j = 0; j < 20; j++)
            {
                if (_tablaISR[j, 0] <= sueldoqui && _tablaISR[j, 1] >= sueldoqui)
                {
                    _limiteIn = _tablaISR[j, 0];
                    _limiteSp = _tablaISR[j, 1];
                    _CuotaF   = _tablaISR[j, 2];
                    _Exedente = _tablaISR[j, 3];
                    _Subsidio = _tablaISR[j, 4];
                }
            }

            
            decimal excedente = ((sueldoqui - _limiteIn) * (_Exedente/ 100));
            decimal impuesto = _CuotaF + excedente - _Subsidio;

            Console.WriteLine("");
            Console.WriteLine("Impuesto a pagar=" + impuesto.ToString("C2"));



        }


        public static void Presentacion() {
            Console.WriteLine("Ingresar nombre del archivo tipo CSV");
            String nombreArchivo = Console.ReadLine();
            CargarTabla(nombreArchivo);

            Console.WriteLine("Ingresar sueldo mensual");
            decimal sueldoMesual = decimal.Parse(Console.ReadLine());

            Calcular(sueldoMesual);
        }
    }
}
