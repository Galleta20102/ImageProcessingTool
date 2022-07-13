using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace ImageProcessingTool
{
    public partial class Form2 : Form
    {
        Bitmap editImg;
        List<Bitmap> StepList = new List<Bitmap>();
        bool isDrawing = false;
        System.Drawing.Point oldPoint;
        private float X; //當前視窗的寬度
        private float Y; //當前視窗的高度
        float imgRate, leftMargin, topMargin;

        private void setTag(Control cons)
        {
            //將控件的寬，高，左邊距，頂邊距和字體大小暫存到tag屬性中
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + " : " + con.Height + " : " + con.Left + " : " + con.Top + " : " + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //根據視窗大小大小調整元件大小、位置與字體
            foreach (Control con in cons.Controls)
            {
                //取得元件的Tag屬性值，並分割存儲到陣列中
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });

                //根據視窗縮放比例決定元件的值
                float a = System.Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a; //寬度
                a = System.Convert.ToSingle(mytag[1]) * newy; //高度
                con.Height = (int)(a);
                a = System.Convert.ToSingle(mytag[2]) * newx; //左邊距離
                con.Left = (int)(a);
                a = System.Convert.ToSingle(mytag[3]) * newy; //上邊緣距離
                con.Top = (int)(a);
                Single currentSize = System.Convert.ToSingle(mytag[4]) * newy; //字體大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }


        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            setTag(this); //調用方法

            penColor.Items.Add("Black");
            penColor.Items.Add("White");
            //pictureBox1.Image = editImg;
            //pictureBox1.Image = editImg;
        }

        public void getImgfromForm1(Bitmap form1Img)
        {
            editImg = new Bitmap(form1Img);
            pictureBox1.Image = editImg;
            Bitmap tmp = new Bitmap(form1Img);
            StepList.Add(tmp);
            label3.Text = "" + StepList.Count;
            float imgRateX = (float)form1Img.Width / (float)pictureBox1.Width;
            float imgRateY = (float)form1Img.Height / (float)pictureBox1.Height;
            imgRate = (imgRateX > imgRateY) ? imgRateX : imgRateY;
            leftMargin = Math.Abs(pictureBox1.Width - ((float)form1Img.Width / imgRate)) / 2;
            topMargin = Math.Abs(pictureBox1.Height - ((float)form1Img.Height / imgRate)) / 2;
        }

        public Bitmap returnImgfromForm2()
        {
            return new Bitmap(pictureBox1.Image);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {

            if (StepList.Count > 1)
            {
                StepList.RemoveAt(StepList.Count - 1);
                Bitmap tmp = new Bitmap(StepList[StepList.Count - 1]);

                //editImg = tmp;
                //pictureBox1.Image = editImg;
                pictureBox1.Image = tmp;

                label3.Text = "" + StepList.Count;

            }
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; //窗體寬度縮放比例
            float newy = (this.Height) / Y; //窗體高度縮放比例
            setControls(newx, newy, this); //隨窗體改變控件大小
            float imgRateX = (float)editImg.Width / (float)pictureBox1.Width;
            float imgRateY = (float)editImg.Height / (float)pictureBox1.Height;
            imgRate = (imgRateX > imgRateY) ? imgRateX : imgRateY;
            leftMargin = Math.Abs(pictureBox1.Width - ((float)editImg.Width / imgRate)) / 2;
            topMargin = Math.Abs(pictureBox1.Height - ((float)editImg.Height / imgRate)) / 2;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint.X = e.X;
            oldPoint.Y = e.Y;
            undoBtn.Enabled = false;
            isDrawing = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            undoBtn.Enabled = true;
            isDrawing = false;

            Bitmap tmp = new Bitmap(pictureBox1.Image);

            StepList.Add(tmp);
            label3.Text = "" + StepList.Count;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition.Text = "（" + e.X + "，" + e.Y + "）";
            if (isDrawing)
            {
                OpenCvSharp.Point imgNewPoint = new OpenCvSharp.Point((e.X - leftMargin)*imgRate
                                                                    ,(e.Y - topMargin)*imgRate);

                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Color color = Color.Black;
                OpenCvSharp.Point imgOldPoint = new OpenCvSharp.Point((oldPoint.X - leftMargin) * imgRate
                                                                    , (oldPoint.Y - topMargin) * imgRate);
                if (oldPoint.X < 0) oldPoint.X = 0;
                else if (oldPoint.X > editImg.Width) oldPoint.X = editImg.Width;
                if (oldPoint.Y < 0) oldPoint.Y = 0;
                else if (oldPoint.Y > editImg.Height) oldPoint.Y = editImg.Height;

                //if (penColor.Text == "White") color = Color.White;
                Brush brush = new SolidBrush((penColor.Text == "White")? Color.White : Color.Black);

                Pen pen = new Pen(brush, (float)penWidth.Value);

                g.DrawLine(pen, imgOldPoint.X, imgOldPoint.Y 
                               , imgNewPoint.X, imgNewPoint.Y);

                oldPoint.X = e.X;
                oldPoint.Y = e.Y;
                pictureBox1.Image = pictureBox1.Image;
                g.Dispose();
            }
        }
    }
}
