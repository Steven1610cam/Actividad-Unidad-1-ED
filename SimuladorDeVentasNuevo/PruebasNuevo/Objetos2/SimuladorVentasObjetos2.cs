namespace Objetos2;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Producto(string nombre, double precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public double CalcularTotal() => Precio * Cantidad;
}

public class SimuladorVentasObjetos
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Simulador de Ventas (Objetos) ---");

        var productos = new Producto[]
        {
            new Producto("Bollo", 1000, 10),
            new Producto("Suero", 2500, 5),
            new Producto("Queso", 25000, 2),
            new Producto("Yuca", 2500, 5),
            new Producto("Chicha", 1500, 12)
        };

        MostrarTabla(productos);
    }

    private static void MostrarTabla(Producto[] productos)
    {
        Console.WriteLine("{0,-10} {1,10} {2,10} {3,10}",
            "Producto", "Precio", "Cantidad", "Total");

        double totalGeneral = 0;
        var masVendido = productos[0];

        foreach (var p in productos)
        {
            Console.WriteLine("{0,-10} {1,10:F1} {2,10} {3,10:F1}",
                p.Nombre, p.Precio, p.Cantidad, p.CalcularTotal());
            totalGeneral += p.CalcularTotal();

            if (p.Cantidad > masVendido.Cantidad)
                masVendido = p;
        }

        Console.WriteLine("\nTotal general de ventas: " + totalGeneral);
        Console.WriteLine("El producto más vendido fue: {0} con {1} unidades.",
            masVendido.Nombre, masVendido.Cantidad);
    }
}
