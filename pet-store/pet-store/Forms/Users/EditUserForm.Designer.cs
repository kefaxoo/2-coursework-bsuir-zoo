namespace pet_store.Forms.Users
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.managerRadioButton = new System.Windows.Forms.RadioButton();
            this.workerRadioButton = new System.Windows.Forms.RadioButton();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 27);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(145, 23);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(145, 23);
            this.passwordTextBox.TabIndex = 4;
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.Location = new System.Drawing.Point(12, 115);
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
            this.workerRadioButton.Location = new System.Drawing.Point(12, 140);
            this.workerRadioButton.Name = "workerRadioButton";
            this.workerRadioButton.Size = new System.Drawing.Size(145, 19);
            this.workerRadioButton.TabIndex = 6;
            this.workerRadioButton.TabStop = true;
            this.workerRadioButton.Text = "Продавец/фармацевт";
            this.workerRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(12, 165);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(145, 23);
            this.saveUserButton.TabIndex = 7;
            this.saveUserButton.Text = "Сохранить изменения";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 195);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.workerRadioButton);
            this.Controls.Add(this.managerRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUserForm";
            this.Text = "PetShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.RadioButton managerRadioButton;
        private System.Windows.Forms.RadioButton workerRadioButton;
        private System.Windows.Forms.Button saveUserButton;
    }
}