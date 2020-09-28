using System.Windows.Forms;

namespace DataGridViewAutoFilterDemo.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Icon = Properties.Resources.DataGridViewAutoFilterIcon;
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            using (var basicForm = new BasicDemoForm())
            {
                basicForm.ShowDialog();
            }
        }
        private void MetroButton1_Click(object sender, System.EventArgs e)
        {
            using (var metroForm = new MetroDemoForm())
            {
                metroForm.ShowDialog();
            }
        }
        private void MaterialButton1_Click(object sender, System.EventArgs e)
        {
            using (var materialForm = new MaterialDemoForm())
            {
                materialForm.ShowDialog();
            }
        }
    }
}
