using System.Drawing;
using System.Windows.Forms;
using MyLibra;

namespace CourseWork_RPVS {

    class ControlOutputGraphics {
        public bool updating = false;
        public static double H { get; set; }
        public static double Lx { get; set; } // ось X
        public static double Ly { get; set; } // ось Y
        public static double Lz { get; set; } // ось Z
        public int Widtth { get; set; } // ширина
        public int Heighht { get; set; } // высота
        public static double XMin { get; set; }
        public static double XMax { get; set; }
        public static double YMin { get; set; }
        public static double YMax { get; set; }
        public static double Alpha { get; set; }
        public static double Beta { get; set; }
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public double Z0 { get; set; }
        public double A { get; set; }
        public Function Func { get; set; }
        public static Color color { get; set; }
        public static int R { get; set; }
        public static int G { get; set; }
        public static int B { get; set; }

        public PictureBox GraphicsScreen { get; set; }

        /// <summary>
        /// Конструктор класса ControlOutputGraphics
        /// </summary>
        /// <param name="GraphicsScreen">ссылка на объект pictureBox в MainForm</param>
        public ControlOutputGraphics(PictureBox GraphicsScreen) {
            InitializeVariables();
            this.GraphicsScreen = GraphicsScreen;
        }

        private void UpClick() {
            ControlOutputGraphics.Beta += 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateUpClick() {
            while (updating) UpClick();
        }
        private void DownClick() {
            ControlOutputGraphics.Beta -= 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateDownClick() {
            while (updating) DownClick();
        }
        private void RightClick() {
            ControlOutputGraphics.Alpha -= 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateRightClick() {
            while (updating) RightClick();
        }
        private void LeftClick() {
            ControlOutputGraphics.Alpha += 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateLeftClick() {
            while (updating) LeftClick();
        }
        public void ReduceClick() {
            ControlOutputGraphics.H = H - 0.01;
            ControlOutputGraphics.Lx -= 0.1;
            ControlOutputGraphics.Ly -= 0.1;
            ControlOutputGraphics.Lz -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void EnlargeClick() {
            ControlOutputGraphics.H = H + 0.01;
            ControlOutputGraphics.Lx += 0.1;
            ControlOutputGraphics.Ly += 0.1;
            ControlOutputGraphics.Lz += 0.1;
            this.GraphicsScreen.Invalidate();
        }

        public void XUpClick() {
            this.X0 -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void XDownClick() {
            this.X0 += 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void YUpClick() {
            this.Y0 -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void YDownClick() {
            this.Y0 += 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void ZYpClick() {
            this.Z0 -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void ZDownClick() {
            this.Z0 += 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void AllUpClick() {
            this.Z0 -= 0.1;
            this.Y0 -= 0.1;
            this.X0 -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void AllDownClick() {
            this.Z0 += 0.1;
            this.Y0 += 0.1;
            this.X0 += 0.1;
            this.GraphicsScreen.Invalidate();
        }
        
        /// <summary>
        /// устанавливаем объект класса Function
        /// </summary>
        /// <param name="func">функция, которую мы выбрали с помощью RadioButton</param>
        public void SetFunction(Function func) {
            this.Func = func;
        }

        /// <summary>
        /// инициализируем переменные 
        /// </summary>
        private void InitializeVariables() {
            ControlOutputGraphics.H = 0.3;
            ControlOutputGraphics.Lx = 2.6;
            ControlOutputGraphics.Ly = 2.6;
            ControlOutputGraphics.Lz = 2.6;
            this.X0 = 0;
            this.Y0 = 0;
            this.Z0 = 0;
            this.A = -15;
            ControlOutputGraphics.Alpha = 10;
            ControlOutputGraphics.Beta = 12;
            ControlOutputGraphics.XMin = -3;
            ControlOutputGraphics.XMax = 3;
            ControlOutputGraphics.YMin = -3;
            ControlOutputGraphics.YMax = 3;
            ControlOutputGraphics.R = 255;
            ControlOutputGraphics.G = 0;
            ControlOutputGraphics.B = 0;
            ControlOutputGraphics.color = Color.FromArgb(R,G,B);
            this.Widtth = 350;
            this.Heighht = 350;
        }
    }
}
