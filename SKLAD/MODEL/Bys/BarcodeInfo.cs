using System;

namespace SKLAD.MODEL.Bys
{
    public class BarcodeInfo : Identity
    {
        public int Serial { get; set; }
        public string Ean { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double M2 { get; set; }
        public int Count { get; set; } = 1;
        public int QuantityInside { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public bool Status { get; set; } = true;
        public string CreatedUser { get; set; }
        public string DeletedUser { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }

    }
}
