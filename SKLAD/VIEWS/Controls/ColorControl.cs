using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using SKLAD.EF;
using SKLAD.MODEL.Bys;
using SKLAD.SERVICE;
using SKLAD.VIEWS.Tools;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Controls
{
    public partial class Ranglar : UserControl
    {
        private EFcontext dbContext;
        public Ranglar()
        {
            InitializeComponent();

            dbContext = new SKLAD.EF.EFcontext();
            dbContext.Color.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Color.Local.ToBindingList();
                paletteBindingSource.DataSource = dbContext.Palette.ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.NewItemRowText = "Yangi Rang kiritish uchun bu yerga bosing";
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var color = (Color)e.Row;
            dbContext.SaveChanges();
            Logger.Log("Color:", color.ToString());
        }


        #region Popup Menu Region
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();

                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Yangi", OnNewRowClick, ImageTool.Get(0)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&O'zgartirish", OnChangeRowClick, ImageTool.Get(1)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&O'chirish", OnDeleteRowClick, ImageTool.Get(2)));
                e.Menu.Items.Add(CreateMenuItem(view, rowHandle, "&Orqaga", OnCancelRowClick, ImageTool.Get(3)));
            }
        }
        DXMenuItem CreateMenuItem(GridView view, int rowHandle, string caption, EventHandler handler, System.Drawing.Image image)
        {
            DXMenuItem menuItem = new DXMenuItem(caption, handler, image);
            menuItem.Tag = new RowInfo(view, rowHandle);
            menuItem.Enabled = view.IsDataRow(rowHandle) || view.IsGroupRow(rowHandle);
            return menuItem;
        }
        void OnNewRowClick(object sender, EventArgs e)
        {
            this.gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
            this.gridView1.ShowEditForm();
        }
        void OnChangeRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            gridView1.ShowPopupEditForm();
        }
        void OnDeleteRowClick(object sender, EventArgs e)
        {
            //DXMenuItem menuItem = sender as DXMenuItem;
            //RowInfo ri = menuItem.Tag as RowInfo;
            //if (ri != null)
            //{
            //    string message = menuItem.Caption.Replace("&", "");
            //    if (XtraMessageBox.Show(message + "ni hohlaysizmi?", "Tasdiqlash", MessageBoxButtons.YesNo) != DialogResult.Yes)
            //        return;
            //    ri.View.DeleteRow(ri.RowHandle);
            //}
        }
        void OnCancelRowClick(object sender, EventArgs e) { return; }
        class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }
            public GridView View;
            public int RowHandle;
        }
        #endregion

    }
}
