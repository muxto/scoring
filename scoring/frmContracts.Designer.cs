namespace Scoring
{
    partial class frmContracts
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
        	System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Данные о заявке");
        	System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Данные о договоре");
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btnFindByAnswer = new System.Windows.Forms.Button();
        	this.txtAnswer = new System.Windows.Forms.TextBox();
        	this.cmbCategory = new System.Windows.Forms.ComboBox();
        	this.lstFound = new System.Windows.Forms.ListBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.lblContractsCount = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.btnClient = new System.Windows.Forms.Button();
        	this.btnPayments = new System.Windows.Forms.Button();
        	this.lstRequest = new System.Windows.Forms.ListView();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.lstContracts = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(13, 49);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(95, 16);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "по категории";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label2.Location = new System.Drawing.Point(13, 88);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(73, 16);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "по ответу";
        	// 
        	// btnFindByAnswer
        	// 
        	this.btnFindByAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnFindByAnswer.Location = new System.Drawing.Point(250, 82);
        	this.btnFindByAnswer.Name = "btnFindByAnswer";
        	this.btnFindByAnswer.Size = new System.Drawing.Size(153, 37);
        	this.btnFindByAnswer.TabIndex = 3;
        	this.btnFindByAnswer.Text = "искать по ответу";
        	this.btnFindByAnswer.UseVisualStyleBackColor = true;
        	this.btnFindByAnswer.Click += new System.EventHandler(this.btnFindByAnswer_Click);
        	// 
        	// txtAnswer
        	// 
        	this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.txtAnswer.Location = new System.Drawing.Point(114, 82);
        	this.txtAnswer.Name = "txtAnswer";
        	this.txtAnswer.Size = new System.Drawing.Size(121, 22);
        	this.txtAnswer.TabIndex = 2;
        	// 
        	// cmbCategory
        	// 
        	this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.cmbCategory.FormattingEnabled = true;
        	this.cmbCategory.Items.AddRange(new object[] {
        	        	        	"Номер договора",
        	        	        	"Номер счета",
        	        	        	"Дата начала контракта",
        	        	        	"Дата окончания контракта"});
        	this.cmbCategory.Location = new System.Drawing.Point(114, 46);
        	this.cmbCategory.Name = "cmbCategory";
        	this.cmbCategory.Size = new System.Drawing.Size(286, 24);
        	this.cmbCategory.TabIndex = 0;
        	this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
        	// 
        	// lstFound
        	// 
        	this.lstFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstFound.FormattingEnabled = true;
        	this.lstFound.ItemHeight = 16;
        	this.lstFound.Items.AddRange(new object[] {
        	        	        	"Введите запрос"});
        	this.lstFound.Location = new System.Drawing.Point(16, 137);
        	this.lstFound.Name = "lstFound";
        	this.lstFound.Size = new System.Drawing.Size(387, 212);
        	this.lstFound.TabIndex = 4;
        	this.lstFound.SelectedIndexChanged += new System.EventHandler(this.lstFound_SelectedIndexChanged);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label3.Location = new System.Drawing.Point(729, 13);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(124, 16);
        	this.label3.TabIndex = 7;
        	this.label3.Text = "договоров в базе";
        	// 
        	// lblContractsCount
        	// 
        	this.lblContractsCount.AutoSize = true;
        	this.lblContractsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblContractsCount.Location = new System.Drawing.Point(859, 13);
        	this.lblContractsCount.Name = "lblContractsCount";
        	this.lblContractsCount.Size = new System.Drawing.Size(15, 16);
        	this.lblContractsCount.TabIndex = 8;
        	this.lblContractsCount.Text = "0";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label4.Location = new System.Drawing.Point(12, 9);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(485, 20);
        	this.label4.TabIndex = 12;
        	this.label4.Text = "Список договоров по категории, поиск по значению категории";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label5.Location = new System.Drawing.Point(13, 114);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(188, 16);
        	this.label5.TabIndex = 13;
        	this.label5.Text = "выберите среди найденных";
        	// 
        	// btnClient
        	// 
        	this.btnClient.Enabled = false;
        	this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnClient.Location = new System.Drawing.Point(740, 314);
        	this.btnClient.Name = "btnClient";
        	this.btnClient.Size = new System.Drawing.Size(140, 40);
        	this.btnClient.TabIndex = 6;
        	this.btnClient.Text = "Клиент";
        	this.btnClient.UseVisualStyleBackColor = true;
        	this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
        	// 
        	// btnPayments
        	// 
        	this.btnPayments.Enabled = false;
        	this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnPayments.Location = new System.Drawing.Point(594, 314);
        	this.btnPayments.Name = "btnPayments";
        	this.btnPayments.Size = new System.Drawing.Size(140, 40);
        	this.btnPayments.TabIndex = 5;
        	this.btnPayments.Text = "Платежи";
        	this.btnPayments.UseVisualStyleBackColor = true;
        	this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
        	// 
        	// lstRequest
        	// 
        	this.lstRequest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader3,
        	        	        	this.columnHeader4});
        	this.lstRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstRequest.FullRowSelect = true;
        	this.lstRequest.GridLines = true;
        	this.lstRequest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        	this.lstRequest.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        	        	        	listViewItem1});
        	this.lstRequest.Location = new System.Drawing.Point(408, 120);
        	this.lstRequest.MultiSelect = false;
        	this.lstRequest.Name = "lstRequest";
        	this.lstRequest.Size = new System.Drawing.Size(472, 93);
        	this.lstRequest.TabIndex = 116;
        	this.lstRequest.UseCompatibleStateImageBehavior = false;
        	this.lstRequest.View = System.Windows.Forms.View.Details;
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Дата изменения";
        	this.columnHeader3.Width = 166;
        	// 
        	// columnHeader4
        	// 
        	this.columnHeader4.Text = "Название кредитного предложения";
        	this.columnHeader4.Width = 261;
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
        	        	        	listViewItem2});
        	this.lstContracts.Location = new System.Drawing.Point(408, 216);
        	this.lstContracts.MultiSelect = false;
        	this.lstContracts.Name = "lstContracts";
        	this.lstContracts.Size = new System.Drawing.Size(472, 93);
        	this.lstContracts.TabIndex = 117;
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
        	// frmContracts
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.lstContracts);
        	this.Controls.Add(this.lstRequest);
        	this.Controls.Add(this.btnPayments);
        	this.Controls.Add(this.btnClient);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.lblContractsCount);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.lstFound);
        	this.Controls.Add(this.cmbCategory);
        	this.Controls.Add(this.txtAnswer);
        	this.Controls.Add(this.btnFindByAnswer);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Name = "frmContracts";
        	this.Text = "Список договоров";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindByAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lstFound;
        private System.Windows.Forms.ListView lstContracts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContractsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.ListView lstRequest;
    }
}