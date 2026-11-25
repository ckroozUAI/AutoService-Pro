namespace Entities
{
    public class RepuestoEntity
    {
        public int IdRepuesto { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int StockFisico { get; set; }
    }
}