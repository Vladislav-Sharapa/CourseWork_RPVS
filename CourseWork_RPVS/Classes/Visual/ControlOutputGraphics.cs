using System.Drawing;
using System.Windows.Forms;
using MyLibra;

namespace CourseWork_RPVS {

    class ControlOutputGraphics {
        public bool updating = false;
        public double H { get; set; }
        public double Lx { get; set; } // ось X
        public double Ly { get; set; } // ось Y
        public double Lz { get; set; } // ось Z
        public int Widtth { get; set; } // ширина
        public int Heighht { get; set; } // высота
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public double Z0 { get; set; }
        public double A { get; set; }
        public Function Func { get; set; }
        public Color color { get; set; }

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
            this.Beta += 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateUpClick() {
            while (updating) UpClick();
        }
        private void DownClick() {
            this.Beta -= 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateDownClick() {
            while (updating) DownClick();
        }
        private void RightClick() {
            this.Alpha += 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateRightClick() {
            while (updating) RightClick();
        }
        private void LeftClick() {
            this.Alpha -= 0.00001;
            this.GraphicsScreen.Invalidate();
        }
        public void UpdateLeftClick() {
            while (updating) LeftClick();
        }
        public void ReduceClick() {
            this.H = H - 0.01;
            this.Lx -= 0.1;
            this.Ly -= 0.1;
            this.Lz -= 0.1;
            this.GraphicsScreen.Invalidate();
        }
        public void EnlargeClick() {
            this.H = H + 0.01;
            this.Lx += 0.1;
            this.Ly += 0.1;
            this.Lz += 0.1;
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
            this.H = 0.3;
            this.Lx = 2.6;
            this.Ly = 2.6;
            this.Lz = 2.6;
            this.X0 = 0;
            this.Y0 = 0;
            this.Z0 = 0;
            this.A = -15;
            this.Alpha = 10;
            this.Beta = 12;
            this.XMin = -3;
            this.XMax = 3;
            this.YMin = -3;
            this.YMax = 3;
            this.color = Color.Red;
            this.Widtth = 350;
            this.Heighht = 350;
        }
    }
}
