namespace Backend.Modelos
{
    public class Contacto
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Parentesco parentesco { get; set; }
        public string Telefono { get; set; }
        
    }
}