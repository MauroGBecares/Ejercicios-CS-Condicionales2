using System;

namespace Actividad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

            int a, b, c, d;

            Console.WriteLine("Ingrese nro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d)
                Console.WriteLine("Esta ordenado de manera decreciente");   
            else
                Console.WriteLine("No esta ordenado de manera decreciente");
            
            do
            {
                
            } while (true);
            
        }
    }
}
