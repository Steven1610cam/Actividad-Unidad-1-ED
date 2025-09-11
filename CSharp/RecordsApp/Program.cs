using System;
using System.Collections.Generic;

// 1. Declaracion

public record struct EstudianteRecord
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    public EstudianteRecord(string nombre, int edad, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }
}

class Program
{
    static void Main()
    {
        // 2. Inicialización

        var alumno1 = new EstudianteRecord("Daniel Arroyo", 21, 4.3);
        var alumno2 = new EstudianteRecord("Mario Padilla", 22, 3.9);
        var alumno3 = new EstudianteRecord("Camila Aguas", 21, 4.8);

        var listaEstudiantes = new List<EstudianteRecord> { alumno1, alumno2, alumno3 };


        // 3. Recorrido

        Console.WriteLine("----Records/Struct----");
        int i = 1;
        foreach (var est in listaEstudiantes)
        {
            Console.WriteLine($"Estudiante {i++}:");
            Console.WriteLine($"  Nombre: {est.Nombre}");
            Console.WriteLine($"  Edad: {est.Edad}");
            Console.WriteLine($"  Promedio: {est.Promedio}");
            Console.WriteLine(new string('-', 30));
        }


        // 4. Modificación

        Console.WriteLine("----Modificar Promedio----");

        for (int j = 0; j < listaEstudiantes.Count; j++)
        {
            if (listaEstudiantes[j].Nombre == "Mario Padilla")
            {
                var est = listaEstudiantes[j];
                est.Promedio = 4.0;  // Modificación
                listaEstudiantes[j] = est; // Guardar cambios
                Console.WriteLine($"El nuevo promedio de {est.Nombre} es: {est.Promedio}");
            }
        }
    }
}
