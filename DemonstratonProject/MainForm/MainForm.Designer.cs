namespace MainForm
{
    partial class MainForm
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
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            Menu = new MenuStrip();
            helpMenu = new ToolStripMenuItem();
            aboutHelpMenu = new ToolStripMenuItem();
            signUpButton = new Button();
            logInButton = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.FlatStyle = FlatStyle.Popup;
            welcomeLabel.Location = new Point(12, 35);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(188, 46);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome";
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ButtonHighlight;
            Menu.GripStyle = ToolStripGripStyle.Visible;
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { helpMenu });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(729, 28);
            Menu.TabIndex = 1;
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
            aboutHelpMenu.Size = new Size(133, 26);
            aboutHelpMenu.Text = "&About";
            aboutHelpMenu.Click += aboutHelpMenu_Click;
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.Location = new Point(12, 84);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 2;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInButton.Location = new Point(112, 84);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(24F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 383);
            Controls.Add(logInButton);
            Controls.Add(signUpButton);
            Controls.Add(welcomeLabel);
            Controls.Add(Menu);
            Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = Menu;
            Margin = new Padding(9, 7, 9, 7);
            Name = "MainForm";
            Text = "Booky";
            Load += MainForm_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private MenuStrip Menu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutHelpMenu;
        private Button signUpButton;
        private Button logInButton;
    }
}
