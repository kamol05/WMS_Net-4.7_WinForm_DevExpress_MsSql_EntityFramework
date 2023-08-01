using SKLAD.VIEWS.Reports;
using System;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Controls
{
    public partial class BarcodeReportEdit : UserControl
    {
        public BarcodeReportEdit()
        {
            InitializeComponent();
        }

        private void BarcodeReportEdit_Load(object sender, EventArgs e)
        {
            BarcodeReport report = new BarcodeReport();
            reportDesigner1.OpenReport(report);
        }
    }
}
