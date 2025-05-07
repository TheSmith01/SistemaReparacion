public class Persona
{
    public string Nombre { get; set;} = string.Empty;

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }
}