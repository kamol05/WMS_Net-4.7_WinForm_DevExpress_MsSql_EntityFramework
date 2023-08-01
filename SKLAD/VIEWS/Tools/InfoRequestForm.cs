using System;

namespace SKLAD.VIEWS.Tools
{
    public partial class InfoRequestForm : DevExpress.XtraEditors.XtraForm
    {
        public string name { get; set; }

        public InfoRequestForm()
        {
            InitializeComponent();
            this.ActiveControl = textBox;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            name = textBox.Text;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangeTitleText(string s)
        {
            labelControl1.Text = s;
        }

        public void HideTextboxChars()
        {
            textBox.UseSystemPasswordChar = true;
        }
    }
}
