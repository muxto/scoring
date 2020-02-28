namespace Scoring
{
    partial class frmOutClient
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnNext = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lblMarkSum = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.lblProfit = new System.Windows.Forms.Label();
        	this.lblCreditStatus = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.lblMonthPay = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.lstClient = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(473, 13);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(394, 20);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Проверьте правильность введенной информации";
        	// 
        	// btnNext
        	// 
        	this.btnNext.Location = new System.Drawing.Point(740, 314);
        	this.btnNext.Name = "btnNext";
        	this.btnNext.Size = new System.Drawing.Size(140, 40);
        	this.btnNext.TabIndex = 3;
        	this.btnNext.Text = "Далее";
        	this.btnNext.UseVisualStyleBackColor = true;
        	this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(537, 96);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(105, 16);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Сумма баллов ";
        	// 
        	// lblMarkSum
        	// 
        	this.lblMarkSum.AutoSize = true;
        	this.lblMarkSum.Location = new System.Drawing.Point(662, 96);
        	this.lblMarkSum.Name = "lblMarkSum";
        	this.lblMarkSum.Size = new System.Drawing.Size(15, 16);
        	this.lblMarkSum.TabIndex = 5;
        	this.lblMarkSum.Text = "0";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(537, 128);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(113, 16);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Чистая прибыль";
        	// 
        	// lblProfit
        	// 
        	this.lblProfit.AutoSize = true;
        	this.lblProfit.Location = new System.Drawing.Point(662, 128);
        	this.lblProfit.Name = "lblProfit";
        	this.lblProfit.Size = new System.Drawing.Size(15, 16);
        	this.lblProfit.TabIndex = 7;
        	this.lblProfit.Text = "0";
        	// 
        	// lblCreditStatus
        	// 
        	this.lblCreditStatus.AutoSize = true;
        	this.lblCreditStatus.Location = new System.Drawing.Point(662, 160);
        	this.lblCreditStatus.Name = "lblCreditStatus";
        	this.lblCreditStatus.Size = new System.Drawing.Size(15, 16);
        	this.lblCreditStatus.TabIndex = 9;
        	this.lblCreditStatus.Text = "_";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(537, 160);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(111, 16);
        	this.label5.TabIndex = 8;
        	this.label5.Text = "Статус кредита";
        	// 
        	// lblMonthPay
        	// 
        	this.lblMonthPay.AutoSize = true;
        	this.lblMonthPay.Location = new System.Drawing.Point(661, 192);
        	this.lblMonthPay.Name = "lblMonthPay";
        	this.lblMonthPay.Size = new System.Drawing.Size(15, 16);
        	this.lblMonthPay.TabIndex = 11;
        	this.lblMonthPay.Text = "_";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(536, 192);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(103, 32);
        	this.label7.TabIndex = 10;
        	this.label7.Text = "Ежемесячный \r\nплатеж";
        	// 
        	// lstClient
        	// 
        	this.lstClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2});
        	this.lstClient.FullRowSelect = true;
        	this.lstClient.GridLines = true;
        	this.lstClient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        	this.lstClient.Location = new System.Drawing.Point(8, 8);
        	this.lstClient.MultiSelect = false;
        	this.lstClient.Name = "lstClient";
        	this.lstClient.Size = new System.Drawing.Size(456, 344);
        	this.lstClient.TabIndex = 12;
        	this.lstClient.UseCompatibleStateImageBehavior = false;
        	this.lstClient.View = System.Windows.Forms.View.Details;
        	// 
        	// frmOutClient
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.lstClient);
        	this.Controls.Add(this.lblMonthPay);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.lblCreditStatus);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.lblProfit);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.lblMarkSum);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.btnNext);
        	this.Controls.Add(this.label1);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "frmOutClient";
        	this.Text = "Проверка данных заявки";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMonthPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreditStatus;

        #endregion

        private System.Windows.Forms.ListView lstClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMarkSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfit;
    }
}