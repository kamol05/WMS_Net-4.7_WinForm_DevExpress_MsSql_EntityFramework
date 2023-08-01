namespace SKLAD.VIEWS.Controls
{
    partial class Nakladnoylar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber;
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colWarehouseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.skladlookupedit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCarNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseMan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladlookupedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // colInvoiceNumber
            // 
            colInvoiceNumber.Caption = "Nak No:";
            colInvoiceNumber.FieldName = "InvoiceNumber";
            colInvoiceNumber.Name = "colInvoiceNumber";
            colInvoiceNumber.OptionsEditForm.Caption = "Nak No:";
            colInvoiceNumber.Visible = true;
            colInvoiceNumber.VisibleIndex = 2;
            colInvoiceNumber.Width = 53;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            colInvoiceNumber,
            this.colDate,
            this.colCustomer,
            this.colWarehouseId,
            this.colCarNumber,
            this.colCarNumber2,
            this.colDriverPhone,
            this.colWarehouseMan,
            this.colNotes,
            this.colDescription,
            this.colModified,
            this.colUser});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yangi nakladnoy kiritish uchun bu yerga bosing!!";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 1;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colId
            // 
            this.colId.Caption = "Fish Nomer";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsEditForm.Caption = "Fish Nomer";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 82;
            // 
            // colDate
            // 
            this.colDate.Caption = "Sana";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 67;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Xaridor";
            this.colCustomer.ColumnEdit = this.lookupEdit;
            this.colCustomer.FieldName = "CustomerId";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsEditForm.Caption = "Xaridor";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 4;
            this.colCustomer.Width = 208;
            // 
            // lookupEdit
            // 
            this.lookupEdit.AutoHeight = false;
            this.lookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "KODI", 8, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "ISMI", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookupEdit.DataSource = this.customerBindingSource;
            this.lookupEdit.DisplayMember = "Name";
            this.lookupEdit.Name = "lookupEdit";
            this.lookupEdit.ValueMember = "Id";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SKLAD.MODEL.Bys.Customer);
            // 
            // colWarehouseId
            // 
            this.colWarehouseId.Caption = "SKLAD";
            this.colWarehouseId.ColumnEdit = this.skladlookupedit;
            this.colWarehouseId.FieldName = "WarehouseId";
            this.colWarehouseId.Name = "colWarehouseId";
            this.colWarehouseId.OptionsEditForm.Caption = "SKLAD";
            this.colWarehouseId.Visible = true;
            this.colWarehouseId.VisibleIndex = 3;
            this.colWarehouseId.Width = 99;
            // 
            // skladlookupedit
            // 
            this.skladlookupedit.AutoHeight = false;
            this.skladlookupedit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.skladlookupedit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "KODI", 8, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.skladlookupedit.DataSource = this.warehouseBindingSource;
            this.skladlookupedit.DisplayMember = "Name";
            this.skladlookupedit.Name = "skladlookupedit";
            this.skladlookupedit.ValueMember = "Id";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(SKLAD.MODEL.Bys.Warehouse);
            // 
            // colCarNumber
            // 
            this.colCarNumber.Caption = "Avto Raqam";
            this.colCarNumber.FieldName = "CarNumber";
            this.colCarNumber.Name = "colCarNumber";
            this.colCarNumber.Visible = true;
            this.colCarNumber.VisibleIndex = 5;
            this.colCarNumber.Width = 81;
            // 
            // colCarNumber2
            // 
            this.colCarNumber2.Caption = "Avto Raqam-2";
            this.colCarNumber2.FieldName = "CarNumber2";
            this.colCarNumber2.Name = "colCarNumber2";
            this.colCarNumber2.Visible = true;
            this.colCarNumber2.VisibleIndex = 6;
            this.colCarNumber2.Width = 89;
            // 
            // colDriverPhone
            // 
            this.colDriverPhone.Caption = "Haydovchi Tel:";
            this.colDriverPhone.FieldName = "DriverPhone";
            this.colDriverPhone.Name = "colDriverPhone";
            this.colDriverPhone.Visible = true;
            this.colDriverPhone.VisibleIndex = 7;
            this.colDriverPhone.Width = 94;
            // 
            // colWarehouseMan
            // 
            this.colWarehouseMan.Caption = "Skladchi";
            this.colWarehouseMan.FieldName = "WarehouseMan";
            this.colWarehouseMan.Name = "colWarehouseMan";
            this.colWarehouseMan.Visible = true;
            this.colWarehouseMan.VisibleIndex = 8;
            this.colWarehouseMan.Width = 62;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Malumot";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 9;
            this.colNotes.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Malumot-2";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 10;
            this.colDescription.Width = 114;
            // 
            // colModified
            // 
            this.colModified.Caption = "Sana-2";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.OptionsColumn.AllowEdit = false;
            this.colModified.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 11;
            this.colModified.Width = 65;
            // 
            // colUser
            // 
            this.colUser.Caption = "Login";
            this.colUser.FieldName = "User.Login";
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.AllowEdit = false;
            this.colUser.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 12;
            this.colUser.Width = 62;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SKLAD.MODEL.Event.Invoice);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupEdit,
            this.skladlookupedit});
            this.gridControl1.Size = new System.Drawing.Size(1259, 465);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Nakladnoylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Nakladnoylar";
            this.Size = new System.Drawing.Size(1259, 465);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladlookupedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCarNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCarNumber2;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseMan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupEdit;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit skladlookupedit;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
    }
}
