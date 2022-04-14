using System.Runtime.InteropServices;
using System.Text;

namespace CourseWork_RPVS.Classes {
    class INIFile {
        //Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buffer, int size, string path);

        //Импорт функции WritePrivateProfileString (для записи значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern int WritePrivateProfileString(string section, string key, string str, string path);

        public string Path { get; set;}
        private const int SIZE = 1024; //Максимальный размер (для чтения значения из файла)

        public INIFile(string path) {
            this.Path = path;
        }

        // Запись в INI-File
        public void WriteINI(string name, string key, string value) {
            WritePrivateProfileString(name, key, value, this.Path);
        }
        // Чтение из INI-File-а
        public string ReadINI(string name, string key) {
            StringBuilder buffer = new StringBuilder(255);
            int ini = GetPrivateProfileString(name, key, "", buffer, SIZE, this.Path);
            return buffer.ToString();
        }
    }
}
