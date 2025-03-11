namespace SignUpForm_Booky
{
    partial class SignUp
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
            signUpMenu = new MenuStrip();
            signUpHelpMenu = new ToolStripMenuItem();
            aboutSignUpMenu = new ToolStripMenuItem();
            welcomeLabelSignUpPage = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            userName = new TextBox();
            signUpButton = new Button();
            signUpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // signUpMenu
            // 
            signUpMenu.BackColor = SystemColors.ButtonHighlight;
            signUpMenu.ImageScalingSize = new Size(20, 20);
            signUpMenu.Items.AddRange(new ToolStripItem[] { signUpHelpMenu });
            signUpMenu.Location = new Point(0, 0);
            signUpMenu.Name = "signUpMenu";
            signUpMenu.Size = new Size(729, 28);
            signUpMenu.TabIndex = 0;
            signUpMenu.Text = "Menu";
            // 
            // signUpHelpMenu
            // 
            signUpHelpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutSignUpMenu });
            signUpHelpMenu.Name = "signUpHelpMenu";
            signUpHelpMenu.Size = new Size(55, 24);
            signUpHelpMenu.Text = "&Help";
            // 
            // aboutSignUpMenu
            // 
            aboutSignUpMenu.Name = "aboutSignUpMenu";
            aboutSignUpMenu.Size = new Size(224, 26);
            aboutSignUpMenu.Text = "&About";
            // 
            // welcomeLabelSignUpPage
            // 
            welcomeLabelSignUpPage.AutoSize = true;
            welcomeLabelSignUpPage.FlatStyle = FlatStyle.Popup;
            welcomeLabelSignUpPage.Location = new Point(12, 39);
            welcomeLabelSignUpPage.Name = "welcomeLabelSignUpPage";
            welcomeLabelSignUpPage.Size = new Size(188, 46);
            welcomeLabelSignUpPage.TabIndex = 1;
            welcomeLabelSignUpPage.Text = "Sign Up";
            // 
            // FirstName
            // 
            FirstName.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstName.Location = new Point(12, 88);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(365, 27);
            FirstName.TabIndex = 2;
            FirstName.MouseHover += FirstName_Mousehover;
            // 
            // LastName
            // 
            LastName.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastName.Location = new Point(12, 121);
            LastName.Name = "LastName";
            LastName.Size = new Size(365, 27);
            LastName.TabIndex = 3;
            LastName.MouseHover += LastName_Mousehover;

            // 
            // userName
            // 
            userName.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(12, 154);
            userName.Name = "userName";
            userName.Size = new Size(365, 27);
            userName.TabIndex = 4;
            userName.MouseHover += userName_MouseHover;
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.Location = new Point(12, 199);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(24F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 383);
            Controls.Add(signUpButton);
            Controls.Add(userName);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(welcomeLabelSignUpPage);
            Controls.Add(signUpMenu);
            Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = signUpMenu;
            Margin = new Padding(9, 7, 9, 7);
            Name = "SignUp";
            Text = "Sign Up Page";
            Load += Form1_Load;
            signUpMenu.ResumeLayout(false);
            signUpMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip signUpMenu;
        private ToolStripMenuItem signUpHelpMenu;
        private ToolStripMenuItem aboutSignUpMenu;
        private Label welcomeLabelSignUpPage;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox userName;
        private Button signUpButton;
    }
}
