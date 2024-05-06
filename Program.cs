
using System;

namespace TP2POO_EXTRA_DOMINGUEZ_MINUCHIN 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion; 
            opcion = MostrarMenu(); 

            switch (opcion)
            {
                case 1: 
                string nom1,ciudad1; 
                double peso1, fuerza1, velocidad1;  
                nom1= IngresarCadena("Ingrese el nombre del súperheroe");
                ciudad1 = IngresarCadena("Ingrese la ciudad del súperheroe");  
                peso1 = IngresarPeso(); 
                fuerza1 = IngresarDoubleEntre1Y100("Ingrese la fuerza"); 
                velocidad1 = IngresarDoubleEntre1Y100("Ingrese la velocidad");  

                Superheroe superheroe1 = ObtenerSuperheroe(nom1,ciudad1,peso1,velocidad1, fuerza1); 
                Console.WriteLine("“Se ha creado el superhéroe ”"+ superheroe1.Nombre);

                break;

                case 2: 
                break;

                case 3:
                break;

                case 4:
                break;

            }

        }  
        static Superheroe ObtenerSuperheroe(string nombre, string ciudad, double peso, double velocidad, double fuerza)
        {
            Superheroe superheroe = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);

            return superheroe;

        }  
        static double IngresarDoubleEntre1Y100(string txt)
        {
            double num; 
            do {
            Console.WriteLine(txt);  
            num= double.Parse(Console.ReadLine());
            }while(num > 100 || num < 1);  
            return num; 
        }
        static double IngresarPeso()
        { 
            double peso;  
            do {
            Console.WriteLine("Ingrese el peso");  
            peso = double.Parse(Console.ReadLine());
            }while(peso <= 0); 
             
            return peso; 

            
        }
        static string IngresarCadena(string txt)
        {
            Console.WriteLine(txt);  
            return Console.ReadLine(); 
        } 

        static int MostrarMenu ()
        { 
            int opcion;  
            do { 
            Console.WriteLine("Ingrese la opcion que quiera:"); 
            Console.WriteLine("1. Cargar Datos Superhéroe 1");  
            Console.WriteLine("2. Cargar Datos Superhéroe 2"); 
            Console.WriteLine("3. Competir");  
            Console.WriteLine("4. Salir"); 
           opcion = int.Parse(Console.ReadLine());

            }while (opcion > 4 || opcion < 1);  
            return opcion; 
            

        }
    }
}
