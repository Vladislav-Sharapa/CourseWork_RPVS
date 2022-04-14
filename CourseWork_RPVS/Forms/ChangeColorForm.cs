using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_RPVS.Forms {
    public partial class ChangeColorForm : Form {
        public ChangeColorForm() {
            InitializeComponent();
            this.Text = "Make color";
            hScrollBar1.Minimum = 0; hScrollBar1.Maximum = 264;
            hScrollBar2.Minimum = 0; hScrollBar2.Maximum = 264;
            hScrollBar3.Minimum = 0; hScrollBar3.Maximum = 264;
            hScrollBar1.Value = 0; hScrollBar2.Value = 0; hScrollBar3.Value = 0;
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0";
            textBox1.BackColor = Color.Black; textBox2.BackColor = Color.Black; textBox3.BackColor = Color.Black;
            textBox4.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, 0, 0);
            textBox4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e) {
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox2.BackColor = Color.FromArgb(0, hScrollBar2.Value, 0);
            textBox4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e) {
            textBox3.Text = hScrollBar3.Value.ToString();
            textBox3.BackColor = Color.FromArgb(0, 0, hScrollBar3.Value);
            textBox4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void button2_Click(object sender, EventArgs e) {
            ControlOutputGraphics.R = Convert.ToInt32(this.textBox1.Text);
            ControlOutputGraphics.G = Convert.ToInt32(this.textBox2.Text);
            ControlOutputGraphics.B = Convert.ToInt32(this.textBox3.Text);
            ControlOutputGraphics.color = textBox4.BackColor;
            this.Close();
        }
    }
}
