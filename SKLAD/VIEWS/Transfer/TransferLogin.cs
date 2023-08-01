using SKLAD.MODEL.Bys;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Transfer
{
    public partial class TransferLogin : DevExpress.XtraEditors.XtraForm
    {
        public TransferLogin()
        {
            InitializeComponent();
            SKLAD.EF.EFcontext dbContext = new SKLAD.EF.EFcontext();
            dbContext.Warehouse.LoadAsync().ContinueWith(loadTask =>
            {
                from.Properties.DataSource = dbContext.Warehouse.AsNoTracking().ToList();
                to.Properties.DataSource = dbContext.Warehouse.AsNoTracking().ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            fromText.Enabled = false;
            toText.Enabled = false;
        }

        private void kirish_Click(object sender, System.EventArgs e)
        {
            var value1 = (Warehouse)from.EditValue;
            var value2 = (Warehouse)to.EditValue;
            if (from.EditValue == null)
            {
                MessageBox.Show("SKLADNI TANLASH KERAK!!");
                return;
            }
            if (to.EditValue == null)
            {
                MessageBox.Show("SKLADNI TANLASH KERAK!!");
                return;
            }
            if (value1.Id == value2.Id)
            {
                MessageBox.Show("BIR XIL SKLAD TANLANGAN!!");
                return;
            }
            var transfer = new TransferMainView(value1, value2);
            //transfer.SetWarehouses(value1, value2);
            transfer.Closed += (s, args) => this.Close();
            transfer.tlogin = this;
            this.Hide();
            transfer.Show();
        }

        private void chiqish_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void from_EditValueChanged(object sender, System.EventArgs e)
        {
            var v = (Warehouse)from.EditValue;
            fromText.Text = v.Name + "  DAN";
        }

        private void to_EditValueChanged(object sender, System.EventArgs e)
        {
            var v = (Warehouse)to.EditValue;
            toText.Text = v.Name + "  GA";
        }
    }
}