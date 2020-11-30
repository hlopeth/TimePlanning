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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.listBoxBuierLog = new System.Windows.Forms.ListBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.probabilityGetMoney = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.listBoxBuierMessages = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelBuierTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listBoxClockShopLog = new System.Windows.Forms.ListBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.listBoxClockShopMessages = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelClockShopTime = new System.Windows.Forms.Label();
            this.groupBoxShopLoan = new System.Windows.Forms.GroupBox();
            this.labelHasLoan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBoxBankLog = new System.Windows.Forms.ListBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.listBoxBankMessages = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelBankMoney = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelBankTime = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.listBoxCarShopLog = new System.Windows.Forms.ListBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.listBoxCarShopMessages = new System.Windows.Forms.ListBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.labelCarShopTime = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.probabilityBuyClock = new System.Windows.Forms.NumericUpDown();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.probabilityBuyCar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityGetMoney)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxShopLoan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBuyClock)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBuyCar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox20);
            this.groupBox1.Controls.Add(this.groupBox19);
            this.groupBox1.Controls.Add(this.groupBox10);
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
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.listBoxBuierLog);
            this.groupBox10.Location = new System.Drawing.Point(328, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(215, 136);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Вывод";
            // 
            // listBoxBuierLog
            // 
            this.listBoxBuierLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBuierLog.FormattingEnabled = true;
            this.listBoxBuierLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxBuierLog.Name = "listBoxBuierLog";
            this.listBoxBuierLog.Size = new System.Drawing.Size(209, 117);
            this.listBoxBuierLog.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.probabilityGetMoney);
            this.groupBox16.Location = new System.Drawing.Point(738, 48);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(126, 51);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Снять деньги";
            // 
            // probabilityGetMoney
            // 
            this.probabilityGetMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.probabilityGetMoney.Location = new System.Drawing.Point(6, 19);
            this.probabilityGetMoney.Name = "probabilityGetMoney";
            this.probabilityGetMoney.Size = new System.Drawing.Size(114, 20);
            this.probabilityGetMoney.TabIndex = 0;
            this.probabilityGetMoney.ValueChanged += new System.EventHandler(this.probabilityGetMoney_ValueChanged);
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
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox14);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Магазин часов";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listBoxClockShopLog);
            this.groupBox8.Location = new System.Drawing.Point(331, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 136);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Вывод";
            // 
            // listBoxClockShopLog
            // 
            this.listBoxClockShopLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClockShopLog.FormattingEnabled = true;
            this.listBoxClockShopLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxClockShopLog.Name = "listBoxClockShopLog";
            this.listBoxClockShopLog.Size = new System.Drawing.Size(209, 117);
            this.listBoxClockShopLog.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.listBoxClockShopMessages);
            this.groupBox14.Location = new System.Drawing.Point(110, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(215, 136);
            this.groupBox14.TabIndex = 7;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "События";
            // 
            // listBoxClockShopMessages
            // 
            this.listBoxClockShopMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClockShopMessages.FormattingEnabled = true;
            this.listBoxClockShopMessages.Location = new System.Drawing.Point(3, 16);
            this.listBoxClockShopMessages.Name = "listBoxClockShopMessages";
            this.listBoxClockShopMessages.Size = new System.Drawing.Size(209, 117);
            this.listBoxClockShopMessages.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelClockShopTime);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 36);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Время";
            // 
            // labelClockShopTime
            // 
            this.labelClockShopTime.AutoSize = true;
            this.labelClockShopTime.Location = new System.Drawing.Point(6, 16);
            this.labelClockShopTime.Name = "labelClockShopTime";
            this.labelClockShopTime.Size = new System.Drawing.Size(23, 13);
            this.labelClockShopTime.TabIndex = 0;
            this.labelClockShopTime.Text = "null";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Банк";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBoxBankLog);
            this.groupBox7.Location = new System.Drawing.Point(328, 19);
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
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox17);
            this.groupBox9.Controls.Add(this.groupBox18);
            this.groupBox9.Location = new System.Drawing.Point(12, 346);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(935, 161);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Магазин машин";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.listBoxCarShopLog);
            this.groupBox11.Location = new System.Drawing.Point(331, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(215, 136);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Вывод";
            // 
            // listBoxCarShopLog
            // 
            this.listBoxCarShopLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCarShopLog.FormattingEnabled = true;
            this.listBoxCarShopLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxCarShopLog.Name = "listBoxCarShopLog";
            this.listBoxCarShopLog.Size = new System.Drawing.Size(209, 117);
            this.listBoxCarShopLog.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.listBoxCarShopMessages);
            this.groupBox17.Location = new System.Drawing.Point(110, 19);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(215, 136);
            this.groupBox17.TabIndex = 7;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "События";
            // 
            // listBoxCarShopMessages
            // 
            this.listBoxCarShopMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCarShopMessages.FormattingEnabled = true;
            this.listBoxCarShopMessages.Location = new System.Drawing.Point(3, 16);
            this.listBoxCarShopMessages.Name = "listBoxCarShopMessages";
            this.listBoxCarShopMessages.Size = new System.Drawing.Size(209, 117);
            this.listBoxCarShopMessages.TabIndex = 0;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.labelCarShopTime);
            this.groupBox18.Location = new System.Drawing.Point(6, 19);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(98, 36);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Время";
            // 
            // labelCarShopTime
            // 
            this.labelCarShopTime.AutoSize = true;
            this.labelCarShopTime.Location = new System.Drawing.Point(6, 16);
            this.labelCarShopTime.Name = "labelCarShopTime";
            this.labelCarShopTime.Size = new System.Drawing.Size(23, 13);
            this.labelCarShopTime.TabIndex = 0;
            this.labelCarShopTime.Text = "null";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.probabilityBuyClock);
            this.groupBox19.Location = new System.Drawing.Point(549, 19);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(126, 51);
            this.groupBox19.TabIndex = 10;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Купить часы";
            // 
            // probabilityBuyClock
            // 
            this.probabilityBuyClock.Location = new System.Drawing.Point(6, 19);
            this.probabilityBuyClock.Name = "probabilityBuyClock";
            this.probabilityBuyClock.Size = new System.Drawing.Size(114, 20);
            this.probabilityBuyClock.TabIndex = 0;
            this.probabilityBuyClock.ValueChanged += new System.EventHandler(this.probabilityBuyClock_ValueChanged);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.probabilityBuyCar);
            this.groupBox20.Location = new System.Drawing.Point(549, 76);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(126, 51);
            this.groupBox20.TabIndex = 11;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Купить машину";
            // 
            // probabilityBuyCar
            // 
            this.probabilityBuyCar.Location = new System.Drawing.Point(6, 19);
            this.probabilityBuyCar.Name = "probabilityBuyCar";
            this.probabilityBuyCar.Size = new System.Drawing.Size(114, 20);
            this.probabilityBuyCar.TabIndex = 0;
            this.probabilityBuyCar.ValueChanged += new System.EventHandler(this.probabilityBuyCar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 710);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityGetMoney)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxShopLoan.ResumeLayout(false);
            this.groupBoxShopLoan.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBuyClock)).EndInit();
            this.groupBox20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBuyCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBuierTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelClockShopTime;
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
        private System.Windows.Forms.ListBox listBoxClockShopMessages;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ListBox listBoxBankMessages;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.NumericUpDown probabilityGetMoney;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listBoxBankLog;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListBox listBoxBuierLog;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox listBoxClockShopLog;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox listBoxCarShopLog;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.ListBox listBoxCarShopMessages;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label labelCarShopTime;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.NumericUpDown probabilityBuyClock;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.NumericUpDown probabilityBuyCar;
    }
}

