public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;

    public void RegistrarCliente() { }
    public void ActualizarCliente() { }
    public void EliminarCliente() { }
    public Cliente ObtenerCliente() => this;
}
