namespace DemonstrationProject
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
            appName = new Label();
            appName2 = new Label();
            SuspendLayout();
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.BackColor = SystemColors.ActiveCaptionText;
            appName.Location = new Point(12, 9);
            appName.Name = "appName";
            appName.Size = new Size(0, 20);
            appName.TabIndex = 0;
            appName.Click += appName_Click;
            // 
            // appName2
            // 
            appName2.AutoSize = true;
            appName2.Location = new Point(521, 119);
            appName2.Name = "appName2";
            appName2.Size = new Size(123, 20);
            appName2.TabIndex = 1;
            appName2.Text = "CLICK ME NOOW";
            appName2.Click += appName2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(appName2);
            Controls.Add(appName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appName;
        private Label appName2;
    }
}
