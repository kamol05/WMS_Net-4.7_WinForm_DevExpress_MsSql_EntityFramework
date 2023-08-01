using System;

namespace SKLAD.MODEL.Sys
{
    public class Log : Identity
    {
        public string Message { get; set; }
        public string Message2 { get; set; }
        public string User { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        public string Info { get; set; }
        public string Type { get; set; }
    }
}
