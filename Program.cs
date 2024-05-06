
using System;

namespace TP2POO_EXTRA_DOMINGUEZ_MINUCHIN 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion; 
            opcion = MostrarMenu(); 
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
