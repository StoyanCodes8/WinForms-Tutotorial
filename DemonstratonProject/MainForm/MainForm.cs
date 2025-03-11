using System.IO;
using System.Windows.Forms.VisualStyles;
using BookyClassLibrary;
namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckAndCreateDirectory();
        }
        // Ensure Directory Exists
        private void CheckAndCreateDirectory()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BookyApp");
            DirectoryUtilities.EnsureDirectoryExists(path);
        }
        private void aboutHelpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This was created by Stoyan Stefanov, It's his first application he had ever created and he will most likely heavilily iterate it as time goes on. Stoyan Stefanov - Out");
        }

        // Buttons are clicked!
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string file = "Log_In.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BookyApp");
            DirectoryUtilities.EnsureFilesExists(file, path);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
