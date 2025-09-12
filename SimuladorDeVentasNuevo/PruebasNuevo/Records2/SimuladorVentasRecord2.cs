namespace Records2;

public record struct ProductoRecord(string Nombre, double Precio, int Cantidad)
{
    public double CalcularTotal() => Precio * Cantidad;
}

public class SimuladorVentasRecord
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Simulador de Ventas (Record) ---");

        var productos = new ProductoRecord[]
        {
            new ProductoRecord("Bollo", 1000, 10),
            new ProductoRecord("Suero", 2500, 5),
            new ProductoRecord("Queso", 25000, 2),
            new ProductoRecord("Yuca", 2500, 5),
            new ProductoRecord("Chicha", 1500, 12)
        };

        MostrarTabla(productos);
    }

    private static void MostrarTabla(ProductoRecord[] productos)
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
