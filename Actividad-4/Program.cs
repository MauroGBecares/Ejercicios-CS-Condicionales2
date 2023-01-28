using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a, b, c;
            
            Console.WriteLine("Ingrese nro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c))
                Console.WriteLine("Es mayor");
            else
                Console.WriteLine("No es mayor");
            
        }
    }
}
