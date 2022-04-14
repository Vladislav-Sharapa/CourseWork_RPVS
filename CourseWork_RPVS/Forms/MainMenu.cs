using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWork_RPVS.Forms;

namespace CourseWork_RPVS {
    public partial class MainMenu : Form {
        private MainForm mainForm = new MainForm();
        private SaveDataMenu saveDataMenu = new SaveDataMenu();
        private LoadDataMenu loadDataMenu = new LoadDataMenu();

        private Button currentButton;
        private Random random = new Random();
        private int temporaryIndex;
        private Form activeForm;
        public MainMenu() {
            // функция для отображения загрузочного экрана
            SplashScreenShow();
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

        private void graphicButton_Click(object sender, EventArgs e) {
            OpenChildForm(mainForm, sender);
            ShowSubMenu();
        }

        private void saveWordButton_Click(object sender, EventArgs e) {
            activeForm.Visible = false;
            ActiveButton(sender);
            HideSubMenu();
        }

        private void saveExcelButton_Click(object sender, EventArgs e) {
            activeForm.Visible = false;
            ActiveButton(sender);
            HideSubMenu();
        }

        private void saveDataButton_Click(object sender, EventArgs e) {
            activeForm.Visible = false;
            ActiveButton(sender);
            HideSubMenu();
        }

        private void helpButton_Click(object sender, EventArgs e) {
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
                LogoPanel.BackColor = Color.FromArgb(51, 51, 76);
                NameFormPanel.BackColor = Color.FromArgb(51, 51, 76);
                currentButton = (Button)btnSender;
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
