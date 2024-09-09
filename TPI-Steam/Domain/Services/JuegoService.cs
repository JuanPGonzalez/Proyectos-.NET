using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class JuegoService
    {
        public void CrearJuego(Juego nuevoJuego)
        {
            using (var context = new SteamContext())
            {
                context.Juegos.Add(nuevoJuego);
                context.SaveChanges();
            }
        }

        public Juego ObtenerJuegoPorId(int id)
        {
            using(var context = new SteamContext())
            {
                return context.Juegos
                        .Include (x => x.Plataforma)
                        .Include(x => x.Progresos)
                        .Include(x => x.Reseñas)
                        .FirstOrDefault(x => x.Id == id);
            }
        }
        public List<Juego> GetAll()
        {
            using (var context = new SteamContext())
            {
                return context.Juegos
                        .Include(x => x.Plataforma)
                        .ToList();
            }
        }

        public void ActualizarJuego(Juego juegoActualizado)
        {
            using (var context = new SteamContext())
            {
                context.Juegos.Update(juegoActualizado);
                context.SaveChanges();
            }
        }

        public void EliminarJuego(int id)
        {
            using  (var context = new SteamContext())
            {
                var juego = context.Juegos.Find(id);
                if (juego != null)
                {
                    context.Juegos.Remove(juego);
                    context.SaveChanges();
                }
            }
        }
    }
}
