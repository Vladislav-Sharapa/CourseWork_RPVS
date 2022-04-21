
namespace CourseWork_RPVS.Forms {
    partial class SaveInWordMenu {
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
            this.CreateDocFileButton = new System.Windows.Forms.Button();
            this.SaveDocFileButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CurrentPathLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OpenCurrentDocBytton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.SavingLabel = new System.Windows.Forms.Label();
            this.SavingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xlsxRadioButton = new System.Windows.Forms.RadioButton();
            this.docRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SavingPanel.SuspendLayout();
            this.SaveInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDocFileButton
            // 
            this.CreateDocFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateDocFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDocFileButton.Location = new System.Drawing.Point(17, 68);
            this.CreateDocFileButton.Name = "CreateDocFileButton";
            this.CreateDocFileButton.Size = new System.Drawing.Size(152, 44);
            this.CreateDocFileButton.TabIndex = 0;
            this.CreateDocFileButton.Text = "Create";
            this.CreateDocFileButton.UseVisualStyleBackColor = true;
            this.CreateDocFileButton.Click += new System.EventHandler(this.CreateDocFileButton_Click);
            // 
            // SaveDocFileButton
            // 
            this.SaveDocFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDocFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDocFileButton.Location = new System.Drawing.Point(721, 389);
            this.SaveDocFileButton.Name = "SaveDocFileButton";
            this.SaveDocFileButton.Size = new System.Drawing.Size(152, 44);
            this.SaveDocFileButton.TabIndex = 1;
            this.SaveDocFileButton.Text = "Save";
            this.SaveDocFileButton.UseVisualStyleBackColor = true;
            this.SaveDocFileButton.Click += new System.EventHandler(this.SaveDocFileButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(17, 40);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(152, 22);
            this.FileNameTextBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CurrentPathLabel
            // 
            this.CurrentPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentPathLabel.AutoSize = true;
            this.CurrentPathLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrentPathLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurrentPathLabel.Location = new System.Drawing.Point(51, 492);
            this.CurrentPathLabel.Name = "CurrentPathLabel";
            this.CurrentPathLabel.Size = new System.Drawing.Size(97, 19);
            this.CurrentPathLabel.TabIndex = 4;
            this.CurrentPathLabel.Text = "Current path: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(127, 12);
            this.progressBar1.TabIndex = 5;
            // 
            // OpenCurrentDocBytton
            // 
            this.OpenCurrentDocBytton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenCurrentDocBytton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCurrentDocBytton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenCurrentDocBytton.Location = new System.Drawing.Point(544, 389);
            this.OpenCurrentDocBytton.Name = "OpenCurrentDocBytton";
            this.OpenCurrentDocBytton.Size = new System.Drawing.Size(152, 44);
            this.OpenCurrentDocBytton.TabIndex = 7;
            this.OpenCurrentDocBytton.Text = "Open current doc";
            this.OpenCurrentDocBytton.UseVisualStyleBackColor = true;
            this.OpenCurrentDocBytton.Click += new System.EventHandler(this.OpenCurrentDocBytton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 266);
            this.dataGridView1.TabIndex = 9;
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenDialogButton.Location = new System.Drawing.Point(386, 389);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(152, 44);
            this.OpenDialogButton.TabIndex = 10;
            this.OpenDialogButton.Text = "Open";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // SavingLabel
            // 
            this.SavingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavingLabel.Location = new System.Drawing.Point(3, 18);
            this.SavingLabel.Name = "SavingLabel";
            this.SavingLabel.Size = new System.Drawing.Size(76, 24);
            this.SavingLabel.TabIndex = 11;
            this.SavingLabel.Text = "Saving . . . ";
            // 
            // SavingPanel
            // 
            this.SavingPanel.Controls.Add(this.progressBar1);
            this.SavingPanel.Controls.Add(this.SavingLabel);
            this.SavingPanel.Location = new System.Drawing.Point(721, 439);
            this.SavingPanel.Name = "SavingPanel";
            this.SavingPanel.Size = new System.Drawing.Size(152, 48);
            this.SavingPanel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last session";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(236, 89);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(42, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "File path:";
            // 
            // SaveInformation
            // 
            this.SaveInformation.Controls.Add(this.label2);
            this.SaveInformation.Controls.Add(this.label4);
            this.SaveInformation.Controls.Add(this.label3);
            this.SaveInformation.Controls.Add(this.textBox1);
            this.SaveInformation.Location = new System.Drawing.Point(46, 51);
            this.SaveInformation.Name = "SaveInformation";
            this.SaveInformation.Size = new System.Drawing.Size(316, 266);
            this.SaveInformation.TabIndex = 18;
            this.SaveInformation.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CreateDocFileButton);
            this.groupBox1.Controls.Add(this.FileNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(46, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 134);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xlsxRadioButton);
            this.groupBox2.Controls.Add(this.docRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(179, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(69, 79);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // xlsxRadioButton
            // 
            this.xlsxRadioButton.AutoSize = true;
            this.xlsxRadioButton.Location = new System.Drawing.Point(7, 45);
            this.xlsxRadioButton.Name = "xlsxRadioButton";
            this.xlsxRadioButton.Size = new System.Drawing.Size(55, 21);
            this.xlsxRadioButton.TabIndex = 21;
            this.xlsxRadioButton.TabStop = true;
            this.xlsxRadioButton.Text = ".xlsx";
            this.xlsxRadioButton.UseVisualStyleBackColor = true;
            // 
            // docRadioButton
            // 
            this.docRadioButton.AutoSize = true;
            this.docRadioButton.Location = new System.Drawing.Point(7, 18);
            this.docRadioButton.Name = "docRadioButton";
            this.docRadioButton.Size = new System.Drawing.Size(56, 21);
            this.docRadioButton.TabIndex = 20;
            this.docRadioButton.TabStop = true;
            this.docRadioButton.Text = ".doc";
            this.docRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveInWordMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveInformation);
            this.Controls.Add(this.SavingPanel);
            this.Controls.Add(this.OpenDialogButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpenCurrentDocBytton);
            this.Controls.Add(this.CurrentPathLabel);
            this.Controls.Add(this.SaveDocFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveInWordMenu";
            this.Text = "Word Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SavingPanel.ResumeLayout(false);
            this.SaveInformation.ResumeLayout(false);
            this.SaveInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDocFileButton;
        private System.Windows.Forms.Button SaveDocFileButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label CurrentPathLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button OpenCurrentDocBytton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OpenDialogButton;
        private System.Windows.Forms.Label SavingLabel;
        private System.Windows.Forms.Panel SavingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SaveInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton docRadioButton;
        private System.Windows.Forms.RadioButton xlsxRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}