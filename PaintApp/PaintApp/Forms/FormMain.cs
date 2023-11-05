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

namespace PaintApp.Forms
{
    public partial class FormMain : Form
    {
        #region variables
        private readonly Bitmap picture = null;
        private readonly Pen pen = null;
        private Image OpenedFile = null;
        private bool isDrawing = false;
        #endregion variables

        public FormMain()
        {
            InitializeComponent();

            {
                this.picture = new Bitmap(1920, 1080);
                this.pen = new Pen(Color.Black)
                {
                    Width = 4,
                    LineJoin = LineJoin.Round
                };
            }

            {
                for (int i = 0; i < picture.Width; i++)
                    for (int j = 0; j < picture.Height; j++)
                        picture.SetPixel(i, j, Color.White);
            }
        }

        private void pbBoard_MouseDownAndUp(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                isDrawing = false;
            }
            else
            {
                isDrawing = true;
            }
        }

        private void pbBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                using (Graphics graphics = Graphics.FromImage(picture))
                {
                    graphics.DrawRectangle
                    (
                        pen: pen,
                        x: e.X,
                        y: e.Y,
                        width: pen.Width,
                        height: pen.Width
                    );
                    pbBoard.Image = picture;
                }
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
                pen.Color = colorDialog.Color;
            }
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            {
                saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();
            }

            if (saveFileDialog.FileName != "")
            {
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            this.pbBoard.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.pbBoard.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }
                    fs.Close();
                }
            }
        }

        private void openToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(openFileDialog.FileName);
                pbBoard.Image = OpenedFile;
            }
        }

        private void toolStripBtnClear_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = Graphics.FromImage(picture))
            {
                graphics.Clear(Color.White);
                pbBoard.Image = picture;
            }
        }

        private void btnPenIncrease_Click(object sender, EventArgs e)
        {
            if(pen.Width <= 30)
            {
                pen.Width = pen.Width + 2;
            }
        }

        private void btnPenDecrease_Click(object sender, EventArgs e)
        {
            if(pen.Width > 2)
            {
                pen.Width = pen.Width - 2;
            }
        }
    }
}