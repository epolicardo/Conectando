namespace Backend.Modelos
{
    public class Usuario
    {
        public string Id { get; set; }
        public string nombreLogin { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoUsuario { get; set; }
        public string Email { get; set; }
    }
}