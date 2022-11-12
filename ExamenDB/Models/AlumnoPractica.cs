
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDB.Models
{
    public class AlumnoPractica
    {
        public int IdAlumno { get; set; }
        public int IdPractica { get; set; }
        public DateTime Fecha { get; set; }
        public int Nota { get; set; }
    }
}
