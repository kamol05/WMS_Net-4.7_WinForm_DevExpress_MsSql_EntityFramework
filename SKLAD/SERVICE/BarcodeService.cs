using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraReports.UI;
using SKLAD.EF;
using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.MODEL.Sys;
using SKLAD.VIEWS.Reports;
using System;
using System.Linq;
using System.Numerics;

namespace SKLAD.SERVICE
{
    public class BarcodeService
    {
        private readonly EFcontext db = new EFcontext();
        public bool ShowPrintDialog = false;
        public bool DontSentToPrinter = false;

        public object[] CreateAndPrint(BarcodeDto dto)
        {
            var product = CheckOrCreateProduct(dto);
            var customer = db.Customer.Where(c => c.Id == dto.CustomerId).FirstOrDefault();
            var warehouse = db.Warehouse.Where(w => w.Id == dto.WarehouseId).FirstOrDefault();
            var inEvent = CreateInEvent(dto, product, Program.User, warehouse);
            var balance = BalanceService.CreateInBalance(inEvent, EventType.InProduction);
            var barcodeInfo = CreateBarcodeInfo(product, inEvent, Program.User.Login);
            try
            {
                db.BarcodeInfo.Add(barcodeInfo);
                db.Event.Add(inEvent);
                db.Balances.Add(balance);
                PrintBarcode(product, inEvent, customer);
                db.SaveChanges();
                return new object[] { true, inEvent };
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, e.ToString());
                return new object[] { false, e };
            }


        }

        private void PrintBarcode(Product product, Event ev, Customer customer)
        {
            BarcodeReport report = new BarcodeReport(product, ev, customer);
            ReportPrintTool printTool = new ReportPrintTool(report);

            if (DontSentToPrinter)
            {
                return;
            }

            if (ShowPrintDialog)
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
                return;
            }

            // Send the report to the default printer.
            printTool.Print();
        }

        public Event CreateInEvent(BarcodeDto dto, Product product, User user, Warehouse warehouse)
        {
            var counter = db.Counter.First();
            counter.Serial = counter.Serial + 1;
            return EventService.CreateInProduction(dto, product, counter, user, warehouse);
        }

        public Product CheckOrCreateProduct(BarcodeDto dto)
        {
            var resutl = db.Product.Where(p => p.QualityId == dto.QualityId &&
                                                p.DesignId == dto.DesignId &&
                                                p.ColorId == dto.ColorId).FirstOrDefault();
            if (resutl != null)
            {
                return resutl;
            }
            var qua = db.Quality.Where(o => o.Id == dto.QualityId).FirstOrDefault();
            var des = db.Design.Where(o => o.Id == dto.DesignId).FirstOrDefault();
            var col = db.Color.Where(o => o.Id == dto.ColorId).FirstOrDefault();

            var counter = db.Counter.First();
            counter.Ean = (BigInteger.Parse(counter.Ean.ToString()) + 1).ToString();

            var Product = new Product(qua, des, col, CalculateEan13(counter.Ean));
            db.Product.Add(Product);
            db.SaveChanges();
            return Product;
        }

        public BarcodeInfo CreateBarcodeInfo(Product p, Event e, string userName)
        {
            var b = new BarcodeInfo
            {
                Serial = e.Serial,
                Ean = p.Ean,
                Width = e.Width,
                Height = e.Height,
                M2 = e.M2,
                Count = e.Count,
                QuantityInside = e.QuantityInside,
                Weight = e.Weight,
                CreatedUser = userName,
                CreatedDate = DateTime.Now,
                Product = e.Product,
                ProductId = e.ProductId,
                Customer = e.Customer,
                CustomerId = e.CustomerId
            };
            return b;
        }

        public static string CalculateEan13(string ean)
        {
            int sum = 0;
            int digit = 0;

            // Calculate the checksum digit here.
            for (int i = ean.Length; i >= 1; i--)
            {
                digit = Convert.ToInt32(ean.Substring(i - 1, 1));
                // This appears to be backwards but the 
                // EAN-13 checksum must be calculated
                // this way to be compatible with UPC-A.
                if (i % 2 == 0)
                { // odd  
                    sum += digit * 3;
                }
                else
                { // even
                    sum += digit * 1;
                }
            }
            int checkSum = (10 - (sum % 10)) % 10;
            return $"{ean}{checkSum}";
        }

    }
}
