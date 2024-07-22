using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace basededatos;

public partial class BasedatosContext : DbContext
{
    public BasedatosContext()
    {
    }

    public BasedatosContext(DbContextOptions<BasedatosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;port=3306;database=basedatos;user=root;password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public static BasedatosContext CreateContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<BasedatosContext>();
        optionsBuilder.UseMySQL(@"server=localhost;port=3306;database=basedatos;user=root;password=root");

        return new BasedatosContext(optionsBuilder.Options);
    }
}
