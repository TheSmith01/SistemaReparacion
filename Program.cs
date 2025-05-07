using System;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente
        {
            IdCliente = 1,
            Nombre = "Juan Pérez",
            Telefono = "555-1234",
            Correo = "juan@example.com"
        };

        Tecnico tecnico = new Tecnico
        {
            IdTecnico = 101,
            Nombre = "Ana Torres",
            Especialidad = "Electrónica",
            Telefono = "555-5678"
        };

        Elemento elemento = new Elemento
        {
            IdElemento = 5001,
            Tipo = "Laptop",
            Marca = "Dell",
            Modelo = "Inspiron 15",
            NumeroSerie = "ABC123XYZ"
        };

        OrdenReparacion orden = new OrdenReparacion
        {
            IdOrden = 9001,
            Cliente = cliente,
            Tecnico = tecnico,
            Descripcion = "No enciende",
            Estado = "Recibido",
            FechaIngreso = DateTime.Now,
            FechaEntrega = DateTime.Now.AddDays(7)
        };

        OrdenElemento ordenElemento = new OrdenElemento
        {
            IdOrdenElemento = 1,
            Orden = orden,
            Elemento = elemento
        };

        Console.WriteLine("Orden de Reparación");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Cliente: {orden.Cliente.Nombre}");
        Console.WriteLine($"Técnico: {orden.Tecnico.Nombre}");
        Console.WriteLine($"Descripción: {orden.Descripcion}");
        Console.WriteLine($"Elemento: {ordenElemento.Elemento.Marca} {ordenElemento.Elemento.Modelo}");
        Console.WriteLine($"Estado: {orden.Estado}");
        Console.WriteLine($"Fecha Ingreso: {orden.FechaIngreso}");
        Console.WriteLine($"Fecha Entrega: {orden.FechaEntrega}");
    }
}
