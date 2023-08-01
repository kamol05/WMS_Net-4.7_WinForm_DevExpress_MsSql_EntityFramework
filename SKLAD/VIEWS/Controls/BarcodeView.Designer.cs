namespace SKLAD.VIEWS.Controls
{
    partial class Barkod_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barkod_));
            this.eni = new System.Windows.Forms.NumericUpDown();
            this.uzunligi = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rulonPaket = new DevExpress.XtraEditors.ToggleSwitch();
            this.paketSoni = new System.Windows.Forms.NumericUpDown();
            this.barkod = new DevExpress.XtraEditors.SimpleButton();
            this.Main = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noprinttoggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.showdialogtoggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.xabar = new DevExpress.XtraEditors.LabelControl();
            this.sifat = new DevExpress.XtraEditors.LookUpEdit();
            this.dizayn = new DevExpress.XtraEditors.LookUpEdit();
            this.palet = new DevExpress.XtraEditors.LookUpEdit();
            this.rang = new DevExpress.XtraEditors.LookUpEdit();
            this.sklad = new DevExpress.XtraEditors.LookUpEdit();
            this.xaridor = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ogirlik2 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.eni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzunligi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulonPaket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketSoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noprinttoggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdialogtoggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dizayn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaridor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // eni
            // 
            this.eni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eni.Location = new System.Drawing.Point(30, 26);
            this.eni.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.eni.Name = "eni";
            this.eni.Size = new System.Drawing.Size(61, 29);
            this.eni.TabIndex = 14;
            this.eni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eni_MouseDown);
            // 
            // uzunligi
            // 
            this.uzunligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uzunligi.Location = new System.Drawing.Point(125, 26);
            this.uzunligi.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.uzunligi.Name = "uzunligi";
            this.uzunligi.Size = new System.Drawing.Size(90, 29);
            this.uzunligi.TabIndex = 15;
            this.uzunligi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uzunligi_MouseDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 23);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "X";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.eni);
            this.groupControl1.Controls.Add(this.uzunligi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(28, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 71);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Razmer";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.rulonPaket);
            this.groupControl2.Controls.Add(this.paketSoni);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(28, 440);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(282, 114);
            this.groupControl2.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 23);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "PAKET ICHIDA";
            // 
            // rulonPaket
            // 
            this.rulonPaket.Location = new System.Drawing.Point(25, 26);
            this.rulonPaket.Name = "rulonPaket";
            this.rulonPaket.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulonPaket.Properties.Appearance.Options.UseFont = true;
            this.rulonPaket.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rulonPaket.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rulonPaket.Properties.OffText = "PAKET";
            this.rulonPaket.Properties.OnText = "RULON";
            this.rulonPaket.Properties.Toggled += new System.EventHandler(this.Rulon_Paket_Toggle);
            this.rulonPaket.Size = new System.Drawing.Size(157, 27);
            this.rulonPaket.TabIndex = 30;
            // 
            // paketSoni
            // 
            this.paketSoni.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paketSoni.Location = new System.Drawing.Point(156, 62);
            this.paketSoni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.paketSoni.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.paketSoni.Name = "paketSoni";
            this.paketSoni.Size = new System.Drawing.Size(63, 33);
            this.paketSoni.TabIndex = 0;
            this.paketSoni.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // barkod
            // 
            this.barkod.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barkod.Appearance.Options.UseFont = true;
            this.barkod.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barkod.ImageOptions.SvgImage")));
            this.barkod.Location = new System.Drawing.Point(455, 492);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(202, 53);
            this.barkod.TabIndex = 20;
            this.barkod.Text = "BARKOD BOSISH";
            this.barkod.Click += new System.EventHandler(this.PrintBarkode);
            // 
            // Main
            // 
            this.Main.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main.AppearanceCaption.Options.UseFont = true;
            this.Main.AppearanceCaption.Options.UseTextOptions = true;
            this.Main.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Main.CaptionImageOptions.SvgImage")));
            this.Main.Controls.Add(this.label6);
            this.Main.Controls.Add(this.label5);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.noprinttoggle);
            this.Main.Controls.Add(this.showdialogtoggle);
            this.Main.Controls.Add(this.xabar);
            this.Main.Controls.Add(this.sifat);
            this.Main.Controls.Add(this.dizayn);
            this.Main.Controls.Add(this.palet);
            this.Main.Controls.Add(this.rang);
            this.Main.Controls.Add(this.sklad);
            this.Main.Controls.Add(this.xaridor);
            this.Main.Controls.Add(this.barkod);
            this.Main.Controls.Add(this.groupControl1);
            this.Main.Controls.Add(this.groupControl3);
            this.Main.Controls.Add(this.groupControl2);
            this.Main.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.Main.Location = new System.Drawing.Point(13, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(722, 668);
            this.Main.TabIndex = 21;
            this.Main.Text = "Barkod Bosish";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(362, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "XARIDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(362, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "SKLAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "RANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "PALET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "DIZAYN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "SIFAT";
            // 
            // noprinttoggle
            // 
            this.noprinttoggle.Location = new System.Drawing.Point(455, 399);
            this.noprinttoggle.Name = "noprinttoggle";
            this.noprinttoggle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noprinttoggle.Properties.Appearance.Options.UseFont = true;
            this.noprinttoggle.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.noprinttoggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.noprinttoggle.Properties.OffText = "NO PRINT";
            this.noprinttoggle.Properties.OnText = "NO PRINT";
            this.noprinttoggle.Properties.Toggled += new System.EventHandler(this.Rulon_Paket_Toggle);
            this.noprinttoggle.Size = new System.Drawing.Size(202, 23);
            this.noprinttoggle.TabIndex = 33;
            // 
            // showdialogtoggle
            // 
            this.showdialogtoggle.Location = new System.Drawing.Point(455, 359);
            this.showdialogtoggle.Name = "showdialogtoggle";
            this.showdialogtoggle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showdialogtoggle.Properties.Appearance.Options.UseFont = true;
            this.showdialogtoggle.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.showdialogtoggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.showdialogtoggle.Properties.OffText = "PRINTER TANLASH";
            this.showdialogtoggle.Properties.OnText = "PRINTER";
            this.showdialogtoggle.Properties.Toggled += new System.EventHandler(this.Rulon_Paket_Toggle);
            this.showdialogtoggle.Size = new System.Drawing.Size(202, 23);
            this.showdialogtoggle.TabIndex = 32;
            // 
            // xabar
            // 
            this.xabar.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xabar.Appearance.Options.UseFont = true;
            this.xabar.Location = new System.Drawing.Point(127, 585);
            this.xabar.Name = "xabar";
            this.xabar.Size = new System.Drawing.Size(0, 35);
            this.xabar.TabIndex = 28;
            // 
            // sifat
            // 
            this.sifat.Location = new System.Drawing.Point(101, 42);
            this.sifat.Name = "sifat";
            this.sifat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sifat.Properties.Appearance.Options.UseFont = true;
            this.sifat.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sifat.Properties.AppearanceDropDown.Options.UseFont = true;
            this.sifat.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sifat.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.sifat.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sifat.Properties.AppearanceFocused.Options.UseFont = true;
            this.sifat.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sifat.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.sifat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sifat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "SIFATNI TANLANG", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.sifat.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Quality);
            this.sifat.Properties.DisplayMember = "Name";
            this.sifat.Properties.NullText = "";
            this.sifat.Properties.ShowHeader = false;
            this.sifat.Properties.ValidateOnEnterKey = true;
            this.sifat.Properties.ValueMember = "Id";
            this.sifat.Size = new System.Drawing.Size(209, 26);
            this.sifat.TabIndex = 21;
            // 
            // dizayn
            // 
            this.dizayn.Location = new System.Drawing.Point(101, 94);
            this.dizayn.Name = "dizayn";
            this.dizayn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dizayn.Properties.Appearance.Options.UseFont = true;
            this.dizayn.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dizayn.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dizayn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dizayn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name37", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.dizayn.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Design);
            this.dizayn.Properties.DisplayMember = "Name";
            this.dizayn.Properties.NullText = "";
            this.dizayn.Properties.ShowHeader = false;
            this.dizayn.Properties.ValueMember = "Id";
            this.dizayn.Size = new System.Drawing.Size(209, 26);
            this.dizayn.TabIndex = 22;
            // 
            // palet
            // 
            this.palet.Location = new System.Drawing.Point(101, 146);
            this.palet.Name = "palet";
            this.palet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.palet.Properties.Appearance.Options.UseFont = true;
            this.palet.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.palet.Properties.AppearanceDropDown.Options.UseFont = true;
            this.palet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.palet.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name39", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.palet.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Design);
            this.palet.Properties.DisplayMember = "Name";
            this.palet.Properties.NullText = "";
            this.palet.Properties.ShowHeader = false;
            this.palet.Properties.ValueMember = "Id";
            this.palet.Size = new System.Drawing.Size(209, 26);
            this.palet.TabIndex = 23;
            this.palet.EditValueChanged += new System.EventHandler(this.Change_Palette_Colors);
            // 
            // rang
            // 
            this.rang.Location = new System.Drawing.Point(101, 198);
            this.rang.Name = "rang";
            this.rang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rang.Properties.Appearance.Options.UseFont = true;
            this.rang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.rang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name42", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.rang.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Design);
            this.rang.Properties.DisplayMember = "Name";
            this.rang.Properties.NullText = "";
            this.rang.Properties.ShowHeader = false;
            this.rang.Properties.ValueMember = "Id";
            this.rang.Size = new System.Drawing.Size(209, 26);
            this.rang.TabIndex = 24;
            // 
            // sklad
            // 
            this.sklad.Location = new System.Drawing.Point(455, 42);
            this.sklad.Name = "sklad";
            this.sklad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sklad.Properties.Appearance.Options.UseFont = true;
            this.sklad.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sklad.Properties.AppearanceDropDown.Options.UseFont = true;
            this.sklad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sklad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.sklad.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Warehouse);
            this.sklad.Properties.DisplayMember = "Name";
            this.sklad.Properties.DropDownRows = 3;
            this.sklad.Properties.KeyMember = "Id";
            this.sklad.Properties.NullText = "";
            this.sklad.Properties.ShowHeader = false;
            this.sklad.Properties.ValueMember = "Id";
            this.sklad.Size = new System.Drawing.Size(202, 26);
            this.sklad.TabIndex = 25;
            // 
            // xaridor
            // 
            this.xaridor.Location = new System.Drawing.Point(455, 94);
            this.xaridor.Name = "xaridor";
            this.xaridor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xaridor.Properties.Appearance.Options.UseFont = true;
            this.xaridor.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xaridor.Properties.AppearanceDropDown.Options.UseFont = true;
            this.xaridor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xaridor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name43", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.xaridor.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Design);
            this.xaridor.Properties.DisplayMember = "Name";
            this.xaridor.Properties.NullText = "";
            this.xaridor.Properties.PopupWidth = 400;
            this.xaridor.Properties.ShowHeader = false;
            this.xaridor.Properties.ValueMember = "Id";
            this.xaridor.Size = new System.Drawing.Size(202, 26);
            this.xaridor.TabIndex = 27;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ogirlik2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(28, 347);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(282, 67);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "KG";
            // 
            // ogirlik2
            // 
            this.ogirlik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ogirlik2.Location = new System.Drawing.Point(156, 33);
            this.ogirlik2.Name = "ogirlik2";
            this.ogirlik2.Size = new System.Drawing.Size(71, 26);
            this.ogirlik2.TabIndex = 40;
            this.ogirlik2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogirlik1_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 23);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "OG\'IRLIGI KG";
            // 
            // Barkod_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main);
            this.Name = "Barkod_";
            this.Size = new System.Drawing.Size(751, 686);
            ((System.ComponentModel.ISupportInitialize)(this.eni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzunligi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulonPaket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketSoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noprinttoggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdialogtoggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dizayn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaridor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown eni;
        private System.Windows.Forms.NumericUpDown uzunligi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.NumericUpDown paketSoni;
        private DevExpress.XtraEditors.SimpleButton barkod;
        private DevExpress.XtraEditors.GroupControl Main;
        private DevExpress.XtraEditors.LookUpEdit sifat;
        private DevExpress.XtraEditors.LookUpEdit dizayn;
        private DevExpress.XtraEditors.LookUpEdit rang;
        private DevExpress.XtraEditors.LookUpEdit palet;
        private DevExpress.XtraEditors.LookUpEdit xaridor;
        private DevExpress.XtraEditors.LookUpEdit sklad;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ToggleSwitch rulonPaket;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl xabar;
        private DevExpress.XtraEditors.ToggleSwitch noprinttoggle;
        private DevExpress.XtraEditors.ToggleSwitch showdialogtoggle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ogirlik2;
    }
}