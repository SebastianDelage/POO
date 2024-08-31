using System;



/*
public class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Animal(string nombre, int edad) {
        this.Nombre = nombre;
        this.Edad = edad;
    }

    public void EmitirSonido()
    {
        Console.WriteLine("Emitiendo sonido...");
    }
}

public class Mamifero : Animal
{
    public string Tipopelaje { get; set; }

    public Mamifero(string nombre,int edad,string tipopelaje):base(nombre,edad) 
    { 
       this.Tipopelaje = tipopelaje;
    }

    public void Amamantar()
    {
        Console.WriteLine("Amamantando...");
    }
}


public class Ave : Animal
{
    public double EnvergaduraAlas { get; set; }
    
    public Ave (string nombre, int edad, double envergadura):base(nombre,edad) 
    {
        this.EnvergaduraAlas = envergadura;
    }

    public void Volar()
    {
        Console.WriteLine("Volando...");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Animal NuevoAnimal = new Animal("Leon", 29);
        Console.WriteLine("El nombre del animal es: " + NuevoAnimal.Nombre);
        Console.WriteLine("La edad del animal es: " + NuevoAnimal.Edad);

        Mamifero AnimalMamifero = new Mamifero(NuevoAnimal.Nombre, NuevoAnimal.Edad, "Pelaje negro");
        Console.WriteLine("El nombre del animal es: " + AnimalMamifero.Nombre);
        Console.WriteLine("La edad del animal es: " + AnimalMamifero.Edad);
        Console.WriteLine("El pelaje del animal es: " + AnimalMamifero.Tipopelaje);

        Ave Pajaro = new Ave("Aguila", 6, 104.4);
        Console.WriteLine("El nombre del ave es: "+ Pajaro.Nombre);
        Console.WriteLine("La edad del ave es: "+ Pajaro.Edad);
        Console.WriteLine("La envergadura del ave es: " + Pajaro.EnvergaduraAlas + "cm");
    }
}

*/

public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int anio { get; set; }

    public Vehiculo (string marca, string modelo, int anio)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.anio = anio;
    }

    public int CalcularAnio(int anio)
    {
        int anioNuevo;
        anioNuevo=DateTime.Now.Year;  
        int resta= anioNuevo-anio;
        return resta;

    }


    public virtual void MostrarInformacion (string marca, string modelo, int anio)
    {
        Console.WriteLine("La marca del auto es: "+ marca);   
        Console.WriteLine("El modelo del auto es: "+  modelo);  
        Console.WriteLine("El año de fabricacion es: "+  anio);
        
    }
}

public class Auto : Vehiculo
{
    public int CantidadPuertas { get; set; }
    public string Combustible { get; set; }

    public Auto (string marca, string modelo, int anio, int cantidadPuertas, string Combustible):base (marca, modelo, anio) 
    {
         this.CantidadPuertas = cantidadPuertas;
         this.Combustible = Combustible;

    }
    
    public override void MostrarInformacion(string marca, string modelo, int anio)
    {
        base.MostrarInformacion(marca, modelo, anio);
        Console.WriteLine("La cantidad de puertas es: " + CantidadPuertas);
        Console.WriteLine("El combustible es: " +  Combustible);
    }

}

public class Moto:Vehiculo
{
    public int Cilindarda { get; set; }

    public Moto(string marca, string modelo, int anio, int cilindradad) : base(marca, modelo, anio)
    {
        this.Cilindarda = cilindradad;
    }

    public override void MostrarInformacion(string marca, string modelo, int anio)
    {
        base.MostrarInformacion(marca, modelo, anio);
        Console.WriteLine("La cilindrada es: "+ Cilindarda);
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Auto NuevoCoche = new Auto("Ford","Fiesta",2016,4,"Diesel");
        Console.WriteLine("La marca y modelo del auto es"+  NuevoCoche.Marca + NuevoCoche.Modelo);
        Console.WriteLine("El año del auto es: " + NuevoCoche.anio);
        Console.WriteLine("Tiene un total de "+NuevoCoche.CantidadPuertas+ "puertas");
        Console.WriteLine("Se le carga " + NuevoCoche.Combustible);
        Console.WriteLine("Los años del vehiculo son"+NuevoCoche.CalcularAnio);

        Moto NuevaMoto = new Moto("Honda", "xr", 2017, 34);
        Console.WriteLine("La marca y modelo del auto es" + NuevaMoto.Marca + NuevaMoto.Modelo);
        Console.WriteLine("El año del auto es: " + NuevaMoto.anio);
        Console.WriteLine("Tiene una cilindrad de: "+NuevaMoto.Cilindarda);
        Console.WriteLine("Los años de la moto son: " + NuevaMoto.CalcularAnio);// preguntar por que me escribe raro el resultado de la funcion
    }
}