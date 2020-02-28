namespace Scoring
{
    partial class frmForms
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
        	this.btnOpenForm = new System.Windows.Forms.Button();
        	this.btnTest = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lblCountQuestions = new System.Windows.Forms.Label();
        	this.lblDateOfChange = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// btnOpenForm
        	// 
        	this.btnOpenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnOpenForm.Location = new System.Drawing.Point(24, 168);
        	this.btnOpenForm.Name = "btnOpenForm";
        	this.btnOpenForm.Size = new System.Drawing.Size(140, 40);
        	this.btnOpenForm.TabIndex = 24;
        	this.btnOpenForm.Text = "Редактировать";
        	this.btnOpenForm.UseVisualStyleBackColor = true;
        	this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
        	// 
        	// btnTest
        	// 
        	this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnTest.Location = new System.Drawing.Point(24, 48);
        	this.btnTest.Name = "btnTest";
        	this.btnTest.Size = new System.Drawing.Size(140, 40);
        	this.btnTest.TabIndex = 26;
        	this.btnTest.Text = "Пройти анкету";
        	this.btnTest.UseVisualStyleBackColor = true;
        	this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(20, 16);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(207, 20);
        	this.label1.TabIndex = 28;
        	this.label1.Text = "Добавить нового клиента";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label2.Location = new System.Drawing.Point(264, 48);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(560, 40);
        	this.label2.TabIndex = 29;
        	this.label2.Text = "Клиент должен пройти анкету, выбрать кредит, указать сумму кредита.\r\nДалее систем" +
        	"а вынесет решение по заявке.\r\n";
        	// 
        	// lblCountQuestions
        	// 
        	this.lblCountQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblCountQuestions.Location = new System.Drawing.Point(504, 168);
        	this.lblCountQuestions.Name = "lblCountQuestions";
        	this.lblCountQuestions.Size = new System.Drawing.Size(100, 23);
        	this.lblCountQuestions.TabIndex = 31;
        	this.lblCountQuestions.Text = "_";
        	// 
        	// lblDateOfChange
        	// 
        	this.lblDateOfChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblDateOfChange.Location = new System.Drawing.Point(504, 200);
        	this.lblDateOfChange.Name = "lblDateOfChange";
        	this.lblDateOfChange.Size = new System.Drawing.Size(100, 23);
        	this.lblDateOfChange.TabIndex = 32;
        	this.lblDateOfChange.Text = "_";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label3.Location = new System.Drawing.Point(24, 136);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(211, 20);
        	this.label3.TabIndex = 33;
        	this.label3.Text = "Изменить вопросы анкеты";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label4.Location = new System.Drawing.Point(264, 168);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(175, 20);
        	this.label4.TabIndex = 34;
        	this.label4.Text = "Количество вопросов";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label5.Location = new System.Drawing.Point(264, 200);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(228, 20);
        	this.label5.TabIndex = 35;
        	this.label5.Text = "Дата последнего изменения";
        	// 
        	// frmForms
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.lblDateOfChange);
        	this.Controls.Add(this.lblCountQuestions);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnTest);
        	this.Controls.Add(this.btnOpenForm);
        	this.Name = "frmForms";
        	this.Text = "Анкеты";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateOfChange;
        private System.Windows.Forms.Label lblCountQuestions;

        #endregion

        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}