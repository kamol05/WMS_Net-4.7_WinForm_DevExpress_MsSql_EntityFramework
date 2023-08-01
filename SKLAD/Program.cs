using SKLAD.EF;
using SKLAD.MODEL.Sys;
using SKLAD.SERVICE;
using SKLAD.VIEWS;
using SKLAD.VIEWS.Transfer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD
{
    internal static class Program
    {
        public static User User { get; set; }

        [STAThread]
        static void Main()
        {
            Programm();
            //ProgramWithoutLogin();
            //Transfer();

            //InitialSetupMethod(); // Dont forget disable/enable Efcontext Drop Database function!!
        }
        private static void Programm()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Logger.Error(e.ToString(), "Main");
            }
        }
        private static void ProgramWithoutLogin()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (var db = new EFcontext()) { Program.User = db.User.Where(o => o.Login.Equals("Admin")).FirstOrDefault(); }
                Application.Run(new Main());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Logger.Error(e.ToString(), "Main");
            }
        }
        private static void Transfer()
        {
            try
            {
                Application.Run(new TransferLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Logger.ErrorWithoutUserName(e.ToString(), "Main", "Transfer");
            }
        }
        private static void InitialSetupMethod()
        {
            try
            {
                InitialSetup.AddTrigger();
                InitialSetup.FillImportantData();

                InitialSetup.FillData();
                InitialSetup.PrintBarcodes();
                InitialSetup.SellBarcodes();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Logger.ErrorWithoutUserName(e.ToString(), "Main", "Transfer");
            }
        }
    }
}
