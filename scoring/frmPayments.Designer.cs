namespace Scoring
{
    partial class frmPayments
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
        	System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Данные о договоре");
        	System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Данные о договоре");
        	this.btnContract = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.lblPaymentsCountInDB = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnSavePayment = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.cmbPay = new System.Windows.Forms.ComboBox();
        	this.lblCountPaymentsInContract = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lstContracts = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.lstPayments = new System.Windows.Forms.ListView();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnContract
        	// 
        	this.btnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnContract.Location = new System.Drawing.Point(740, 316);
        	this.btnContract.Name = "btnContract";
        	this.btnContract.Size = new System.Drawing.Size(140, 40);
        	this.btnContract.TabIndex = 30;
        	this.btnContract.Text = "Договор";
        	this.btnContract.UseVisualStyleBackColor = true;
        	this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label4.Location = new System.Drawing.Point(12, 11);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(238, 20);
        	this.label4.TabIndex = 27;
        	this.label4.Text = "Список платежей по договору";
        	// 
        	// lblPaymentsCountInDB
        	// 
        	this.lblPaymentsCountInDB.AutoSize = true;
        	this.lblPaymentsCountInDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblPaymentsCountInDB.Location = new System.Drawing.Point(859, 15);
        	this.lblPaymentsCountInDB.Name = "lblPaymentsCountInDB";
        	this.lblPaymentsCountInDB.Size = new System.Drawing.Size(15, 16);
        	this.lblPaymentsCountInDB.TabIndex = 26;
        	this.lblPaymentsCountInDB.Text = "0";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label3.Location = new System.Drawing.Point(729, 15);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(118, 16);
        	this.label3.TabIndex = 25;
        	this.label3.Text = "платежей в базе";
        	// 
        	// btnSavePayment
        	// 
        	this.btnSavePayment.Location = new System.Drawing.Point(164, 53);
        	this.btnSavePayment.Name = "btnSavePayment";
        	this.btnSavePayment.Size = new System.Drawing.Size(140, 40);
        	this.btnSavePayment.TabIndex = 104;
        	this.btnSavePayment.Text = "Сохранить";
        	this.btnSavePayment.UseVisualStyleBackColor = true;
        	this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(6, 23);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(136, 16);
        	this.label1.TabIndex = 18;
        	this.label1.Text = "Получен ли платеж";
        	// 
        	// cmbPay
        	// 
        	this.cmbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.cmbPay.FormattingEnabled = true;
        	this.cmbPay.Items.AddRange(new object[] {
        	        	        	"Оплачено",
        	        	        	"Неоплачено"});
        	this.cmbPay.Location = new System.Drawing.Point(164, 23);
        	this.cmbPay.Name = "cmbPay";
        	this.cmbPay.Size = new System.Drawing.Size(140, 24);
        	this.cmbPay.TabIndex = 22;
        	// 
        	// lblCountPaymentsInContract
        	// 
        	this.lblCountPaymentsInContract.AutoSize = true;
        	this.lblCountPaymentsInContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblCountPaymentsInContract.Location = new System.Drawing.Point(645, 15);
        	this.lblCountPaymentsInContract.Name = "lblCountPaymentsInContract";
        	this.lblCountPaymentsInContract.Size = new System.Drawing.Size(15, 16);
        	this.lblCountPaymentsInContract.TabIndex = 108;
        	this.lblCountPaymentsInContract.Text = "0";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label6.Location = new System.Drawing.Point(483, 15);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(156, 16);
        	this.label6.TabIndex = 107;
        	this.label6.Text = "платежей по договору";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.cmbPay);
        	this.groupBox1.Controls.Add(this.btnSavePayment);
        	this.groupBox1.Location = new System.Drawing.Point(12, 122);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(319, 112);
        	this.groupBox1.TabIndex = 109;
        	this.groupBox1.TabStop = false;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label2.Location = new System.Drawing.Point(16, 99);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(237, 20);
        	this.label2.TabIndex = 110;
        	this.label2.Text = "Измените состояние платежа";
        	// 
        	// lstContracts
        	// 
        	this.lstContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2});
        	this.lstContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstContracts.FullRowSelect = true;
        	this.lstContracts.GridLines = true;
        	this.lstContracts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        	this.lstContracts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        	        	        	listViewItem1});
        	this.lstContracts.Location = new System.Drawing.Point(336, 40);
        	this.lstContracts.MultiSelect = false;
        	this.lstContracts.Name = "lstContracts";
        	this.lstContracts.Size = new System.Drawing.Size(544, 85);
        	this.lstContracts.TabIndex = 118;
        	this.lstContracts.UseCompatibleStateImageBehavior = false;
        	this.lstContracts.View = System.Windows.Forms.View.Details;
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "Дата изменения";
        	this.columnHeader1.Width = 166;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Название кредитного предложения";
        	this.columnHeader2.Width = 261;
        	// 
        	// lstPayments
        	// 
        	this.lstPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader3,
        	        	        	this.columnHeader4,
        	        	        	this.columnHeader5,
        	        	        	this.columnHeader6});
        	this.lstPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstPayments.FullRowSelect = true;
        	this.lstPayments.GridLines = true;
        	this.lstPayments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.lstPayments.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        	        	        	listViewItem2});
        	this.lstPayments.Location = new System.Drawing.Point(336, 128);
        	this.lstPayments.MultiSelect = false;
        	this.lstPayments.Name = "lstPayments";
        	this.lstPayments.Size = new System.Drawing.Size(544, 184);
        	this.lstPayments.TabIndex = 119;
        	this.lstPayments.UseCompatibleStateImageBehavior = false;
        	this.lstPayments.View = System.Windows.Forms.View.Details;
        	this.lstPayments.SelectedIndexChanged += new System.EventHandler(this.lstPayments_SelectedIndexChanged);
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Номер договора";
        	this.columnHeader3.Width = 136;
        	// 
        	// columnHeader4
        	// 
        	this.columnHeader4.Text = "Дата платежа";
        	this.columnHeader4.Width = 25;
        	// 
        	// columnHeader5
        	// 
        	this.columnHeader5.Text = "Состояние платежа";
        	this.columnHeader5.Width = 25;
        	// 
        	// columnHeader6
        	// 
        	this.columnHeader6.Text = "Номер транзакции";
        	// 
        	// frmPayments
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.lstPayments);
        	this.Controls.Add(this.lstContracts);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.lblCountPaymentsInContract);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.btnContract);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.lblPaymentsCountInDB);
        	this.Controls.Add(this.label3);
        	this.Name = "frmPayments";
        	this.Text = "Платежи";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;

        #endregion

        private System.Windows.Forms.ListView lstPayments;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaymentsCountInDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstContracts;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.Label lblCountPaymentsInContract;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}