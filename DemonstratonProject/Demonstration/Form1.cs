using System.Windows.Forms;
using System;
namespace Demonstration
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            //button1.Text = "Send"; //не най-доброто решение
        }

        private void aboutHelpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This was created by Stoyan Stefanov, It's his first application he had ever created and he will most likely heavilily iterate it as time goes on. Stoyan Stefanov - Out");
        }
    }
    /*public class LabelClass : Label
    {
        public LabelClass()
        {
           
        }
    
    }*/

}
