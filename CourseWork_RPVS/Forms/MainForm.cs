﻿using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork_RPVS {
    public partial class MainForm : Form {

        /// <summary>
        /// <object name="ControlOutputGraphicsObject">объект класса для отображения графики</object>
        /// </summary>
        private ControlOutputGraphics ControlOutputGraphicsObject;
        private Function func;
        // для скриншота области с графиком
        private static PictureBox pictureScreen; 

        public MainForm() {

            InitializeComponent();
            this.func = new FirstFunction();
            this.ControlOutputGraphicsObject = new ControlOutputGraphics(GraphicsScreen);
            ControlOutputGraphics.funcString = firstFunctionRB.Text;
            this.ControlOutputGraphicsObject.SetFunction(func);
            firstFunctionRB.Checked = true;
            pictureScreen = GraphicsScreen;
        }

        private void Function_CheckedChanged(object sender, System.EventArgs e) {
            if (firstFunctionRB.Checked) {
                this.func = new FirstFunction();
                ControlOutputGraphicsObject.SetFunction(func);
                ControlOutputGraphics.funcString = firstFunctionRB.Text;
                System.Console.WriteLine("First");
            }
            else if (secondFunctionRB.Checked) {
                this.func = new SecondFunction();
                ControlOutputGraphicsObject.SetFunction(func);
                ControlOutputGraphics.funcString = secondFunctionRB.Text;
                System.Console.WriteLine("Second");
            }
            else if (thirdFunctionRB.Checked) {
                this.func = new ThirdFunction();
                ControlOutputGraphicsObject.SetFunction(func);
                ControlOutputGraphics.funcString = thirdFunctionRB.Text;
                System.Console.WriteLine("Third");
            }
            GraphicsScreen.Invalidate();
        }
        public static void GetScreenOfGraphics() {
            // запоминаем размеры контрола
            Size szCurrent = pictureScreen.Size;
            //ресайзим контрол до возможного максимума перед скриншотом
            pictureScreen.AutoSize = true;
            //создаем картинку нужных размеров
            Bitmap bitmap = new Bitmap(pictureScreen.Width, pictureScreen.Height);
            //копируем изображение нужного контрола в bmp
            pictureScreen.DrawToBitmap(bitmap, pictureScreen.ClientRectangle);
            //возвращаем изначальные настройки контрола
            pictureScreen.AutoSize = false;
            pictureScreen.Size = szCurrent;

            bitmap.Save(System.IO.Path.GetFullPath("../../Saves/screenshot_01.jpg"), ImageFormat.Jpeg);
        }
        private void GraphicsScreen_Paint(object sender, PaintEventArgs e) {
            Graphics.ShowGraphics(ControlOutputGraphicsObject, e);
        }
        private void Enlarge_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.EnlargeClick();
        }
        private void Reduce_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.ReduceClick();
        }
        private void Up_MouseUp(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = false;
        }
        private void Up_MouseDown(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = true;
            Thread updating = new Thread(ControlOutputGraphicsObject.UpdateUpClick);
            updating.Start();
        }
        private void Down_MouseUp(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = false;
        }
        private void Down_MouseDown(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = true;
            Thread updating = new Thread(ControlOutputGraphicsObject.UpdateDownClick);
            updating.Start();
        }
        private void Right_MouseUp(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = false;
        }
        private void Right_MouseDown(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = true;
            Thread updating = new Thread(ControlOutputGraphicsObject.UpdateRightClick);
            updating.Start();
        }
        private void Left_MouseUp(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = false;
        }
        private void Left_MouseDown(object sender, MouseEventArgs e) {
            ControlOutputGraphicsObject.updating = true;
            Thread updating = new Thread(ControlOutputGraphicsObject.UpdateLeftClick);
            updating.Start();
        }
        private void XUp_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.XUpClick();
        }

        private void XDown_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.XDownClick();
        }
        private void YUp_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.YUpClick();
        }
        private void YDown_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.YDownClick();
        }
        private void ZUp_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.ZYpClick();
        }
        private void ZDown_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.ZDownClick();
        }
        private void AllUp_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.AllUpClick();
        }
        private void AllDown_Click(object sender, System.EventArgs e) {
            ControlOutputGraphicsObject.AllDownClick();
        }
    }
}
