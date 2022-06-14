using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneraln
{
    public class Archivotxt
    {
        StringReader _name = null;
        StringReader _archivo = null;
        string _opci;


        public static void MostrarTxt(string name) {
            string lineas;
            StreamReader archi = new StreamReader(@"E:\TICH\SEMANA 2\31-05-2022\Pruebas TXT\" + name);
            lineas = archi.ReadToEnd();
            Console.WriteLine(lineas);
            archi.Close();
            Console.ReadLine();
        }


        public static void MostrarCSV(string name) {

            string lineas;
            StreamReader archi = new StreamReader(@"D:\TICH\SEMANA 2\01-06-2022\" + name);
            lineas = archi.ReadToEnd();
            string[] lin = lineas.Split(';');

            foreach (var cas in lin)
            {
                Console.WriteLine(cas);
            }
            archi.Close();
            Console.ReadLine();
        }

        public static void Presentar() {
            Console.WriteLine("Ingresa el nombre del archivo");
            string name = Console.ReadLine();

            string[] naArray = name.Split('.');
            Console.WriteLine(naArray[1]);


            if (naArray[1] == "txt")
            {
                Console.WriteLine("Archivo tipo txt");
                MostrarTxt(name);
            }
            else if (naArray[1] == "csv")
            {
                Console.WriteLine("Archivo tipo csv");
                MostrarCSV(name);
            }
            else {

                Console.WriteLine("No soportado");
                
            }
        }

        public static void EscribirTxt(/*string ruta,string name,bool exists,int code*/)
        {

            //Presentacion();







            /*
            if (!File.Exists(ruta+ name)) {
                Console.WriteLine("El arhivo {0} ya existe", ruta+name);
            }*/
            /*
            StreamWriter archivo = new StreamWriter(ruta+name);
            archivo.WriteLine("Linea 1");
            archivo.Close();

            archivo = new StreamWriter(ruta+name, true);
            archivo.WriteLine("Linea 2");
            archivo.WriteLine("Linea 3");
            archivo.Close();

            archivo = new StreamWriter(ruta+ name, false);
            archivo.WriteLine("Linea 3 y linea 4");
            archivo.Close();
            */


        }


        public static void Presentacion()
        {
            
           
                Console.WriteLine("Nombre");
                string nom = Console.ReadLine();

                Console.WriteLine("Apellido 1");
                string a1 = Console.ReadLine();

                Console.WriteLine("Apellido 2");
                string a2 = Console.ReadLine();


                string com = nom + " " + a1 + " " + a2;
            string[] caArray = nom.Split(' ');
            Console.WriteLine(com);

            Console.WriteLine("Ingrese nombre del archivo");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese codificacion");
            string code = Console.ReadLine().ToUpper();


            StreamWriter _archivo = new StreamWriter(@"E:\TICH\SEMANA 2\31-05-2022\Pruebas TXT\" + name);
            _archivo.Close();
            string ruta = (@"E:\TICH\SEMANA 2\31-05-2022\Pruebas TXT\" + name);
            Console.WriteLine(ruta);
            if (!File.Exists(ruta))
            {
                Console.WriteLine("El arhivo {0} ya existe", name);
            }

            else
            {
               
                Console.WriteLine("El arhivo {0} no existe", name);

                if (code == "UTF8")
                {
                    try
                    {
                        _archivo = new StreamWriter(ruta, false, Encoding.UTF8);
                        _archivo.WriteLine("Archivo UTF8");
                        _archivo.WriteLine(com);
                    }
                    catch (Exception e){
                        Console.WriteLine(e);
                    
                    }     
                    
                }
                else if (code == "UTF7")
                {
                    _archivo = new StreamWriter(ruta, false, Encoding.UTF7);
                    _archivo.WriteLine("Archivo UTF7");
                    _archivo.WriteLine(com);
                }
                else if (code == "Unicode")
                {
                    _archivo = new StreamWriter(ruta, false, Encoding.Unicode);
                    _archivo.WriteLine("Archivo Unicode");
                    _archivo.WriteLine(com);
                }
                else if (code == "UTF32")
                {
                    _archivo = new StreamWriter(ruta, false, Encoding.Unicode);
                    _archivo.WriteLine("UTF32");
                    _archivo.WriteLine(com);
                }
                else if (code == "ASCII")
                {
                    _archivo = new StreamWriter(ruta, false, Encoding.Unicode);
                    _archivo.WriteLine("ASCII");
                    _archivo.WriteLine(com);
                }
                else
                {
                    Console.WriteLine("No valido");
                }


                _archivo.Close();

            }


        }


    }


}







