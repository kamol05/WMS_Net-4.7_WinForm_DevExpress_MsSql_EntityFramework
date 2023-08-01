namespace SKLAD.VIEWS.Transfer
{
    partial class TransferLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferLogin));
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.toText = new DevExpress.XtraEditors.TextEdit();
            this.to = new DevExpress.XtraEditors.LookUpEdit();
            this.fromText = new DevExpress.XtraEditors.TextEdit();
            this.from = new DevExpress.XtraEditors.LookUpEdit();
            this.chiqish = new DevExpress.XtraEditors.SimpleButton();
            this.kirish = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.toText);
            this.panel.Controls.Add(this.to);
            this.panel.Controls.Add(this.fromText);
            this.panel.Controls.Add(this.from);
            this.panel.Controls.Add(this.chiqish);
            this.panel.Controls.Add(this.kirish);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(737, 452);
            this.panel.TabIndex = 0;
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(335, 135);
            this.toText.Name = "toText";
            this.toText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toText.Properties.Appearance.Options.UseFont = true;
            this.toText.Size = new System.Drawing.Size(373, 42);
            this.toText.TabIndex = 6;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(53, 135);
            this.to.Name = "to";
            this.to.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to.Properties.Appearance.Options.UseFont = true;
            this.to.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to.Properties.AppearanceDropDown.Options.UseFont = true;
            this.to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "SKLAD KODI"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "SKLAD NOMI")});
            this.to.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Warehouse);
            this.to.Properties.DisplayMember = "Code";
            this.to.Properties.NullText = "";
            this.to.Properties.PopupWidth = 500;
            this.to.Size = new System.Drawing.Size(233, 40);
            this.to.TabIndex = 5;
            this.to.EditValueChanged += new System.EventHandler(this.to_EditValueChanged);
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(335, 54);
            this.fromText.Name = "fromText";
            this.fromText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromText.Properties.Appearance.Options.UseFont = true;
            this.fromText.Size = new System.Drawing.Size(373, 42);
            this.fromText.TabIndex = 4;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(53, 54);
            this.from.Name = "from";
            this.from.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from.Properties.Appearance.Options.UseFont = true;
            this.from.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from.Properties.AppearanceDropDown.Options.UseFont = true;
            this.from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "SKLAD KODI", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "SKLAD NOMI", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.from.Properties.DataSource = typeof(SKLAD.MODEL.Bys.Warehouse);
            this.from.Properties.DisplayMember = "Code";
            this.from.Properties.NullText = "";
            this.from.Properties.PopupWidth = 500;
            this.from.Size = new System.Drawing.Size(233, 40);
            this.from.TabIndex = 2;
            this.from.EditValueChanged += new System.EventHandler(this.from_EditValueChanged);
            // 
            // chiqish
            // 
            this.chiqish.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiqish.Appearance.Options.UseFont = true;
            this.chiqish.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chiqish.ImageOptions.Image")));
            this.chiqish.Location = new System.Drawing.Point(99, 311);
            this.chiqish.Name = "chiqish";
            this.chiqish.Size = new System.Drawing.Size(233, 64);
            this.chiqish.TabIndex = 1;
            this.chiqish.Text = "CHIQISH";
            this.chiqish.Click += new System.EventHandler(this.chiqish_Click);
            // 
            // kirish
            // 
            this.kirish.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kirish.Appearance.Options.UseFont = true;
            this.kirish.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kirish.ImageOptions.Image")));
            this.kirish.Location = new System.Drawing.Point(411, 311);
            this.kirish.Name = "kirish";
            this.kirish.Size = new System.Drawing.Size(233, 64);
            this.kirish.TabIndex = 0;
            this.kirish.Text = "O\'TKAZISH";
            this.kirish.Click += new System.EventHandler(this.kirish_Click);
            // 
            // TransferLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 485);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = global::SKLAD.Properties.Resources.Transmit;
            this.Name = "TransferLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton chiqish;
        private DevExpress.XtraEditors.SimpleButton kirish;
        private DevExpress.XtraEditors.LookUpEdit from;
        private DevExpress.XtraEditors.TextEdit fromText;
        private DevExpress.XtraEditors.TextEdit toText;
        private DevExpress.XtraEditors.LookUpEdit to;
    }
}