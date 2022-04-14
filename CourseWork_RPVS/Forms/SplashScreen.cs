using System.Windows.Forms;

namespace CourseWork_RPVS {
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
            timer.Start();
        }

        private void TimerTick(object sender, System.EventArgs e) {
            progressBar.Increment(1);
            if(progressBar.Value == 100) {
                timer.Stop();
                this.Close();
            }
        }
    }
}
    
