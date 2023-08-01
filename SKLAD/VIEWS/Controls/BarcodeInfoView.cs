using SKLAD.EF;
using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.MODEL.Sys;
using SKLAD.SERVICE;
using SKLAD.VIEWS.Tools;
using SKLAD.VIEWS.Transfer;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Controls
{
    public partial class BARKOD_MALUMOTLARI : DevExpress.XtraEditors.XtraUserControl
    {
        public BARKOD_MALUMOTLARI()
        {
            InitializeComponent();
            this.serialTextbox.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void SearchBarkod(string barkodText)
        {
            try
            {
                var barkodNumber = Int32.Parse(barkodText);
                var even = new Event();
                var barcodeInfo = new BarcodeInfo();
                using (var db = new EFcontext())
                {
                    barcodeInfo = db.BarcodeInfo
                                    .Where(o => o.Serial == barkodNumber)
                                    .AsNoTracking()
                                    .FirstOrDefault();
                    if (barcodeInfo != null)
                    {
                        if (barcodeInfo.Status)
                        {
                            even = db.Event.BuildEventIncludedAllRelationships()
                                    .Where(o => o.Serial == barkodNumber)
                                    .AsNoTracking()
                                    .FirstOrDefault();
                            gridControl1.DataSource =
                            db.Event.BuildEventIncludedAllRelationships()
                            .Where(o => o.Serial == barkodNumber)
                            .AsNoTracking()
                            .ToList();
                        }

                        sifat.Text = barcodeInfo.Product.Quality.Name;
                        dizayn.Text = barcodeInfo.Product.Design.Name;
                        rang.Text = barcodeInfo.Product.Color.Name;
                        eni.Text = barcodeInfo.Width.ToString();
                        uzunlig.Text = barcodeInfo.Height.ToString();
                        m2.Text = barcodeInfo.M2.ToString();
                        kg.Text = barcodeInfo.Weight.ToString();
                        xaridor.Text = barcodeInfo.Customer.Name;
                        sana.Text = barcodeInfo.CreatedDate.ToString();
                        sanaochirgan.Text = barcodeInfo.DeletedDate.ToString();
                        barkodchi.Text = barcodeInfo.CreatedUser;
                        kimochirgan.Text = barcodeInfo.DeletedUser;
                        return;
                    }
                    MessageBox.Show("BUNDAY BARKOD TOPILMADI!!!");
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString(), "BarkodeInfoView");
                MessageBox.Show(e.ToString());
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchBarkod(serialTextbox.Text);
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchBarkod(serialTextbox.Text);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var form = new InfoRequestForm();
            form.ChangeTitleText("PAROLNI KIRITING");
            form.HideTextboxChars();
            form.ShowDialog();


            User bdelete;
            if (!string.IsNullOrEmpty(form.name))
            {
                using (var db = new EFcontext())
                {
                    bdelete = db.User.Where(u => u.Login.Equals("BarkodDelete")).AsNoTracking().FirstOrDefault();
                }
                if (form.name.Equals(bdelete.Password))
                {
                    var barcodeDeleteForm = new BarcodeDeleteForm();
                    barcodeDeleteForm.ShowDialog();
                    return;
                }

            }
            MessageBox.Show("PAROL NOTO'G'RI!!!");
        }
    }
}
