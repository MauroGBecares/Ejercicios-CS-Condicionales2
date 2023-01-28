using System;

namespace Actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //     La resta si el primero es mayor que el segundo.
            //     La suma si son iguales.
            //     El producto si el primero es menor.
            //     Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int numero1, numero2, resultado;
            
            Console.WriteLine("Ingrese un número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            numero2 = int.Parse(Console.ReadLine());

            if(numero1 > numero2)
                resultado = numero1 - numero2;
            else if(numero1 == numero2)
                resultado = numero1 + numero2;
            else
                resultado = numero1 * numero2;
            
            Console.WriteLine("El resultado es: " + resultado);
            


        }
    }
}
