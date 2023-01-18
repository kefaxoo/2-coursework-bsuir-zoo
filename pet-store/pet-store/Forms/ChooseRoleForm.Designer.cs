namespace pet_store
{
    partial class ChooseRoleForm
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
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.workerRadioButton = new System.Windows.Forms.RadioButton();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите роль для пользователя";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Checked = true;
            this.adminRadioButton.Location = new System.Drawing.Point(12, 27);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(78, 19);
            this.adminRadioButton.TabIndex = 1;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Директор";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // workerRadioButton
            // 
            this.workerRadioButton.AutoSize = true;
            this.workerRadioButton.Location = new System.Drawing.Point(12, 52);
            this.workerRadioButton.Name = "workerRadioButton";
            this.workerRadioButton.Size = new System.Drawing.Size(145, 19);
            this.workerRadioButton.TabIndex = 3;
            this.workerRadioButton.Text = "Продавец/фармацевт";
            this.workerRadioButton.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(12, 77);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(191, 23);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Зарегестрироваться";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ChooseRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 109);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.workerRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "ChooseRoleForm";
            this.Text = "PetShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton workerRadioButton;
        private System.Windows.Forms.Button signUpButton;
    }
}