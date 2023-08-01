using DevExpress.Data.ODataLinq.Helpers;
using SKLAD.EF;
using SKLAD.MODEL.Event;
using SKLAD.SERVICE;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Transfer
{
    public partial class BarcodeDeleteForm : DevExpress.XtraEditors.XtraForm
    {
        public BarcodeDeleteForm()
        {
            InitializeComponent();
            topInfo.Text = "BARKOD O'CHIRISH OYNASI";
            this.serialEnter.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void BeginDelete(string stringserial)
        {
            try
            {
                var serial = Int32.Parse(stringserial);
                serialEnter.Text = "";
                using (var db = new EFcontext())
                {
                    var binfo = db.BarcodeInfo.Where(b => b.Serial == serial).FirstOrDefault();
                    if (binfo != null)
                    {
                        if (!binfo.Status)
                        {
                            info.Text = serial + "->     " + "BU BARKOD OLDIN O'CHIRILGAN!!!";
                            return;
                        }
                    }
                    var barkod = db.Balances.Where(b => b.Serial == serial ).FirstOrDefault();
                    if (barkod != null)
                    {
                        LoadTransferedEvents(serial);
                        if (barkod.Status == EventType.Sale)
                        {
                            info.Text = serial + "->     " + "BU BARKOD SOTILGAN!!!";
                            return;
                        }
                        db.Event.RemoveRange(db.Event.Where(e => e.Serial == serial));
                        db.Balances.RemoveRange(db.Balances.Where(e => e.Serial == serial));
                        binfo.Status = false;
                        binfo.DeletedDate = DateTime.Now;
                        binfo.DeletedUser = Program.User.Login;
                        db.SaveChanges();
                        info.Text = serial + "->     " + "BARKOD O'CHIRILDI!!!";
                        return;
                    }
                    info.Text = serial + "->     " + "BUNDAY BARKOD TOPILMADI!!";
                }
                Logger.Log(info.Text, "BarcodeDeleteForm");
            }
            catch (Exception e)
            {
                info.Text = "NOMALUM XATO!!!";
                Logger.Log(e.ToString(), serialEnter.Text);
                MessageBox.Show(e.ToString());
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void serialEnter_EditValueChanged(object sender, EventArgs e)
        {
            if (serialEnter.Text.Trim().Length == 8)
            {
                BeginDelete(serialEnter.Text);
            }
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BeginDelete(serialEnter.Text);
            }
        }

        private void LoadTransferedEvents(int serial)
        {
            harakatlari.Text = harakatlari.Text + "    ->" + serial;
            using (var db = new EFcontext())
            {
                var query = from ev in db.Event.BuildEventIncludedAllRelationships()
                            where ev.Serial == serial
                            select ev;
                gridControl1.DataSource = query.AsNoTracking().ToList();
            }
        }
    }
}