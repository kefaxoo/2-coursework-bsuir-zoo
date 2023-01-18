namespace pet_store
{
    partial class LoginForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(203, 65);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "PetShop";
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(50, 74);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(115, 15);
            this.signLabel.TabIndex = 1;
            this.signLabel.Text = "Вход и регистрация";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(61, 99);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(89, 15);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Введите логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(54, 143);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Введите пароль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 117);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(203, 23);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(203, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(12, 190);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(203, 23);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Вход";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(12, 219);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(203, 23);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Регистрация";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 259);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "LoginForm";
            this.Text = "PetShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button signUpButton;
    }
}
