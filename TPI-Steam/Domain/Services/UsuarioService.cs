using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class UsuarioService
    {
        public void CrearUsuario(Usuario nuevoUsuario)
        {
            using (var context = new SteamContext())
            {
                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();
            }
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (var context = new SteamContext())
            {
                return context.Usuarios
                    /*.Include(u => u.Rol)
                    .Include(u => u.Progresos)
                    .Include(u => u.Reseñas)*/
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            using (var context = new SteamContext())
            {
                return context.Usuarios
                    //.Include(u => u.Rol)
                    .ToList();
            }

        }

        public void ActualizarUsuario(Usuario usuarioActualizado)
        {
            using (var context = new SteamContext())
            {
                context.Usuarios.Update(usuarioActualizado);
                context.SaveChanges();
            }
        }

        public void EliminarUsuario(int id)
        {
            
            using (var context = new SteamContext())
            {
                var usuario = context.Usuarios.Find(id);
                if (usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            }
            
        }



    }

}
