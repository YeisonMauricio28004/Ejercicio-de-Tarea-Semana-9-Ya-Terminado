using System;
using EjercicioSemana8.DAO;
using EjercicioSemana8.Models;

while (true)
{
    Console.WriteLine("Por Favor Seleccione una Opción del Menú");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Salir");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Producto producto = new Producto();
            crudProductos crudProductos = new crudProductos();
            Console.WriteLine("Ingrese el Nombre del Producto que desee llevar");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Descripción Producto que desee llevar");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio del Producto que desee llevar");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock del Producto que desee llevar");
            producto.Stock = int.Parse(Console.ReadLine());
            break;
        case 2:
            break;
    }
    Console.WriteLine("¿Desea Volver a la Ejecución del Programa? SI= S / No= N");
    String seguir = Console.ReadLine();
    if(!(seguir.Equals ('S')))  
    {
        break;
    }
    
}



    




