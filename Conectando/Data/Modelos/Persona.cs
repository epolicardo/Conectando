namespace Backend.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? apellido { get; set; }
        public string? dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public Genero? genero { get; set; }
        public Domicilio? domicilio { get; set; }
        public string? telefono { get; set; }
        public Antecedente? antecedente { get; set; }
        public Contacto? contacto { get; set; }
    }
}
