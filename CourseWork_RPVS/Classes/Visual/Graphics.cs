using System.Drawing;
using System.Windows.Forms;
using MyLibra;

namespace CourseWork_RPVS {

    /// <summary>
    /// отображение графики на pictureBox
    /// </summary>
    class Graphics {
        internal static void ShowGraphics(ControlOutputGraphics obj, PaintEventArgs e) {

            int xx1, xx2, yy1, yy2;
            int[] xx = new int[4];
            int[] yy = new int[4];
            const double h0 = 0;

            int i, j;

            Pen p = new Pen(Color.Black);
            Font font = new Font("Courier New", 12, FontStyle.Bold);
            SolidBrush b = new SolidBrush(Color.Blue);

            // рисование осей
            // ось X
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            MyLibra.Calculate.Zoom_XY(obj.Lx, 0, 0, out xx2, out yy2, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("X", font, b, xx2 + 3, yy2);

            // ось Y
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            MyLibra.Calculate.Zoom_XY(0, obj.Ly, 0, out xx2, out yy2, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("Y", font, b, xx2 + 3, yy2);

            // ось Z
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            MyLibra.Calculate.Zoom_XY(0, 0, obj.Lz, out xx2, out yy2, obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("Z", font, b, xx2 , yy2 - 3);

            // рисование поверхности
            Pen p1 = new Pen(Color.Red);
            p1.Width = 1;
            for (j = 0; j <= 9; j++)
                for (i = 0; i <= 9; i++) {
                    MyLibra.Calculate.Zoom_XY(h0 + obj.H * i, h0 + obj.H * j, obj.Func.GetFunction(h0 + obj.H * i, h0 + obj.H * j),
                            out xx[0], out yy[0], obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
                    MyLibra.Calculate.Zoom_XY(h0 + obj.H * i, obj.H + obj.H * j, obj.Func.GetFunction(h0 + obj.H * i, obj.H + obj.H * j),
                            out xx[1], out yy[1], obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
                    MyLibra.Calculate.Zoom_XY(obj.H + obj.H * i, obj.H + obj.H * j, obj.Func.GetFunction(obj.H + obj.H * i, obj.H + obj.H * j),
                            out xx[2], out yy[2], obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
                    MyLibra.Calculate.Zoom_XY(obj.H + obj.H * i, h0 + obj.H * j, obj.Func.GetFunction(obj.H + obj.H * i, h0 + obj.H * j),
                            out xx[3], out yy[3], obj.Widtth, obj.Heighht, obj.XMin, obj.XMax, obj.YMin, obj.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, obj.Alpha, obj.Beta);
                    e.Graphics.DrawLine(p1, xx[0], yy[0], xx[1], yy[1]);
                    e.Graphics.DrawLine(p1, xx[1], yy[1], xx[2], yy[2]);
                    e.Graphics.DrawLine(p1, xx[2], yy[2], xx[3], yy[3]);
                    e.Graphics.DrawLine(p1, xx[3], yy[3], xx[0], yy[0]);
                }
        }
    }
}
