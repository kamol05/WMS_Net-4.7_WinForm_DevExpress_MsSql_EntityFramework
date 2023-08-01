namespace SKLAD.VIEWS.Reports
{
    partial class BarcodeReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ogirlik = new DevExpress.XtraReports.UI.XRLabel();
            this.kglabel = new DevExpress.XtraReports.UI.XRLabel();
            this.razmer = new DevExpress.XtraReports.UI.XRLabel();
            this.rang = new DevExpress.XtraReports.UI.XRLabel();
            this.dizayn = new DevExpress.XtraReports.UI.XRLabel();
            this.sifat = new DevExpress.XtraReports.UI.XRLabel();
            this.clientcode = new DevExpress.XtraReports.UI.XRLabel();
            this.barkodserial = new DevExpress.XtraReports.UI.XRLabel();
            this.SIZE = new DevExpress.XtraReports.UI.XRLabel();
            this.COLOR = new DevExpress.XtraReports.UI.XRLabel();
            this.DESIGN = new DevExpress.XtraReports.UI.XRLabel();
            this.datetime = new DevExpress.XtraReports.UI.XRLabel();
            this.smena = new DevExpress.XtraReports.UI.XRLabel();
            this.QUALITY = new DevExpress.XtraReports.UI.XRLabel();
            this.ean13 = new DevExpress.XtraReports.UI.XRBarCode();
            this.barkod = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ogirlik,
            this.kglabel,
            this.razmer,
            this.rang,
            this.dizayn,
            this.sifat,
            this.clientcode,
            this.barkodserial,
            this.SIZE,
            this.COLOR,
            this.DESIGN,
            this.datetime,
            this.smena,
            this.QUALITY,
            this.ean13,
            this.barkod});
            this.Detail.Dpi = 254F;
            this.Detail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Detail.HeightF = 399.0001F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 254F);
            this.Detail.StylePriority.UseFont = false;
            // 
            // ogirlik
            // 
            this.ogirlik.CanGrow = false;
            this.ogirlik.Dpi = 254F;
            this.ogirlik.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ogirlik.LocationFloat = new DevExpress.Utils.PointFloat(514.1955F, 232.1532F);
            this.ogirlik.Multiline = true;
            this.ogirlik.Name = "ogirlik";
            this.ogirlik.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.ogirlik.SizeF = new System.Drawing.SizeF(108.3908F, 50.06549F);
            this.ogirlik.StylePriority.UseFont = false;
            this.ogirlik.StylePriority.UseTextAlignment = false;
            this.ogirlik.Text = "122.6";
            this.ogirlik.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // kglabel
            // 
            this.kglabel.CanGrow = false;
            this.kglabel.Dpi = 254F;
            this.kglabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kglabel.LocationFloat = new DevExpress.Utils.PointFloat(438.3018F, 232.1532F);
            this.kglabel.Multiline = true;
            this.kglabel.Name = "kglabel";
            this.kglabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.kglabel.SizeF = new System.Drawing.SizeF(71.65628F, 50.06549F);
            this.kglabel.StylePriority.UseFont = false;
            this.kglabel.StylePriority.UseTextAlignment = false;
            this.kglabel.Text = "Kg:";
            this.kglabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // razmer
            // 
            this.razmer.CanGrow = false;
            this.razmer.Dpi = 254F;
            this.razmer.Font = new System.Drawing.Font("Bahnschrift", 15.5F, System.Drawing.FontStyle.Bold);
            this.razmer.LocationFloat = new DevExpress.Utils.PointFloat(270.5049F, 166.7355F);
            this.razmer.Name = "razmer";
            this.razmer.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.razmer.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.razmer.SizeF = new System.Drawing.SizeF(315.3468F, 50.09521F);
            this.razmer.StylePriority.UseFont = false;
            this.razmer.StylePriority.UsePadding = false;
            this.razmer.StylePriority.UseTextAlignment = false;
            this.razmer.Text = ":150X7777 W1";
            this.razmer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.razmer.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkAndGrow;
            this.razmer.WordWrap = false;
            // 
            // rang
            // 
            this.rang.CanGrow = false;
            this.rang.Dpi = 254F;
            this.rang.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Bold);
            this.rang.LocationFloat = new DevExpress.Utils.PointFloat(270.5049F, 130.3554F);
            this.rang.Name = "rang";
            this.rang.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.rang.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.rang.SizeF = new System.Drawing.SizeF(327.5726F, 36F);
            this.rang.StylePriority.UseFont = false;
            this.rang.StylePriority.UsePadding = false;
            this.rang.StylePriority.UseTextAlignment = false;
            this.rang.Text = ":55-QIZIL";
            this.rang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.rang.WordWrap = false;
            // 
            // dizayn
            // 
            this.dizayn.CanGrow = false;
            this.dizayn.Dpi = 254F;
            this.dizayn.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.dizayn.LocationFloat = new DevExpress.Utils.PointFloat(270.5049F, 81.88F);
            this.dizayn.Name = "dizayn";
            this.dizayn.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.dizayn.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.dizayn.SizeF = new System.Drawing.SizeF(327.5726F, 35.99999F);
            this.dizayn.StylePriority.UseFont = false;
            this.dizayn.StylePriority.UsePadding = false;
            this.dizayn.StylePriority.UseTextAlignment = false;
            this.dizayn.Text = ":07134";
            this.dizayn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.dizayn.WordWrap = false;
            // 
            // sifat
            // 
            this.sifat.CanGrow = false;
            this.sifat.Dpi = 254F;
            this.sifat.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.sifat.ForeColor = System.Drawing.Color.Black;
            this.sifat.LocationFloat = new DevExpress.Utils.PointFloat(270.5049F, 33.40459F);
            this.sifat.Multiline = true;
            this.sifat.Name = "sifat";
            this.sifat.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.sifat.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.sifat.SizeF = new System.Drawing.SizeF(364.6144F, 36.00001F);
            this.sifat.StylePriority.UseFont = false;
            this.sifat.StylePriority.UseForeColor = false;
            this.sifat.StylePriority.UsePadding = false;
            this.sifat.StylePriority.UseTextAlignment = false;
            this.sifat.Text = ":SINTEPON";
            this.sifat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.sifat.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkAndGrow;
            // 
            // clientcode
            // 
            this.clientcode.CanGrow = false;
            this.clientcode.Dpi = 254F;
            this.clientcode.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientcode.LocationFloat = new DevExpress.Utils.PointFloat(473.4774F, 313.2187F);
            this.clientcode.Multiline = true;
            this.clientcode.Name = "clientcode";
            this.clientcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.clientcode.SizeF = new System.Drawing.SizeF(178.8784F, 50.06552F);
            this.clientcode.StylePriority.UseFont = false;
            this.clientcode.StylePriority.UseTextAlignment = false;
            this.clientcode.Text = "M014";
            this.clientcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // barkodserial
            // 
            this.barkodserial.Angle = 90F;
            this.barkodserial.CanGrow = false;
            this.barkodserial.Dpi = 254F;
            this.barkodserial.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.barkodserial.LocationFloat = new DevExpress.Utils.PointFloat(598.0776F, 90.82573F);
            this.barkodserial.Multiline = true;
            this.barkodserial.Name = "barkodserial";
            this.barkodserial.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.barkodserial.SizeF = new System.Drawing.SizeF(37.04163F, 125.5297F);
            this.barkodserial.StylePriority.UseFont = false;
            this.barkodserial.StylePriority.UseTextAlignment = false;
            this.barkodserial.Text = "0011422";
            this.barkodserial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // SIZE
            // 
            this.SIZE.CanGrow = false;
            this.SIZE.Dpi = 254F;
            this.SIZE.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.SIZE.LocationFloat = new DevExpress.Utils.PointFloat(64.36072F, 178.8308F);
            this.SIZE.Name = "SIZE";
            this.SIZE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.SIZE.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.SIZE.SizeF = new System.Drawing.SizeF(181.5432F, 36F);
            this.SIZE.StylePriority.UseFont = false;
            this.SIZE.StylePriority.UsePadding = false;
            this.SIZE.StylePriority.UseTextAlignment = false;
            this.SIZE.Text = "SIZE";
            this.SIZE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.SIZE.WordWrap = false;
            // 
            // COLOR
            // 
            this.COLOR.CanGrow = false;
            this.COLOR.Dpi = 254F;
            this.COLOR.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.COLOR.LocationFloat = new DevExpress.Utils.PointFloat(64.36072F, 130.3554F);
            this.COLOR.Name = "COLOR";
            this.COLOR.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.COLOR.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.COLOR.SizeF = new System.Drawing.SizeF(181.5432F, 36F);
            this.COLOR.StylePriority.UseFont = false;
            this.COLOR.StylePriority.UsePadding = false;
            this.COLOR.StylePriority.UseTextAlignment = false;
            this.COLOR.Text = "COLOR";
            this.COLOR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.COLOR.WordWrap = false;
            // 
            // DESIGN
            // 
            this.DESIGN.CanGrow = false;
            this.DESIGN.Dpi = 254F;
            this.DESIGN.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.DESIGN.LocationFloat = new DevExpress.Utils.PointFloat(64.36072F, 81.87999F);
            this.DESIGN.Name = "DESIGN";
            this.DESIGN.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.DESIGN.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.DESIGN.SizeF = new System.Drawing.SizeF(181.5432F, 36F);
            this.DESIGN.StylePriority.UseFont = false;
            this.DESIGN.StylePriority.UsePadding = false;
            this.DESIGN.StylePriority.UseTextAlignment = false;
            this.DESIGN.Text = "DESIGN";
            this.DESIGN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.DESIGN.WordWrap = false;
            // 
            // datetime
            // 
            this.datetime.CanGrow = false;
            this.datetime.Dpi = 254F;
            this.datetime.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.datetime.LocationFloat = new DevExpress.Utils.PointFloat(62.99999F, 347.488F);
            this.datetime.Multiline = true;
            this.datetime.Name = "datetime";
            this.datetime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.datetime.SizeF = new System.Drawing.SizeF(298.5078F, 31.62076F);
            this.datetime.StylePriority.UseFont = false;
            this.datetime.Text = "8:53:03";
            // 
            // smena
            // 
            this.smena.CanGrow = false;
            this.smena.Dpi = 254F;
            this.smena.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smena.LocationFloat = new DevExpress.Utils.PointFloat(674.3657F, 312.3188F);
            this.smena.Multiline = true;
            this.smena.Name = "smena";
            this.smena.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.smena.SizeF = new System.Drawing.SizeF(101.8689F, 50.96539F);
            this.smena.StylePriority.UseFont = false;
            this.smena.StylePriority.UseTextAlignment = false;
            this.smena.Text = "1 - S";
            this.smena.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // QUALITY
            // 
            this.QUALITY.CanGrow = false;
            this.QUALITY.Dpi = 254F;
            this.QUALITY.Font = new System.Drawing.Font("Bahnschrift", 11.5F, System.Drawing.FontStyle.Bold);
            this.QUALITY.LocationFloat = new DevExpress.Utils.PointFloat(64.36072F, 33.4046F);
            this.QUALITY.Name = "QUALITY";
            this.QUALITY.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.QUALITY.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.QUALITY.SizeF = new System.Drawing.SizeF(181.5432F, 36F);
            this.QUALITY.StylePriority.UseFont = false;
            this.QUALITY.StylePriority.UsePadding = false;
            this.QUALITY.StylePriority.UseTextAlignment = false;
            this.QUALITY.Text = "QUALITY";
            this.QUALITY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.QUALITY.WordWrap = false;
            // 
            // ean13
            // 
            this.ean13.AutoModule = true;
            this.ean13.BarCodeOrientation = DevExpress.XtraPrinting.BarCode.BarCodeOrientation.RotateLeft;
            this.ean13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ean13.Dpi = 254F;
            this.ean13.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.ean13.LocationFloat = new DevExpress.Utils.PointFloat(636.0001F, 23.60714F);
            this.ean13.Module = 1.5F;
            this.ean13.Name = "ean13";
            this.ean13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.ean13.SizeF = new System.Drawing.SizeF(140.2345F, 272.8708F);
            this.ean13.StylePriority.UseBorderDashStyle = false;
            this.ean13.StylePriority.UseFont = false;
            this.ean13.StylePriority.UsePadding = false;
            this.ean13.StylePriority.UseTextAlignment = false;
            this.ean13.Symbology = eaN13Generator1;
            this.ean13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // barkod
            // 
            this.barkod.Dpi = 254F;
            this.barkod.Font = new System.Drawing.Font("Arial", 7F);
            this.barkod.LocationFloat = new DevExpress.Utils.PointFloat(63.00001F, 222.2202F);
            this.barkod.Module = 2.8F;
            this.barkod.Name = "barkod";
            this.barkod.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.barkod.SizeF = new System.Drawing.SizeF(365.0655F, 125F);
            this.barkod.StylePriority.UseFont = false;
            this.barkod.StylePriority.UsePadding = false;
            this.barkod.StylePriority.UseTextAlignment = false;
            this.barkod.Symbology = code128Generator1;
            this.barkod.Text = "0011422";
            this.barkod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BarcodeReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(5, 0, 0, 0);
            this.PageHeight = 399;
            this.PageWidth = 800;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PrinterName = "Godex G500 (Copy 1)";
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RequestParameters = false;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.SnapGridSize = 1F;
            this.SnapGridStepCount = 1;
            this.Version = "21.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel razmer;
        private DevExpress.XtraReports.UI.XRLabel rang;
        private DevExpress.XtraReports.UI.XRLabel dizayn;
        private DevExpress.XtraReports.UI.XRLabel sifat;
        private DevExpress.XtraReports.UI.XRLabel clientcode;
        private DevExpress.XtraReports.UI.XRLabel barkodserial;
        private DevExpress.XtraReports.UI.XRLabel SIZE;
        private DevExpress.XtraReports.UI.XRLabel COLOR;
        private DevExpress.XtraReports.UI.XRLabel DESIGN;
        private DevExpress.XtraReports.UI.XRLabel datetime;
        private DevExpress.XtraReports.UI.XRLabel smena;
        private DevExpress.XtraReports.UI.XRLabel QUALITY;
        private DevExpress.XtraReports.UI.XRBarCode ean13;
        private DevExpress.XtraReports.UI.XRBarCode barkod;
        private DevExpress.XtraReports.UI.XRLabel kglabel;
        private DevExpress.XtraReports.UI.XRLabel ogirlik;
    }
}
