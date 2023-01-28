using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
                // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

                 // i5 (1)	i7 (2)	i9 (3)
                // 8 RAM (1)	USD 800	USD 900	USD 1200
                // 16 RAM (2)	USD 900	USD 1000	USD 1400
                // 32 RAM (3)	USD 1000	USD 1400	USD 2000
                // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual 
                // tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la 
                // opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule 
                // y emita por pantalla el monto de la máquina seleccionada.
            
            int opciónProcesador, opciónMemoria, opciónDisco;
            float precio = 0;
            

            Console.WriteLine("Que procesador quiere? 1.i5 2.i7 3.i9");
            opciónProcesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Que memoria ram quiere? 1. 8 RAM 2. 16 RAM 3. 32 RAM");
            opciónMemoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea extender disco o no? (De 500 GB a 1 TB)");
            opciónDisco = int.Parse(Console.ReadLine());

            switch(opciónProcesador){
                case 1:
                    switch(opciónMemoria){
                        case 1:
                     precio = 800;
                        break;
                        case 2:
                     precio = 900;
                        break;
                        case 3:
                     precio = 1000;
                        break;
                    }
                break;
                case 2:
                    switch(opciónMemoria){
                        case 1:
                     precio = 900;
                        break;
                        case 2:
                     precio = 1000;
                        break;
                        case 3:
                     precio = 1400;
                        break;
                    }
                break;
                case 3:
                    switch(opciónMemoria){
                        case 1:
                     precio = 1200;
                        break;
                        case 2:
                     precio = 1400;
                        break;
                        case 3:
                     precio = 2000;
                        break;
                    }
                break;
            }
            if(opciónDisco == 1)
                precio = precio + 500;
            
                
            
            Console.WriteLine("El precio de la pc es: " + precio);



            



        }
    }
}
