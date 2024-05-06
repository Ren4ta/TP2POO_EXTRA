
using System;

namespace TP2POO_EXTRA_DOMINGUEZ_MINUCHIN 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion; 
            opcion = MostrarMenu(); 
            Superheroe superheroe1 = null; 
            Superheroe superheroe2 = null;

            while (opcion != 4) 
            {
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

                 superheroe1 = ObtenerSuperheroe(nom1,ciudad1,peso1,velocidad1, fuerza1); 
                Console.WriteLine("Se ha creado el superhéroe "+ superheroe1.Nombre);

                break;

                case 2:  
                string nom2,ciudad2; 
                double peso2, fuerza2, velocidad2;  
                nom2= IngresarCadena("Ingrese el nombre del súperheroe");
                ciudad2 = IngresarCadena("Ingrese la ciudad del súperheroe");  
                peso2 = IngresarPeso(); 
                fuerza2 = IngresarDoubleEntre1Y100("Ingrese la fuerza"); 
                velocidad2 = IngresarDoubleEntre1Y100("Ingrese la velocidad");  

                superheroe2 = ObtenerSuperheroe(nom2,ciudad2,peso2,velocidad2, fuerza2); 
                Console.WriteLine("Se ha creado el superhéroe "+ superheroe2.Nombre);

                break;

                case 3: 
                while (superheroe1 != null && superheroe2 != null ) 
                {
                    double diferencia = superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill(); 
                    string ganador = "";
                    if (diferencia > 0)
                    {
                        ganador = superheroe1.Nombre; 
                        
                    }  
                    else if (diferencia < 0)
                    {
                        ganador = superheroe2.Nombre; 
                        diferencia = diferencia * (-1); 
                    }   
                    else 
                    {
                        Console.WriteLine("Hay empate"); 
                    }

                    if (diferencia >= 30)
                    {
                        Console.WriteLine($"Ganó {ganador} por amplia diferencia"); 
                    } 
                    else if (diferencia >= 10 && diferencia < 30)
                    {
                        Console.WriteLine($"Ganó {ganador} ¡Fue muy parejo!");
                    } 
                    else if (diferencia < 10 && diferencia > 0)
                    {
                        Console.WriteLine($"Ganó {ganador} ¡No le sobró nada!");
                    }
                }
                break;

            }
                 opcion = MostrarMenu();
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
