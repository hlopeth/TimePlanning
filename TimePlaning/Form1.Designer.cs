namespace TimePlaning
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nudMoneyToGet = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.listBoxBuierMessages = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelBuierTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.listBoxShopMessages = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelShopTime = new System.Windows.Forms.Label();
            this.groupBoxShopLoan = new System.Windows.Forms.GroupBox();
            this.labelHasLoan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.listBoxBankMessages = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelBankMoney = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelBankTime = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBoxBankLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyToGet)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxShopLoan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox16);
            this.groupBox1.Controls.Add(this.groupBox13);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Покупатель";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.button2);
            this.groupBox16.Controls.Add(this.nudMoneyToGet);
            this.groupBox16.Location = new System.Drawing.Point(331, 25);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(322, 72);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Снять деньги";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(241, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Снять";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudMoneyToGet
            // 
            this.nudMoneyToGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMoneyToGet.Location = new System.Drawing.Point(6, 19);
            this.nudMoneyToGet.Name = "nudMoneyToGet";
            this.nudMoneyToGet.Size = new System.Drawing.Size(229, 20);
            this.nudMoneyToGet.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.listBoxBuierMessages);
            this.groupBox13.Location = new System.Drawing.Point(110, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(215, 136);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "События";
            // 
            // listBoxBuierMessages
            // 
            this.listBoxBuierMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBuierMessages.FormattingEnabled = true;
            this.listBoxBuierMessages.Location = new System.Drawing.Point(3, 16);
            this.listBoxBuierMessages.Name = "listBoxBuierMessages";
            this.listBoxBuierMessages.Size = new System.Drawing.Size(209, 117);
            this.listBoxBuierMessages.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelBuierTime);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 36);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Время";
            // 
            // labelBuierTime
            // 
            this.labelBuierTime.AutoSize = true;
            this.labelBuierTime.Location = new System.Drawing.Point(6, 16);
            this.labelBuierTime.Name = "labelBuierTime";
            this.labelBuierTime.Size = new System.Drawing.Size(23, 13);
            this.labelBuierTime.TabIndex = 0;
            this.labelBuierTime.Text = "null";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox14);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Магазин";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оформить кредит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.listBoxShopMessages);
            this.groupBox14.Location = new System.Drawing.Point(110, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(215, 136);
            this.groupBox14.TabIndex = 7;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "События";
            // 
            // listBoxShopMessages
            // 
            this.listBoxShopMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShopMessages.FormattingEnabled = true;
            this.listBoxShopMessages.Location = new System.Drawing.Point(3, 16);
            this.listBoxShopMessages.Name = "listBoxShopMessages";
            this.listBoxShopMessages.Size = new System.Drawing.Size(209, 117);
            this.listBoxShopMessages.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelShopTime);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 36);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Время";
            // 
            // labelShopTime
            // 
            this.labelShopTime.AutoSize = true;
            this.labelShopTime.Location = new System.Drawing.Point(6, 16);
            this.labelShopTime.Name = "labelShopTime";
            this.labelShopTime.Size = new System.Drawing.Size(23, 13);
            this.labelShopTime.TabIndex = 0;
            this.labelShopTime.Text = "null";
            // 
            // groupBoxShopLoan
            // 
            this.groupBoxShopLoan.Controls.Add(this.labelHasLoan);
            this.groupBoxShopLoan.Location = new System.Drawing.Point(6, 103);
            this.groupBoxShopLoan.Name = "groupBoxShopLoan";
            this.groupBoxShopLoan.Size = new System.Drawing.Size(98, 36);
            this.groupBoxShopLoan.TabIndex = 6;
            this.groupBoxShopLoan.TabStop = false;
            this.groupBoxShopLoan.Text = "Кредитов";
            // 
            // labelHasLoan
            // 
            this.labelHasLoan.AutoSize = true;
            this.labelHasLoan.Location = new System.Drawing.Point(7, 20);
            this.labelHasLoan.Name = "labelHasLoan";
            this.labelHasLoan.Size = new System.Drawing.Size(23, 13);
            this.labelHasLoan.TabIndex = 0;
            this.labelHasLoan.Text = "null";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox15);
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.groupBoxShopLoan);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Банк";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.listBoxBankMessages);
            this.groupBox15.Location = new System.Drawing.Point(110, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(215, 136);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "События";
            // 
            // listBoxBankMessages
            // 
            this.listBoxBankMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBankMessages.FormattingEnabled = true;
            this.listBoxBankMessages.Location = new System.Drawing.Point(3, 16);
            this.listBoxBankMessages.Name = "listBoxBankMessages";
            this.listBoxBankMessages.Size = new System.Drawing.Size(209, 117);
            this.listBoxBankMessages.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelBankMoney);
            this.groupBox12.Location = new System.Drawing.Point(6, 61);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(98, 36);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Деньги";
            // 
            // labelBankMoney
            // 
            this.labelBankMoney.AutoSize = true;
            this.labelBankMoney.Location = new System.Drawing.Point(7, 20);
            this.labelBankMoney.Name = "labelBankMoney";
            this.labelBankMoney.Size = new System.Drawing.Size(23, 13);
            this.labelBankMoney.TabIndex = 0;
            this.labelBankMoney.Text = "null";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelBankTime);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(98, 36);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Время";
            // 
            // labelBankTime
            // 
            this.labelBankTime.AutoSize = true;
            this.labelBankTime.Location = new System.Drawing.Point(6, 16);
            this.labelBankTime.Name = "labelBankTime";
            this.labelBankTime.Size = new System.Drawing.Size(23, 13);
            this.labelBankTime.TabIndex = 0;
            this.labelBankTime.Text = "null";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBoxBankLog);
            this.groupBox7.Location = new System.Drawing.Point(337, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 136);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Вывод";
            // 
            // listBoxBankLog
            // 
            this.listBoxBankLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBankLog.FormattingEnabled = true;
            this.listBoxBankLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxBankLog.Name = "listBoxBankLog";
            this.listBoxBankLog.Size = new System.Drawing.Size(209, 117);
            this.listBoxBankLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyToGet)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxShopLoan.ResumeLayout(false);
            this.groupBoxShopLoan.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBuierTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelShopTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelBankTime;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBoxShopLoan;
        private System.Windows.Forms.Label labelHasLoan;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label labelBankMoney;
        private System.Windows.Forms.ListBox listBoxBuierMessages;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ListBox listBoxShopMessages;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ListBox listBoxBankMessages;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudMoneyToGet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listBoxBankLog;
    }
}

