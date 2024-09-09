using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class PlataformaService
    {
        public void CrearPlataforma(Plataforma nuevaPlataforma)
        {
            using (var context = new SteamContext())
            {
                context.Plataformas.Add(nuevaPlataforma);
                context.SaveChanges();
            }
        }

        public Plataforma ObtenerPlataformaPorId(int id)
        {
            using (var context = new SteamContext())
            {
                return context.Plataformas
                        .Include(x => x.Juegos)
                        .FirstOrDefault(x => x.Id == id);
            }
        }

        public List <Plataforma> GetAll()
        {
            using(var context = new SteamContext())
            {
                return context.Plataformas.ToList();
            }
        }

        public void ActualizarPlataforma(Plataforma plataformaActualizada)
        {
            using(var context = new SteamContext())
            {
                context.Plataformas.Update(plataformaActualizada);
                context.SaveChanges();
            } 
        }

        public void EliminarPlataforma(int id)
        {
            using(var context = new SteamContext())
            {
                var plataforma = context.Plataformas.Find(id);
                if(plataforma != null)
                {
                    context.Plataformas.Remove(plataforma);
                    context.SaveChanges();
                }
            }
        }


    }
}
