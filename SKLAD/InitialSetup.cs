using DevExpress.Data.ODataLinq.Helpers;
using SKLAD.EF;
using SKLAD.MODEL.Bys;
using SKLAD.MODEL.Event;
using SKLAD.MODEL.Sys;
using SKLAD.SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SKLAD
{
    public class InitialSetup
    {
        private static EFcontext db = new EFcontext();
        private static Random random = new Random();

        private static List<Quality> qualities = new List<Quality>();
        private static List<Design> designs = new List<Design>();
        private static List<Palette> palettes = new List<Palette>();
        private static List<Color> colors = new List<Color>();
        private static List<Customer> customers = new List<Customer>();
        private static List<Invoice> invoices = new List<Invoice>();
        private static List<Terminal> terminals = new List<Terminal>();

        public static void AddTrigger()
        {
            using (db = new EFcontext())
            {
                db.Database.ExecuteSqlCommand(sqlCommand);
            }
        }

        public static void SellBarcodes()
        {
            using (db = new EFcontext())
            {
                List<Balance> balances = new List<Balance>();
                List<Invoice> invoices = new List<Invoice>();
                Warehouse kleyka;

                kleyka = db.Warehouse.Where(w => w.Code == 4000).First();
                balances = db.Balances.ToList();
                invoices = db.Invoice.ToList();

                for (int i = 0; i < 500; i++)
                {
                    terminals.Add(new Terminal
                    {
                        InvoiceId = invoices[random.Next(invoices.Count)].Id,
                        WarehouseId = kleyka.Id,
                        Serial = balances[random.Next(balances.Count)].Serial.ToString(),
                        Remove = false
                    });

                }
                db.Terminal.AddRange(terminals);
                db.SaveChanges();
            }

        }

        public static void FillImportantData()
        {
            var user0 = new User { Login = "Barkod1", Password = "1", Role = "Barkod" };
            var user4 = new User { Login = "Barkod2", Password = "1", Role = "Barkod" };
            var user = new User { Login = "Admin", Password = "1", Role = "Admin" };
            var user2 = new User { Login = "Sklad", Password = "1", Role = "Sklad" };
            var user3 = new User { Login = "Sotuv", Password = "1", Role = "Sotuv" };
            var user5= new User { Login = "BarkodDelete", Password = "1", Role = "Barkod" };
            var counter = new Counter { Ean = "478000278888", Serial = 7701029 };
            using (db = new EFcontext())
            {
                db.User.Add(user0);
                db.User.Add(user4);
                db.User.Add(user);
                db.User.Add(user2);
                db.User.Add(user3);
                db.User.Add(user5);
                db.Counter.Add(counter);
                db.SaveChanges();
            }
        }

        public static void FillData()
        {
            var sayim = new Customer { Name = "SAYIM", Code = "SAYIM", City = "SAYIM" };
            var kleyka = new Warehouse { Name = "Palos-2 Kleyka", Code = 4000 };
            var tayyor = new Warehouse { Name = "Palos-2 Tayyor", Code = 4500 };
            User user;

            using (db = new EFcontext())
            {
                user = db.User.Where(o => o.Login.Equals("Admin")).FirstOrDefault();
                for (int i = 0; i < 10; i++) { customers.Add(new Customer { Name = "Klent-" + i.ToString(), Code = "M" + i.ToString(), }); }
                for (int i = 0; i < 4; i++) { qualities.Add(new Quality { Name = "SIFAT-" + i.ToString() }); }
                for (int i = 0; i < 4; i++) { designs.Add(new Design { Name = "Design-" + i.ToString() }); }
                for (int i = 0; i < 1; i++) { palettes.Add(new Palette { Name = "Palette-" + i.ToString() }); }
                for (int i = 0; i < 4; i++) { colors.Add(new Color { Name = "Color-" + i.ToString(), Palette = palettes[random.Next(palettes.Count)] }); }
                for (int i = 0; i < 4; i++)
                {
                    invoices.Add(new Invoice
                    {
                        DriverPhone = i.ToString() + "9 777 77 77",
                        CarNumber = i.ToString() + "0 A 777 OK",
                        CarNumber2 = i.ToString() + "0 A 777 OK",
                        InvoiceNumber = "NAK-" + i.ToString(),
                        WarehouseMan = i.ToString() + "TEST",
                        Date = DateTime.Now,
                        Modified = DateTime.Now,
                        Customer = customers[random.Next(customers.Count)],
                        User = user,
                        Warehouse = kleyka
                    }); ; ;
                }
                customers.Add(sayim);
                db.Warehouse.Add(kleyka);
                db.Warehouse.Add(tayyor);
                db.Quality.AddRange(qualities);
                db.Design.AddRange(designs);
                db.Palette.AddRange(palettes);
                db.Color.AddRange(colors);
                db.Customer.AddRange(customers);
                db.Invoice.AddRange(invoices);
                db.SaveChanges();
            }
            Program.User = user;
        }

        public static void PrintBarcodes()
        {
            var enlar = new int[] { 50, 60, 70, 80, 90, 100, 120, 150, 180, 200, 220, 250, 300, 350, 400 };
            var buylar = new string[] { "27", "29", "31", "32" };
            var buylar2 = new string[] { "30", "50", "70", "80" };
            Customer sayim = null;
            Warehouse kleyka = null;
            using (db = new EFcontext())
            {
                sayim = db.Customer.Where(c => c.Name.Equals("SAYIM")).First();
                kleyka = db.Warehouse.Where(c => c.Code == 4000).First();
                qualities = db.Quality.ToList();
                designs = db.Design.ToList();
                colors = db.Color.ToList();
            }

            var srv = new BarcodeService();
            for (int i = 0; i < 1000; i++)
            {
                srv.CreateAndPrint(new BarcodeDto(
                kleyka.Id,
                qualities[random.Next(qualities.Count)].Id,
                designs[random.Next(designs.Count)].Id,
                colors[random.Next(colors.Count)].Id,
                sayim.Id,
                enlar[random.Next(enlar.Length)], // width
                int.Parse(buylar[random.Next(buylar.Length)] + buylar2[random.Next(buylar2.Length)]), // height
                random.Next(50, 60).ToString(), //weight
                1, //quantityinside
                false          // isPaket
                ));
            }
        }

        private static readonly string sqlCommand =
@"CREATE TRIGGER [dbo].[SALE_EVENT_UPDATER] ON [dbo].[Terminals]
for INSERT
AS

Declare @ID as bigint
Declare @Iserial as varchar(255)
Declare @Iinvoiceid as bigint
Declare @Remove as bit

Declare @Iwarehouseid as bigint
Declare @Icustomerid as bigint
Declare @Iuserid as bigint

Declare @bserial as varchar(255) = ''
Declare @bwidth as integer
Declare @bheight as integer
Declare @bm2 as float
Declare @bcount as integer
Declare @bquantityInside as integer
Declare @bweight as float
Declare @bstatus as tinyint
Declare @bwarehouseid as bigint -->
Declare @binvoiceid as bigint -->
Declare @bproductid as bigint
Declare @bcustomerid as bigint



Declare @workInfo as varchar(255)='BAZADA XATO'
Declare @workStatus as smallint=0
--ie:
--0-> start position
--7-> selled
--5-> deleted
--100-> notfoundserial 
--200-> otherwarehouse 
--300-> moved to other warehouse
--400-> selled to other fish
--500-> not selled

Select @Iinvoiceid = I.InvoiceId,
        @Iserial = I.Serial,
        @ID=Id,
        @Remove=I.Remove
From inserted I


if not exists(select  *  from Balances where Serial <= @Iserial and Serial >= @Iserial )
	begin
		set @workInfo= 'BARKOD TOPILMADI!!!'
		set @workStatus = 100
	end
else
	begin
		-- here we get info about Invoice
		select @Iwarehouseid = WarehouseId,
			    @Icustomerid = Customerid,
			    @Iuserid = UserId
		from Invoices where Id=@Iinvoiceid
	
		if not exists(select  *  from Balances where Serial=@Iserial and Warehouseid=@Iwarehouseid)
			begin
				set @workInfo='BARKOD BOSHQA SKLADGA TURIBDI!!!'
				set @workStatus = 200
			end
		else
			begin
				--balansdan shu serialni oloyabmiz
				Select @bserial=Serial,
					    @bwidth=Width,
					    @bheight=Height,
					    @bm2=M2,
					    @bcount=Count,
					    @bquantityInside=QuantityInside,
					    @bweight=Weight,
					    @bstatus=Status,
					    @bwarehouseid=WarehouseId,
					    @bproductid=ProductId,
					    @binvoiceid=InvoiceId
				From Balances where Serial=@Iserial and Warehouseid=@Iwarehouseid
				
				if(@bstatus = 3)
					begin
						set @workInfo='BOSHQA SKLADGA O""TKAZILGAN!!!'
						set @workStatus = 300
					end
				
				if(@workStatus = 0)
					begin
						if(@Remove = 0)
							begin
								if(@bstatus = 4)
									begin
										set @workInfo='BARKOD SOTILGAN!!!'
										set @workStatus = 400
									end
								else
									begin
										set @workInfo='SOTILDI!!!'
										set @workStatus = 7
									end
							end
						if(@Remove = 1)
							begin
								set @workInfo='O""CHIRILDI!!!'
								set @workStatus = 5
								if(@binvoiceid != @Iinvoiceid)
									begin
										set @workInfo='BOSHQA NAKLADNOYA SOTILGAN!!!'
										set @workStatus = 400
									end
								if(@bstatus != 4)
									begin
										set @workInfo='BARKOD SOTILMAGAN!!!'
										set @workStatus = 500
									end	
							end
					end
			end
	end
	
if(@workStatus = 7 and @Remove = 0) --UPDATE FOR SELLING OPERATION
	begin
			
		update dbo.Balances
		set OldStatus=Status, Status = 4, InvoiceId = @Iinvoiceid
		where Serial = @Iserial;
		
		insert into dbo.SaleEvents (Serial ,Width ,Height ,M2 ,Count ,QuantityInside ,Weight ,EventType ,Date ,Modified ,Notes ,Description ,ProductId ,InvoiceId ,CustomerId ,UserId )
							values (@bserial, @bwidth, @bheight, @bm2, @bcount, @bquantityInside, @bweight, 4, GETDATE(), GETDATE(), '', '', @bproductid, @Iinvoiceid, @ICustomerid, @Iuserid );
							
		insert into dbo.Events ( Serial, Width, Height, M2, Count, QuantityInside, Weight, EventType, Date, Modified, Description, Notes, WarehouseId, CustomerId, ProductId, UserId, InvoiceId )
							values (@bserial, @bwidth, @bheight, @bm2, @bcount, @bquantityInside, @bweight, 4, GETDATE(), GETDATE(), '', '', @Iwarehouseid, @ICustomerid, @bproductid, @Iuserid, @Iinvoiceid);
							
	end
	
if(@workStatus = 5 and @Remove = 1 ) --UPDATE FOR REMOVE OPERATION
	begin	
		update dbo.Balances
		set Status = OldStatus, InvoiceId = null
		where Serial = @Iserial;
		
		--delete from dbo.Events where Serial=@bserial and EventType=4
		delete from dbo.SaleEvents where Serial=@bserial
		
		--insert into dbo.SaleEvents (Serial ,Width ,Height ,M2 ,Count ,QuantityInside ,Weight ,EventType ,Date ,Modified ,Notes ,Description ,ProductId ,InvoiceId ,CustomerId ,UserId )
		--					values (@bserial, @bwidth, @bheight, @bm2, @bcount, @bquantityInside, @bweight, 4, GETDATE(), GETDATE(), '', '', @bproductid, @Iinvoiceid, @ICustomerid, 1 );
							
		insert into dbo.Events ( Serial, Width, Height, M2, Count, QuantityInside, Weight, EventType, Date, Modified, Description, Notes, WarehouseId, CustomerId, ProductId, UserId, InvoiceId )
							values (@bserial, @bwidth, @bheight, @bm2, @bcount, @bquantityInside, @bweight, 5, GETDATE(), GETDATE(), '', '', @Iwarehouseid, @ICustomerid, @bproductid, @Iuserid, @Iinvoiceid);
							
	end
	
	
update Terminals
set WorkInfo=@workInfo, WorkStatus=@workStatus, Created=GETDATE(), WarehouseId=@Iwarehouseid, InvoiceId=@Iinvoiceid, CustomerId=@Icustomerid
where Serial=@Iserial and Id=@ID
;";
    }
}
