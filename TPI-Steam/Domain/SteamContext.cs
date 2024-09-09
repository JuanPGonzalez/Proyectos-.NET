using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Domain
{
    internal class SteamContext : DbContext
    {
        internal DbSet<Juego> Juegos{ get; set; }
        internal DbSet<Plataforma> Plataformas { get; set; }
        internal DbSet<Usuario> Usuarios { get; set; }

        internal SteamContext(){
            this.Database.EnsureCreated();
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    //optionsBuilder.UseMySQL(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=ClienteDb");
    
}
}
