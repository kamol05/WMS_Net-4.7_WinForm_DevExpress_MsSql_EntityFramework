namespace SKLAD.MODEL
{
    public class ReportLayout : Identity
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public ReportLayoutType Type { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public string ToString2()
        {
            return "ID-" + Id + " " +
                   "Name-" + Name + " " +
                   "Type-" + Type;
        }

        public enum ReportLayoutType
        {
            Balance = 1,
            Sell = 2,
            Incoming = 3
        }
    }
}
