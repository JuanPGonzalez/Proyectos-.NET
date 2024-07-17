using Microsoft.EntityFrameworkCore;
using System;

public class UniversidadContext : DbContext
{
    public DbSet<Alumno> Alumnos { get; set; }
    public UniversidadContext()
    {
        this.Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true");

    }

    //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);


}
