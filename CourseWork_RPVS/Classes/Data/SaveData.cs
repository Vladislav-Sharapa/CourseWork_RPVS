using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CourseWork_RPVS.Classes.Data {
    
    static class SaveData {
        public static string Date { get; set; } // дата последней сессии
        public static string OldFilePath { get; set; } // путь к файла последней сессии
    
        public static string FilePath { get; set; }
        public static string[,] GetDataArray() {
            string[,] DataMassive = {
            {"Function", ControlOutputGraphics.funcString.ToString()},
            {"Coff Lx", ControlOutputGraphics.Lx.ToString()},
            {"Coff Ly", ControlOutputGraphics.Ly.ToString()},
            {"Coff Lz", ControlOutputGraphics.Lz.ToString()},
            {"Coff. alpha", ControlOutputGraphics.Alpha.ToString()},
            {"Coff. beta", ControlOutputGraphics.Beta.ToString()},
            {"Color","(" + (ControlOutputGraphics.R.ToString() +", "+ ControlOutputGraphics.G.ToString() +", "+ ControlOutputGraphics.B.ToString()+ ")").ToString()},
            { "Cord XMin", ControlOutputGraphics.XMin.ToString()},
            { "Cord XMax ", ControlOutputGraphics.XMax.ToString()},
            { "Cord YMin", ControlOutputGraphics.YMin.ToString()},
            { "Cord YMax", ControlOutputGraphics.YMax.ToString()}
                };
            return DataMassive; ;
        }
        public static void RecordDataInDocFile() {
                   
            object missing = Type.Missing;
            object fileName = SaveData.FilePath;
            object f = false;
            object t = true;
            string[,] array = SaveData.GetDataArray();

            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add(Visible: true);

            // вставляем текст
            Word.Paragraph pText = doc.Paragraphs.Add();
            pText.Range.Text = "Таблица данных";
            pText.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            pText.Range.InsertParagraphAfter();

            // вставляем таблицу
            var pTable = doc.Paragraphs.Add();
            Word.Table tbl = doc.Tables.Add(pTable.Range, 11, 2);
            tbl.Borders.Enable = 1;
            for(int i = 0; i < tbl.Rows.Count; i++) {
                for(int j = 0; j <tbl.Columns.Count; j++) {
                    tbl.Cell(i + 1, j + 1).Range.Text = array[i, j];
                }
            }
            pTable.Range.InsertParagraphAfter();

            // добавляем картинку в документ
            var pPicture = doc.Paragraphs.Add();
            pPicture.Range.Text = "График функции двух переменных";
            pPicture.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            pPicture.Range.InsertParagraphAfter();
            pPicture.Format.SpaceBefore = 25f;
            doc.InlineShapes.AddPicture(Path.GetFullPath("../../Saves/screenshot_01.jpg"), Range: pPicture.Range) ;

            object save_changes = false;
            // сохраняем документ по заданному пути
            try {
                doc.SaveAs2(ref fileName, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);
            }
            catch (Exception e) { Console.WriteLine(e);MessageBox.Show("Не удалось сохранить файл, закройте все несохраненные документы "); }
            finally {// закрываем документ
                doc.Close(ref save_changes, ref missing, ref missing);
                app.Quit(ref save_changes, ref missing, ref missing);
            }
        }
        /// <summary>
        /// Метод для создание нового документа
        /// </summary>
        /// <param name="FileNameTextBox">название файла</param>
        /// <param name="Format">расширение файла</param>
        /// <param name="CurrentPath">текущий путь к документу</param>
        public static void CreateFile(TextBox FileNameTextBox, string Format, Label CurrentPath) {
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    try {
                        SaveData.FilePath = fbd.SelectedPath + "\\" + FileNameTextBox.Text + Format;
                        FileStream file = new FileStream(SaveData.FilePath, FileMode.Create);
                        CurrentPath.Text =  "Current path:" + SaveData.FilePath;
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    return;
                }
            }
            Console.WriteLine(SaveData.FilePath);
        }/// <summary>
        /// Метод с OpenFileDialog
        /// </summary>
        /// <param name="CurrentPath"></param>
        public static void OpenDialog(Label CurrentPath) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = @"D:\Learning\BNTU\Subjects\CourseWork\CourseWork_RPVS\CourseWork_RPVS\Saves\";
                openFileDialog.Filter = "docx or excel files (*.docx;*.xlsx)|*.docx;*.xlsx|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    SaveData.FilePath = openFileDialog.FileName;
                    CurrentPath.Text = "Current path:" + SaveData.FilePath;
                }
            }
        }
    }
}
