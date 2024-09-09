using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Juego
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Genero { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        //public EstadoJuego Estado {  get; set; }

        public int PlataformaId { get; set; }
        public required Plataforma Plataforma { get; set; }

        //public List<Progreso> Progresos { get; set; }

        //public List<Reseña> Reseñas { get; set; }
    }
}

/*public enum EstadoJuego
{

}*/
