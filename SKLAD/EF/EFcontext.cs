using SKLAD.MODEL;
using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.MODEL.Sys;
using System.Data.Entity;

namespace SKLAD.EF
{
    public class EFcontext : DbContext
    {

        private static readonly string connectionString = "Data Source=192.168.50.1; Database=SKLAD; User ID=sa; Password=Aa2003; Persist Security Info=True;";
        public EFcontext() : base(nameOrConnectionString: "SKLAD")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<EFcontext>());

            //Database.SetInitializer(new CreateDatabaseIfNotExists<EFcontext>());
            //Database.SetInitializer<EFcontext>(new DropCreateDatabaseIfModelChanges<EFcontext>());
            //Database.SetInitializer<EFcontext>(new DropCreateDatabaseAlways<EFcontext>());
            //Database.SetInitializer<EFcontext>(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            //Database.SetInitializer<EFcontext>(null);
        }

        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Design> Design { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<SaleEvent> SaleEvent { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Palette> Palette { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Terminal> Terminal { get; set; }
        public virtual DbSet<ReportLayout> ReportLayout { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<BarcodeInfo> BarcodeInfo { get; set; }

    }
}
