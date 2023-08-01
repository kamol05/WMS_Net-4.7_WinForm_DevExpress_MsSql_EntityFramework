using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKLAD.MODEL.Bys
{
    public class Quality : Identity
    {
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; } = true;

        public override string ToString()
        {
            return "ID-" + Id + " " +
                   "Name-" + Name + " " +
                   "Description-" + Description + " " +
                   "Notes-" + Notes + " " +
                   "Status-" + Status;
        }
    }
}
