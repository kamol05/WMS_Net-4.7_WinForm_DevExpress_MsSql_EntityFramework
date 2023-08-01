using SKLAD.MODEL.Event;
using System;
using System.Collections.Generic;

namespace SKLAD.VIEWS.Reports
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void SetValuesForReport(Invoice invoice, List<SaleEvent> list)
        {
            pCustomer.Value = invoice.Customer.Name;
            pNaknoo.Value = invoice.InvoiceNumber;
            pFishno.Value = invoice.Id;
            pMoshin1.Value = invoice.CarNumber;
            pMoshin2.Value = invoice.CarNumber2;
            pDateSelled.Value = invoice.Date;
            pPrintDate.Value = DateTime.Now;
            pPhone.Value = invoice.DriverPhone;
            pWarehouseMan.Value = invoice.WarehouseMan;
            pNotes.Value = invoice.Notes;
            pDescription.Value = invoice.Description;
            objectDataSource1.DataSource = list;
        }
    }
}
