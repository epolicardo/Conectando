using System.Security.Principal;

namespace Backend.Modelos
{
    public class Domicilio
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Numero { get; set; }
        public string Manzana { get; set; }
        public string Lote { get; set; }
        public Barrio barrio { get; set; }


    }
}