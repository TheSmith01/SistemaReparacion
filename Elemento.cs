public class Elemento
{
    public int IdElemento { get; set; }
    public string Tipo { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string NumeroSerie { get; set; } = string.Empty;

    public void RegistrarElemento() { }
    public void ActualizarElemento() { }
    public void EliminarElemento() { }
    public Elemento ObtenerElemento() => this;
}