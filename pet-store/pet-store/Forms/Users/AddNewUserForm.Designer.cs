namespace pet_store
{
    partial class AddNewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.managerRadioButton = new System.Windows.Forms.RadioButton();
            this.workerRadioButton = new System.Windows.Forms.RadioButton();
            this.addUserButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(179, 15);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Подключённый пользователь: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 86);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(299, 23);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 42);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(299, 23);
            this.loginTextBox.TabIndex = 4;
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.Location = new System.Drawing.Point(12, 130);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Size = new System.Drawing.Size(78, 19);
            this.managerRadioButton.TabIndex = 5;
            this.managerRadioButton.TabStop = true;
            this.managerRadioButton.Text = "Директор";
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // workerRadioButton
            // 
            this.workerRadioButton.AutoSize = true;
            this.workerRadioButton.Location = new System.Drawing.Point(12, 155);
            this.workerRadioButton.Name = "workerRadioButton";
            this.workerRadioButton.Size = new System.Drawing.Size(145, 19);
            this.workerRadioButton.TabIndex = 6;
            this.workerRadioButton.TabStop = true;
            this.workerRadioButton.Text = "Продавец\\фармацевт";
            this.workerRadioButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 180);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(299, 23);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите должность:";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.workerRadioButton);
            this.Controls.Add(this.managerRadioButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLabel);
            this.Name = "AddNewUserForm";
            this.Text = "PetShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.RadioButton managerRadioButton;
        private System.Windows.Forms.RadioButton workerRadioButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label4;
    }
}