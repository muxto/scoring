namespace Scoring
{
    partial class frmButtons
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
        	this.lblStudents = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.btnParams = new System.Windows.Forms.Button();
        	this.btnContracts = new System.Windows.Forms.Button();
        	this.btnForms = new System.Windows.Forms.Button();
        	this.btnStat = new System.Windows.Forms.Button();
        	this.btnClients = new System.Windows.Forms.Button();
        	this.btnCalculate = new System.Windows.Forms.Button();
        	this.btnCreditsEditor = new System.Windows.Forms.Button();
        	this.btnGenerateClient = new System.Windows.Forms.Button();
        	this.label5 = new System.Windows.Forms.Label();
        	this.btnGenerateMore = new System.Windows.Forms.Button();
        	this.btnGeneratePays = new System.Windows.Forms.Button();
        	this.label6 = new System.Windows.Forms.Label();
        	this.lblClientsCount = new System.Windows.Forms.Label();
        	this.lblContractsCount = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lblStudents
        	// 
        	this.lblStudents.AutoSize = true;
        	this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblStudents.Location = new System.Drawing.Point(173, 39);
        	this.lblStudents.Name = "lblStudents";
        	this.lblStudents.Size = new System.Drawing.Size(420, 20);
        	this.lblStudents.TabIndex = 9;
        	this.lblStudents.Text = "Редактирование анкет и добавление новых клиентов";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(173, 177);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(285, 20);
        	this.label1.TabIndex = 10;
        	this.label1.Text = "Список договоров. Всего договоров";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label2.Location = new System.Drawing.Point(173, 85);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(196, 20);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "Кредитный калькулятор";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label3.Location = new System.Drawing.Point(173, 131);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(267, 20);
        	this.label3.TabIndex = 13;
        	this.label3.Text = "Список клиентов. Всего клиентов";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.btnParams);
        	this.groupBox1.Controls.Add(this.btnContracts);
        	this.groupBox1.Controls.Add(this.btnForms);
        	this.groupBox1.Controls.Add(this.btnStat);
        	this.groupBox1.Controls.Add(this.btnClients);
        	this.groupBox1.Controls.Add(this.btnCalculate);
        	this.groupBox1.Controls.Add(this.btnCreditsEditor);
        	this.groupBox1.Location = new System.Drawing.Point(12, 12);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(155, 342);
        	this.groupBox1.TabIndex = 0;
        	this.groupBox1.TabStop = false;
        	// 
        	// btnParams
        	// 
        	this.btnParams.Location = new System.Drawing.Point(6, 296);
        	this.btnParams.Name = "btnParams";
        	this.btnParams.Size = new System.Drawing.Size(140, 40);
        	this.btnParams.TabIndex = 6;
        	this.btnParams.Text = "Параметры";
        	this.btnParams.UseVisualStyleBackColor = true;
        	this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
        	// 
        	// btnContracts
        	// 
        	this.btnContracts.Location = new System.Drawing.Point(6, 156);
        	this.btnContracts.Name = "btnContracts";
        	this.btnContracts.Size = new System.Drawing.Size(140, 40);
        	this.btnContracts.TabIndex = 3;
        	this.btnContracts.Text = "Договора";
        	this.btnContracts.UseVisualStyleBackColor = true;
        	this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
        	// 
        	// btnForms
        	// 
        	this.btnForms.Location = new System.Drawing.Point(6, 19);
        	this.btnForms.Name = "btnForms";
        	this.btnForms.Size = new System.Drawing.Size(140, 39);
        	this.btnForms.TabIndex = 0;
        	this.btnForms.Text = "Анкеты";
        	this.btnForms.UseVisualStyleBackColor = true;
        	this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
        	// 
        	// btnStat
        	// 
        	this.btnStat.Location = new System.Drawing.Point(6, 248);
        	this.btnStat.Name = "btnStat";
        	this.btnStat.Size = new System.Drawing.Size(140, 40);
        	this.btnStat.TabIndex = 5;
        	this.btnStat.Text = "Статистика";
        	this.btnStat.UseVisualStyleBackColor = true;
        	this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
        	// 
        	// btnClients
        	// 
        	this.btnClients.Location = new System.Drawing.Point(6, 110);
        	this.btnClients.Name = "btnClients";
        	this.btnClients.Size = new System.Drawing.Size(140, 40);
        	this.btnClients.TabIndex = 2;
        	this.btnClients.Text = "Клиенты";
        	this.btnClients.UseVisualStyleBackColor = true;
        	this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
        	// 
        	// btnCalculate
        	// 
        	this.btnCalculate.Location = new System.Drawing.Point(6, 64);
        	this.btnCalculate.Name = "btnCalculate";
        	this.btnCalculate.Size = new System.Drawing.Size(140, 40);
        	this.btnCalculate.TabIndex = 1;
        	this.btnCalculate.Text = "Кредитный калькулятор";
        	this.btnCalculate.UseVisualStyleBackColor = true;
        	this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        	// 
        	// btnCreditsEditor
        	// 
        	this.btnCreditsEditor.Location = new System.Drawing.Point(6, 202);
        	this.btnCreditsEditor.Name = "btnCreditsEditor";
        	this.btnCreditsEditor.Size = new System.Drawing.Size(140, 40);
        	this.btnCreditsEditor.TabIndex = 4;
        	this.btnCreditsEditor.Text = "Редактор кредитов";
        	this.btnCreditsEditor.UseVisualStyleBackColor = true;
        	this.btnCreditsEditor.Click += new System.EventHandler(this.btnCredits_Click);
        	// 
        	// btnGenerateClient
        	// 
        	this.btnGenerateClient.Location = new System.Drawing.Point(6, 19);
        	this.btnGenerateClient.Name = "btnGenerateClient";
        	this.btnGenerateClient.Size = new System.Drawing.Size(140, 40);
        	this.btnGenerateClient.TabIndex = 0;
        	this.btnGenerateClient.Text = "Подать 1 заявку";
        	this.btnGenerateClient.UseVisualStyleBackColor = true;
        	this.btnGenerateClient.Click += new System.EventHandler(this.btnGenerateClient_Click);
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label5.Location = new System.Drawing.Point(173, 317);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(304, 20);
        	this.label5.TabIndex = 17;
        	this.label5.Text = "Значения параметров оценки кредита";
        	// 
        	// btnGenerateMore
        	// 
        	this.btnGenerateMore.Location = new System.Drawing.Point(6, 64);
        	this.btnGenerateMore.Name = "btnGenerateMore";
        	this.btnGenerateMore.Size = new System.Drawing.Size(140, 40);
        	this.btnGenerateMore.TabIndex = 1;
        	this.btnGenerateMore.Text = "Подать 200 заявок";
        	this.btnGenerateMore.UseVisualStyleBackColor = true;
        	this.btnGenerateMore.Click += new System.EventHandler(this.btnGenerateMore_Click);
        	// 
        	// btnGeneratePays
        	// 
        	this.btnGeneratePays.Location = new System.Drawing.Point(8, 112);
        	this.btnGeneratePays.Name = "btnGeneratePays";
        	this.btnGeneratePays.Size = new System.Drawing.Size(140, 40);
        	this.btnGeneratePays.TabIndex = 2;
        	this.btnGeneratePays.Text = "Выполнить платежи";
        	this.btnGeneratePays.UseVisualStyleBackColor = true;
        	this.btnGeneratePays.Click += new System.EventHandler(this.btnGeneratePays_Click);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label6.Location = new System.Drawing.Point(173, 223);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(373, 20);
        	this.label6.TabIndex = 20;
        	this.label6.Text = "Редактирование и добавление новых кредитов";
        	// 
        	// lblClientsCount
        	// 
        	this.lblClientsCount.AutoSize = true;
        	this.lblClientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblClientsCount.Location = new System.Drawing.Point(469, 131);
        	this.lblClientsCount.Name = "lblClientsCount";
        	this.lblClientsCount.Size = new System.Drawing.Size(18, 20);
        	this.lblClientsCount.TabIndex = 24;
        	this.lblClientsCount.Text = "0";
        	// 
        	// lblContractsCount
        	// 
        	this.lblContractsCount.AutoSize = true;
        	this.lblContractsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lblContractsCount.Location = new System.Drawing.Point(469, 177);
        	this.lblContractsCount.Name = "lblContractsCount";
        	this.lblContractsCount.Size = new System.Drawing.Size(18, 20);
        	this.lblContractsCount.TabIndex = 25;
        	this.lblContractsCount.Text = "0";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.btnGenerateClient);
        	this.groupBox2.Controls.Add(this.btnGenerateMore);
        	this.groupBox2.Controls.Add(this.btnGeneratePays);
        	this.groupBox2.Location = new System.Drawing.Point(680, 24);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(152, 164);
        	this.groupBox2.TabIndex = 1;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Заполнение базы";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label7.Location = new System.Drawing.Point(173, 260);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(351, 40);
        	this.label7.TabIndex = 27;
        	this.label7.Text = "Определение платжеспособности клиентов,\r\nвывод таблицы по критериям";
        	// 
        	// frmButtons
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.lblContractsCount);
        	this.Controls.Add(this.lblClientsCount);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.lblStudents);
        	this.Name = "frmButtons";
        	this.Text = "Главное меню";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCreditsEditor;
        private System.Windows.Forms.Button btnGenerateClient;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateMore;
        private System.Windows.Forms.Button btnGeneratePays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label lblClientsCount;
        private System.Windows.Forms.Label lblContractsCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}