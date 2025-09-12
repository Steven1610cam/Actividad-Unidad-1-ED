using System;
using Objetos2;
using Structs2;
using Records2;


class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== Protocolo Individual Unidad 1 - Daniel Arroyo ===");
            Console.WriteLine("1. Simulador de Ventas (Objetos)");
            Console.WriteLine("2. Simulador de Ventas (Struct)");
            Console.WriteLine("3. Simulador de Ventas (Record)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = -1;

            switch (opcion)
            {
                case 1:
                    Objetos2.SimuladorVentasObjetos.Ejecutar();
                    break;
                case 2:
                    Structs2.SimuladorVentasStruct.Ejecutar();
                    break;
                case 3:
                    Records2.SimuladorVentasRecord.Ejecutar();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}
