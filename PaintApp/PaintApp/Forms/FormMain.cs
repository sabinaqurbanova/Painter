using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp.Forms
{
    public partial class FormMain : Form
    {
        private readonly Bitmap sekil = new Bitmap(1920, 1080);
        private readonly Pen qelem = new Pen(Color.Black, 3);
        private bool isDrawing = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void pbBoard_MouseDownAndUp(object sender, MouseEventArgs e)
        {
            if(isDrawing == true)
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
                using (Graphics graphics = Graphics.FromImage(sekil))
                {
                    graphics.DrawRectangle
                    (
                        pen: qelem,
                        x: e.X,
                        y: e.Y,
                        width: 3,
                        height: 1
                    );
                    pbBoard.Image = sekil;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
