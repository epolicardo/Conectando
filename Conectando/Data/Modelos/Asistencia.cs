namespace Backend.Modelos
{
    public class Asistencia
    {
        public int Id { get; set; }
        public Grado grado { get; set; }
        public Division division { get; set; }
        public Turno turno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string estado { get; set; }
        public string justificacion { get; set; }



    }
}