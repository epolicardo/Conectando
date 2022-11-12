namespace Backend.Modelos
{
    public class Barrio
    {
        public int Id { get; set; }
        public string detalle { get; set; }
        public string CodPostal { get; set; }
        public Localidad localidad { get; set; }
    }
}