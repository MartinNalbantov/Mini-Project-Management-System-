namespace Mini_Project_Management_System
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            LogIn = new Button();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LogIn
            // 
            LogIn.Location = new Point(358, 270);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(75, 23);
            LogIn.TabIndex = 1;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(328, 172);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(139, 29);
            Username.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(328, 223);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(139, 29);
            Password.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 86);
            label1.Name = "label1";
            label1.Size = new Size(177, 67);
            label1.TabIndex = 4;
            label1.Text = "Log In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LogIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button LogIn;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
    }
}