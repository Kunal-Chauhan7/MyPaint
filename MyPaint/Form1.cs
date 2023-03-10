using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        static int size = 4;
        Pen p = new Pen(Color.Black,size);
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing= false;
            }
            else
            {
                drawing= true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image= bmp;
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            p.Color= Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color= Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color= Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Violet;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "JPeg Image*.jpg|bitmap Image*.bmp";
            savefiledialog.Title = "Save the Drawing";
            savefiledialog.ShowDialog();
            if (savefiledialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)savefiledialog.OpenFile();
                switch (savefiledialog.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            size = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            size = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            size = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            size = 4;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            size = 5;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            size = 6;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            size = 7;
        }
    }
}
