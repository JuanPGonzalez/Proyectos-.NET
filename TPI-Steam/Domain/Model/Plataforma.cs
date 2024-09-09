using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Plataforma
    {
        public int ID { get; set; }
        public required string Nombre { get; set; }

        public List<Juego>? Juegos { get; set; }
    }
}
