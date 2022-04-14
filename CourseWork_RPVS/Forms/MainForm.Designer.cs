
namespace CourseWork_RPVS {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.GraphicsScreen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thirdFunctionRB = new System.Windows.Forms.RadioButton();
            this.secondFunctionRB = new System.Windows.Forms.RadioButton();
            this.firstFunctionRB = new System.Windows.Forms.RadioButton();
            this.AllDown = new System.Windows.Forms.Button();
            this.ZUp = new System.Windows.Forms.Button();
            this.ZDown = new System.Windows.Forms.Button();
            this.YUp = new System.Windows.Forms.Button();
            this.YDown = new System.Windows.Forms.Button();
            this.XUp = new System.Windows.Forms.Button();
            this.XDown = new System.Windows.Forms.Button();
            this.Touchpad = new System.Windows.Forms.Button();
            this.Reduce = new System.Windows.Forms.Button();
            this.Enlarge = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.AllUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsScreen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicsScreen
            // 
            this.GraphicsScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsScreen.BackColor = System.Drawing.Color.SkyBlue;
            this.GraphicsScreen.Location = new System.Drawing.Point(12, 44);
            this.GraphicsScreen.Name = "GraphicsScreen";
            this.GraphicsScreen.Size = new System.Drawing.Size(607, 462);
            this.GraphicsScreen.TabIndex = 0;
            this.GraphicsScreen.TabStop = false;
            this.GraphicsScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsScreen_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.thirdFunctionRB);
            this.groupBox1.Controls.Add(this.secondFunctionRB);
            this.groupBox1.Controls.Add(this.firstFunctionRB);
            this.groupBox1.Location = new System.Drawing.Point(646, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции";
            // 
            // thirdFunctionRB
            // 
            this.thirdFunctionRB.AutoSize = true;
            this.thirdFunctionRB.Location = new System.Drawing.Point(21, 76);
            this.thirdFunctionRB.Name = "thirdFunctionRB";
            this.thirdFunctionRB.Size = new System.Drawing.Size(130, 21);
            this.thirdFunctionRB.TabIndex = 2;
            this.thirdFunctionRB.Text = "thirdFunctionRB";
            this.thirdFunctionRB.UseVisualStyleBackColor = true;
            this.thirdFunctionRB.CheckedChanged += new System.EventHandler(this.Function_CheckedChanged);
            // 
            // secondFunctionRB
            // 
            this.secondFunctionRB.AutoSize = true;
            this.secondFunctionRB.Location = new System.Drawing.Point(21, 49);
            this.secondFunctionRB.Name = "secondFunctionRB";
            this.secondFunctionRB.Size = new System.Drawing.Size(148, 21);
            this.secondFunctionRB.TabIndex = 1;
            this.secondFunctionRB.Text = "secondFunctionRB";
            this.secondFunctionRB.UseVisualStyleBackColor = false;
            this.secondFunctionRB.CheckedChanged += new System.EventHandler(this.Function_CheckedChanged);
            // 
            // firstFunctionRB
            // 
            this.firstFunctionRB.AutoSize = true;
            this.firstFunctionRB.Checked = true;
            this.firstFunctionRB.Location = new System.Drawing.Point(21, 22);
            this.firstFunctionRB.Name = "firstFunctionRB";
            this.firstFunctionRB.Size = new System.Drawing.Size(125, 21);
            this.firstFunctionRB.TabIndex = 0;
            this.firstFunctionRB.TabStop = true;
            this.firstFunctionRB.Text = "firstFunctionRB";
            this.firstFunctionRB.UseVisualStyleBackColor = true;
            this.firstFunctionRB.CheckedChanged += new System.EventHandler(this.Function_CheckedChanged);
            // 
            // AllDown
            // 
            this.AllDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AllDown.BackColor = System.Drawing.SystemColors.Control;
            this.AllDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllDown.Location = new System.Drawing.Point(776, 479);
            this.AllDown.Name = "AllDown";
            this.AllDown.Size = new System.Drawing.Size(82, 27);
            this.AllDown.TabIndex = 33;
            this.AllDown.Text = "All ▼";
            this.AllDown.UseVisualStyleBackColor = false;
            this.AllDown.Click += new System.EventHandler(this.AllDown_Click);
            // 
            // ZUp
            // 
            this.ZUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZUp.BackColor = System.Drawing.SystemColors.Control;
            this.ZUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZUp.Location = new System.Drawing.Point(677, 453);
            this.ZUp.Name = "ZUp";
            this.ZUp.Size = new System.Drawing.Size(83, 27);
            this.ZUp.TabIndex = 32;
            this.ZUp.Text = "Z ▲";
            this.ZUp.UseVisualStyleBackColor = false;
            this.ZUp.Click += new System.EventHandler(this.ZUp_Click);
            // 
            // ZDown
            // 
            this.ZDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZDown.BackColor = System.Drawing.SystemColors.Control;
            this.ZDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZDown.Location = new System.Drawing.Point(677, 479);
            this.ZDown.Name = "ZDown";
            this.ZDown.Size = new System.Drawing.Size(83, 27);
            this.ZDown.TabIndex = 31;
            this.ZDown.Text = "Z ▼";
            this.ZDown.UseVisualStyleBackColor = false;
            this.ZDown.Click += new System.EventHandler(this.ZDown_Click);
            // 
            // YUp
            // 
            this.YUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YUp.BackColor = System.Drawing.SystemColors.Control;
            this.YUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YUp.Location = new System.Drawing.Point(776, 389);
            this.YUp.Name = "YUp";
            this.YUp.Size = new System.Drawing.Size(83, 27);
            this.YUp.TabIndex = 30;
            this.YUp.Text = "Y ▲";
            this.YUp.UseVisualStyleBackColor = false;
            this.YUp.Click += new System.EventHandler(this.YUp_Click);
            // 
            // YDown
            // 
            this.YDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YDown.BackColor = System.Drawing.SystemColors.Control;
            this.YDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YDown.Location = new System.Drawing.Point(776, 415);
            this.YDown.Name = "YDown";
            this.YDown.Size = new System.Drawing.Size(82, 27);
            this.YDown.TabIndex = 29;
            this.YDown.Text = "Y ▼";
            this.YDown.UseVisualStyleBackColor = false;
            this.YDown.Click += new System.EventHandler(this.YDown_Click);
            // 
            // XUp
            // 
            this.XUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XUp.BackColor = System.Drawing.SystemColors.Control;
            this.XUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XUp.Location = new System.Drawing.Point(677, 389);
            this.XUp.Name = "XUp";
            this.XUp.Size = new System.Drawing.Size(83, 27);
            this.XUp.TabIndex = 28;
            this.XUp.Text = "X ▲";
            this.XUp.UseVisualStyleBackColor = false;
            this.XUp.Click += new System.EventHandler(this.XUp_Click);
            // 
            // XDown
            // 
            this.XDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XDown.BackColor = System.Drawing.SystemColors.Control;
            this.XDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XDown.Location = new System.Drawing.Point(677, 415);
            this.XDown.Name = "XDown";
            this.XDown.Size = new System.Drawing.Size(83, 27);
            this.XDown.TabIndex = 27;
            this.XDown.Text = "X ▼";
            this.XDown.UseVisualStyleBackColor = false;
            this.XDown.Click += new System.EventHandler(this.XDown_Click);
            // 
            // Touchpad
            // 
            this.Touchpad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Touchpad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Touchpad.Location = new System.Drawing.Point(740, 197);
            this.Touchpad.Name = "Touchpad";
            this.Touchpad.Size = new System.Drawing.Size(56, 53);
            this.Touchpad.TabIndex = 26;
            this.Touchpad.UseVisualStyleBackColor = false;
            // 
            // Reduce
            // 
            this.Reduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reduce.BackColor = System.Drawing.SystemColors.Control;
            this.Reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reduce.Location = new System.Drawing.Point(676, 354);
            this.Reduce.Margin = new System.Windows.Forms.Padding(4);
            this.Reduce.Name = "Reduce";
            this.Reduce.Size = new System.Drawing.Size(182, 28);
            this.Reduce.TabIndex = 24;
            this.Reduce.Text = "Уменьшить";
            this.Reduce.UseVisualStyleBackColor = false;
            this.Reduce.Click += new System.EventHandler(this.Reduce_Click);
            // 
            // Enlarge
            // 
            this.Enlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Enlarge.BackColor = System.Drawing.SystemColors.Control;
            this.Enlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enlarge.Location = new System.Drawing.Point(676, 318);
            this.Enlarge.Margin = new System.Windows.Forms.Padding(4);
            this.Enlarge.Name = "Enlarge";
            this.Enlarge.Size = new System.Drawing.Size(182, 28);
            this.Enlarge.TabIndex = 23;
            this.Enlarge.Text = "Увеличить";
            this.Enlarge.UseVisualStyleBackColor = false;
            this.Enlarge.Click += new System.EventHandler(this.Enlarge_Click);
            // 
            // Right
            // 
            this.Right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Right.BackColor = System.Drawing.SystemColors.Control;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Location = new System.Drawing.Point(803, 199);
            this.Right.Margin = new System.Windows.Forms.Padding(4);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(56, 52);
            this.Right.TabIndex = 22;
            this.Right.Text = "▶";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Right_MouseDown);
            this.Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Right_MouseUp);
            // 
            // Left
            // 
            this.Left.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Left.BackColor = System.Drawing.SystemColors.Control;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Location = new System.Drawing.Point(677, 198);
            this.Left.Margin = new System.Windows.Forms.Padding(4);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(56, 54);
            this.Left.TabIndex = 21;
            this.Left.Text = "◀";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_MouseDown);
            this.Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_MouseUp);
            // 
            // Up
            // 
            this.Up.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Up.BackColor = System.Drawing.SystemColors.Control;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Up.Location = new System.Drawing.Point(740, 257);
            this.Up.Margin = new System.Windows.Forms.Padding(4);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(56, 53);
            this.Up.TabIndex = 20;
            this.Up.Text = "▼";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_MouseDown);
            this.Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up_MouseUp);
            // 
            // Down
            // 
            this.Down.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Down.BackColor = System.Drawing.SystemColors.Control;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down.Location = new System.Drawing.Point(740, 137);
            this.Down.Margin = new System.Windows.Forms.Padding(4);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(56, 53);
            this.Down.TabIndex = 25;
            this.Down.Text = "▲";
            this.Down.UseVisualStyleBackColor = false;
            this.Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_MouseDown);
            this.Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Down_MouseUp);
            // 
            // AllUp
            // 
            this.AllUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AllUp.BackColor = System.Drawing.SystemColors.Control;
            this.AllUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllUp.Location = new System.Drawing.Point(776, 453);
            this.AllUp.Name = "AllUp";
            this.AllUp.Size = new System.Drawing.Size(82, 27);
            this.AllUp.TabIndex = 34;
            this.AllUp.Text = "All ▲";
            this.AllUp.UseVisualStyleBackColor = false;
            this.AllUp.Click += new System.EventHandler(this.AllUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.AllUp);
            this.Controls.Add(this.AllDown);
            this.Controls.Add(this.ZUp);
            this.Controls.Add(this.ZDown);
            this.Controls.Add(this.YUp);
            this.Controls.Add(this.YDown);
            this.Controls.Add(this.XUp);
            this.Controls.Add(this.XDown);
            this.Controls.Add(this.Touchpad);
            this.Controls.Add(this.Reduce);
            this.Controls.Add(this.Enlarge);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphicsScreen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Graphic";
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsScreen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphicsScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton thirdFunctionRB;
        private System.Windows.Forms.RadioButton secondFunctionRB;
        private System.Windows.Forms.RadioButton firstFunctionRB;
        private System.Windows.Forms.Button AllDown;
        private System.Windows.Forms.Button ZUp;
        private System.Windows.Forms.Button ZDown;
        private System.Windows.Forms.Button YUp;
        private System.Windows.Forms.Button YDown;
        private System.Windows.Forms.Button XUp;
        private System.Windows.Forms.Button XDown;
        private System.Windows.Forms.Button Touchpad;
        private System.Windows.Forms.Button Reduce;
        private System.Windows.Forms.Button Enlarge;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button AllUp;
    }
}

