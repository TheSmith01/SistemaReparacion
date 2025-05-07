public class Tecnico : Persona
{
    public int IdTecnico { get; set; }
    public string Especialidad { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;

    public void AsignarReparacion() { }
    public void ActualizarTecnico() { }
    public void EliminarTecnico() { }
    public Tecnico ObtenerTecnico() => this;

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Tecnico] Nombre: {Nombre}, Especialidad: {Especialidad}, Telefono: {Telefono}");
    }
}
