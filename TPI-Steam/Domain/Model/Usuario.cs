using System.Security.Principal;

namespace Domain.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string Contraseña { get; set; }

        public int RolId { get; set; }
        //public Rol Rol { get; set; }

        //public List<Progreso> Progresos { get; set; }
        //public List <Reseña> Reseñas { get; set; }
    }
}
