namespace Entities
{
    public class OrdenTrabajoEntity
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public decimal CostoTotal { get; set; }
        public int? IdTecnico { get; set; }
    }
}