using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Sys;
using System;
using System.ComponentModel.DataAnnotations;

namespace SKLAD.MODEL.Event
{
    public class Invoice : Identity
    {
        public string DriverPhone { get; set; } = string.Empty;
        public string CarNumber { get; set; } = string.Empty;
        public string CarNumber2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nakladnoy Nomerni kiriting!!")]
        public string InvoiceNumber { get; set; } = string.Empty;
        public string WarehouseMan { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public DateTime? Modified { get; set; }
        public bool Status { get; set; } = true;


        public virtual Customer Customer { get; set; }
        public long CustomerId { get; set; }
        public virtual User User { get; set; }
        public long? UserId { get; set; }

        public virtual Warehouse Warehouse { get; set; }
        public long WarehouseId { get; set; }

        public override string ToString()
        {
            return "FISHNO-" + Id +
                    " KLENT-" + CustomerId +
                    " SKLAD-" + WarehouseId + " " +
                    InvoiceNumber + " " +
                    DriverPhone + " " +
                    CarNumber + " " +
                    CarNumber2 + " " +
                    WarehouseMan + " " +
                    Description + " " +
                    Notes + " " +
                    "STATUS-" + Status;
        }
    }
}
