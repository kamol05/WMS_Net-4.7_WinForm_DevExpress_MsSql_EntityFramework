using SKLAD.MODEL.Event;

namespace SKLAD.SERVICE
{
    public static class BalanceService
    {
        public static Balance CreateInBalance(Event ev, EventType type)
        {
            return new Balance()
            {
                Serial = ev.Serial,
                QuantityInside = ev.QuantityInside,
                M2 = ev.M2,
                Count = ev.Count,
                Width = ev.Width,
                Height = ev.Height,
                Weight = ev.Weight,
                Status = type,
                Warehouse = ev.Warehouse,
                WarehouseId = ev.WarehouseId,
                Product = ev.Product,
                ProductId = ev.ProductId,
                Invoice = null,
                InvoiceId = null,
                CustomerId = ev.CustomerId
            };
        }
        public static void MapToSale(this Balance existing, Invoice invoice)
        {
            existing.Status = EventType.OutTransfer;
            existing.Invoice = invoice;
            existing.InvoiceId = invoice.Id;
        }

        public static void MapToOutTransfer(this Balance existing)
        {
            existing.Status = EventType.OutTransfer;
        }
        public static void MapToInTransfer(this Balance existing)
        {
            existing.Status = EventType.InTransfer;
        }



    }
}
