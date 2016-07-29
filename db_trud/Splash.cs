using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace db_trud
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

           /* //Делаем форму круглой
            System.Drawing.Drawing2D.GraphicsPath Form_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Form_Path.AddEllipse(0, 0, this.Width, this.Height);
            Region Form_Region = new Region(Form_Path);
            this.Region = Form_Region;*/
            Paint += new PaintEventHandler(Splash_Paint);//перерисовываем

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Splash_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Gray, 10);
            pen.LineJoin = LineJoin.Bevel;//задаем скошенные углы
            pen.MiterLimit = 10;//задаем ограничение толщины скошенных углов
           g.DrawRectangle(pen, new Rectangle(-2, -2 , this.Width+3, this.Height+3));
           /* label1.Text += Environment.NewLine;
            label1.Text += this.Location.X.ToString();
            label1.Text += Environment.NewLine;
            label1.Text += this.Location.Y.ToString();
            e.Graphics.DrawRectangle(pen, 5, 5, this.Width, this.Height);*/
            //рисуем прямоугольник с параметрами испоьзуемыми выше            
            // ex Hermein
        }
    }
}
