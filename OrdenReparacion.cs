using System;
using System.Collections.Generic;

public class OrdenReparacion
{
    public int IdOrden { get; set; }
    public Cliente Cliente { get; set; } = new Cliente();
    public Tecnico Tecnico { get; set; } = new Tecnico();
    public string Descripcion { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaEntrega { get; set; }

    public void RegistrarOrden() { }
    public void ActualizarOrden() { }
    public void EliminarOrden() { }
    public OrdenReparacion ObtenerOrden() => this;
}
