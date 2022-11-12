namespace Backend.Modelos
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Provincia provincia { get; set; }

    }
}