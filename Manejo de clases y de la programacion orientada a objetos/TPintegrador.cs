using System;
using System.Text.RegularExpressions;



interface IVendible
{
    public void Vender(int cantidad);
}





public abstract class ProductoEnVenta:IVendible
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Descripcion { get; set; }
    public int Inventario { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("El producto es: " + Nombre);
        Console.WriteLine("El precio es: " + Precio);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Inventario disponible: " + Inventario);
    }

    public virtual void Vender(int cantidad)
    {
        Console.WriteLine("No se puede vender desde la calse base");
    }

    public ProductoEnVenta(string nombre, double precio, string descripcion, int inventario)
    {
        Nombre = nombre;
        Precio = precio;
        Descripcion = descripcion;
        Inventario = inventario;
    }
}

public class Electronicos : ProductoEnVenta, IVendible
{
    public string Marca { get; set; }
    public Electronicos(string nombre, double precio, string descripcion, int inventario, string marca) : base(nombre, precio, descripcion, inventario)
    {
        this.Marca = marca;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"La marca es: {Marca}");
    }


    public override void Vender(int cantidad)
    {
        if (cantidad <= Inventario)
        {
            Inventario -= cantidad;
            Console.WriteLine("El producto fue vendido");
            Console.WriteLine($"El inventario restante es: {Inventario} ");
        }
        else
        {
            Console.WriteLine("No hay stock suficiente");
        }
    }
}

public class Libros : ProductoEnVenta, IVendible
{
   
    public string Marca { get; set;}
    
    public Libros(string nombre, double precio, string descripcion, int inventario, string marca) : base(nombre, precio, descripcion, inventario)
    {
        this.Marca = marca;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"La marca es: {Marca}");
    }

    public override void Vender(int cantidad)
    {
        if (cantidad <= Inventario)
        {
            Inventario -= cantidad;
            Console.WriteLine("El producto fue vendido");
            Console.WriteLine($"El inventario restante es: {Inventario} ");
        }
        else
        {
            Console.WriteLine("No hay stock suficiente");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Libros Libro = new Libros("El principito", 2000, "Divertido", 200, "Planeta");
        Libro.MostrarInformacion();
        Libro.Vender(5);
    }
}