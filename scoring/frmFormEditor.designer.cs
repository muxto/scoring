namespace Scoring
{
    partial class frmFormEditor
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormEditor));
        	this.btnSort = new System.Windows.Forms.Button();
        	this.lblMaxSum = new System.Windows.Forms.Label();
        	this.lblMinSum = new System.Windows.Forms.Label();
        	this.btnSaveForm = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.btnDown = new System.Windows.Forms.Button();
        	this.lstQuestions = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.txtQuestion = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.chkFail = new System.Windows.Forms.CheckBox();
        	this.chkHumanExpert = new System.Windows.Forms.CheckBox();
        	this.txtAnswer = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtMark = new System.Windows.Forms.TextBox();
        	this.btnSaveQuestion = new System.Windows.Forms.Button();
        	this.btn_AddNewQuestion = new System.Windows.Forms.Button();
        	this.btnUp = new System.Windows.Forms.Button();
        	this.btnClearQuestions = new System.Windows.Forms.Button();
        	this.btn_DelQuestion = new System.Windows.Forms.Button();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnSort
        	// 
        	this.btnSort.Location = new System.Drawing.Point(12, 314);
        	this.btnSort.Name = "btnSort";
        	this.btnSort.Size = new System.Drawing.Size(140, 40);
        	this.btnSort.TabIndex = 82;
        	this.btnSort.Text = "Сортировать";
        	this.btnSort.UseVisualStyleBackColor = true;
        	this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
        	// 
        	// lblMaxSum
        	// 
        	this.lblMaxSum.AutoSize = true;
        	this.lblMaxSum.Location = new System.Drawing.Point(355, 339);
        	this.lblMaxSum.Name = "lblMaxSum";
        	this.lblMaxSum.Size = new System.Drawing.Size(14, 15);
        	this.lblMaxSum.TabIndex = 92;
        	this.lblMaxSum.Text = "0";
        	// 
        	// lblMinSum
        	// 
        	this.lblMinSum.AutoSize = true;
        	this.lblMinSum.Location = new System.Drawing.Point(355, 314);
        	this.lblMinSum.Name = "lblMinSum";
        	this.lblMinSum.Size = new System.Drawing.Size(14, 15);
        	this.lblMinSum.TabIndex = 91;
        	this.lblMinSum.Text = "0";
        	// 
        	// btnSaveForm
        	// 
        	this.btnSaveForm.Location = new System.Drawing.Point(741, 314);
        	this.btnSaveForm.Name = "btnSaveForm";
        	this.btnSaveForm.Size = new System.Drawing.Size(140, 40);
        	this.btnSaveForm.TabIndex = 81;
        	this.btnSaveForm.Text = "Сохранить анкету";
        	this.btnSaveForm.UseVisualStyleBackColor = true;
        	this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(158, 339);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(179, 15);
        	this.label4.TabIndex = 90;
        	this.label4.Text = "Максимальная сумма баллов";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(158, 314);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(174, 15);
        	this.label3.TabIndex = 89;
        	this.label3.Text = "Минимальная сумма баллов";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.btnDown);
        	this.groupBox1.Controls.Add(this.lstQuestions);
        	this.groupBox1.Controls.Add(this.label6);
        	this.groupBox1.Controls.Add(this.label7);
        	this.groupBox1.Controls.Add(this.label5);
        	this.groupBox1.Controls.Add(this.txtQuestion);
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.chkFail);
        	this.groupBox1.Controls.Add(this.chkHumanExpert);
        	this.groupBox1.Controls.Add(this.txtAnswer);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Controls.Add(this.txtMark);
        	this.groupBox1.Controls.Add(this.btnSaveQuestion);
        	this.groupBox1.Controls.Add(this.btn_AddNewQuestion);
        	this.groupBox1.Controls.Add(this.btnUp);
        	this.groupBox1.Controls.Add(this.btnClearQuestions);
        	this.groupBox1.Controls.Add(this.btn_DelQuestion);
        	this.groupBox1.Location = new System.Drawing.Point(12, 12);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(869, 296);
        	this.groupBox1.TabIndex = 95;
        	this.groupBox1.TabStop = false;
        	// 
        	// btnDown
        	// 
        	this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnDown.Location = new System.Drawing.Point(488, 263);
        	this.btnDown.Name = "btnDown";
        	this.btnDown.Size = new System.Drawing.Size(41, 27);
        	this.btnDown.TabIndex = 115;
        	this.btnDown.Text = "↓";
        	this.btnDown.UseVisualStyleBackColor = true;
        	this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
        	// 
        	// lstQuestions
        	// 
        	this.lstQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2,
        	        	        	this.columnHeader3,
        	        	        	this.columnHeader4,
        	        	        	this.columnHeader5});
        	this.lstQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstQuestions.FullRowSelect = true;
        	this.lstQuestions.GridLines = true;
        	this.lstQuestions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.lstQuestions.Location = new System.Drawing.Point(344, 40);
        	this.lstQuestions.MultiSelect = false;
        	this.lstQuestions.Name = "lstQuestions";
        	this.lstQuestions.Size = new System.Drawing.Size(512, 216);
        	this.lstQuestions.TabIndex = 114;
        	this.lstQuestions.UseCompatibleStateImageBehavior = false;
        	this.lstQuestions.View = System.Windows.Forms.View.Details;
        	this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.LstQuestionsSelectedIndexChanged);
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "№";
        	this.columnHeader1.Width = 42;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Вопрос";
        	this.columnHeader2.Width = 67;
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Ответ";
        	// 
        	// columnHeader4
        	// 
        	this.columnHeader4.Text = "Балл";
        	// 
        	// columnHeader5
        	// 
        	this.columnHeader5.Text = "Тип";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(347, 17);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(106, 15);
        	this.label6.TabIndex = 111;
        	this.label6.Text = "Список вопросов";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label7.Location = new System.Drawing.Point(7, 17);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(334, 100);
        	this.label7.TabIndex = 110;
        	this.label7.Text = "Добавляйте вопросы в анкету.\r\nВопросы могут с уточнениями \r\nили с вариантами отве" +
        	"тов.\r\nПосле добавления нажмите Сортировать,\r\nзатем Сохранить";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(10, 126);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(102, 15);
        	this.label5.TabIndex = 109;
        	this.label5.Text = "Текущий вопрос:";
        	// 
        	// txtQuestion
        	// 
        	this.txtQuestion.Location = new System.Drawing.Point(11, 144);
        	this.txtQuestion.Name = "txtQuestion";
        	this.txtQuestion.Size = new System.Drawing.Size(314, 21);
        	this.txtQuestion.TabIndex = 102;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(8, 168);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(102, 15);
        	this.label1.TabIndex = 108;
        	this.label1.Text = "Вариант ответа";
        	// 
        	// chkFail
        	// 
        	this.chkFail.AutoSize = true;
        	this.chkFail.Location = new System.Drawing.Point(129, 230);
        	this.chkFail.Name = "chkFail";
        	this.chkFail.Size = new System.Drawing.Size(122, 19);
        	this.chkFail.TabIndex = 107;
        	this.chkFail.Text = "Отказ в кредите";
        	this.chkFail.UseVisualStyleBackColor = true;
        	this.chkFail.Click += new System.EventHandler(this.chkFail_CheckedChanged);
        	// 
        	// chkHumanExpert
        	// 
        	this.chkHumanExpert.AutoSize = true;
        	this.chkHumanExpert.Location = new System.Drawing.Point(129, 210);
        	this.chkHumanExpert.Name = "chkHumanExpert";
        	this.chkHumanExpert.Size = new System.Drawing.Size(155, 19);
        	this.chkHumanExpert.TabIndex = 106;
        	this.chkHumanExpert.Text = "Оценивается позднее";
        	this.chkHumanExpert.UseVisualStyleBackColor = true;
        	this.chkHumanExpert.Click += new System.EventHandler(this.chkHumanExpert_CheckedChanged);
        	// 
        	// txtAnswer
        	// 
        	this.txtAnswer.Location = new System.Drawing.Point(11, 186);
        	this.txtAnswer.Name = "txtAnswer";
        	this.txtAnswer.Size = new System.Drawing.Size(314, 21);
        	this.txtAnswer.TabIndex = 103;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(10, 210);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(36, 15);
        	this.label2.TabIndex = 105;
        	this.label2.Text = "Балл";
        	// 
        	// txtMark
        	// 
        	this.txtMark.Location = new System.Drawing.Point(11, 228);
        	this.txtMark.Name = "txtMark";
        	this.txtMark.Size = new System.Drawing.Size(94, 21);
        	this.txtMark.TabIndex = 104;
        	
        	this.txtMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMark_KeyPress);
        	// 
        	// btnSaveQuestion
        	// 
        	this.btnSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnSaveQuestion.Location = new System.Drawing.Point(255, 263);
        	this.btnSaveQuestion.Name = "btnSaveQuestion";
        	this.btnSaveQuestion.Size = new System.Drawing.Size(86, 27);
        	this.btnSaveQuestion.TabIndex = 101;
        	this.btnSaveQuestion.Text = "Сохранить";
        	this.btnSaveQuestion.UseVisualStyleBackColor = true;
        	this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
        	// 
        	// btn_AddNewQuestion
        	// 
        	this.btn_AddNewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btn_AddNewQuestion.Location = new System.Drawing.Point(163, 263);
        	this.btn_AddNewQuestion.Name = "btn_AddNewQuestion";
        	this.btn_AddNewQuestion.Size = new System.Drawing.Size(86, 27);
        	this.btn_AddNewQuestion.TabIndex = 100;
        	this.btn_AddNewQuestion.Text = "Добавить";
        	this.btn_AddNewQuestion.UseVisualStyleBackColor = true;
        	this.btn_AddNewQuestion.Click += new System.EventHandler(this.btn_AddNewQuestion_Click);
        	// 
        	// btnUp
        	// 
        	this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnUp.Location = new System.Drawing.Point(439, 263);
        	this.btnUp.Name = "btnUp";
        	this.btnUp.Size = new System.Drawing.Size(41, 27);
        	this.btnUp.TabIndex = 98;
        	this.btnUp.Text = "↑";
        	this.btnUp.UseVisualStyleBackColor = true;
        	this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
        	// 
        	// btnClearQuestions
        	// 
        	this.btnClearQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnClearQuestions.Location = new System.Drawing.Point(768, 263);
        	this.btnClearQuestions.Name = "btnClearQuestions";
        	this.btnClearQuestions.Size = new System.Drawing.Size(86, 27);
        	this.btnClearQuestions.TabIndex = 96;
        	this.btnClearQuestions.Text = "Очистить";
        	this.btnClearQuestions.UseVisualStyleBackColor = true;
        	this.btnClearQuestions.Click += new System.EventHandler(this.btnClearQuestions_Click);
        	// 
        	// btn_DelQuestion
        	// 
        	this.btn_DelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btn_DelQuestion.Location = new System.Drawing.Point(668, 263);
        	this.btn_DelQuestion.Name = "btn_DelQuestion";
        	this.btn_DelQuestion.Size = new System.Drawing.Size(86, 27);
        	this.btn_DelQuestion.TabIndex = 95;
        	this.btn_DelQuestion.Text = "Удалить";
        	this.btn_DelQuestion.UseVisualStyleBackColor = true;
        	this.btn_DelQuestion.Click += new System.EventHandler(this.btn_DelQuestion_Click);
        	// 
        	// frmFormEditor
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.btnSort);
        	this.Controls.Add(this.lblMaxSum);
        	this.Controls.Add(this.lblMinSum);
        	this.Controls.Add(this.btnSaveForm);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "frmFormEditor";
        	this.Text = "Редактор анкет";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblMaxSum;
        private System.Windows.Forms.Label lblMinSum;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFail;
        private System.Windows.Forms.CheckBox chkHumanExpert;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btn_AddNewQuestion;
        private System.Windows.Forms.ListView lstQuestions;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnClearQuestions;
        private System.Windows.Forms.Button btn_DelQuestion;

    }
}

