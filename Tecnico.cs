public class Tecnico
{
    public int IdTecnico { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Especialidad { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;

    public void AsignarReparacion() { }
    public void ActualizarTecnico() { }
    public void EliminarTecnico() { }
    public Tecnico ObtenerTecnico() => this;
}
