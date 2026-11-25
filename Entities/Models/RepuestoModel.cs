namespace Entities.Models
{
    public partial class RepuestoModel
    {
        public int IdRepuesto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int StockFisico { get; set; }
    }
}