namespace DemonstrationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void appName_Click(object sender, EventArgs e)
        {
            appName.Text = "Welcome!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void appName2_Click(object sender, EventArgs e)
        {
            appName.Text = "freaking tenx!";
        }
    }
}
