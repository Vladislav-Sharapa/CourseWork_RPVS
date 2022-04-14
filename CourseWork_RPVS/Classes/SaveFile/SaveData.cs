

namespace CourseWork_RPVS.Classes.SaveFile {
    class SaveData {
        // для сохранения/записи в INI-File
        INIFile iniFile;
        ControlOutputGraphics data;
        public SaveData(ControlOutputGraphics data) {
            this.data = data;
        }
    }
}
