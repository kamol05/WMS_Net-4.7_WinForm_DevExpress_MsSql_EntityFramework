using System;

namespace SKLAD.MODEL.Event
{
    public class Terminal : Identity
    {
        public long InvoiceId { get; set; }
        public string Serial { get; set; }
        public long? WarehouseId { get; set; }
        public long? CustomerId { get; set; }
        public short? WorkStatus { get; set; }
        public string WorkInfo { get; set; }
        public DateTime? Created { get; set; }
        public bool? Remove { get; set; }
    }
}
