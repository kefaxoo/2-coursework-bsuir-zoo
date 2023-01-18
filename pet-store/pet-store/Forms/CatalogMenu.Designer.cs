namespace pet_store
{
    partial class CatalogMenu
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
            this.showCatalogButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(179, 15);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Подключённый пользователь: ";
            // 
            // showCatalogButton
            // 
            this.showCatalogButton.Location = new System.Drawing.Point(12, 27);
            this.showCatalogButton.Name = "showCatalogButton";
            this.showCatalogButton.Size = new System.Drawing.Size(271, 23);
            this.showCatalogButton.TabIndex = 6;
            this.showCatalogButton.Text = "Просмотр каталога";
            this.showCatalogButton.UseVisualStyleBackColor = true;
            this.showCatalogButton.Click += new System.EventHandler(this.ShowCatalogButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(12, 56);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(271, 23);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "Добавление нового товара";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(12, 85);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(271, 23);
            this.editItemButton.TabIndex = 8;
            this.editItemButton.Text = "Редактирование товара";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(12, 114);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(271, 23);
            this.deleteItemButton.TabIndex = 9;
            this.deleteItemButton.Text = "Удаление товара";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // CatalogMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 144);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.showCatalogButton);
            this.Controls.Add(this.userLabel);
            this.Name = "CatalogMenu";
            this.Text = "PetShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatalogMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button showCatalogButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button deleteItemButton;
    }
}