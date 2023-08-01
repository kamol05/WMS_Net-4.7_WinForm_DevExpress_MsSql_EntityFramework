using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKLAD.MODEL.Bys
{
    public class Color : Identity
    {
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; } = true;
        public virtual Palette Palette { get; set; }
        public long PaletteId { get; set; }
        public override string ToString()
        {
            return "ID-" + Id + " " +
                    "Name-" + Name + " " +
                    "PaletteId-" + PaletteId + " " +
                    "Description-" + Description + " " +
                    "Notes-" + Notes + " " +
                    "Status-" + Status;
        }
    }
}
