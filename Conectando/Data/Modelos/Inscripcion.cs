namespace Backend.Modelos
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public estadoInscripcion estadoInscripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string NroMatricula { get; set; }
        public Grado grado { get; set; }
        public Division division { get; set; }
        public Turno turno { get; set; }
        public int vacante { get; set; }

    }
}