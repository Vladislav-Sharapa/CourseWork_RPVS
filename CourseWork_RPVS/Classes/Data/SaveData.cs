using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork_RPVS.Classes.Data {
    class SaveData {
        // для сохранения/записи в INI-File
        INIFileManager iniFile;
        public SaveData() { 

        }
        public void SaveDataInINIFile() {
            try {
                iniFile = new INIFileManager(@"D:\Learning\BNTU\Subjects\Курсовая\CourseWork_RPVS\CourseWork_RPVS\DataFile\INIFile.ini");
                iniFile.WriteINI("main", "H", Convert.ToString(ControlOutputGraphics.H));
                iniFile.WriteINI("main", "lx", Convert.ToString(ControlOutputGraphics.Lx));
                iniFile.WriteINI("main", "ly", Convert.ToString(ControlOutputGraphics.Ly));
                iniFile.WriteINI("main", "lz", Convert.ToString(ControlOutputGraphics.Lz));
                iniFile.WriteINI("main", "X_min", Convert.ToString(ControlOutputGraphics.XMin));
                iniFile.WriteINI("main", "X_max", Convert.ToString(ControlOutputGraphics.XMax));
                iniFile.WriteINI("main", "Y_min", Convert.ToString(ControlOutputGraphics.YMin));
                iniFile.WriteINI("main", "Y_max", Convert.ToString(ControlOutputGraphics.YMax));
                iniFile.WriteINI("main", "alfa", Convert.ToString(ControlOutputGraphics.Alpha));
                iniFile.WriteINI("main", "beta", Convert.ToString(ControlOutputGraphics.Beta));
                iniFile.WriteINI("main", "R", Convert.ToString(ControlOutputGraphics.R));
                iniFile.WriteINI("main", "G", Convert.ToString(ControlOutputGraphics.G));
                iniFile.WriteINI("main", "B", Convert.ToString(ControlOutputGraphics.B));
                MessageBox.Show("Сохранение прошло успешно. . .");
            }
            catch {
                MessageBox.Show("Ошибка сохранения. . .");
            }
        }
        public void LoadDataInFile() {
            try {
                iniFile = new INIFileManager(@"D:\Learning\BNTU\Subjects\Курсовая\CourseWork_RPVS\CourseWork_RPVS\DataFile\INIFile.ini");
                ControlOutputGraphics.H = Convert.ToDouble(iniFile.ReadINI("main", "H"));
                ControlOutputGraphics.Lx = Convert.ToDouble(iniFile.ReadINI("main", "lx"));
                ControlOutputGraphics.Ly = Convert.ToDouble(iniFile.ReadINI("main", "ly"));
                ControlOutputGraphics.Lz = Convert.ToDouble(iniFile.ReadINI("main", "lz"));
                ControlOutputGraphics.XMin = Convert.ToDouble(iniFile.ReadINI("main", "X_min"));
                ControlOutputGraphics.XMax = Convert.ToDouble(iniFile.ReadINI("main", "X_max"));
                ControlOutputGraphics.YMin = Convert.ToDouble(iniFile.ReadINI("main", "Y_min"));
                ControlOutputGraphics.YMax = Convert.ToDouble(iniFile.ReadINI("main", "Y_max"));
                ControlOutputGraphics.Alpha = Convert.ToDouble(iniFile.ReadINI("main", "alfa"));
                ControlOutputGraphics.Beta = Convert.ToDouble(iniFile.ReadINI("main", "beta"));
                ControlOutputGraphics.color = Color.FromArgb(Convert.ToInt32(iniFile.ReadINI("main", "R")),
                    Convert.ToInt32(iniFile.ReadINI("main", "G")),
                    Convert.ToInt32(iniFile.ReadINI("main", "B")));
                MessageBox.Show("Загразка прошла успешно . . .");
            }
            catch {
                MessageBox.Show("Ошибка загрузки. . .");
            }
        }
    }
}
