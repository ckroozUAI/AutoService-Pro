namespace Entities
{
    public class RepuestoEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int StockFisico { get; set; }
    }
}