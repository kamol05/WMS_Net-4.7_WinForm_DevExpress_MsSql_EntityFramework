using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using SKLAD.VIEWS.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
            var role = Program.User.Role;
            BarcodeReportEdit.Enabled = false;

            switch (role)
            {
                case "Sklad":
                    Sifatlar.Enabled = false;
                    Paletlar.Enabled = false;
                    Ishchilar.Enabled = false;
                    break;
                case "Sotuv":
                    Nakladnoylar.Enabled = false;
                    Xaridorlar.Enabled = false;
                    Barkod_.Enabled = false;
                    transfer.Enabled = false;
                    Sifatlar.Enabled = false;
                    Dizaynlar.Enabled = false;
                    Paletlar.Enabled = false;
                    Ranglar.Enabled = false;
                    Ishchilar.Enabled = false;
                    Skladlar.Enabled = false;
                    break;
                case "Barkod":
                    Nakladnoylar.Enabled = false;
                    Xaridorlar.Enabled = false;
                    BarcodeReportEdit.Enabled = false;
                    transfer.Enabled = false;
                    Sifatlar.Enabled = false;
                    Dizaynlar.Enabled = false;
                    Paletlar.Enabled = false;
                    Ranglar.Enabled = false;
                    Ishchilar.Enabled = false;
                    Skladlar.Enabled = false;
                    Mahsulotlar_Qoldigi.Enabled = false;
                    Mahsulotlar_Kirim.Enabled = false;
                    Mahsulotlar_Sotilgan.Enabled = false;
                    break;
            }

            this.tabbedView.QueryControl += TabbedView1_QueryControl;
            registerHandlers();
        }
        private void registerHandlers()
        {
            Nakladnoylar.Click += new EventHandler(menuButton_Click);
            Xaridorlar.Click += new EventHandler(menuButton_Click);
            Sifatlar.Click += new EventHandler(menuButton_Click);
            Dizaynlar.Click += new EventHandler(menuButton_Click);
            Ranglar.Click += new EventHandler(menuButton_Click);
            Paletlar.Click += new EventHandler(menuButton_Click);
            Ishchilar.Click += new EventHandler(menuButton_Click);
            Mahsulotlar_Sotilgan.Click += new EventHandler(menuButton_Click);
            Mahsulotlar_Qoldigi.Click += new EventHandler(menuButton_Click);
            Mahsulotlar_Kirim.Click += new EventHandler(menuButton_Click);
            Skladlar.Click += new EventHandler(menuButton_Click);

            Barkod_.Click += new EventHandler(menuButton_Click);
            BARKOD_MALUMOTLARI.Click += new EventHandler(menuButton_Click);
            BarcodeReportEdit.Click += new EventHandler(menuButton_Click);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            var controlName = ((AccordionControlElement)sender).Name;
            var dos = tabbedView.Documents.Where(x => x.Caption.Equals(controlName)).FirstOrDefault();
            if (dos == null || !dos.IsEnabled)
            {
                dos = tabbedView.AddDocument(controlName, controlName);
                dos.ControlTypeName = "SKLAD.VIEWS.Controls." + controlName;
            }
            tabbedView.Controller.Activate(dos);
        }

        private void TabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            #region For using controls from cache
            //if (!tabs.ContainsKey(e.Document.Caption))
            //{
            //    var crl = Helper.GetInstance(e.Document.ControlTypeName);
            //    tabs.Add(e.Document.Caption, crl);
            //    Debug.WriteLine("Control created");
            //}
            //e.Control = tabs[e.Document.Caption];
            //if (e.Control == null)
            //    e.Control = new System.Windows.Forms.Control();
            #endregion
            e.Control = SERVICE.Tools.Helper.GetInstance(e.Document.ControlTypeName);
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        #region No Need maybe need
        Dictionary<string, Control> tabs = new Dictionary<string, Control>();
        private void barButtonItem1_ItemClick(object sender, EventArgs e)
        {
            var dos = tabbedView.Documents.Where(x => x.Caption.Equals("ColorControl")).FirstOrDefault();
            if (dos == null)
            {
                dos = tabbedView.AddDocument("ColorControl", "ColorControl");
                dos.ControlTypeName = "SKLAD.VIEWS.Controls.ColorControl";
            }
            tabbedView.Controller.Activate(dos);
        }
        private void barButtonItem2_ItemClick(object sender, EventArgs e)
        {
            var dos = tabbedView.Documents.Where(x => x.Caption.Equals("CustomerControl")).FirstOrDefault();
            if (dos == null)
            {
                var doc = tabbedView.AddDocument("CustomerControl", "CustomerControl");
                doc.ControlTypeName = "SKLAD.VIEWS.Controls.CustomerControl";
            }
            tabbedView.Controller.Activate(dos);
        }

        #endregion

        private void exit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Prorammadan chiqish ?", "Chiqish", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            var transfer = new TransferLogin();
            transfer.Show();
        }
    }

}
