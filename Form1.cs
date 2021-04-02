using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaDeter
{
    public struct CrNewDialogRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }
    public partial class F_MainForm : Form
    {
        F_Image imageField = null;
        public static bool ImageFieldOpened = false;

        public static IMageEditor imageEditor = new IMageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();

        public F_MainForm()
        {
            InitializeComponent();
            CreateField();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_new_Click(object sender, EventArgs e)
        {
            F_CreateNewBitmap createNewBitmap = new F_CreateNewBitmap();
            createNewBitmap.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CreateField()
        {
            imageField = new F_Image();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void open_draw_window_Click(object sender, EventArgs e)
        {
            if(!ImageFieldOpened)
            {
                CreateField();
            }
        }

        private void close_open_window_Click(object sender, EventArgs e)
        {
            if(ImageFieldOpened)
            {
                imageField.Close();
                ImageFieldOpened = false;
            }
        }
    }
}

