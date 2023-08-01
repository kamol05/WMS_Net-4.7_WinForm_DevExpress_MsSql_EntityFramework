namespace SKLAD
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.hisobotlarMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mahsulotlar_Qoldigi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mahsulotlar_Sotilgan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mahsulotlar_Kirim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sotuvMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Nakladnoylar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Xaridorlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.malumotlarMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sifatlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Dizaynlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Paletlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Ranglar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Ishchilar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Skladlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.barkodMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Barkod_ = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.transfer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BarcodeReportEdit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BARKOD_MALUMOTLARI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.exit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Appearance.BackColor = System.Drawing.Color.White;
            this.fluentDesignFormContainer.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(219, 31);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(770, 745);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.hisobotlarMenu,
            this.sotuvMenu,
            this.malumotlarMenu,
            this.barkodMenu,
            this.exit});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(219, 745);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // hisobotlarMenu
            // 
            this.hisobotlarMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Mahsulotlar_Qoldigi,
            this.Mahsulotlar_Sotilgan,
            this.Mahsulotlar_Kirim});
            this.hisobotlarMenu.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.hisobotlarMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("hisobotlarMenu.ImageOptions.SvgImage")));
            this.hisobotlarMenu.Name = "hisobotlarMenu";
            this.hisobotlarMenu.Text = "HISOBOTLAR";
            // 
            // Mahsulotlar_Qoldigi
            // 
            this.Mahsulotlar_Qoldigi.Name = "Mahsulotlar_Qoldigi";
            this.Mahsulotlar_Qoldigi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mahsulotlar_Qoldigi.Text = "QOLDIQ";
            // 
            // Mahsulotlar_Sotilgan
            // 
            this.Mahsulotlar_Sotilgan.Name = "Mahsulotlar_Sotilgan";
            this.Mahsulotlar_Sotilgan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mahsulotlar_Sotilgan.Text = "SOTILGAN";
            // 
            // Mahsulotlar_Kirim
            // 
            this.Mahsulotlar_Kirim.Name = "Mahsulotlar_Kirim";
            this.Mahsulotlar_Kirim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mahsulotlar_Kirim.Text = "ISHLAB CHIQARISH";
            // 
            // sotuvMenu
            // 
            this.sotuvMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Nakladnoylar,
            this.Xaridorlar});
            this.sotuvMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sotuvMenu.ImageOptions.SvgImage")));
            this.sotuvMenu.Name = "sotuvMenu";
            this.sotuvMenu.Text = "SOTUV";
            // 
            // Nakladnoylar
            // 
            this.Nakladnoylar.Name = "Nakladnoylar";
            this.Nakladnoylar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Nakladnoylar.Text = "NAKLADNOYLAR";
            // 
            // Xaridorlar
            // 
            this.Xaridorlar.Name = "Xaridorlar";
            this.Xaridorlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Xaridorlar.Text = "XARIDORLAR";
            // 
            // malumotlarMenu
            // 
            this.malumotlarMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Sifatlar,
            this.Dizaynlar,
            this.Paletlar,
            this.Ranglar,
            this.Ishchilar,
            this.Skladlar});
            this.malumotlarMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("malumotlarMenu.ImageOptions.SvgImage")));
            this.malumotlarMenu.Name = "malumotlarMenu";
            this.malumotlarMenu.Text = "MALUMOTLAR";
            // 
            // Sifatlar
            // 
            this.Sifatlar.Name = "Sifatlar";
            this.Sifatlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Sifatlar.Text = "SIFAT";
            // 
            // Dizaynlar
            // 
            this.Dizaynlar.Name = "Dizaynlar";
            this.Dizaynlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Dizaynlar.Text = "DIZAYN";
            // 
            // Paletlar
            // 
            this.Paletlar.Name = "Paletlar";
            this.Paletlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Paletlar.Text = "PALETLAR";
            // 
            // Ranglar
            // 
            this.Ranglar.Name = "Ranglar";
            this.Ranglar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Ranglar.Text = "RANG";
            // 
            // Ishchilar
            // 
            this.Ishchilar.Name = "Ishchilar";
            this.Ishchilar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Ishchilar.Text = "ISHCHILAR";
            // 
            // Skladlar
            // 
            this.Skladlar.Name = "Skladlar";
            this.Skladlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Skladlar.Text = "SKLADLAR";
            // 
            // barkodMenu
            // 
            this.barkodMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Barkod_,
            this.transfer,
            this.BarcodeReportEdit,
            this.BARKOD_MALUMOTLARI});
            this.barkodMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barkodMenu.ImageOptions.SvgImage")));
            this.barkodMenu.Name = "barkodMenu";
            this.barkodMenu.Text = "MAHSULOTLAR";
            // 
            // Barkod_
            // 
            this.Barkod_.Name = "Barkod_";
            this.Barkod_.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Barkod_.Text = "BARKOD BOSISH";
            // 
            // transfer
            // 
            this.transfer.Name = "transfer";
            this.transfer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.transfer.Text = "O\'TKAZISH";
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // BarcodeReportEdit
            // 
            this.BarcodeReportEdit.Name = "BarcodeReportEdit";
            this.BarcodeReportEdit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BarcodeReportEdit.Text = "BARKOD DIZAYN";
            // 
            // BARKOD_MALUMOTLARI
            // 
            this.BARKOD_MALUMOTLARI.Name = "BARKOD_MALUMOTLARI";
            this.BARKOD_MALUMOTLARI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BARKOD_MALUMOTLARI.Text = "BARKOD MALUMOTI";
            // 
            // exit
            // 
            this.exit.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left)});
            this.exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exit.ImageOptions.SvgImage")));
            this.exit.Name = "exit";
            this.exit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.exit.Text = "CHIQISH";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(989, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager
            // 
            this.fluentFormDefaultManager.Form = this;
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.fluentFormDefaultManager;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 776);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.Name = "Main";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main2";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sotuvMenu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Nakladnoylar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Xaridorlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement malumotlarMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement hisobotlarMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Sifatlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Dizaynlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Ranglar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mahsulotlar_Qoldigi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mahsulotlar_Sotilgan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement exit;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mahsulotlar_Kirim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Ishchilar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Paletlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Barkod_;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BarcodeReportEdit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Skladlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement transfer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement barkodMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BARKOD_MALUMOTLARI;
    }
}