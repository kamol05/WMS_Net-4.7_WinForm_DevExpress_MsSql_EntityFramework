using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using System;

namespace SKLAD.VIEWS.Reports
{
    public partial class BarcodeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BarcodeReport()
        {
        }

        public BarcodeReport(Product product, Event ev, Customer customer)
        {
            InitializeComponent();
            sifat.Text = ":" + ev.Product.Quality.Name;
            dizayn.Text = ":" + ev.Product.Design.Name;
            rang.Text = ":" + ev.Product.Color.Name;
            razmer.Text = ":" + ev.Width + "X" + ev.Height + "  " + ev.QuantityInside;
            barkod.Text = ev.Serial.ToString();
            barkodserial.Text = ev.Serial.ToString();
            datetime.Text = DateTime.Now.ToString("HH:mm:ss  dd-MM");
            clientcode.Text = customer.Code;
            smena.Text = ev.UserId + "-S";
            ean13.Text = product.Ean;
            ogirlik.Text = ev.Weight.ToString();
        }


    }
}
