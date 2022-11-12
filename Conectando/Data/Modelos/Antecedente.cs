namespace Backend.Modelos
{
    public class Antecedente
    {
        public int Id { get; set; }
        public string? ObraSocial { get; set; }
        public string? DetalleObra { get; set; }
        public string? GrupoSanguineo { get; set; }
        public string? EnfermedadCronica { get; set; }
        public string? DescripcionEnfermedad { get; set; }
        public string? TomaMedicacion { get; set; }
        public string? DetalleMedicacion { get; set; }
        public Patologia? patologia { get; set; }
    }
}