using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWork_RPVS.Forms;
using CourseWork_RPVS.Classes.Data;

namespace CourseWork_RPVS {
    public partial class MainMenu : Form {
        private MainForm mainForm = new MainForm();
        private LoadDataMenu loadDataMenu = new LoadDataMenu();
        private SaveInWordMenu saveInWordMenu = new SaveInWordMenu();
        private SaveInExcelMenu saveInExcelMenu = new SaveInExcelMenu();
        // для сохранения данных
        private SaveConfig save = new SaveConfig();

        // для изменения цвета кнопок
        private Button currentButton;
        private Random random = new Random();
        private int temporaryIndex;
        // для переключения форм
        private Form activeForm;
        public MainMenu() {
            // функция для отображения загрузочного экрана
            //SplashScreenShow();
            InitializeComponent();
            CustomizeDesign();
        }

        /// <summary>
        /// метод, в котором инициализируем SplashForm (загрузочный экран)
        /// </summary>
        private void SplashScreenShow() {
            SplashScreen newForm = new SplashScreen();
            newForm.ShowDialog();
        }
        // случайно выбираем цвет из списка ColorList
        private Color SelectThemeColor() {
            int indexOfColor = random.Next(ThemeColor.colorList.Count);
            string color;
            while (temporaryIndex == indexOfColor) {
                indexOfColor = random.Next(ThemeColor.colorList.Count);
            }
            temporaryIndex = indexOfColor;
            color = ThemeColor.colorList[indexOfColor];
            return ColorTranslator.FromHtml(color);
        }
        // изменяем внешний вид выбранной кнопки
        private void ActiveButton(object btnSender) {
            if (btnSender != null) {
                if (currentButton != (Button)btnSender) {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Cooper Black", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    NameFormPanel.BackColor = color;
                    LogoPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.5);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton() {
            foreach(Control previosButton in navigationPanel.Controls) {
                if(previosButton.GetType()== typeof(Button)) {
                    previosButton.BackColor = Color.FromArgb(51, 51, 76);
                    previosButton.ForeColor = Color.Gainsboro;
                    previosButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object buttonSender) {
            if (activeForm != null) activeForm.Visible = false;
            ActiveButton(buttonSender);
            this.CloseButton.Visible = true;  // turn on close button on MainMenuForm
            //this.CloseButton.BackColor = ThemeColor.PrimaryColor; 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            PageName.Text = childForm.Text;
        }
        private void CustomizeDesign() {
            GraphicSubMenu.Visible = false;
        }
        private void HideSubMenu() {
            if (GraphicSubMenu.Visible)
                GraphicSubMenu.Visible = false;
        }
        private void ShowSubMenu() {
            if (!GraphicSubMenu.Visible)
                GraphicSubMenu.Visible = true;
            GraphicSubMenu.BackColor = ThemeColor.SecondaryColor;
        }

        private void GraphicButton_Click(object sender, EventArgs e) {
            OpenChildForm(mainForm, sender);
            ShowSubMenu();
        }

        private void SaveWordButton_Click(object sender, EventArgs e) {
            OpenChildForm(saveInWordMenu, sender);
            HideSubMenu();
        }

        private void SaveExcelButton_Click(object sender, EventArgs e) {
            OpenChildForm(saveInExcelMenu, sender);
            HideSubMenu();
        }

        private void SaveDataButton_Click(object sender, EventArgs e) {
            activeForm.Visible = false;
            ActiveButton(sender);
            HideSubMenu();
        }
        private void HelpButton_Click(object sender, EventArgs e) {
            activeForm.Visible = false;
            ActiveButton(sender);
            HideSubMenu();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            DisplayStandartColorTheme(sender);
            activeForm.Visible = false;
            CloseButton.Visible = false;
            HideSubMenu();
            PageName.Text = "HOME";
        }
        private void DisplayStandartColorTheme(object btnSender) {
            if (CloseButton.Visible) {
                DisableButton();
                LogoPanel.BackColor = Color.FromArgb(39, 39, 58);
                NameFormPanel.BackColor = Color.FromArgb(51, 51, 76);
                currentButton = (Button)btnSender;
            }
        }
        private void LoadData_Click(object sender, EventArgs e) {
            save.LoadDataInFile();
            mainForm.GraphicsScreen.Invalidate();
        }
        private void SaveData_Click(object sender, EventArgs e) {
            save.SaveDataInINIFile();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e) {
            ChangeColorForm colorForm = new ChangeColorForm();
            colorForm.ShowDialog();
            mainForm.GraphicsScreen.Invalidate();
        }
    }
}
