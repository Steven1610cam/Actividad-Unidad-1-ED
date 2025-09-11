namespace ObjetosApp;

// # 1. Declaración
public class EstudianteClase
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    // Constructor (equivalente al __init__ de Python)
    public EstudianteClase(string nombre, int edad, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }

    // Método mostrarInfo (equivalente a mostrarInfo de Python)
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
    }

    // Método setPromedio (equivalente a setPromedio de Python)
    public void SetPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}
