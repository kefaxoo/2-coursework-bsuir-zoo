namespace pet_store
{
    partial class CloseBillForm
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
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.givenSumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.closeBillButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.givenSumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Окончательный расчёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(66, 27);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(138, 23);
            this.sumTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип оплаты:";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(92, 56);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(83, 19);
            this.cashRadioButton.TabIndex = 4;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Наличные";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(92, 81);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(56, 19);
            this.cardRadioButton.TabIndex = 5;
            this.cardRadioButton.Text = "Карта";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Получено:";
            // 
            // givenSumNumericUpDown
            // 
            this.givenSumNumericUpDown.DecimalPlaces = 2;
            this.givenSumNumericUpDown.Location = new System.Drawing.Point(84, 106);
            this.givenSumNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.givenSumNumericUpDown.Name = "givenSumNumericUpDown";
            this.givenSumNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.givenSumNumericUpDown.TabIndex = 7;
            this.givenSumNumericUpDown.ValueChanged += new System.EventHandler(this.GivenSumNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сдача:";
            // 
            // changeTextBox
            // 
            this.changeTextBox.Location = new System.Drawing.Point(61, 135);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(143, 23);
            this.changeTextBox.TabIndex = 9;
            // 
            // closeBillButton
            // 
            this.closeBillButton.Location = new System.Drawing.Point(12, 164);
            this.closeBillButton.Name = "closeBillButton";
            this.closeBillButton.Size = new System.Drawing.Size(192, 23);
            this.closeBillButton.TabIndex = 10;
            this.closeBillButton.Text = "Закрыть чек";
            this.closeBillButton.UseVisualStyleBackColor = true;
            this.closeBillButton.Click += new System.EventHandler(this.CloseBillButton_Click);
            // 
            // CloseBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 197);
            this.Controls.Add(this.closeBillButton);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.givenSumNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cardRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CloseBillForm";
            this.Text = "PetShop";
            ((System.ComponentModel.ISupportInitialize)(this.givenSumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown givenSumNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Button closeBillButton;
    }
}