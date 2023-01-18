namespace pet_store
{
    partial class Menu
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
            this.workersButton = new System.Windows.Forms.Button();
            this.catalogButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workersButton
            // 
            this.workersButton.Location = new System.Drawing.Point(12, 72);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(302, 23);
            this.workersButton.TabIndex = 0;
            this.workersButton.Text = "Сотрудники";
            this.workersButton.UseVisualStyleBackColor = true;
            this.workersButton.Click += new System.EventHandler(this.WorkersButton_Click);
            // 
            // catalogButton
            // 
            this.catalogButton.Location = new System.Drawing.Point(12, 101);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(302, 23);
            this.catalogButton.TabIndex = 1;
            this.catalogButton.Text = "Каталог";
            this.catalogButton.UseVisualStyleBackColor = true;
            this.catalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(12, 130);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(302, 23);
            this.salesButton.TabIndex = 2;
            this.salesButton.Text = "Продажи";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(182, 15);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Подключённый пользователь:  ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Дата:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 54);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(42, 15);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Время";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(12, 24);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(75, 15);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "Должность: ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 160);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.catalogButton);
            this.Controls.Add(this.workersButton);
            this.Name = "Menu";
            this.Text = "PetShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button workersButton;
        private System.Windows.Forms.Button catalogButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleLabel;
    }
}