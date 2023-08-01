namespace SKLAD.VIEWS.Controls
{
    partial class Ranglar
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
            this.colId1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaletteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupedit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.paletteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowSort = true;
            this.colId1.OptionsColumn.ReadOnly = true;
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 35;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowSort = true;
            this.colName1.OptionsColumn.ReadOnly = true;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 968;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SKLAD.MODEL.Bys.Color);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupedit});
            this.gridControl1.Size = new System.Drawing.Size(700, 400);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colNotes,
            this.colPaletteId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 1;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 39;
            // 
            // colName
            // 
            this.colName.Caption = "Rang nomi";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.Caption = "Rang nomi";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 156;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Malumot";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.Caption = "Malumot";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 156;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Malumot-2";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsEditForm.Caption = "Malumot-2";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 3;
            this.colNotes.Width = 156;
            // 
            // colPaletteId
            // 
            this.colPaletteId.Caption = "Palet nomi";
            this.colPaletteId.ColumnEdit = this.lookupedit;
            this.colPaletteId.FieldName = "PaletteId";
            this.colPaletteId.Name = "colPaletteId";
            this.colPaletteId.OptionsEditForm.Caption = "Palet nomi";
            this.colPaletteId.Visible = true;
            this.colPaletteId.VisibleIndex = 4;
            this.colPaletteId.Width = 168;
            // 
            // lookupedit
            // 
            this.lookupedit.AutoHeight = false;
            this.lookupedit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupedit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookupedit.DataSource = this.paletteBindingSource;
            this.lookupedit.DisplayMember = "Name";
            this.lookupedit.Name = "lookupedit";
            this.lookupedit.ValueMember = "Id";
            // 
            // paletteBindingSource
            // 
            this.paletteBindingSource.DataSource = typeof(SKLAD.MODEL.Bys.Palette);
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            this.colId2.Width = 50;
            // 
            // colName2
            // 
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 1;
            this.colName2.Width = 1224;
            // 
            // Ranglar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Ranglar";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colPaletteId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupedit;
        private System.Windows.Forms.BindingSource paletteBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName2;
    }
}
