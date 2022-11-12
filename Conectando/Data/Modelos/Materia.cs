namespace Backend.Modelos
{
    public class Materia
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public Docente docente { get; set; }
    }
}