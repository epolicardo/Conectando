﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Modelos
{
    public class Calificacion
    {
        public int Id { get; set; }
        public string nota { get; set; }
        public Estudiante estudiante { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
