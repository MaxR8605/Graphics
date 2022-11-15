using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = CreateGraphics();

            /// GRAPHICS TEST

            //Pen redPen = new Pen(Color.Red, 5);
            //SolidBrush whiteBrush = new SolidBrush(Color.White);
            //SolidBrush purpleBrush = new SolidBrush(Color.Purple);

            //g.Clear(Color.Black);

            //g.FillPie(purpleBrush, 75, 75, 100, 100, 90, 270);
            //g.DrawLine(redPen, 0, 0, 100, 100);
            //g.DrawRectangle(redPen, 100, 100, 50, 50);
            //g.FillRectangle(whiteBrush, 110, 110, 30, 30);
            //g.FillEllipse(purpleBrush, 111, 111, 28, 28);
            //g.DrawArc(redPen, 75, 75, 100, 100, 270, 270);


            /// LOGO

            Pen lightGrey = new Pen(Color.LightGray, 16);
            Pen darkGrey = new Pen(Color.DarkGray, 25);
            Pen white = new Pen(Color.WhiteSmoke, 5);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush greyBrush = new SolidBrush(Color.DimGray);
            Font font = new Font("CenturyGothic", 50, FontStyle.Bold);

            g.Clear(Color.DarkGray);

            g.FillEllipse(greyBrush, 100, 100, 200, 150);

            g.DrawEllipse(darkGrey, 100, 100, 200, 150);
            g.DrawArc(darkGrey, 97, 100, 206, 70, 10, 160);
            g.DrawEllipse(darkGrey, 170, 100, 60, 150);

            g.DrawEllipse(lightGrey, 97, 97, 206, 156);
            g.DrawArc(lightGrey, 97, 100, 206, 70, 10, 160);
            g.DrawEllipse(lightGrey, 170, 97, 60, 156);

            g.DrawEllipse(white, 97, 93, 206, 156);
            g.DrawArc(white, 97, 96, 206, 70, 8, 164);
            g.DrawEllipse(white, 170, 93, 60, 156);

            g.DrawString("TOYOTA", font, red, 52, 279);
            g.DrawString("TOYOTA", font, red, 53, 279);
            g.DrawString("TOYOTA", font, red, 54, 279);
            g.DrawString("TOYOTA", font, red, 52, 280);
            g.DrawString("TOYOTA", font, red, 53, 280);
            g.DrawString("TOYOTA", font, red, 54, 280);
            g.DrawString("TOYOTA", font, red, 52, 281);
            g.DrawString("TOYOTA", font, red, 53, 281);
            g.DrawString("TOYOTA", font, red, 54, 281);


            /// 8 POINT STAR

            //Pen green = new Pen(Color.LimeGreen, 10);

            //int num1 = 159;
            //int num2 = 241;
            //int num3 = 100;
            //int num4 = 300;

            //g.DrawLine(green, num1, num4, num1, num3);
            //g.DrawLine(green, num1, num3, num4, num2);
            //g.DrawLine(green, num4, num2, num3, num2);
            //g.DrawLine(green, num3, num2, num2, num3);
            //g.DrawLine(green, num2, num3, num2, num4);
            //g.DrawLine(green, num2, num4, num3, num1);
            //g.DrawLine(green, num3, num1, num4, num1);
            //g.DrawLine(green, num4, num1, num1, num4);
        }
    }
}
