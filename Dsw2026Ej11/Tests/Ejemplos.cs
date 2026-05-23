using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Alumno alumno1 = new Alumno(0, "Mauro", 7.5);
        Alumno alumno2 = new Alumno(1, "Pol", 10.0);
        Alumno alumno3 = new Alumno(2, "Elvira", 4.5);

        CasoList listaAlumnos = new CasoList();
        listaAlumnos.AgregarAlumno(alumno1);
        listaAlumnos.AgregarAlumno(alumno2);
        listaAlumnos.AgregarAlumno(alumno3);

        List<Alumno> alumnos = listaAlumnos.ObtenerLista();
        Console.WriteLine("Alumnos:");
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
        Console.WriteLine(listaAlumnos.BuscarAlumno("Sandra")?.ToString() ?? "No existe");
        listaAlumnos.EliminarAlumno(alumno2);   
        Console.WriteLine("Pol eliminado");
        Console.WriteLine("Alumnos restantes:");
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
        listaAlumnos.EliminarAlumnoEnPosicion(0);
        Console.WriteLine("Alumno en la primera posición eliminado");
        Console.WriteLine("Alumnos restantes:");
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Alumno alumno1 = new Alumno(0, "Mauro", 7.5);
        Alumno alumno2 = new Alumno(1, "Pol", 10.0);
        Alumno alumno3 = new Alumno(2, "Elvira", 4.5);

        CasoDictionary diccionarioAlumnos = new CasoDictionary();
        diccionarioAlumnos.AgregarAlumno(alumno1.Id, alumno1);
        diccionarioAlumnos.AgregarAlumno(alumno2.Id, alumno2);
        diccionarioAlumnos.AgregarAlumno(alumno3.Id, alumno3);

        Console.WriteLine("Alumnos:");
        foreach (Alumno alumno in diccionarioAlumnos.ObtenerDiccionario().Values)
        {
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine("Buscar por id 2:");
        Console.WriteLine(diccionarioAlumnos.BuscarAlumno(2)?.ToString() ?? "No existe");

        Console.WriteLine("Buscar por id 3:");
        Console.WriteLine(diccionarioAlumnos.BuscarAlumno(3)?.ToString() ?? "No existe");
        diccionarioAlumnos.EliminarAlumno(1);
        Console.WriteLine("Alumno con id 1 eliminado");
        Console.WriteLine("Alumnos restantes:");
        foreach (Alumno alumno in diccionarioAlumnos.ObtenerDiccionario().Values)
        {
            Console.WriteLine(alumno.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linqLibros = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(linqLibros.GetPrimero()?.ToString() ?? "No existe");
        Console.WriteLine("Último libro:");
        Console.WriteLine(linqLibros.GetUltimo()?.ToString() ?? "No existe");
        Console.WriteLine("Suma de precios:");
        Console.WriteLine(linqLibros.GetTotalPrecios());
        Console.WriteLine("Promedio de precios:");
        Console.WriteLine(linqLibros.GetPromedioPrecios());
        Console.WriteLine("Libros con id mayor a 15:");
        foreach (var libro in linqLibros.GetListById())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("Lista de cada libro con su título y precio:");
        foreach (var libro in linqLibros.GetLibros())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("Libro con precio mas alto:");
        Console.WriteLine(linqLibros.GetMayorPrecio()?.ToString() ?? "No existe");
        Console.WriteLine("Libro con precio mas bajo:");
        Console.WriteLine(linqLibros.GetMenorPrecio()?.ToString() ?? "No existe");
        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (var libro in linqLibros.GetMayorPromedio())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("Libros ordenados por titulo descendente:");
        foreach (var libro in linqLibros.GetLibrosOrdenados())
        {
            Console.WriteLine(libro.ToString());
        }
    }
}
