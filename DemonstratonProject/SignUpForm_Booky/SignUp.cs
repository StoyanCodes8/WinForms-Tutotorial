using System.IO;
using System.Windows.Forms.VisualStyles;
using BookyClassLibrary;
namespace SignUpForm_Booky
{
    public partial class SignUp : Form
    {
        public ToolTip toolTip;
        public SignUp()
        {
            InitializeComponent();
            toolTip = new ToolTip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FirstName_Mousehover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(FirstName, "First Name");

        }

        private void LastName_Mousehover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(LastName, "Last Name");
        }

        private void userName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(userName, "Username");
        }

    }
}
