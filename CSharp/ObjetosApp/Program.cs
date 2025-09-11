using System;
using System.Collections.Generic;

namespace ObjetosApp
{
    class Program
    {
        static void Main()
        {
            // # 2. Inicialización
            var alumno1 = new EstudianteClase("Daniel Arroyo", 21, 4.3);
            var alumno2 = new EstudianteClase("Mario Padilla", 22, 3.9);
            var alumno3 = new EstudianteClase("Camila Aguas", 21, 4.8);

            var listaEstudiantes = new List<EstudianteClase> { alumno1, alumno2, alumno3 };

            // # 3. Recorrido
            Console.WriteLine("----Información de Estudiantes----");
            foreach (var est in listaEstudiantes)
            {
                est.MostrarInfo();
            }

            // # 4. Modificación
            Console.WriteLine("\n----Modificación de Promedio----");
            alumno2.SetPromedio(4.5);  // Cambio de promedio para Mario otra vez xd
            alumno2.MostrarInfo();
        }
    }
}
