using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKLAD.MODEL.Bys
{
    public class Customer : Identity
    {
        [Index(IsUnique = true)]
        [StringLength(12)]
        public string Code { get; set; }
        public string City { get; set; }
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; } = true;
        public override string ToString()
        {
            return "ID-" + Id + " " +
                    "CODE-" + Code + " " +
                    "City-" + City + " " +
                    "Name-" + Name + " " +
                    "Description-" + Description + " " +
                    "Notes-" + Notes + " " +
                    "Status-" + Status;
        }
    }
}
