namespace Backend.Modelos
{
    public class Docente
    {
        public int Id { get; set; }
        public string Jornada { get; set; }
        public string DescripcionJornada { get; set; }
        public Persona persona { get; set; }


    }
}