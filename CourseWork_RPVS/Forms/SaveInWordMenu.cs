using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using CourseWork_RPVS.Classes.Data;
using Word = Microsoft.Office.Interop.Word;

namespace CourseWork_RPVS.Forms {
    public partial class SaveInWordMenu : Form {
        public SaveInWordMenu() {
            InitializeComponent();
            SaveData.FilePath = Path.GetFullPath("../../Saves/word.docx");
            CurrentPathLabel.Text = "Current path:" + SaveData.FilePath; // текущий путь к файлу
            SavingPanel.Visible = false;
            SaveConfig.LoadSession(); // загружаем данные о последней сессии 
            label3.Text = "Date: " + SaveData.Date; // дата последней сессии 
            textBox1.Text = SaveData.OldFilePath; // путь к файлу от последней сессии
            docRadioButton.Checked = true;
        }
        private void CreateDocFileButton_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(FileNameTextBox.Text))
                MessageBox.Show("Введите название файла. . .");
            else
                if (docRadioButton.Checked)
                    SaveData.CreateFile(FileNameTextBox, ".docx", CurrentPathLabel);
                else
                    SaveData.CreateFile(FileNameTextBox, ".xlsx", CurrentPathLabel);
        }
        
        private void SaveDocFileButton_Click(object sender, System.EventArgs e) {
            if (Path.GetExtension(SaveData.FilePath) != ".docx") MessageBox.Show("Выберите файл формата [.docx]");
            else {
                try {
                    SavingPanel.Visible = true;
                    Thread saving = new Thread(SaveData.RecordDataInDocFile);
                    MainForm.GetScreenOfGraphics(); // статический метод. Класс MainForm
                    saving.Start();
                    while (saving.IsAlive) {
                        progressBar1.Increment(1);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
                SetDataGridView();
                SetSaveInformation();
                SavingPanel.Visible = false;
                progressBar1.Value = 0;
            }
        }
        private void OpenDialogButton_Click(object sender, EventArgs e) {
            SaveData.OpenDialog(CurrentPathLabel);
        }

        private void OpenCurrentDocBytton_Click(object sender, EventArgs e) {
            var application = new Word.Application();
            var document = new Word.Document();
            document = application.Documents.Add(Template: SaveData.FilePath);
            application.Visible = true;
        }
        private void SetDataGridView() {
            string[,] array = SaveData.GetDataArray();
            DataGridView newData = new DataGridView();

            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 11;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Data";

            for (int i = 0; i < dataGridView1.RowCount; i++) {
                dataGridView1.Rows[i].Cells[0].Value = array[i, 0];
            }
            for (int i = 0; i < dataGridView1.RowCount; i++) {
                dataGridView1.Rows[i].Cells[1].Value = array[i, 1];
            }
        }
        private void SetSaveInformation() {
            SaveData.Date = DateTime.Now.ToString();
            label3.Text = "Data: " + SaveData.Date;
            textBox1.Text = SaveData.FilePath;
            try {
                SaveConfig.SaveSession();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}
