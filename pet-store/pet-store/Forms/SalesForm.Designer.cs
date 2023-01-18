namespace pet_store
{
    partial class SalesForm
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.closeBillButton = new System.Windows.Forms.Button();
            this.openItemsButton = new System.Windows.Forms.Button();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 24);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(42, 15);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Время";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 15);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сумма:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(66, 42);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(100, 23);
            this.sumTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите номер товара:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Location = new System.Drawing.Point(150, 71);
            this.idNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.idNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.idNumericUpDown.TabIndex = 11;
            this.idNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(442, 73);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.countNumericUpDown.TabIndex = 12;
            this.countNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите количество товара:";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(568, 73);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(105, 23);
            this.addItemButton.TabIndex = 14;
            this.addItemButton.Text = "Добавить товар";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // closeBillButton
            // 
            this.closeBillButton.Location = new System.Drawing.Point(12, 415);
            this.closeBillButton.Name = "closeBillButton";
            this.closeBillButton.Size = new System.Drawing.Size(94, 23);
            this.closeBillButton.TabIndex = 15;
            this.closeBillButton.Text = "Закрыть чек";
            this.closeBillButton.UseVisualStyleBackColor = true;
            // 
            // openItemsButton
            // 
            this.openItemsButton.Location = new System.Drawing.Point(573, 415);
            this.openItemsButton.Name = "openItemsButton";
            this.openItemsButton.Size = new System.Drawing.Size(182, 23);
            this.openItemsButton.TabIndex = 16;
            this.openItemsButton.Text = "Открыть таблицу с товарами";
            this.openItemsButton.UseVisualStyleBackColor = true;
            this.openItemsButton.Click += new System.EventHandler(this.openItemsButton_Click);
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.NameItem,
            this.Price,
            this.Count,
            this.Sum,
            this.Edit,
            this.Remove});
            this.itemsDataGridView.Location = new System.Drawing.Point(12, 100);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.RowTemplate.Height = 25;
            this.itemsDataGridView.Size = new System.Drawing.Size(743, 309);
            this.itemsDataGridView.TabIndex = 17;
            // 
            // Position
            // 
            this.Position.HeaderText = "Позиция";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Название";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.openItemsButton);
            this.Controls.Add(this.closeBillButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "SalesForm";
            this.Text = "PetShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button closeBillButton;
        private System.Windows.Forms.Button openItemsButton;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}