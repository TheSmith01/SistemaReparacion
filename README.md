# Sistema de Gestión para Servicio de Reparación de Computadoras

Este proyecto fue desarrollado como parte de la asignatura de **Programación Orientada a Objetos**, y tiene como objetivo modelar e implementar un sistema que permita gestionar de forma estructurada los procesos en un taller técnico.

## 👨‍💻 Estudiante
- **Nombre:** Yefreider Smith Diaz Diaz
- **Código:** 82202425526

## 🧩 Descripción del sistema

El sistema permite:

- Registrar clientes, técnicos y elementos a reparar.
- Crear órdenes de reparación asociadas a un cliente, técnico y varios elementos.
- Aplicar herencia y polimorfismo con una clase base `Persona`.
- Reflejar en código lo modelado en el diagrama UML entregado.

## 📐 Diagrama UML

![Diagrama UML](Diagrama.png)

## ⚙️ Requisitos cumplidos

- ✅ Diagrama de clases completo y subido en `.png`
- ✅ Código C# con clases y métodos según el diagrama
- ✅ Polimorfismo implementado con la clase `Persona` y el método `MostrarDatos()`
- ✅ Instancias de todas las clases creadas en `Main()`
- ✅ Métodos implementados (con retornos dummy cuando aplica)
- ✅ Proyecto subido a GitHub

## ▶️ Ejecución

Para compilar y correr el proyecto:

```bash
dotnet build
dotnet run
```

## 📁 Estructura

```
├── Cliente.cs
├── Tecnico.cs
├── Persona.cs
├── Elemento.cs
├── OrdenReparacion.cs
├── OrdenElemento.cs
├── Program.cs
├── Diagrama.png
└── README.md
```
