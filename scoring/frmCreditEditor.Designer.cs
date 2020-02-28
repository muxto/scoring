namespace Scoring
{
    partial class frmCreditEditor
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
        	this.btnSaveCredit = new System.Windows.Forms.Button();
        	this.btnSort = new System.Windows.Forms.Button();
        	this.txtPercent = new System.Windows.Forms.TextBox();
        	this.txtSum = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnUp = new System.Windows.Forms.Button();
        	this.btnSaveSumPercent = new System.Windows.Forms.Button();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.lstSumPercent = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.btn_AddNewSumPercent = new System.Windows.Forms.Button();
        	this.btnClearSumPercent = new System.Windows.Forms.Button();
        	this.btn_DelSumPercent = new System.Windows.Forms.Button();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.numMaxMonth = new System.Windows.Forms.NumericUpDown();
        	this.label5 = new System.Windows.Forms.Label();
        	this.numMinMonth = new System.Windows.Forms.NumericUpDown();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtMaxSum = new System.Windows.Forms.TextBox();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.btnDown = new System.Windows.Forms.Button();
        	this.groupBox2.SuspendLayout();
        	this.groupBox3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMaxMonth)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinMonth)).BeginInit();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnSaveCredit
        	// 
        	this.btnSaveCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnSaveCredit.Location = new System.Drawing.Point(736, 317);
        	this.btnSaveCredit.Margin = new System.Windows.Forms.Padding(4);
        	this.btnSaveCredit.Name = "btnSaveCredit";
        	this.btnSaveCredit.Size = new System.Drawing.Size(139, 33);
        	this.btnSaveCredit.TabIndex = 8;
        	this.btnSaveCredit.Text = "Сохранить кредит";
        	this.btnSaveCredit.UseVisualStyleBackColor = true;
        	this.btnSaveCredit.Click += new System.EventHandler(this.btnSaveCredit_Click);
        	// 
        	// btnSort
        	// 
        	this.btnSort.Location = new System.Drawing.Point(935, 23);
        	this.btnSort.Margin = new System.Windows.Forms.Padding(4);
        	this.btnSort.Name = "btnSort";
        	this.btnSort.Size = new System.Drawing.Size(153, 28);
        	this.btnSort.TabIndex = 26;
        	this.btnSort.Text = "Сортировать";
        	this.btnSort.UseVisualStyleBackColor = true;
        	// 
        	// txtPercent
        	// 
        	this.txtPercent.Location = new System.Drawing.Point(167, 40);
        	this.txtPercent.Margin = new System.Windows.Forms.Padding(4);
        	this.txtPercent.Name = "txtPercent";
        	this.txtPercent.Size = new System.Drawing.Size(124, 22);
        	this.txtPercent.TabIndex = 1;
        	this.txtPercent.Text = "0";
        	this.txtPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercent_KeyPress);
        	// 
        	// txtSum
        	// 
        	this.txtSum.Location = new System.Drawing.Point(11, 40);
        	this.txtSum.Margin = new System.Windows.Forms.Padding(4);
        	this.txtSum.Name = "txtSum";
        	this.txtSum.Size = new System.Drawing.Size(124, 22);
        	this.txtSum.TabIndex = 0;
        	this.txtSum.Text = "0";
        	this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
        	this.txtSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(164, 19);
        	this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(180, 16);
        	this.label4.TabIndex = 62;
        	this.label4.Text = "Процент до данной суммы";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(8, 19);
        	this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(51, 16);
        	this.label3.TabIndex = 61;
        	this.label3.Text = "Cумма";
        	// 
        	// btnUp
        	// 
        	this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnUp.Location = new System.Drawing.Point(391, 317);
        	this.btnUp.Margin = new System.Windows.Forms.Padding(4);
        	this.btnUp.Name = "btnUp";
        	this.btnUp.Size = new System.Drawing.Size(55, 33);
        	this.btnUp.TabIndex = 6;
        	this.btnUp.Text = "↑";
        	this.btnUp.UseVisualStyleBackColor = true;
        	this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
        	// 
        	// btnSaveSumPercent
        	// 
        	this.btnSaveSumPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnSaveSumPercent.Location = new System.Drawing.Point(140, 317);
        	this.btnSaveSumPercent.Margin = new System.Windows.Forms.Padding(4);
        	this.btnSaveSumPercent.Name = "btnSaveSumPercent";
        	this.btnSaveSumPercent.Size = new System.Drawing.Size(115, 33);
        	this.btnSaveSumPercent.TabIndex = 4;
        	this.btnSaveSumPercent.Text = "Сохранить";
        	this.btnSaveSumPercent.UseVisualStyleBackColor = true;
        	this.btnSaveSumPercent.Click += new System.EventHandler(this.btnSaveSumPercent_Click);
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox2.Controls.Add(this.lstSumPercent);
        	this.groupBox2.Location = new System.Drawing.Point(390, 3);
        	this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox2.Size = new System.Drawing.Size(488, 306);
        	this.groupBox2.TabIndex = 1;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Список процентных ставок";
        	// 
        	// lstSumPercent
        	// 
        	this.lstSumPercent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2});
        	this.lstSumPercent.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lstSumPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstSumPercent.FullRowSelect = true;
        	this.lstSumPercent.GridLines = true;
        	this.lstSumPercent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.lstSumPercent.Location = new System.Drawing.Point(4, 19);
        	this.lstSumPercent.MultiSelect = false;
        	this.lstSumPercent.Name = "lstSumPercent";
        	this.lstSumPercent.Size = new System.Drawing.Size(480, 283);
        	this.lstSumPercent.TabIndex = 0;
        	this.lstSumPercent.UseCompatibleStateImageBehavior = false;
        	this.lstSumPercent.View = System.Windows.Forms.View.Details;
        	this.lstSumPercent.SelectedIndexChanged += new System.EventHandler(this.LstSumPercentSelectedIndexChanged);
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "Процентная ставка";
        	this.columnHeader1.Width = 166;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Максимальная сумма";
        	this.columnHeader2.Width = 261;
        	// 
        	// btn_AddNewSumPercent
        	// 
        	this.btn_AddNewSumPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btn_AddNewSumPercent.Location = new System.Drawing.Point(17, 317);
        	this.btn_AddNewSumPercent.Margin = new System.Windows.Forms.Padding(4);
        	this.btn_AddNewSumPercent.Name = "btn_AddNewSumPercent";
        	this.btn_AddNewSumPercent.Size = new System.Drawing.Size(115, 33);
        	this.btn_AddNewSumPercent.TabIndex = 3;
        	this.btn_AddNewSumPercent.Text = "Добавить";
        	this.btn_AddNewSumPercent.UseVisualStyleBackColor = true;
        	this.btn_AddNewSumPercent.Click += new System.EventHandler(this.btn_AddNewSumPercent_Click);
        	// 
        	// btnClearSumPercent
        	// 
        	this.btnClearSumPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnClearSumPercent.Location = new System.Drawing.Point(576, 317);
        	this.btnClearSumPercent.Margin = new System.Windows.Forms.Padding(4);
        	this.btnClearSumPercent.Name = "btnClearSumPercent";
        	this.btnClearSumPercent.Size = new System.Drawing.Size(115, 33);
        	this.btnClearSumPercent.TabIndex = 7;
        	this.btnClearSumPercent.Text = "Очистить";
        	this.btnClearSumPercent.UseVisualStyleBackColor = true;
        	this.btnClearSumPercent.Click += new System.EventHandler(this.btnClearSumPercent_Click);
        	// 
        	// btn_DelSumPercent
        	// 
        	this.btn_DelSumPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btn_DelSumPercent.Location = new System.Drawing.Point(264, 317);
        	this.btn_DelSumPercent.Margin = new System.Windows.Forms.Padding(4);
        	this.btn_DelSumPercent.Name = "btn_DelSumPercent";
        	this.btn_DelSumPercent.Size = new System.Drawing.Size(115, 33);
        	this.btn_DelSumPercent.TabIndex = 5;
        	this.btn_DelSumPercent.Text = "Удалить";
        	this.btn_DelSumPercent.UseVisualStyleBackColor = true;
        	this.btn_DelSumPercent.Click += new System.EventHandler(this.btn_DelSumPercent_Click);
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox3.AutoSize = true;
        	this.groupBox3.Controls.Add(this.numMaxMonth);
        	this.groupBox3.Controls.Add(this.label5);
        	this.groupBox3.Controls.Add(this.numMinMonth);
        	this.groupBox3.Controls.Add(this.label1);
        	this.groupBox3.Controls.Add(this.label2);
        	this.groupBox3.Controls.Add(this.txtMaxSum);
        	this.groupBox3.Controls.Add(this.txtName);
        	this.groupBox3.Location = new System.Drawing.Point(13, 66);
        	this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox3.Size = new System.Drawing.Size(369, 173);
        	this.groupBox3.TabIndex = 0;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "Название кредита";
        	// 
        	// numMaxMonth
        	// 
        	this.numMaxMonth.Location = new System.Drawing.Point(188, 69);
        	this.numMaxMonth.Margin = new System.Windows.Forms.Padding(4);
        	this.numMaxMonth.Name = "numMaxMonth";
        	this.numMaxMonth.Size = new System.Drawing.Size(160, 22);
        	this.numMaxMonth.TabIndex = 2;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(184, 48);
        	this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(177, 16);
        	this.label5.TabIndex = 48;
        	this.label5.Text = "Число месяцев, максимум";
        	// 
        	// numMinMonth
        	// 
        	this.numMinMonth.Location = new System.Drawing.Point(14, 69);
        	this.numMinMonth.Margin = new System.Windows.Forms.Padding(4);
        	this.numMinMonth.Name = "numMinMonth";
        	this.numMinMonth.Size = new System.Drawing.Size(160, 22);
        	this.numMinMonth.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(10, 48);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(171, 16);
        	this.label1.TabIndex = 46;
        	this.label1.Text = "Число месяцев, минимум";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 106);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(148, 16);
        	this.label2.TabIndex = 45;
        	this.label2.Text = "Максимальная сумма";
        	// 
        	// txtMaxSum
        	// 
        	this.txtMaxSum.Location = new System.Drawing.Point(16, 128);
        	this.txtMaxSum.Margin = new System.Windows.Forms.Padding(4);
        	this.txtMaxSum.Name = "txtMaxSum";
        	this.txtMaxSum.Size = new System.Drawing.Size(144, 22);
        	this.txtMaxSum.TabIndex = 3;
        	this.txtMaxSum.Text = "0";
        	this.txtMaxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSum_KeyPress);
        	// 
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(16, 19);
        	this.txtName.Margin = new System.Windows.Forms.Padding(4);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(336, 22);
        	this.txtName.TabIndex = 0;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.txtPercent);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.txtSum);
        	this.groupBox1.Location = new System.Drawing.Point(17, 235);
        	this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Size = new System.Drawing.Size(367, 74);
        	this.groupBox1.TabIndex = 2;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Процентные ставки";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label7.Location = new System.Drawing.Point(12, 9);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(310, 40);
        	this.label7.TabIndex = 111;
        	this.label7.Text = "Добавляйте кредиты\r\nПосле добавления нажмите Сохранить";
        	// 
        	// btnDown
        	// 
        	this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnDown.Location = new System.Drawing.Point(454, 317);
        	this.btnDown.Margin = new System.Windows.Forms.Padding(4);
        	this.btnDown.Name = "btnDown";
        	this.btnDown.Size = new System.Drawing.Size(55, 33);
        	this.btnDown.TabIndex = 112;
        	this.btnDown.Text = "↓";
        	this.btnDown.UseVisualStyleBackColor = true;
        	this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
        	// 
        	// frmCreditEditor
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.btnDown);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.btnUp);
        	this.Controls.Add(this.btnSaveSumPercent);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.btn_AddNewSumPercent);
        	this.Controls.Add(this.btnClearSumPercent);
        	this.Controls.Add(this.btn_DelSumPercent);
        	this.Controls.Add(this.groupBox3);
        	this.Controls.Add(this.btnSaveCredit);
        	this.Controls.Add(this.btnSort);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "frmCreditEditor";
        	this.Text = "Редактор кредитов";
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox3.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMaxMonth)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinMonth)).EndInit();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;

        #endregion

        private System.Windows.Forms.Button btnSaveCredit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSaveSumPercent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstSumPercent;
        private System.Windows.Forms.Button btn_AddNewSumPercent;
        private System.Windows.Forms.Button btnClearSumPercent;
        private System.Windows.Forms.Button btn_DelSumPercent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numMaxMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxSum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}