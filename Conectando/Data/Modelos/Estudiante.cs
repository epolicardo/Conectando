using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Modelos
{
    public class Estudiante
    {
        public int Id { get; set; }
        public Persona? Persona { get; set; }    
        public Domicilio domicilio { get; set; }
        public Inscripcion inscripcion { get; set; }
        public List<Asistencia> asistencias { get; set; }

    }
}
