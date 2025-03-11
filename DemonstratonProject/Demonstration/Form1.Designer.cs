namespace Demonstration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() // MAIN METHOD
        {
            components = new System.ComponentModel.Container();
            welcomeText = new Label();
            Send = new Button();
            bindingSource1 = new BindingSource(components);
            Menu = new MenuStrip();
            helpMenu = new ToolStripMenuItem();
            aboutHelpMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeText
            // 
            welcomeText.AutoSize = true;
            welcomeText.BackColor = Color.Transparent;
            welcomeText.Dock = DockStyle.Fill;
            welcomeText.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeText.Location = new Point(0, 28);
            welcomeText.Name = "welcomeText";
            welcomeText.RightToLeft = RightToLeft.No;
            welcomeText.Size = new Size(392, 106);
            welcomeText.TabIndex = 0;
            welcomeText.Text = "Welcome";
            // 
            // Send
            // 
            Send.Location = new Point(12, 407);
            Send.Name = "Send";
            Send.Size = new Size(94, 29);
            Send.TabIndex = 2;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { helpMenu });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(756, 28);
            Menu.TabIndex = 3;
            Menu.Text = "Menu";
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutHelpMenu });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(55, 24);
            helpMenu.Text = "&Help";
            // 
            // aboutHelpMenu
            // 
            aboutHelpMenu.Name = "aboutHelpMenu";
            aboutHelpMenu.Size = new Size(224, 26);
            aboutHelpMenu.Text = "&About";
            aboutHelpMenu.Click += aboutHelpMenu_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(756, 441);
            Controls.Add(Send);
            Controls.Add(welcomeText);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "Form1";
            Text = "Booky App";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeText;
        private Button Send;
        private BindingSource bindingSource1;
        private MenuStrip Menu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutHelpMenu;
    }
}
