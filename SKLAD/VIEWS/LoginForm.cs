using SKLAD.EF;
using SKLAD.SERVICE;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD.VIEWS
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            parol.UseSystemPasswordChar = true;
            this.parol.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            try
            {
                using (var db = new EFcontext())
                {
                    lookUpEdit1.Properties.DataSource = db.User.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, e.ToString());
                MessageBox.Show("Server Bilan Aloqa Yo'q!!");
                MessageBox.Show(e.Message);
            }
        }

        public void CheckForLogin(bool passwordCorrect)
        {
            if (passwordCorrect)
            {
                Logger.Log("Sistemaga kirildi", "");
                var main = new Main();
                main.Closed += (s, args) => this.Close();
                this.Hide();
                main.Show();
                return;
            }
            MessageBox.Show("Login Yoki Parol noto'g'ri!!");
        }

        public bool LoginMethod()
        {
            string login = (string)lookUpEdit1.EditValue;
            string password = parol.Text;
            using (var db = new EFcontext())
            {
                var user = db.User.Where(o => o.Login.Equals(login) && o.Password.Equals(password)).AsNoTracking().FirstOrDefault();
                if (user != null)
                {
                    Program.User = user;
                    return true;
                }
                return false;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            CheckForLogin(LoginMethod());
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckForLogin(LoginMethod());
            }
        }
    }
}