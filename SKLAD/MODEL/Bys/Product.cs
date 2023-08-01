namespace SKLAD.MODEL.Bys
{
    public class Product : Identity
    {
        public Product() { }
        public Product(Quality qua, Design des, Color col, string ean)
        {
            Quality = qua;
            Design = des;
            Color = col;
            QualityId = qua.Id;
            DesignId = des.Id;
            ColorId = col.Id;
            Ean = ean;
        }

        public virtual Quality Quality { get; set; }
        public virtual Design Design { get; set; }
        public virtual Color Color { get; set; }
        public long QualityId { get; set; }
        public long DesignId { get; set; }
        public long ColorId { get; set; }
        public string Ean { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; } = true;

        public override string ToString()
        {
            return Quality.Name + " " + Design.Name + " " + Color.Name;
        }
    }
}
