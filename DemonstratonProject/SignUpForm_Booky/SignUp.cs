using System.IO;
using System.Windows.Forms.VisualStyles;
using System;
using BookyClassLibrary;
using System.Linq.Expressions;
namespace SignUpForm_Booky
{
    public partial class SignUp : Form
    {
        public ToolTip toolTip;
        public string firstname;
        public string lastname;
        public SignUp()
        {
            InitializeComponent();
            toolTip = new ToolTip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ELEMENTS HOVER SECTION
        private void FirstName_Mousehover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(FirstName, "First Name");
        }
        private void LastName_Mousehover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(LastName, "Last Name");
            lastname = LastName.Text;
        }
        private void nickname_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(nickname, "Full Name");
        }

        // FIRST TWO ELEMENTS VALUE FILLING AND CHECKING
        private void FirstName_FocusLeave(object sender, EventArgs e)
        {
                firstname = FirstName.Text;
                string text = firstname;
                string file = "Log_In.txt";
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BookyApp");

                DirectoryUtilities.EnsureNamesComplyWithRestrictions(text, file, path);
        }

        private void LastName_FocusLeave(object sender, EventArgs e)
        {
            lastname = LastName.Text;
            string text = lastname;
            string file = "Log_In.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BookyApp");

           DirectoryUtilities.EnsureNamesComplyWithRestrictions(text, file, path);
        }



        private void sendButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nickname.Text);
        }
    }
}
