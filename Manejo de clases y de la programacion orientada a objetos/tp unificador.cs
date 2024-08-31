


using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PC
{
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public int Resolucion { get; set; }
    public string Descripcion { get; set; }
    public int TamanioDisco { get; set; }
    public int TamaniDiscoMax { get; set; }

    public void AniadirDatos(int datos)
    {


        if (datos < TamaniDiscoMax)
        {
            TamanioDisco = TamanioDisco + datos;
            Console.WriteLine($"Al disco tiene {TamanioDisco} de {TamaniDiscoMax}");
        } else
        {
            Console.WriteLine("El archivo sobre pasa el maximo del permitido");
        }
    }

    public void EliminarDatos(int datos)
    {
        if (TamanioDisco > 0)
        {
            TamanioDisco = TamanioDisco - datos;
            Console.WriteLine($"Al disco tiene {TamanioDisco} de {TamaniDiscoMax}");
        } else {
            Console.WriteLine("El disco esta vacio");
        }

    }

    public virtual void Encender(int bateria)
    {
        Console.WriteLine("El disposotivo esta encendido");
    }

    public virtual void Apagar()
    {
        Console.WriteLine("El disposotivo esta apagado");
    }


    public  PC(string nombre, string marca, int resolucion, string descripcion,int disco,int discoMax)
    {
        Nombre = nombre;
        Marca = marca;
        Resolucion = resolucion;
        Descripcion = descripcion;
        TamaniDiscoMax = discoMax;
        TamanioDisco = disco;
    }
}

public class Notebook : PC 
{
    public int Bateria { get; set; }

    public Notebook(string nombre, string marca, int resolucion, string descripcion, int disco, int discoMax,int bateria):base(nombre,marca,resolucion,descripcion,disco,discoMax) 
    {
        this.Bateria = bateria;   
    }

    public override void Encender(int bateria)
    {
        if (bateria > 0)
        {
            Console.WriteLine("el dispositivo se encendio");
        } else
        {
            Console.WriteLine("EL dispostivo no tiene bateria");
        }
    }


}

public class Tablet:PC
{
    public int Bateria { get; set; }

    public Tablet(string nombre, string marca, int resolucion, string descripcion, int disco, int discoMax, int bateria) : base(nombre, marca, resolucion, descripcion, disco, discoMax) 
    {
        this.Bateria= bateria;
    }
}



class Prorgram
{
    static void Main(string[] args)
    {
        PC compu = new PC("jasdjasd", "aorus", 2020, "compu", 1000, 2000);
        compu.Encender(10);
        compu.AniadirDatos(100);
        compu.EliminarDatos(100);
        compu.Apagar();

        Notebook note = new Notebook ("jasdjasd", "aorus", 2020, "compu", 1000, 2000,40);
        note.Encender(40);
        note.AniadirDatos (100);
        note.EliminarDatos (100);
        note.Apagar();
    }
}
