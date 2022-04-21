
namespace CourseWork_RPVS {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NameFormPanel = new System.Windows.Forms.Panel();
            this.PageName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DesktopPanel = new System.Windows.Forms.PictureBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoPhoto = new System.Windows.Forms.PictureBox();
            this.graphicButton = new System.Windows.Forms.Button();
            this.GraphicSubMenu = new System.Windows.Forms.Panel();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.saveWordButton = new System.Windows.Forms.Button();
            this.NameFormPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesktopPanel)).BeginInit();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPhoto)).BeginInit();
            this.GraphicSubMenu.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameFormPanel
            // 
            this.NameFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.NameFormPanel.Controls.Add(this.PageName);
            this.NameFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameFormPanel.Location = new System.Drawing.Point(209, 0);
            this.NameFormPanel.Name = "NameFormPanel";
            this.NameFormPanel.Size = new System.Drawing.Size(885, 88);
            this.NameFormPanel.TabIndex = 1;
            // 
            // PageName
            // 
            this.PageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageName.AutoSize = true;
            this.PageName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PageName.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PageName.Location = new System.Drawing.Point(374, 31);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(103, 32);
            this.PageName.TabIndex = 0;
            this.PageName.Text = "HOME";
            this.PageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.DesktopPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(209, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 544);
            this.panel1.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(12, 7);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseButton.Size = new System.Drawing.Size(35, 32);
            this.CloseButton.TabIndex = 36;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DesktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Image = ((System.Drawing.Image)(resources.GetObject("DesktopPanel.Image")));
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(885, 544);
            this.DesktopPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DesktopPanel.TabIndex = 0;
            this.DesktopPanel.TabStop = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.LogoPanel.Controls.Add(this.LogoPhoto);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(209, 88);
            this.LogoPanel.TabIndex = 1;
            // 
            // LogoPhoto
            // 
            this.LogoPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPhoto.Image = ((System.Drawing.Image)(resources.GetObject("LogoPhoto.Image")));
            this.LogoPhoto.Location = new System.Drawing.Point(0, 0);
            this.LogoPhoto.Name = "LogoPhoto";
            this.LogoPhoto.Size = new System.Drawing.Size(209, 88);
            this.LogoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPhoto.TabIndex = 0;
            this.LogoPhoto.TabStop = false;
            // 
            // graphicButton
            // 
            this.graphicButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphicButton.FlatAppearance.BorderSize = 0;
            this.graphicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.graphicButton.Image = ((System.Drawing.Image)(resources.GetObject("graphicButton.Image")));
            this.graphicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphicButton.Location = new System.Drawing.Point(0, 88);
            this.graphicButton.Name = "graphicButton";
            this.graphicButton.Size = new System.Drawing.Size(209, 72);
            this.graphicButton.TabIndex = 2;
            this.graphicButton.Text = "Graphic";
            this.graphicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.graphicButton.UseVisualStyleBackColor = true;
            this.graphicButton.Click += new System.EventHandler(this.GraphicButton_Click);
            // 
            // GraphicSubMenu
            // 
            this.GraphicSubMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.GraphicSubMenu.Controls.Add(this.ChangeColorButton);
            this.GraphicSubMenu.Controls.Add(this.SaveData);
            this.GraphicSubMenu.Controls.Add(this.LoadData);
            this.GraphicSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.GraphicSubMenu.Location = new System.Drawing.Point(0, 160);
            this.GraphicSubMenu.Name = "GraphicSubMenu";
            this.GraphicSubMenu.Size = new System.Drawing.Size(209, 188);
            this.GraphicSubMenu.TabIndex = 7;
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeColorButton.FlatAppearance.BorderSize = 0;
            this.ChangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColorButton.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeColorButton.Image")));
            this.ChangeColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeColorButton.Location = new System.Drawing.Point(0, 122);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ChangeColorButton.Size = new System.Drawing.Size(209, 61);
            this.ChangeColorButton.TabIndex = 43;
            this.ChangeColorButton.Text = "Color";
            this.ChangeColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // SaveData
            // 
            this.SaveData.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveData.FlatAppearance.BorderSize = 0;
            this.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveData.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveData.Image = ((System.Drawing.Image)(resources.GetObject("SaveData.Image")));
            this.SaveData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveData.Location = new System.Drawing.Point(0, 61);
            this.SaveData.Name = "SaveData";
            this.SaveData.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SaveData.Size = new System.Drawing.Size(209, 61);
            this.SaveData.TabIndex = 42;
            this.SaveData.Text = "Save Data";
            this.SaveData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadData.FlatAppearance.BorderSize = 0;
            this.LoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadData.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadData.Image = ((System.Drawing.Image)(resources.GetObject("LoadData.Image")));
            this.LoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadData.Location = new System.Drawing.Point(0, 0);
            this.LoadData.Name = "LoadData";
            this.LoadData.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.LoadData.Size = new System.Drawing.Size(209, 61);
            this.LoadData.TabIndex = 41;
            this.LoadData.Text = "Load save";
            this.LoadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.navigationPanel.Controls.Add(this.helpButton);
            this.navigationPanel.Controls.Add(this.saveExcelButton);
            this.navigationPanel.Controls.Add(this.saveWordButton);
            this.navigationPanel.Controls.Add(this.GraphicSubMenu);
            this.navigationPanel.Controls.Add(this.graphicButton);
            this.navigationPanel.Controls.Add(this.LogoPanel);
            this.navigationPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(209, 632);
            this.navigationPanel.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(0, 492);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(209, 72);
            this.helpButton.TabIndex = 10;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // saveExcelButton
            // 
            this.saveExcelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveExcelButton.FlatAppearance.BorderSize = 0;
            this.saveExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveExcelButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveExcelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("saveExcelButton.Image")));
            this.saveExcelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveExcelButton.Location = new System.Drawing.Point(0, 420);
            this.saveExcelButton.Name = "saveExcelButton";
            this.saveExcelButton.Size = new System.Drawing.Size(209, 72);
            this.saveExcelButton.TabIndex = 9;
            this.saveExcelButton.Text = "Save Excel";
            this.saveExcelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveExcelButton.UseVisualStyleBackColor = true;
            this.saveExcelButton.Click += new System.EventHandler(this.SaveExcelButton_Click);
            // 
            // saveWordButton
            // 
            this.saveWordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveWordButton.FlatAppearance.BorderSize = 0;
            this.saveWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWordButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveWordButton.Image = ((System.Drawing.Image)(resources.GetObject("saveWordButton.Image")));
            this.saveWordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveWordButton.Location = new System.Drawing.Point(0, 348);
            this.saveWordButton.Name = "saveWordButton";
            this.saveWordButton.Size = new System.Drawing.Size(209, 72);
            this.saveWordButton.TabIndex = 8;
            this.saveWordButton.Text = "Save Word";
            this.saveWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveWordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveWordButton.UseVisualStyleBackColor = true;
            this.saveWordButton.Click += new System.EventHandler(this.SaveWordButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1094, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameFormPanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicCAD";
            this.NameFormPanel.ResumeLayout(false);
            this.NameFormPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DesktopPanel)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPhoto)).EndInit();
            this.GraphicSubMenu.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NameFormPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.PictureBox DesktopPanel;
        public System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoPhoto;
        private System.Windows.Forms.Button graphicButton;
        private System.Windows.Forms.Panel GraphicSubMenu;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button saveExcelButton;
        private System.Windows.Forms.Button saveWordButton;
        private System.Windows.Forms.Button ChangeColorButton;
    }
}