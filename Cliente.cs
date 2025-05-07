public class Cliente : Persona
{
    public int IdCliente { get; set; }
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;

    public void RegistrarCliente() { }
    public void ActualizarCliente() { }
    public void EliminarCliente() { }
    public Cliente ObtenerCliente() => this;

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Cliente] Nombre: {Nombre}, Telefono: {Telefono}, Correo: {Correo}");
    }
}
