using DevExpress.XtraEditors;
using SKLAD.EF;
using SKLAD.MODEL.Event;
using SKLAD.SERVICE;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Controls
{
    public partial class Barkod_ : UserControl //DevExpress.XtraEditors.XtraForm
    {
        public Barkod_()
        {
            InitializeComponent();
            paketSoni.ReadOnly = true;
            paketSoni.Controls[0].Visible = false;
            //sklad.ReadOnly = true;
            if (!Program.User.Role.Equals("Admin"))
            {
                showdialogtoggle.ReadOnly = true;
                noprinttoggle.ReadOnly = true;
            }
            FillData();
        }

        private async void FillData()
        {
            using (var dbContext = new SKLAD.EF.EFcontext())
            {
                sifat.Properties.DataSource = dbContext.Quality.AsNoTracking().ToList();
                dizayn.Properties.DataSource = dbContext.Design.AsNoTracking().ToList();
                palet.Properties.DataSource = dbContext.Palette.AsNoTracking().ToList();
                xaridor.Properties.DataSource = dbContext.Customer.AsNoTracking().ToList();

                sklad.Properties.DataSource = dbContext.Warehouse.AsNoTracking().ToList();
                sklad.EditValue = long.Parse("1");
            }
        }

        private void Rulon_Paket_Toggle(object sender, EventArgs e)
        {
            paketSoni.ReadOnly = ((ToggleSwitch)sender).IsOn ? false : true;
        }

        private void Change_Palette_Colors(object sender, EventArgs e)
        {
            var paletteId = (long)palet.EditValue;
            using (var db = new EFcontext())
            {
                rang.Properties.DataSource = db.Color.Where(c => c.PaletteId == paletteId).AsNoTracking().ToList();
            }
        }

        private void PrintBarkode(object sender, EventArgs e)
        {
            if (lookUpEdit_Validating())
            {
                return;
            }

            var quality = (long)sifat.EditValue;
            var design = (long)dizayn.EditValue;
            var color = (long)rang.EditValue;
            var customer = (long)xaridor.EditValue;
            var warehouse = (long)sklad.EditValue;

            var width = eni.Value;
            var height = uzunligi.Value;
            var weight = ogirlik2.Text;
            var quantityInside = paketSoni.Value;
            var IsPaket = rulonPaket.IsOn;

            var dto = new BarcodeDto(warehouse, quality, design, color, customer, width, height, weight, quantityInside, IsPaket);
            var barcodeService = new BarcodeService();

            barcodeService.ShowPrintDialog = showdialogtoggle.IsOn;
            barcodeService.DontSentToPrinter = noprinttoggle.IsOn;
            var result = barcodeService.CreateAndPrint(dto);

            if ((bool)result[0])
            {
                Logger.Log("Barkod Bosildi!!  ", ((Event)result[1]).Serial.ToString());
                xabar.Text = "Barkod Bosildi!!  " + ((Event)result[1]).Serial;
            }
            else
            {
                Logger.Log(((Exception)result[1]).ToString(), "barkod xato");
                MessageBox.Show(((Exception)result[1]).ToString());
            }

            eni.Value = 0;
            eni.BackColor = System.Drawing.Color.Aqua;
            uzunligi.Value = 0;
            uzunligi.BackColor = System.Drawing.Color.Aqua;
            ogirlik2.Text = "0";
            ogirlik2.BackColor = System.Drawing.Color.Aqua;
            paketSoni.Value = 5;
            rulonPaket.IsOn = false;
        }


        bool lookUpEdit_Validating()
        {
            var validateResult = false;
            if (sifat.EditValue == null)
            {
                sifat.ErrorText = "Sifatni Tanlash Kerak!!!";
                validateResult = true;
            }
            if (dizayn.EditValue == null)
            {
                dizayn.ErrorText = "Dizayn Tanlash Kerak!!!";
                validateResult = true;
            }
            if (palet.EditValue == null)
            {
                palet.ErrorText = "Rang Tanlash Kerak!!!";
                validateResult = true;
            }
            if (rang.EditValue == null)
            {
                rang.ErrorText = "Rang Tanlash Kerak!!!";
                validateResult = true;
            }
            if (xaridor.EditValue == null)
            {
                xaridor.ErrorText = "Xaridor Tanlash Kerak!!!";
                validateResult = true;
            }
            if (sklad.EditValue == null)
            {
                sklad.ErrorText = "Sklad Tanlash Kerak!!!";
                validateResult = true;
            }
            if (!(eni.Value > 49 && eni.Value < 401))
            {
                MessageBox.Show("RULON ENI NOTO'GRI!!!");
                eni.BackColor = System.Drawing.Color.Red;
                eni.Focus();
                validateResult = true;
            }
            if (!(uzunligi.Value > 49 && uzunligi.Value < 7501))
            {
                MessageBox.Show("RULON UZUNLIGI NOTO'GRI!!");
                uzunligi.BackColor = System.Drawing.Color.Red;
                uzunligi.Focus();
                validateResult = true;
            }
            try
            {
                if (!(double.Parse(ogirlik2.Text) > -1 && double.Parse(ogirlik2.Text) < 200))
                {
                    MessageBox.Show("OG'IRLIK NOTO'GRI!!");
                    ogirlik2.BackColor = System.Drawing.Color.Red;
                    ogirlik2.Focus();
                    validateResult = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("OG'IRLIK NOTO'GRI!!");
                ogirlik2.BackColor = System.Drawing.Color.Red;
                ogirlik2.Focus();
                validateResult = true;
                return validateResult;
            }
            
            return validateResult;
        }

        private void eni_MouseDown(object sender, MouseEventArgs e)
        {
            eni.BackColor = System.Drawing.Color.White;
            uzunligi.BackColor = System.Drawing.Color.White;
            ogirlik2.BackColor = System.Drawing.Color.White;
        }

        private void ogirlik_MouseDown(object sender, MouseEventArgs e)
        {
            eni_MouseDown(sender, e);
        }

        private void uzunligi_MouseDown(object sender, MouseEventArgs e)
        {
            eni_MouseDown(sender, e);
        }

        private void ogirlik1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }

            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (Regex.IsMatch(
                 ogirlik2.Text,
                 "^\\d*\\.\\d{1}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
