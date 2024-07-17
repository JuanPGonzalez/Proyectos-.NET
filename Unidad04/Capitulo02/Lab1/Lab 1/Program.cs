using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Crear un nuevo alumno
        CrearAlumno(new Alumno(1, "Gomez", "Ana", 67890, "Avenida Siempre Viva 742"));

        // Leer un alumno por nombre
        LeerAlumnoPorNombre("Ana");

        // Actualizar un alumno por legajo
        ActualizarAlumno(67890, "Avenida Siempre Viva 743");

        // Eliminar un alumno por legajo
        EliminarAlumno(67890);
    }

    static void CrearAlumno(Alumno alumno)
    {
        using (var context = new UniversidadContext())
        {
            context.Alumnos.Add(alumno);
            context.SaveChanges();
            Console.WriteLine($"Alumno {alumno.Nombre} {alumno.Apellido} creado exitosamente.");
        }
    }

    static void LeerAlumnoPorNombre(string nombre)
    {
        using (var context = new UniversidadContext())
        {
            var alumno = context.Alumnos.FirstOrDefault(a => a.Nombre == nombre);
            if (alumno != null)
            {
                Console.WriteLine($"Alumno encontrado: {alumno.Nombre} {alumno.Apellido}, Legajo: {alumno.Legajo}, Dirección: {alumno.Direccion}");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún alumno con el nombre {nombre}.");
            }
        }
    }

    static void ActualizarAlumno(int legajo, string nuevaDireccion)
    {
        using (var context = new UniversidadContext())
        {
            var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == legajo);
            if (alumno != null)
            {
                alumno.Direccion = nuevaDireccion;
                context.SaveChanges();
                Console.WriteLine($"Alumno con legajo {legajo} actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún alumno con el legajo {legajo}.");
            }
        }
    }

    static void EliminarAlumno(int legajo)
    {
        using (var context = new UniversidadContext())
        {
            var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == legajo);
            if (alumno != null)
            {
                context.Alumnos.Remove(alumno);
                context.SaveChanges();
                Console.WriteLine($"Alumno con legajo {legajo} eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún alumno con el legajo {legajo}.");
            }
        }
    }
}