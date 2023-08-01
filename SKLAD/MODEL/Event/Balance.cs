using SKLAD.MODEL.Bys;

namespace SKLAD.MODEL.Event
{
    public class Balance : Identity
    {
        public int Serial { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double M2 { get; set; }
        public int Count { get; set; } = 1;
        public int QuantityInside { get; set; } = 0;
        public double Weight { get; set; } = 0.0;
        public EventType? Status { get; set; }
        public EventType? OldStatus { get; set; }

        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public long? WarehouseId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public long? InvoiceId { get; set; }




    }
}
