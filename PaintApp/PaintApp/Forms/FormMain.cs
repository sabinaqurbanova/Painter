using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace PaintApp.Forms
{
    public partial class FormMain : Form
    {
        #region variables
       
        //private Image OpenedFile = null;
        Graphics graphics;
        Rectangle rect;
        Bitmap bmp;
       
        Boolean isCursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        #endregion variables

        public FormMain()
        {
            InitializeComponent();

            {

                bmp = new Bitmap(pnlArt.Size.Width, pnlArt.Size.Height);
                

                cursorPen = new Pen(Color.Black, 7);
                cursorPen.StartCap = LineCap.Round;
                cursorPen.EndCap = LineCap.Round;
            }
        }



        private void btnSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.FullOpen = true;
            }

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                cursorPen.Color = colorDialog.Color;
            }
        }

        //private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    {
        //        saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
        //        saveFileDialog.Title = "Save an Image File";
        //        saveFileDialog.FileName = $"image-_-{DateTime.UtcNow.Ticks}-{Guid.NewGuid().ToString().Replace("-", "")}";

        //        if(saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            int width = pnlArt.Size.Width;
        //            int height = pnlArt.Size.Height;

        //            Bitmap bitmap = new Bitmap(width, height);
        //            pnlArt.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));

        //            bitmap.Save(saveFileDialog.FileName);
        //        }
        //    }
        //}

        //private void openToolStripMenuOpen_Click(object sender, EventArgs e)
        //{
        ////    OpenFileDialog openFileDialog = new OpenFileDialog();
        ////    DialogResult dialogResult = openFileDialog.ShowDialog();
        ////    if (dialogResult == DialogResult.OK)
        ////    {
        ////        OpenedFile = Image.FromFile(openFileDialog.FileName);
        ////        pbBoard.Image = OpenedFile;
        ////    }
        //}

        private void toolStripBtnClear_Click(object sender, EventArgs e)
        {
            pnlArt.Invalidate();
        }

        private void btnPenIncrease_Click(object sender, EventArgs e)
        {
            if(cursorPen.Width <= 30)
            {
                cursorPen.Width = cursorPen.Width + 2;
            }
        }

        private void btnPenDecrease_Click(object sender, EventArgs e)
        {
            if(cursorPen.Width > 2)
            {
                cursorPen.Width = cursorPen.Width - 2;
            }
        }

        private void pnlArt_MouseDown(object sender, MouseEventArgs e)
        {
            // pnlArt_Paint(sender, new PaintEventArgs(graphics, new Rectangle(0, 0, pnlArt.Size.Width, pnlArt.Size.Height)));

            isCursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void pnlArt_MouseUp(object sender, MouseEventArgs e)
        {
            isCursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void pnlArt_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && isCursorMoving == true)
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        //private void pnlArt_Paint(object sender, PaintEventArgs e)
        //{
        //    graphics = e.Graphics;
            
        //}

        private void FormMain_Load(object sender, EventArgs e)
        {
            graphics = pnlArt.CreateGraphics();
        }
    }
}