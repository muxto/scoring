namespace Scoring
{
    partial class frmCalculate
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lstCredit = new System.Windows.Forms.ListBox();
        	this.cmbCredits = new System.Windows.Forms.ComboBox();
        	this.numMonth = new System.Windows.Forms.NumericUpDown();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txtCreditSum = new System.Windows.Forms.TextBox();
        	this.btnAnnuity = new System.Windows.Forms.Button();
        	this.label7 = new System.Windows.Forms.Label();
        	this.lblPercent = new System.Windows.Forms.Label();
        	this.lstPayments = new System.Windows.Forms.ListBox();
        	this.btnDifferent = new System.Windows.Forms.Button();
        	this.lblStudents = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btnNext = new System.Windows.Forms.Button();
        	this.btnGraph = new System.Windows.Forms.Button();
        	this.lblMonthPay = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lstCredit
        	// 
        	this.lstCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstCredit.FormattingEnabled = true;
        	this.lstCredit.HorizontalScrollbar = true;
        	this.lstCredit.ItemHeight = 16;
        	this.lstCredit.Location = new System.Drawing.Point(349, 60);
        	this.lstCredit.MultiColumn = true;
        	this.lstCredit.Name = "lstCredit";
        	this.lstCredit.Size = new System.Drawing.Size(278, 292);
        	this.lstCredit.TabIndex = 21;
        	// 
        	// cmbCredits
        	// 
        	this.cmbCredits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.cmbCredits.FormattingEnabled = true;
        	this.cmbCredits.Location = new System.Drawing.Point(16, 60);
        	this.cmbCredits.Name = "cmbCredits";
        	this.cmbCredits.Size = new System.Drawing.Size(327, 24);
        	this.cmbCredits.TabIndex = 0;
        	this.cmbCredits.SelectedIndexChanged += new System.EventHandler(this.cmbCredits_SelectedIndexChanged);
        	// 
        	// numMonth
        	// 
        	this.numMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.numMonth.Location = new System.Drawing.Point(212, 131);
        	this.numMonth.Name = "numMonth";
        	this.numMonth.Size = new System.Drawing.Size(120, 22);
        	this.numMonth.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(17, 137);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(114, 16);
        	this.label1.TabIndex = 23;
        	this.label1.Text = "Месяцев, кол-во";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label3.Location = new System.Drawing.Point(17, 107);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(81, 16);
        	this.label3.TabIndex = 27;
        	this.label3.Text = "Сумма, руб";
        	// 
        	// txtCreditSum
        	// 
        	this.txtCreditSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.txtCreditSum.Location = new System.Drawing.Point(212, 101);
        	this.txtCreditSum.Name = "txtCreditSum";
        	this.txtCreditSum.Size = new System.Drawing.Size(120, 22);
        	this.txtCreditSum.TabIndex = 1;
        	this.txtCreditSum.Text = "1000";
        	this.txtCreditSum.TextChanged += new System.EventHandler(this.txtCreditSum_TextChanged);
        	this.txtCreditSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditSum_KeyPress);
        	// 
        	// btnAnnuity
        	// 
        	this.btnAnnuity.Enabled = false;
        	this.btnAnnuity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnAnnuity.Location = new System.Drawing.Point(192, 312);
        	this.btnAnnuity.Name = "btnAnnuity";
        	this.btnAnnuity.Size = new System.Drawing.Size(140, 40);
        	this.btnAnnuity.TabIndex = 4;
        	this.btnAnnuity.Text = "Аннуитетные платежи";
        	this.btnAnnuity.UseVisualStyleBackColor = true;
        	this.btnAnnuity.Click += new System.EventHandler(this.btnAnnuity_Click);
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label7.Location = new System.Drawing.Point(17, 163);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(65, 16);
        	this.label7.TabIndex = 34;
        	this.label7.Text = "Процент";
        	// 
        	// lblPercent
        	// 
        	this.lblPercent.AutoSize = true;
        	this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblPercent.Location = new System.Drawing.Point(209, 160);
        	this.lblPercent.Name = "lblPercent";
        	this.lblPercent.Size = new System.Drawing.Size(15, 16);
        	this.lblPercent.TabIndex = 35;
        	this.lblPercent.Text = "0";
        	// 
        	// lstPayments
        	// 
        	this.lstPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstPayments.FormattingEnabled = true;
        	this.lstPayments.ItemHeight = 16;
        	this.lstPayments.Location = new System.Drawing.Point(633, 12);
        	this.lstPayments.Name = "lstPayments";
        	this.lstPayments.Size = new System.Drawing.Size(247, 292);
        	this.lstPayments.TabIndex = 36;
        	// 
        	// btnDifferent
        	// 
        	this.btnDifferent.Enabled = false;
        	this.btnDifferent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnDifferent.Location = new System.Drawing.Point(12, 312);
        	this.btnDifferent.Name = "btnDifferent";
        	this.btnDifferent.Size = new System.Drawing.Size(140, 40);
        	this.btnDifferent.TabIndex = 3;
        	this.btnDifferent.Text = "Дифференцированные платежи";
        	this.btnDifferent.UseVisualStyleBackColor = true;
        	this.btnDifferent.Click += new System.EventHandler(this.btnDifferent_Click);
        	// 
        	// lblStudents
        	// 
        	this.lblStudents.AutoSize = true;
        	this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblStudents.Location = new System.Drawing.Point(12, 9);
        	this.lblStudents.Name = "lblStudents";
        	this.lblStudents.Size = new System.Drawing.Size(395, 40);
        	this.lblStudents.TabIndex = 38;
        	this.lblStudents.Text = "Кредитный калькулятор\r\nВыберите кредит, введите сумму и число месяцев\r\n";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label2.Location = new System.Drawing.Point(12, 280);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(316, 20);
        	this.label2.TabIndex = 39;
        	this.label2.Text = "Выберите один из двух видов платежей";
        	// 
        	// btnNext
        	// 
        	this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnNext.Location = new System.Drawing.Point(740, 314);
        	this.btnNext.Name = "btnNext";
        	this.btnNext.Size = new System.Drawing.Size(140, 40);
        	this.btnNext.TabIndex = 6;
        	this.btnNext.Text = "Оформить";
        	this.btnNext.UseVisualStyleBackColor = true;
        	this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        	// 
        	// btnGraph
        	// 
        	this.btnGraph.Enabled = false;
        	this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnGraph.Location = new System.Drawing.Point(633, 314);
        	this.btnGraph.Name = "btnGraph";
        	this.btnGraph.Size = new System.Drawing.Size(101, 40);
        	this.btnGraph.TabIndex = 5;
        	this.btnGraph.Text = "График";
        	this.btnGraph.UseVisualStyleBackColor = true;
        	this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
        	// 
        	// lblMonthPay
        	// 
        	this.lblMonthPay.AutoSize = true;
        	this.lblMonthPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblMonthPay.Location = new System.Drawing.Point(208, 189);
        	this.lblMonthPay.Name = "lblMonthPay";
        	this.lblMonthPay.Size = new System.Drawing.Size(15, 16);
        	this.lblMonthPay.TabIndex = 50;
        	this.lblMonthPay.Text = "0";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label5.Location = new System.Drawing.Point(16, 192);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(157, 16);
        	this.label5.TabIndex = 49;
        	this.label5.Text = "Ежемесячная выплата";
        	// 
        	// frmCalculate
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.lblMonthPay);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.btnGraph);
        	this.Controls.Add(this.btnNext);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.lblStudents);
        	this.Controls.Add(this.btnDifferent);
        	this.Controls.Add(this.lstPayments);
        	this.Controls.Add(this.lblPercent);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.btnAnnuity);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.txtCreditSum);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.numMonth);
        	this.Controls.Add(this.lstCredit);
        	this.Controls.Add(this.cmbCredits);
        	this.Name = "frmCalculate";
        	this.Text = "Кредитный калькулятор";
        	((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonthPay;

        #endregion

        private System.Windows.Forms.ListBox lstCredit;
        private System.Windows.Forms.ComboBox cmbCredits;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditSum;
        private System.Windows.Forms.Button btnAnnuity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.Button btnDifferent;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGraph;
    }
}