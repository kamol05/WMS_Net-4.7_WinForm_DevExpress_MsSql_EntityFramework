using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKLAD.MODEL.Bys
{
    public class Warehouse : Identity
    {
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        [Index(IsUnique = true)]
        public int Code { get; set; }
        public bool Status { get; set; }
        public override string ToString()
        {
            return "ID-" + Id + " " +
                    "Name-" + Name + " " +
                    "Code-" + Code + " " +
                    "Description-" + Description + " " +
                    "Notes-" + Notes + " " +
                    "Status-" + Status;
        }
    }

}
