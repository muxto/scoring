namespace Scoring
{
    partial class frmParams
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtLowPercent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHighPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDelayForBad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Коэффициент платежа от чистой прибыли";
            // 
            // txtLowPercent
            // 
            this.txtLowPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLowPercent.Location = new System.Drawing.Point(332, 76);
            this.txtLowPercent.Name = "txtLowPercent";
            this.txtLowPercent.Size = new System.Drawing.Size(99, 22);
            this.txtLowPercent.TabIndex = 26;
            this.txtLowPercent.Text = " ";
            this.txtLowPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Program.txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Нижний предел анкеты, %";
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtK.Location = new System.Drawing.Point(332, 50);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(99, 22);
            this.txtK.TabIndex = 24;
            this.txtK.Text = " ";
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Program.txtAndPoint_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Введите параметры скоринговой оценки";
            // 
            // txtHighPercent
            // 
            this.txtHighPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHighPercent.Location = new System.Drawing.Point(332, 99);
            this.txtHighPercent.Name = "txtHighPercent";
            this.txtHighPercent.Size = new System.Drawing.Size(99, 22);
            this.txtHighPercent.TabIndex = 76;
            this.txtHighPercent.Text = " ";
            this.txtHighPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Program.txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Верхний предел анкеты, %";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(740, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(707, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Сохранить в базе данных";
            // 
            // txtDelayForBad
            // 
            this.txtDelayForBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelayForBad.Location = new System.Drawing.Point(332, 127);
            this.txtDelayForBad.Name = "txtDelayForBad";
            this.txtDelayForBad.Size = new System.Drawing.Size(99, 22);
            this.txtDelayForBad.TabIndex = 81;
            this.txtDelayForBad.Text = " ";
            this.txtDelayForBad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Program.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Число невыплат платежей плохого клиента";
            // 
            // frmParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 366);
            this.Controls.Add(this.txtDelayForBad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHighPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLowPercent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label11);
            this.Name = "frmParams";
            this.Text = "Параметры скоринговых расчетов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLowPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHighPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDelayForBad;
        private System.Windows.Forms.Label label2;
    }
}