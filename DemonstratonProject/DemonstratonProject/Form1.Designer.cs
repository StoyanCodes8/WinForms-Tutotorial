namespace DemonstratonProject
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
        private void InitializeComponent()
        {
            ApplicationName = new Label();
            SuspendLayout();
            // 
            // ApplicationName
            // 
            ApplicationName.AutoSize = true;
            ApplicationName.Location = new Point(12, 9);
            ApplicationName.Name = "ApplicationName";
            ApplicationName.Size = new Size(126, 20);
            ApplicationName.TabIndex = 0;
            ApplicationName.Text = "ApplicationName";
            ApplicationName.Click += ApplicationName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(592, 450);
            Controls.Add(ApplicationName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ApplicationName;
    }
}
