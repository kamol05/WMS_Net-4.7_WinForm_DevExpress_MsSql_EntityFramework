using System.Drawing;
using System.Windows.Forms;

namespace SKLAD.VIEWS.Tools
{
    public partial class ImageTool : UserControl
    {
        private static ImageTool ins = new ImageTool();
        public ImageTool()
        {
            InitializeComponent();
        }
        public static Image Get(int i)
        {
            return ins.imageCollection.Images[i];
        }
    }
}
