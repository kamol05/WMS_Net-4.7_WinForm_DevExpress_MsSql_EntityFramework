using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.MODEL.Sys;

namespace SKLAD.SERVICE
{
    public class EventService
    {
        public static Event CreateInTranfer(Balance balance, long warehouseId)
        {
            var outEvent = new Event();
            outEvent.Serial = balance.Serial;
            outEvent.Width = balance.Width;
            outEvent.Height = balance.Height;
            outEvent.M2 = balance.M2;
            outEvent.QuantityInside = balance.QuantityInside;
            outEvent.Weight = balance.Weight;
            outEvent.EventType = EventType.InTransfer;
            outEvent.ProductId = balance.ProductId;
            outEvent.Product = balance.Product;
            outEvent.UserId = null;
            outEvent.CustomerId = balance.CustomerId;
            //outEvent.Warehouse = warehouse;
            outEvent.WarehouseId = warehouseId;
            return outEvent;
        }
        public static Event CreateOutTranfer(Balance balance)
        {
            var outEvent = new Event();
            outEvent.Serial = balance.Serial;
            outEvent.Width = balance.Width;
            outEvent.Height = balance.Height;
            outEvent.M2 = balance.M2;
            outEvent.QuantityInside = balance.QuantityInside;
            outEvent.Weight = balance.Weight;
            outEvent.EventType = EventType.OutTransfer;
            outEvent.ProductId = balance.ProductId;
            outEvent.Product = balance.Product;
            outEvent.UserId = null;
            outEvent.CustomerId = balance.CustomerId;
            outEvent.Warehouse = balance.Warehouse;
            outEvent.WarehouseId = balance.WarehouseId;
            return outEvent;
        }

        public static Event CreateInProduction(BarcodeDto dto, Product product, Counter counter, User user, Warehouse warehouse)
        {
            var inEvent = new Event();
            inEvent.Serial = counter.Serial;
            inEvent.Width = dto.Width;
            inEvent.Height = dto.Height;
            inEvent.M2 = CreateM2(dto);
            inEvent.QuantityInside = dto.IsPaket ? dto.QuantityInside : 1;
            inEvent.Weight = dto.Weight;
            inEvent.EventType = EventType.InProduction;
            inEvent.ProductId = product.Id;
            inEvent.Product = product;
            inEvent.UserId = user.Id;
            inEvent.CustomerId = dto.CustomerId;
            inEvent.Warehouse = warehouse;
            inEvent.WarehouseId = warehouse.Id;
            return inEvent;
        }

        private static double CreateM2(BarcodeDto dto)
        {
            double m2 = dto.Width * dto.Height;
            if (dto.IsPaket)
            {
                m2 = m2 * dto.QuantityInside;
                return m2 / 10_000.0;
            }
            return m2 / 10_000.0;
        }
    }
}
