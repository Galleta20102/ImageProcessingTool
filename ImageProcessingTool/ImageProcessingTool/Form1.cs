using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
//openCvSharp
using OpenCvSharp;
using OpenCvSharp.XImgProc;

namespace ImageProcessingTool
{

    public partial class Form1 : Form
    {
        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);
        Mat img_origin_Mat = new Mat();
        Bitmap cannyImg, hsvImg;
        Stack<Bitmap> StepStack = new Stack<Bitmap>();
        //當前視窗的寬度高度
        private float X, Y;
        //選取圖像
        bool isSelecting = false, startSelect = false;
        float imgRate, leftMargin, topMargin;
        System.Drawing.Point selectStartPoint;


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
        private int getOtsu_Kmeans(Bitmap otsuImg, int central1, int central2)
        {
            int central1Sum = 0, cetral1Num = 0, newCentral1;
            int central2Sum = 0, cetral2Num = 0, newCentral2;
            for (int x = 0; x < otsuImg.Width; x++)
            {
                for (int y = 0; y < otsuImg.Height; y++)
                {
                    int diff1 = Math.Abs(otsuImg.GetPixel(x, y).R - central1);
                    int diff2 = Math.Abs(otsuImg.GetPixel(x, y).R - central2);
                    if (diff1 < diff2)
                    {
                        central1Sum += otsuImg.GetPixel(x, y).R;
                        cetral1Num++;
                    }
                    else
                    {
                        central2Sum += otsuImg.GetPixel(x, y).R;
                        cetral2Num++;
                    }
                }
            }
            newCentral1 = (cetral1Num == 0) ? central1Sum : central1Sum / cetral1Num;
            newCentral2 = (cetral2Num == 0) ? central2Sum : central2Sum / cetral2Num;
            if (central1 != newCentral1 || central2 != newCentral2)
            {
                return getOtsu_Kmeans(otsuImg, newCentral1, newCentral2);
            }
            else
            {
                return Math.Abs(newCentral1 + newCentral2) / 2;
            }
            //int sumLeft = 0, sumRight = 0;
            //for (int x = 0; x < img.Width; x++)
            //{
            //    for (int y = 0; y < img.Height; y++)
            //    {
            //        if (img.GetPixel(x, y).R >= devide) sumRight++;
            //        else sumLeft++;
            //    }
            //}
            //if ()
        }

        private void initForm()
        {
            Photo_WH.Text = "0x0";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            X = this.Width; //獲取窗體的寬度
            Y = this.Height; //獲取窗體的高度
            setTag(this); //調用方法
            skltMorphShape.Items.Add("Rectangle");
            skltMorphShape.Items.Add("Ellipse");
            skltMorphShape.Items.Add("Cross");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (X != 0 && Y != 0)
            {
                float newx = (this.Width) / X; //窗體寬度縮放比例
                float newy = (this.Height) / Y; //窗體高度縮放比例
                setControls(newx, newy, this); //隨窗體改變控件大小
            }

            float imgRateX = (float)img.Width / (float)resultImg.Width;
            float imgRateY = (float)img.Height / (float)resultImg.Height;
            imgRate = (imgRateX > imgRateY) ? imgRateX : imgRateY;
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a Picture",
                Filter = "All files (*.*)|*.*",
                Title = "Open Image File"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                initForm();
                img = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                img_origin = new Bitmap(img);
                img_origin_Mat = new Mat(openFileDialog1.FileName);
                StepStack.Clear();
                StepStack.Push(img);

                pictureBox1.Image = img_origin;
                Photo_WH.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image File";
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "All files (*.Jpg)|*.*|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            try
            {
                StepStack.Pop();
            }
            catch { }
            if (StepStack.Count > 0)
            {
                img = StepStack.Pop();
                resultImg.Image = img;
                StepStack.Push(img);
            }
            else if (StepStack.Count == 0)
            {
                StepStack.Push(img_origin);
            }
        }

        private void grayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);

                img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                StepStack.Push(img);
                resultImg.Image = img;

            }
            catch { }
        }
        private void otsuBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            try
            {
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);
            }
            catch { }
            int otsuValue = getOtsu_Kmeans(img, 55, 200);
            otsuLbl.Text = "Value : " + otsuValue;
            Cv2.Threshold(matImg, matImg, otsuValue, 255, 0);
            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            StepStack.Push(img);
            resultImg.Image = img;
        }
        private void thresholdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                Cv2.Threshold(matImg, matImg, Convert.ToDouble(thresholdThresh.Text), 255, 0);
                //Cv2.AdaptiveThreshold(matImg, matImg, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, Convert.ToInt32(thresholdThresh.Text), -1);

                //Binary Not
                //Cv2.BitwiseNot(matImg, matImg);

                img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                StepStack.Push(img);
                resultImg.Image = img;
            }
            catch { }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            //Mat tmpImg = new Mat(matImg, MatType.CV_8UC1);
            //Mat logImg = Mat.Zeros(matImg.Size(), matImg.Type());
            //Cv2.CvtColor(matImg, matImg, ColorConversionCodes.RGB2GRAY);
            //Cv2.Log(matImg, matImg);

            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            StepStack.Push(img);
            resultImg.Image = img;
        }
        private void gammaBtn_Click(object sender, EventArgs e)
        {
            double gamma = Convert.ToDouble(gammaValue.Text);
            Bitmap gammaImg = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int R, G, B;
                    R = (int)(Math.Pow((img.GetPixel(x, y).R) / 255.0, gamma) * 255.0);
                    G = (int)(Math.Pow((img.GetPixel(x, y).G) / 255.0, gamma) * 255.0);
                    B = (int)(Math.Pow((img.GetPixel(x, y).B) / 255.0, gamma) * 255.0);
                    gammaImg.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            img = gammaImg;
            StepStack.Push(img);
            resultImg.Image = img;
        }
        private void equalizeHistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                Cv2.EqualizeHist(matImg, matImg);

                img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                StepStack.Push(img);
                resultImg.Image = img;
            }
            catch { }

        }

        private void meanFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(meanFilterX.Text) % 2 != 0 && Convert.ToInt32(meanFilterY.Text) % 2 != 0)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Cv2.Blur(matImg, matImg
                        , new OpenCvSharp.Size(Convert.ToInt32(meanFilterX.Text), Convert.ToInt32(meanFilterY.Text))
                        , new OpenCvSharp.Point(-1, -1));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }

        }

        private void gaussianBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(gaussianX.Text) % 2 != 0 && Convert.ToInt32(gaussianY.Text) % 2 != 0)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Cv2.GaussianBlur(matImg, matImg
                        , new OpenCvSharp.Size(Convert.ToInt32(gaussianX.Text), Convert.ToInt32(gaussianY.Text))
                        , Convert.ToInt32(gaussianX.Text), Convert.ToInt32(gaussianY.Text));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }

        }


        private void laplacianBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(laplacianKsize.Text) % 2 != 0)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Cv2.Laplacian(matImg, matImg, -1, Convert.ToInt32(laplacianKsize.Text));
                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }

        }

        private void sobelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(sobelKsize.Text) % 2 != 0)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Mat sobelX = new Mat();
                    Mat sobelY = new Mat();
                    Mat sobelAbsX = new Mat();
                    Mat sobelAbsY = new Mat();

                    Cv2.Sobel(matImg, sobelX, -1, 1, 0, Convert.ToInt32(sobelKsize.Text));
                    Cv2.Sobel(matImg, sobelY, -1, 0, 1, Convert.ToInt32(sobelKsize.Text));
                    Cv2.ConvertScaleAbs(sobelX, sobelAbsX, 1.0); //缩放,計算絕對值並將结果轉換為8bit
                    Cv2.ConvertScaleAbs(sobelY, sobelAbsY, 1.0); //缩放,計算絕對值並將结果轉換為8bit
                    Cv2.AddWeighted(sobelAbsX, 0.5, sobelAbsY, 0.5, 0, matImg); //權重相加

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;

                    Cv2.ImShow("X", sobelX);
                    Cv2.ImShow("Y", sobelY);
                    Cv2.WaitKey(0);
                }
            }
            catch { }
        }

        private void cannyBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cannyApertureSize.Text) % 2 != 0)
            {
                if (Cannythreshold1.Enabled == false && Cannythreshold1.Enabled == false)
                {
                    cannyBtn.Text = "Canny（on）";
                    Cannythreshold1.Enabled = Cannythreshold2.Enabled = true;
                }
                else
                {
                    img = cannyImg;
                    StepStack.Push(img);
                    cannyBtn.Text = "Canny（off）";
                    Cannythreshold1.Enabled = Cannythreshold2.Enabled = false;
                }
            }
        }

        private void cannyThresholdScroll(object sender, EventArgs e)
        {
            try
            {
                Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);
            }
            catch { }
            if (Convert.ToInt32(cannyApertureSize.Text) % 2 != 0
                && Cannythreshold1.Value < Cannythreshold2.Value)
            {
                cannyThreshold1Lbl.Text = "T1：" + Cannythreshold1.Value.ToString();
                cannyThreshold2Lbl.Text = "T2：" + Cannythreshold2.Value.ToString();

                Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                Cv2.Canny(matImg, matImg
                    , Cannythreshold1.Value, Cannythreshold2.Value
                    , Convert.ToInt32(cannyApertureSize.Text));
                cannyImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);

                resultImg.Image = cannyImg;
            }
        }

        private void hsvBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            if (hsvLowH.Enabled == false && hsvLowS.Enabled == false && hsvLowV.Enabled == false
                && hsvHighH.Enabled == false && hsvHighS.Enabled == false && hsvHighV.Enabled == false)
            {
                hsvBtn.Text = "HSV（on）";
                try
                {
                    Cv2.CvtColor(matImg, matImg, ColorConversionCodes.GRAY2BGR);
                }
                catch { }
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2HSV);

                img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                resultImg.Image = img;
                StepStack.Push(img);
                hsvHighH.Enabled = hsvHighS.Enabled = hsvHighV.Enabled = true;
                hsvLowV.Enabled = hsvLowS.Enabled = hsvLowH.Enabled = true;
            }
            else
            {
                hsvBtn.Text = "HSV（off）";
                img = hsvImg;
                StepStack.Push(img);
                hsvHighH.Enabled = hsvHighS.Enabled = hsvHighV.Enabled = false;
                hsvLowV.Enabled = hsvLowS.Enabled = hsvLowH.Enabled = false;
            }
        }

        private void hsvThresholdScroll(object sender, EventArgs e)
        {
            hsvHighHLbl.Text = "highH：" + hsvHighH.Value;
            hsvHighSLbl.Text = "highS：" + hsvHighS.Value;
            hsvHighVLbl.Text = "highV：" + hsvHighV.Value;
            hsvLowHLbl.Text = "lowH：" + hsvLowH.Value;
            hsvLowSLbl.Text = "lowS：" + hsvLowS.Value;
            hsvLowVLbl.Text = "lowV：" + hsvLowV.Value;

            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            Cv2.InRange(matImg
                , new Scalar(hsvLowH.Value, hsvLowS.Value, hsvLowV.Value)
                , new Scalar(hsvHighH.Value, hsvHighS.Value, hsvHighV.Value)
                , matImg);

            hsvImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            resultImg.Image = hsvImg;
        }

        private void dilationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dilationSizeW.Text) % 2 == 1 && Convert.ToInt32(dilationSizeH.Text) % 2 == 1)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Mat element = Cv2.GetStructuringElement(MorphShapes.Rect
                                    , new OpenCvSharp.Size(Convert.ToInt32(dilationSizeW.Text), Convert.ToInt32(dilationSizeH.Text)));
                    Cv2.MorphologyEx(matImg, matImg, MorphTypes.Dilate, element
                                    , new OpenCvSharp.Point(-1, -1), Convert.ToInt32(dilationIteration.Text));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }
        }
        private void ErosionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(erosionSizeW.Text) % 2 == 1 && Convert.ToInt32(erosionSizeH.Text) % 2 == 1)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Mat element = Cv2.GetStructuringElement(MorphShapes.Rect
                                    , new OpenCvSharp.Size(Convert.ToInt32(erosionSizeW.Text), Convert.ToInt32(erosionSizeH.Text)));
                    Cv2.MorphologyEx(matImg, matImg, MorphTypes.Erode, element
                                    , new OpenCvSharp.Point(-1, -1), Convert.ToInt32(erosionIteration.Text));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(openSizeW.Text) % 2 == 1 && Convert.ToInt32(openSizeH.Text) % 2 == 1)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Mat element = Cv2.GetStructuringElement(MorphShapes.Rect
                                    , new OpenCvSharp.Size(Convert.ToInt32(openSizeW.Text), Convert.ToInt32(openSizeH.Text)));
                    Cv2.MorphologyEx(matImg, matImg, MorphTypes.Open, element
                                    , new OpenCvSharp.Point(-1, -1), Convert.ToInt32(openIteration.Text));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(closeSizeW.Text) % 2 == 1 && Convert.ToInt32(closeSizeH.Text) % 2 == 1)
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Mat element = Cv2.GetStructuringElement(MorphShapes.Rect
                                    , new OpenCvSharp.Size(Convert.ToInt32(closeSizeW.Text), Convert.ToInt32(closeSizeH.Text)));
                    Cv2.MorphologyEx(matImg, matImg, MorphTypes.Close, element
                                    , new OpenCvSharp.Point(-1, -1), Convert.ToInt32(closeIteration.Text));

                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                    StepStack.Push(img);
                    resultImg.Image = img;
                }
            }
            catch { }
        }

        private void skeletonizationBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            Scalar s = new Scalar(0, 0, 0);
            Mat sketImg = new Mat(img.Height, img.Width, MatType.CV_8UC1, s);
            int morphShapeType = 2;
            if (skltMorphShape.Text == "Rectangle") morphShapeType = 0;
            else if (skltMorphShape.Text == "Cross") morphShapeType = 1;
            Mat element = Cv2.GetStructuringElement((MorphShapes)morphShapeType
                          , new OpenCvSharp.Size(Convert.ToInt32(skltSizeW.Text), Convert.ToInt32(skltSizeH.Text)));
            Mat openImg = new Mat();
            Mat tmpImg = new Mat();
            try
            {
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);
            }
            catch { }
            while (Cv2.CountNonZero(matImg) != 0)
            {
                //open
                Cv2.MorphologyEx(matImg, openImg, MorphTypes.Open, element
                                , new OpenCvSharp.Point(-1, -1));
                //Substract open from the original image
                Cv2.Subtract(matImg, openImg, tmpImg);
                //Erode the original image and refine the skeleton
                Cv2.MorphologyEx(matImg, matImg, MorphTypes.Erode, element, new OpenCvSharp.Point(-1, -1));
                Cv2.BitwiseOr(sketImg, tmpImg, sketImg);
            }
            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(sketImg);
            StepStack.Push(img);
            resultImg.Image = img;
        }

        private void thinningBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            try
            {
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);
            }
            catch { }

            CvXImgProc.Thinning(matImg, matImg, ThinningTypes.ZHANGSUEN);
            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            StepStack.Push(img);
            resultImg.Image = img;
        }

        private void hmBtn_Click(object sender, EventArgs e)
        {
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            int[] ele = new int[9] { 0, 1, 0, 1, -1, 1, 0, 1, 0 };
            Mat element = new Mat(3, 3, MatType.CV_16SC1, ele);
            try
            {
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.BGR2GRAY);
            }
            catch { }

            Cv2.MorphologyEx(matImg, matImg, MorphTypes.HitMiss, element);
            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            StepStack.Push(img);
            resultImg.Image = img;
        }


        bool checkStructureElement(int[,] imgArr, int[,] element, int elementSize)
        {
            bool isSuit;

            for (int i = 0; i < 4; i++)
            {
                isSuit = true;
                for (int x = 0; x < elementSize; x++)
                {
                    for (int y = 0; y < elementSize; y++)
                    {
                        int newX = x, newY = y;
                        switch (i)
                        {
                            case 1:
                                newX = elementSize - 1 - y;
                                newY = x;
                                break;
                            case 2:
                                newX = elementSize - 1 - x;
                                newY = elementSize - 1 - y;
                                break;
                            case 3:
                                newX = y;
                                newY = elementSize - 1 - x;
                                break;
                            default:
                                break;
                        }
                        if (element[newX, newY] != -1 && imgArr[x, y] != element[newX, newY])
                        {
                            isSuit = false;
                            x = y = elementSize + 1;
                        }
                    }
                }
                if (isSuit) return isSuit;
            }
            return false;
        }

        private void prunBtn_Click(object sender, EventArgs e)
        {
            //Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            //Mat X1 = new Mat();
            //Mat X2 = new Mat();
            //Mat X3 = new Mat();

            ////X1 : Thinning
            //CvXImgProc.Thinning(matImg, X1, ThinningTypes.ZHANGSUEN);
            //Cv2.ImShow("X1 : Thinning", X1);

            ////X2 : Hit or Miss (find end point) and Dilate point
            //int[] ele = new int[9] { 0, 1, 0, 1, -1, 1, 0, 1, 0 };
            //Mat element = new Mat(3, 3, MatType.CV_16SC1, ele);
            //Cv2.MorphologyEx(X1, X2, MorphTypes.HitMiss, element);
            //Cv2.ImShow("X2 : Hit or Miss", X2);
            //element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
            //Cv2.MorphologyEx(X2, X2, MorphTypes.Dilate, element, new OpenCvSharp.Point(-1, -1), 3);
            //Cv2.ImShow("X2 : Hit or Miss Dilate", X2);

            ////X3 : 交集 ∩
            //Cv2.BitwiseAnd(matImg, X2, X3);
            //Cv2.ImShow("X3 : ∩", X3);

            ////X4 : Find the union of X1 and X3 ∪
            //Cv2.BitwiseOr(X1, X3, matImg);
            ////Cv2.MorphologyEx(matImg, matImg, MorphTypes.Dilate, element, new OpenCvSharp.Point(-1, -1), 1);
            //img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            //StepStack.Push(img);
            //resultImg.Image = img;

            //Step1 : Thinning 
            Bitmap step1Bmp = new Bitmap(img.Width, img.Height);
            const int elementSize = 3;
            int[,] thinElement1 = new int[elementSize, elementSize]
            //{
            //    { -1, -1, 0,0,0 },
            //    { -1, -1, 0,0,0 },
            //    { 255,255,255,0,0 },
            //    { -1,-1,0,0,0 },
            //    { -1, -1, 0,0,0 }
            //};
            {
                {-1,0,0},
                {255,255,0},
                {-1,0,0}
            };
            int[,] thinElement2 = new int[elementSize, elementSize]
            //{
            //    {-1,0,0,0,0},
            //    {0,255,0,0,0},
            //    {0,0,255,0,0},
            //    {0,0,0,0,0},
            //    {0,0,0,0,0}
            //};
            {
                {255,0,0},
                {0,255,0},
                {0,0,0}
            };
            int[,] thinElement3 = new int[elementSize, elementSize]
            {
                {0,0,0},
                {0,255,0},
                {0,0,0}
            };
            for (int x = 2; x < img.Width - 2; x++)
            {
                for (int y = 2; y < img.Height - 2; y++)
                {
                    if (img.GetPixel(x, y).R == 255)
                    {
                        //Get element
                        int[,] thisElement = new int[elementSize, elementSize];
                        for (int i = -(elementSize / 2); i <= elementSize / 2; i++)
                        {
                            for (int j = -(elementSize / 2); j <= elementSize / 2; j++)
                            {
                                thisElement[i + (elementSize / 2), j + (elementSize / 2)] = img.GetPixel(x + i, y + j).R;
                            }
                        }

                        //Check this pixel is need to be removed or not
                        if (checkStructureElement(thisElement, thinElement1, elementSize) || checkStructureElement(thisElement, thinElement2, elementSize)
                            || checkStructureElement(thisElement, thinElement3, elementSize))
                        {
                            step1Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else
                        {
                            step1Bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                    }
                    else step1Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
            Cv2.ImShow("Thinning", OpenCvSharp.Extensions.BitmapConverter.ToMat(step1Bmp));

            //Step2 : Find End Point
            Bitmap step2Bmp = new Bitmap(img.Width, img.Height);
            //const int elementSize = 3;
            int[,] findEPelement1 = new int[elementSize, elementSize]
            {
                {-1,0,0},
                {255,255,0},
                {-1,0,0}
            };
            int[,] findEPelement2 = new int[elementSize, elementSize]
            {
                {255,-1,0},
                {-1,255,0},
                {0,0,0}
            };

            for (int x = 2; x < img.Width - 2; x++)
            {
                for (int y = 2; y < img.Height - 2; y++)
                {
                    if (img.GetPixel(x, y).R == 255)
                    {
                        //Get element
                        int[,] thisElement = new int[elementSize, elementSize];
                        for (int i = -(elementSize / 2); i <= elementSize / 2; i++)
                        {
                            for (int j = -(elementSize / 2); j <= elementSize / 2; j++)
                            {
                                thisElement[i + (elementSize / 2), j + (elementSize / 2)] = img.GetPixel(x + i, y + j).R;
                            }
                        }
                        //Check this pixel is need to be removed or not
                        if (checkStructureElement(thisElement, findEPelement1, elementSize) || checkStructureElement(thisElement, findEPelement2, elementSize))
                        {
                            step2Bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            step2Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                    else step2Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
            Cv2.ImShow("findEndPoint", OpenCvSharp.Extensions.BitmapConverter.ToMat(step2Bmp));


            //Step3 : Dilation > EP ∩ img
            Bitmap step2BmpDilation = new Bitmap(img.Width, img.Height);
            Bitmap step3Bmp = new Bitmap(img.Width, img.Height);

            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(step2Bmp);
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect
                            , new OpenCvSharp.Size(3, 3));
            Cv2.MorphologyEx(matImg, matImg, MorphTypes.Dilate, element
                            , new OpenCvSharp.Point(-1, -1), 1);
            step2BmpDilation = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
            Cv2.ImShow("Dilation the EndPoint", OpenCvSharp.Extensions.BitmapConverter.ToMat(step2BmpDilation));
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    if (step2BmpDilation.GetPixel(x, y).R == 255 && img.GetPixel(x, y).R == 255)
                        step3Bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else step3Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
            Cv2.ImShow("EndPoint∩img", OpenCvSharp.Extensions.BitmapConverter.ToMat(step3Bmp));

            //Step4 : Thinning∪previous
            Bitmap step4Bmp = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    if (step3Bmp.GetPixel(x, y).R == 255 || step1Bmp.GetPixel(x, y).R == 255)
                        step4Bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else step4Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
            //Cv2.ImShow("Thinning∪previous", OpenCvSharp.Extensions.BitmapConverter.ToMat(step4Bmp));
            img = step4Bmp;
            resultImg.Image = img;
            StepStack.Push(img);
        }

        private void connectedBtn_Click(object sender, EventArgs e)
        {
            Mat labels = new Mat();
            Mat stats = new Mat();
            Mat centroids = new Mat();

            Mat img_src = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            try
            {
                Cv2.CvtColor(img_src, img_src, ColorConversionCodes.RGB2GRAY);
                Cv2.Threshold(img_src, img_src, 0, 255, ThresholdTypes.Binary);
            }
            catch { };

            int total = Cv2.ConnectedComponentsWithStats(img_src, labels, stats, centroids, PixelConnectivity.Connectivity8, MatType.CV_32S);

            Vec3b black = new Vec3b(0, 0, 0);
            Vec3b white = new Vec3b(255, 255, 255);

            Mat img_color = Mat.Zeros(img_src.Size(), MatType.CV_8UC1);
            for (int y = 1; y < img_color.Rows; y++)
            {
                for (int x = 1; x < img_color.Cols; x++)
                {
                    int label = labels.At<int>(y, x);
                    if (0 < label && label <= total)
                    {
                        img_color.Set<Vec3b>(y, x, white);
                        if (stats.At<int>(label, 4) < Convert.ToDouble(connectedArea.Text))
                        {
                            img_color.Set<Vec3b>(y, x, black);
                        }
                    }
                }
            }

            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img_color);
            StepStack.Push(img);
            resultImg.Image = img;
        }

        private void findToolContourBtn_Click(object sender, EventArgs e)
        {
            Mat img_src = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            Mat img_contour = new Mat(img.Height, img.Width,MatType.CV_8UC3);
            img_contour.SetTo(new Scalar(255, 255, 255));
            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchly;

            Cv2.FindContours(img_src, out contours, out hierarchly, RetrievalModes.List, ContourApproximationModes.ApproxSimple, new OpenCvSharp.Point(0, 0));
            double areaMax = 0;
            int targetContourIndex = 0;
            for (int i = 0; i < contours.Length; i++)
            {
                //算面積並標示
                bool isBackground = false;
                for (int p = 0; p < contours[i].Length && isBackground == false; p++)
                {
                    //labelDebug.Text = Convert.ToString(contours[i][p].X);
                    if ((contours[i][p].X < img.Width / 5 && contours[i][p].Y < img.Height / 5) || //左上角
                        (contours[i][p].X < img.Width / 5 && contours[i][p].Y > img.Height / 5 * 4) || //左下角
                        (contours[i][p].X > img.Width / 5 * 4 && contours[i][p].Y < img.Height / 5) || //右上角
                        (contours[i][p].X > img.Width / 5 * 4 && contours[i][p].Y > img.Height / 5 * 4)) //右下角
                    {
                        isBackground = true;
                    }
                }
                double area = Cv2.ContourArea(contours[i], false);
                if (!isBackground && area > areaMax)
                {
                    areaMax = area;
                    targetContourIndex = i;
                }
            }

            //畫輪廓
            Scalar color = new Scalar(0, 0, 255);
            Cv2.DrawContours(img_contour, contours, targetContourIndex, color, img.Width / 400, LineTypes.Link8, hierarchly);
            Cv2.NamedWindow("Contour", WindowMode.Normal);
            Cv2.ImShow("Contour", img_contour);
            //Cv2.ImShow("Contour", img_origin_Mat);
            Cv2.WaitKey(1);
            //試著在原圖上畫輪廓
            Cv2.DrawContours(img_origin_Mat, contours, targetContourIndex, color, img.Width / 400, LineTypes.Link8, hierarchly);
            //如果直接將原圖bmp轉為mat來畫圖的話，畫筆顏色會跑掉

            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img_origin_Mat);
            StepStack.Push(img);
            resultImg.Image = img;
        }


        //繪圖
        private void editImgBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            //將圖像轉為彩色空間以便畫畫
            Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
            try
            {
                Cv2.CvtColor(matImg, matImg, ColorConversionCodes.GRAY2BGR);
            }
            catch { }
            img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);

            //丟給Form2
            form2.getImgfromForm1(img);

            //跳出form2並在form2按下OK按鈕時呼叫form2的取值函式
            if (form2.ShowDialog() == DialogResult.OK)
            {
                img = form2.returnImgfromForm2();
                resultImg.Image = img;
                StepStack.Push(img);
            }
        }

        //裁切圖片
        private void cropImgBtn_Click(object sender, EventArgs e)
        {
            if (!startSelect)
            {
                resultImg.Cursor = Cursors.Cross;
                startSelect = true;
                cropImgBtn.ForeColor = Color.Green;
                selectImgBtn.ForeColor = Color.Black;

                //計算圖片比例與XY邊界
                float imgRateX = (float)img.Width / (float)resultImg.Width;
                float imgRateY = (float)img.Height / (float)resultImg.Height;
                imgRate = (imgRateX > imgRateY) ? imgRateX : imgRateY;
                leftMargin = Math.Abs(resultImg.Width - ((float)img.Width / imgRate)) / 2;
                topMargin = Math.Abs(resultImg.Height - ((float)img.Height / imgRate)) / 2;
            }
            else
            {
                resultImg.Cursor = Cursors.AppStarting;
                startSelect = false;
                isSelecting = false;
                cropImgBtn.ForeColor = Color.Black;
            }
        }

        //選取圖片範圍
        private void selectImgBtn_Click(object sender, EventArgs e)
        {
            if (!startSelect)
            {
                resultImg.Cursor = Cursors.Cross;
                startSelect = true;
                selectImgBtn.ForeColor = Color.Green;
                cropImgBtn.ForeColor = Color.Black;


                //計算圖片比例與XY邊界
                float imgRateX = (float)img.Width / (float)resultImg.Width;
                float imgRateY = (float)img.Height / (float)resultImg.Height;
                imgRate = (imgRateX > imgRateY) ? imgRateX : imgRateY;
                leftMargin = Math.Abs(resultImg.Width - ((float)img.Width / imgRate)) / 2;
                topMargin = Math.Abs(resultImg.Height - ((float)img.Height / imgRate)) / 2;
            }
            else
            {
                resultImg.Cursor = Cursors.AppStarting;
                startSelect = false;
                isSelecting = false;
                selectImgBtn.ForeColor = Color.Black;
            }
        }
        private void resultImg_MouseDown(object sender, MouseEventArgs e)
        {
            float nowX = (e.X - leftMargin) * imgRate;
            float nowY = (e.Y - topMargin) * imgRate;
            if (startSelect 
                && nowX >=0 && nowX <= img.Width
                && nowY >=0 && nowY <= img.Height)
            {
                isSelecting = true;
                selectStartPoint.X = e.X;
                selectStartPoint.Y = e.Y;
                try
                {
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(img);
                    Cv2.CvtColor(matImg, matImg, ColorConversionCodes.GRAY2BGR);
                    img = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matImg);
                }
                catch { }
            }
            else if(selectImgBtn.ForeColor == Color.Green || cropImgBtn.ForeColor == Color.Green)
            {
                startSelect = false;
                selectImgBtn.Enabled = true;
                resultImg.Cursor = Cursors.AppStarting;
                selectImgBtn.ForeColor = cropImgBtn.ForeColor = Color.Black;
                MessageBox.Show("選取範圍請勿超過圖片區域！");
            }
        }
        private void resultImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                OpenCvSharp.Point mouseP = new OpenCvSharp.Point((e.X - leftMargin) * imgRate,
                                                                (e.Y - topMargin) * imgRate);
                OpenCvSharp.Point startP = new OpenCvSharp.Point((selectStartPoint.X - leftMargin) * imgRate
                                                                , (selectStartPoint.Y - topMargin) *imgRate);
                //防止使用者不小心選取超過圖片範圍的終點
                if (mouseP.X < 0) mouseP.X = 0;
                else if (mouseP.X > img.Width) mouseP.X = img.Width;
                if (mouseP.Y < 0) mouseP.Y = 0;
                else if (mouseP.Y > img.Height) mouseP.Y = img.Height;

                int w = Math.Abs(mouseP.X - startP.X);
                int h = Math.Abs(mouseP.Y - startP.Y);
                if(w == 0 || h == 0)
                {
                    MessageBox.Show("範圍長度或寬度不能為 0！");
                }
                else
                {
                    //避免往左上選取防呆
                    if (mouseP.X < startP.X) startP.X = mouseP.X;
                    if (mouseP.Y < startP.Y) startP.Y = mouseP.Y;

                    //裁切圖片
                    Bitmap tmpImg = new Bitmap(img);
                    Rectangle cropArea = new Rectangle((int)(startP.X), (int)(startP.Y)
                                                        , w, h);
                    tmpImg = tmpImg.Clone(cropArea, PixelFormat.Format32bppArgb);

                    if (selectImgBtn.ForeColor == Color.Green)
                    {
                        //試著轉為灰階二值圖像
                        Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(tmpImg);
                        try
                        {
                            Cv2.CvtColor(matImg, matImg, ColorConversionCodes.RGB2GRAY);
                            Cv2.Threshold(matImg, matImg, 127, 255, 0);
                        }
                        catch { }

                        //找輪廓
                        OpenCvSharp.Point[][] contours;
                        HierarchyIndex[] hierarchly;
                        Cv2.FindContours(matImg, out contours, out hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple, new OpenCvSharp.Point(0, 0));

                        //將結果畫出
                        Random rnd = new Random();
                        try
                        {
                            Cv2.CvtColor(matImg, matImg, ColorConversionCodes.GRAY2BGR);
                        }
                        catch { }
                        for (int i = 0; i < contours.Length; i++)
                        {
                            Scalar color = new Scalar(rnd.Next(80, 255), rnd.Next(80, 255), rnd.Next(80, 255));
                            Cv2.DrawContours(matImg, contours, i, color, 2, LineTypes.Link8, hierarchly);

                            OpenCvSharp.Point[] contou = contours[i];
                            double area = Cv2.ContourArea(contours[i], false);
                            Rect rec = Cv2.BoundingRect(contou);

                            Cv2.PutText(matImg, area.ToString(), rec.TopLeft, HersheyFonts.HersheyComplex, 1, color);
                        }

                        //Cv2.ImWrite("tmpImg.jpeg",matImg);
                        Cv2.NamedWindow("test", WindowMode.Normal);
                        Cv2.ImShow("test", matImg);
                        Cv2.WaitKey(1);
                    }
                    else
                    {
                        img = tmpImg;
                        StepStack.Push(img);
                        resultImg.Image = tmpImg;
                    }
                    selectImgBtn.Enabled = true;
                    resultImg.Cursor = Cursors.AppStarting;
                    startSelect = false;
                    isSelecting = false;
                    selectImgBtn.ForeColor = Color.Black;
                    cropImgBtn.ForeColor = Color.Black;
                }

            }
        }
        private void resultImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                Bitmap tmpImg = new Bitmap(img);
                Graphics g = Graphics.FromImage(tmpImg);
                Pen pen = new Pen(Color.Green, 1);
                OpenCvSharp.Point start = new OpenCvSharp.Point(selectStartPoint.X, selectStartPoint.Y);

                if (e.X < selectStartPoint.X) start.X = e.X;
                if (e.Y < selectStartPoint.Y) start.Y = e.Y;
                g.DrawRectangle(pen,  (start.X-leftMargin) * imgRate, (start.Y - topMargin) * imgRate
                                , Math.Abs(e.X - selectStartPoint.X) * imgRate
                                , Math.Abs(e.Y - selectStartPoint.Y) * imgRate);

                resultImg.Image = tmpImg;
                g.Dispose();
            }
        }


    }
}