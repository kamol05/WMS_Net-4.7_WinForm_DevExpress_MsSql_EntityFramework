using SKLAD.EF;
using SKLAD.MODEL.Sys;

namespace SKLAD.SERVICE
{
    public static class Logger
    {
        public static void Log(string message, string message2)
        {
            var pcname = Tools.Helper.GetPcName();
            var ip4 = Tools.Helper.GetAllLocalIPv4();
            var log = new Log { Type = "Log", Message = message, Message2 = message2, Info = pcname + " " + ip4, User = Program.User.Login };

            using (var db = new EFcontext())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }

        public static void Error(string message, string message2)
        {
            var pcname = Tools.Helper.GetPcName();
            var ip4 = Tools.Helper.GetAllLocalIPv4();
            var log = new Log { Type = "Error", Message = message, Message2 = message2, Info = pcname + " " + ip4, User = Program.User.Login };

            using (var db = new EFcontext())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }

        public static void ErrorWithoutUserName(string message, string message2, string username)
        {
            var pcname = Tools.Helper.GetPcName();
            var ip4 = Tools.Helper.GetAllLocalIPv4();
            var log = new Log { Type = "Error", Message = message, Message2 = message2, Info = pcname + " " + ip4, User = username };

            using (var db = new EFcontext())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }

        public static void LogWithoutUserName(string message, string message2, string username)
        {
            var pcname = Tools.Helper.GetPcName();
            var ip4 = Tools.Helper.GetAllLocalIPv4();
            var log = new Log { Type = "Log", Message = message, Message2 = message2, Info = pcname + " " + ip4, User = username };

            using (var db = new EFcontext())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }
    }
}
