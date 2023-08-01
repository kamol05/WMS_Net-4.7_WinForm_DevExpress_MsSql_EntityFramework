using DevExpress.Data.ODataLinq.Helpers;
using SKLAD.EF;
using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.SERVICE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Transfer
{
    public partial class TransferMainView : DevExpress.XtraEditors.XtraForm
    {
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private Warehouse warehouseFrom;
        private Warehouse warehouseTo;
        public TransferLogin tlogin;
        public TransferMainView(Warehouse value1, Warehouse value2)
        {
            InitializeComponent();
            warehouseFrom = value1;
            warehouseTo = value2;
            topInfo.Text = "   " + value1.Name + "  DAN   " + value2.Name + "  GA";
            this.serialEnter.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            LoadTransferedEventsToday();
        }

        private void BeginTransfer(string stringserial)
        {
            try
            {
                var serial = Int32.Parse(stringserial);
                serialEnter.Text = "";
                var resultText = serial + "->     Nomalum xato!!!";
                var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                using (var db = new EFcontext())
                {
                    var balanceFrom = db.Balances.Where(b => b.Serial == serial &&
                                                        b.WarehouseId == warehouseFrom.Id &&
                                                        (b.Status == EventType.InTransfer || b.Status == EventType.InProduction))
                                                    .FirstOrDefault();

                    var balanceTo = db.Balances.Where(b => b.Serial == serial && b.WarehouseId == warehouseTo.Id).FirstOrDefault();

                    if (balanceFrom != null)
                    {
                        var outTransfer = EventService.CreateOutTranfer(balanceFrom);
                        var inTransfer = EventService.CreateInTranfer(balanceFrom, warehouseTo.Id);

                        if (balanceTo != null)
                        {
                            balanceTo.Status = EventType.InTransfer;
                        }
                        else
                        {
                            var inBalance = BalanceService.CreateInBalance(inTransfer, EventType.InTransfer);
                            db.Balances.Add(inBalance);
                        }
                        balanceFrom.OldStatus = balanceFrom.Status;
                        balanceFrom.Status = EventType.OutTransfer;

                        db.Event.AddRange(new List<Event>() { outTransfer, inTransfer });
                        db.SaveChanges();
                        resultText = serial + "->     " + warehouseTo.Code + "GA O'TDI!!";
                        player.SoundLocation = path + "\\Sound\\ok.wav";
                        LoadTransferedEventsToday();
                    }
                    else
                    {
                        resultText = serial + "->     " + "BUNDAY BARKOD YO'Q, SOTILGAN, BOSHQA SKLADDA TURIBTI!!";
                        player.SoundLocation = path + "\\Sound\\hata.wav";
                    }

                }
                info.Text = resultText;
                Logger.LogWithoutUserName(resultText, serial.ToString(), "Transfer");
                player.Play();
            }
            catch (Exception e)
            {
                Logger.ErrorWithoutUserName(e.ToString(), serialEnter.Text, "Transfer");
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
                BeginTransfer(serialEnter.Text);
            }
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BeginTransfer(serialEnter.Text);

            }
        }

        private void orqaga_Click(object sender, EventArgs e)
        {
            this.Hide();
            tlogin.Show();
        }

        private void LoadTransferedEventsToday()
        {
            DateTime startDateTime = DateTime.Today; //Today at 00:00:00
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59
            LoadTransferedEventsBetween(startDateTime, endDateTime);
        }

        private void LoadTransferedEventsBetween(DateTime startDateTime, DateTime endDateTime)
        {
            using (var db = new EFcontext())
            {
                var query = from ev in db.Event.BuildEventIncludedAllRelationships()
                            where ev.WarehouseId == warehouseTo.Id &&
                            ev.EventType == EventType.InTransfer &&
                            ev.Date > startDateTime && ev.Date < endDateTime
                            select ev;
                gridControl1.DataSource = query.AsNoTracking().ToList();
            }

        }

        private void loadEventsBetween_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = dateFrom.DateTime;
            DateTime endDateTime = dateTo.DateTime;
            LoadTransferedEventsBetween(startDateTime, endDateTime);
        }
    }
}