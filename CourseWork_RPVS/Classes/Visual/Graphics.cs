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
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            MyLibra.Calculate.Zoom_XY(ControlOutputGraphics.Lx, 0, 0, out xx2, out yy2, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("X", font, b, xx2 + 3, yy2);

            // ось Y
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            MyLibra.Calculate.Zoom_XY(0, ControlOutputGraphics.Ly, 0, out xx2, out yy2, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("Y", font, b, xx2 + 3, yy2);

            // ось Z
            MyLibra.Calculate.Zoom_XY(0, 0, 0, out xx1, out yy1, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            MyLibra.Calculate.Zoom_XY(0, 0, ControlOutputGraphics.Lz, out xx2, out yy2, obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin,
                ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
            e.Graphics.DrawLine(p, xx1, yy1, xx2, yy2);
            e.Graphics.DrawString("Z", font, b, xx2 , yy2 - 3);

            // рисование поверхности
            Pen p1 = new Pen(ControlOutputGraphics.color);
            p1.Width = 1;
            for (j = 0; j <= 9; j++)
                for (i = 0; i <= 9; i++) {
                    MyLibra.Calculate.Zoom_XY(h0 + ControlOutputGraphics.H * i, h0 + ControlOutputGraphics.H * j, obj.Func.GetFunction(h0 + ControlOutputGraphics.H * i, h0 + ControlOutputGraphics.H * j),
                            out xx[0], out yy[0], obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin, ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
                    MyLibra.Calculate.Zoom_XY(h0 + ControlOutputGraphics.H * i, ControlOutputGraphics.H + ControlOutputGraphics.H * j, obj.Func.GetFunction(h0 + ControlOutputGraphics.H * i, ControlOutputGraphics.H + ControlOutputGraphics.H * j),
                            out xx[1], out yy[1], obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin, ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
                    MyLibra.Calculate.Zoom_XY(ControlOutputGraphics.H + ControlOutputGraphics.H * i, ControlOutputGraphics.H + ControlOutputGraphics.H * j, obj.Func.GetFunction(ControlOutputGraphics.H + ControlOutputGraphics.H * i, ControlOutputGraphics.H + ControlOutputGraphics.H * j),
                            out xx[2], out yy[2], obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin, ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
                    MyLibra.Calculate.Zoom_XY(ControlOutputGraphics.H + ControlOutputGraphics.H * i, h0 + ControlOutputGraphics.H * j, obj.Func.GetFunction(ControlOutputGraphics.H + ControlOutputGraphics.H * i, h0 + ControlOutputGraphics.H * j),
                            out xx[3], out yy[3], obj.Widtth, obj.Heighht, ControlOutputGraphics.XMin, ControlOutputGraphics.XMax, ControlOutputGraphics.YMin, ControlOutputGraphics.YMax, obj.X0, obj.Y0, obj.Z0, obj.A, ControlOutputGraphics.Alpha, ControlOutputGraphics.Beta);
                    e.Graphics.DrawLine(p1, xx[0], yy[0], xx[1], yy[1]);
                    e.Graphics.DrawLine(p1, xx[1], yy[1], xx[2], yy[2]);
                    e.Graphics.DrawLine(p1, xx[2], yy[2], xx[3], yy[3]);
                    e.Graphics.DrawLine(p1, xx[3], yy[3], xx[0], yy[0]);
                }
        }
    }
}
