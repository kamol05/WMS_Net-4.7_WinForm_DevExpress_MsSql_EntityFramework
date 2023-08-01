namespace SKLAD.SERVICE
{
    public class BarcodeDto
    {
        public BarcodeDto(long warehouse, long quality, long design, long color, long customer, decimal width, decimal height, string weight, decimal quantityInside, bool isPaket)
        {
            WarehouseId = warehouse;
            QualityId = quality;
            DesignId = design;
            ColorId = color;
            CustomerId = customer;
            Width = (int)width;
            Height = (int)height;
            Weight = double.Parse(weight);
            QuantityInside = (int)quantityInside;
            IsPaket = isPaket;
        }

        public long WarehouseId { get; set; }
        public long QualityId { get; set; }
        public long DesignId { get; set; }
        public long ColorId { get; set; }
        public long CustomerId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public int QuantityInside { get; set; }
        public bool IsPaket { get; set; }

    }
}
