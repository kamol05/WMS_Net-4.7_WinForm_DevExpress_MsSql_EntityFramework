using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Sys;
using System;

namespace SKLAD.MODEL.Event
{
    public class Event : Identity
    {
        public int Serial { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double M2 { get; set; }
        public int Count { get; set; } = 1;
        public int QuantityInside { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public EventType EventType { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        public DateTime? Modified { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }
        public virtual User User { get; set; }
        public long? UserId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public long? WarehouseId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public long? InvoiceId { get; set; }
    }
}
