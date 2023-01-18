namespace pet_store
{
    partial class WorkersMenu
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
            this.viewUsersButton = new System.Windows.Forms.Button();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.Location = new System.Drawing.Point(12, 27);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(299, 23);
            this.viewUsersButton.TabIndex = 0;
            this.viewUsersButton.Text = "Просмотр всех пользователей";
            this.viewUsersButton.UseVisualStyleBackColor = true;
            this.viewUsersButton.Click += new System.EventHandler(this.ViewUsersButton_Click);
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Location = new System.Drawing.Point(12, 56);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(299, 23);
            this.addNewUserButton.TabIndex = 1;
            this.addNewUserButton.Text = "Добавление нового пользователя";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(12, 85);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(299, 23);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Редактирование учётной записи";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(12, 114);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(299, 23);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Удаление учётной записи";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(179, 15);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Подключённый пользователь: ";
            // 
            // WorkersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 148);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.viewUsersButton);
            this.Name = "WorkersMenu";
            this.Text = "PetShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkersMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewUsersButton;
        private System.Windows.Forms.Button addNewUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label userLabel;
    }
}