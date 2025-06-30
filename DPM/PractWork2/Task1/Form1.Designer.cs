namespace Task1
{
    partial class RegistrationForm
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
            loginLabel = new Label();
            passwordLabel = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(24, 22);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(24, 108);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(24, 40);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(206, 23);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(24, 126);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(206, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(220, 183);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(129, 23);
            registrationButton.TabIndex = 3;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += RegistrationButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 218);
            Controls.Add(registrationButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label passwordLabel;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button registrationButton;
    }
}
