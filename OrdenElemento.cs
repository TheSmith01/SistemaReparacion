public class OrdenElemento
{
    public int IdOrdenElemento { get; set; }
    public OrdenReparacion Orden { get; set; } = new OrdenReparacion();
    public Elemento Elemento { get; set; } = new Elemento();

    public void RegistrarOrdenElemento() { }
    public void ActualizarOrdenElemento() { }
    public void EliminarOrdenElemento() { }
    public OrdenElemento ObtenerOrdenElemento() => this;
}