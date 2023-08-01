using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using SKLAD.EF;
using SKLAD.MODEL.Event;
using SKLAD.SERVICE;
using SKLAD.VIEWS.Reports;
using SKLAD.VIEWS.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;


namespace SKLAD.VIEWS.Controls
{
    public partial class Nakladnoylar : UserControl
    {
        private EFcontext dbContext;
        public Nakladnoylar()
        {
            var role = Program.User.Role;

            if (role.Equals("Admin") || role.Equals("Sotuv") || role.Equals("Sklad"))
            {

            }
            InitializeComponent();
            gridView1.ValidateRow += gridView1_ValidateRow;
            gridView1.InvalidRowException += gridView1_InvalidRowException;
            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.NewItemRowText = "Yangi nakladnoy kiritish uchun bu yerga bosing!!";
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;

            dbContext = new EFcontext();
            dbContext.Invoice.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Invoice.Local.ToBindingList();
                customerBindingSource.DataSource = dbContext.Customer.ToList();
                warehouseBindingSource.DataSource = dbContext.Warehouse.ToList();
            },
            System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn nakColumn = view.Columns["InvoiceNumber"];
            GridColumn skladColumn = view.Columns["WarehouseId"];
            GridColumn klentColumn = view.Columns["CustomerId"];
            string nakValue = (string)view.GetRowCellValue(e.RowHandle, nakColumn);
            long skladValue = (long)view.GetRowCellValue(e.RowHandle, skladColumn);
            long klentValue = (long)view.GetRowCellValue(e.RowHandle, klentColumn);
            if (string.IsNullOrEmpty(nakValue) || nakValue.Count() < 4)
            {
                e.Valid = false;
                view.SetColumnError(nakColumn, "Nakladnoy Nomer to'gri kiritilmagan!!");
            }
            if (skladValue == 0)
            {
                e.Valid = false;
                view.SetColumnError(skladColumn, "Skladni Tanlash Kerak!!");
            }
            if (klentValue == 0)
            {
                e.Valid = false;
                view.SetColumnError(klentColumn, "Xaridorni Tanlash Kerak!!");
            }
            if (e.Valid)
                view.ClearColumnErrors();
        }
        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var invoice = (Invoice)e.Row;
            if (invoice.Id != 0)
            {
                var anyProductSelled = false;
                var dbInvoiceToString = "";
                using (var db = new EFcontext())
                {
                    var dbInvoice = db.Invoice.Where(o => o.Id == invoice.Id).AsNoTracking().FirstOrDefault();
                    dbInvoiceToString = dbInvoice.ToString();
                    if (!dbInvoice.Status)
                    {
                        MessageBox.Show("NAKLADNOY YOPILGAN O'ZGARTIRISH MUMKIN EMAS!!!");
                        return;
                    }

                    if (invoice.CustomerId != dbInvoice.CustomerId)
                    {
                        anyProductSelled = db.SaleEvent.Where(s => s.InvoiceId == dbInvoice.Id).Any();
                        if (anyProductSelled)
                        {
                            MessageBox.Show("Yuk Sotilgandan keyin 'XARIDORNI' almashtitib bo'lmaydi!!");
                        }
                    }
                    if (invoice.WarehouseId != dbInvoice.WarehouseId)
                    {
                        anyProductSelled = db.SaleEvent.Where(s => s.InvoiceId == dbInvoice.Id).Any();
                        if (anyProductSelled)
                        {
                            MessageBox.Show("Yuk Sotilgandan keyin 'SKLADNI' almashtitib bo'lmaydi!!");
                        }
                    }
                }

                if (!anyProductSelled)
                {
                    invoice.Modified = DateTime.UtcNow;
                    Logger.Log("Change Invoice:" + invoice.ToString(), dbInvoiceToString.ToString());
                    dbContext.SaveChanges();
                }
                return;
            }
            invoice.UserId = Program.User.Id;
            Logger.Log("New Invoice:", invoice.ToString());
            dbContext.SaveChanges();
        }
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Yangi", OnNewRowClick, ImageTool.Get(0)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&O'zgartirish", OnChangeRowClick, ImageTool.Get(1)));

                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Nakladnoy ESKI", HandlePrintInvoiceButton, ImageTool.Get(4)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Nakladnoy KG", HandlePrintInvoiceButton, ImageTool.Get(4)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Nakladnoy DONA", HandlePrintInvoiceButton, ImageTool.Get(4)));

                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Nakladnoy YOPISH", OnBlockInvoiceClick, ImageTool.Get(5)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Nakladnoy OCHISH", OnUnBlockInvoiceClick, ImageTool.Get(6)));

                //e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&O'chirish", OnDeleteRowClick, ImageTool.Get(2)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Orqaga", OnCancelRowClick, ImageTool.Get(3)));
            }
        }
        DXMenuItem CreateMenuItem(GridView view, int rowHandle, string caption, EventHandler handler, System.Drawing.Image image)
        {
            DXMenuItem menuItem = new DXMenuItem(caption, handler, image);
            menuItem.Tag = new RowInfo(view, rowHandle);
            menuItem.Enabled = view.IsDataRow(rowHandle) || view.IsGroupRow(rowHandle);
            return menuItem;
        }
        void HandlePrintInvoiceButton(object sender, EventArgs e)
        {
            var invoice = gridView1.GetFocusedRow() as Invoice;
            var KG = ((DXMenuItem)sender).Caption.Contains("KG");
            var DONA = ((DXMenuItem)sender).Caption.Contains("DONA");

            var saleEventList = new List<SaleEvent>();
            using (var db = new EFcontext())
            {
                var query = from s in db.SaleEvent.BuildSaleEventIncludedAllRelationships()
                            where s.InvoiceId == invoice.Id
                            select s;
                saleEventList = query.AsNoTracking().ToList();
            }
            if (KG)
            {
                var kg = new InvoiceReportKg();
                kg.SetValuesForReport(invoice, saleEventList);
                SendReportToPrintTool(kg);
                return;
            }
            if (DONA)
            {
                var piece = new InvoiceReportKgPiece();
                piece.SetValuesForReport(invoice, saleEventList);
                SendReportToPrintTool(piece);
                return;
            }
            var old = new InvoiceReport();
            old.SetValuesForReport(invoice, saleEventList);
            SendReportToPrintTool(old);

        }
        void SendReportToPrintTool(XtraReport invoiceReport)
        {
            foreach (var p in invoiceReport.Parameters)
                p.Visible = false;

            ReportPrintTool printTool = new ReportPrintTool(invoiceReport);
            printTool.PreviewRibbonForm.SaveState = false;
            printTool.PreviewRibbonForm.WindowState = FormWindowState.Maximized;
            printTool.ShowRibbonPreview();
        }
        void OnNewRowClick(object sender, EventArgs e)
        {
            this.gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
            this.gridView1.ShowEditForm();
        }
        void OnChangeRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            gridView1.ShowPopupEditForm();
        }
        void OnDeleteRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            RowInfo ri = menuItem.Tag as RowInfo;
            if (ri != null)
            {
                string message = menuItem.Caption.Replace("&", "");
                if (XtraMessageBox.Show(message + "ni hohlaysizmi?", "Tasdiqlash", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                ri.View.DeleteRow(ri.RowHandle);
            }
        }
        void OnCancelRowClick(object sender, EventArgs e) { return; }
        void OnBlockInvoiceClick(object sender, EventArgs e)
        {
            var invoice = gridView1.GetFocusedRow() as Invoice;
            DXMenuItem menuItem = sender as DXMenuItem;
            RowInfo ri = menuItem.Tag as RowInfo;
            string message = menuItem.Caption.Replace("&", "");
            if (XtraMessageBox.Show(message + "ni hohlaysizmi?", "Tasdiqlash", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new EFcontext())
                {
                    Logger.Log("NAKLADNOY YOPILDI" + Program.User.Login, invoice.ToString());
                    var dbInvoice = db.Invoice.Where(o => o.Id == invoice.Id).FirstOrDefault();
                    dbInvoice.Status = false;
                    db.SaveChanges();
                }
            }
        }
        void OnUnBlockInvoiceClick(object sender, EventArgs e)
        {
            var invoice = gridView1.GetFocusedRow() as Invoice;
            var form = new InfoRequestForm();
            form.ChangeTitleText("PAROLNI KIRITING");
            form.HideTextboxChars();
            form.ShowDialog();
            if (!string.IsNullOrEmpty(form.name))
            {
                if (form.name.Equals("123456"))
                {
                    using (var db = new EFcontext())
                    {
                        Logger.Log("NAKLADNOY OCHILDI" + Program.User.Login, invoice.ToString());
                        var dbInvoice = db.Invoice.Where(o => o.Id == invoice.Id).FirstOrDefault();
                        dbInvoice.Status = true;
                        db.SaveChanges();
                    }
                    return;
                }

            }
            MessageBox.Show("PAROL NOTO'G'RI!!!");
        }
        class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }
            public GridView View;
            public int RowHandle;
        }
    }
}
