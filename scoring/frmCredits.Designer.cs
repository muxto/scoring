namespace Scoring
{
    partial class frmCredits
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
        	this.btnCreateCredit = new System.Windows.Forms.Button();
        	this.btnDelCredit = new System.Windows.Forms.Button();
        	this.btnOpenCredit = new System.Windows.Forms.Button();
        	this.label7 = new System.Windows.Forms.Label();
        	this.lstCredits = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.SuspendLayout();
        	// 
        	// btnCreateCredit
        	// 
        	this.btnCreateCredit.Location = new System.Drawing.Point(16, 320);
        	this.btnCreateCredit.Margin = new System.Windows.Forms.Padding(4);
        	this.btnCreateCredit.Name = "btnCreateCredit";
        	this.btnCreateCredit.Size = new System.Drawing.Size(192, 40);
        	this.btnCreateCredit.TabIndex = 28;
        	this.btnCreateCredit.Text = "Новое предложение";
        	this.btnCreateCredit.UseVisualStyleBackColor = true;
        	this.btnCreateCredit.Click += new System.EventHandler(this.btnCreateCredit_Click);
        	// 
        	// btnDelCredit
        	// 
        	this.btnDelCredit.Location = new System.Drawing.Point(472, 320);
        	this.btnDelCredit.Margin = new System.Windows.Forms.Padding(4);
        	this.btnDelCredit.Name = "btnDelCredit";
        	this.btnDelCredit.Size = new System.Drawing.Size(176, 40);
        	this.btnDelCredit.TabIndex = 30;
        	this.btnDelCredit.Text = "Удалить предложение";
        	this.btnDelCredit.UseVisualStyleBackColor = true;
        	this.btnDelCredit.Click += new System.EventHandler(this.btnDelCredit_Click);
        	// 
        	// btnOpenCredit
        	// 
        	this.btnOpenCredit.Location = new System.Drawing.Point(224, 320);
        	this.btnOpenCredit.Margin = new System.Windows.Forms.Padding(4);
        	this.btnOpenCredit.Name = "btnOpenCredit";
        	this.btnOpenCredit.Size = new System.Drawing.Size(232, 40);
        	this.btnOpenCredit.TabIndex = 29;
        	this.btnOpenCredit.Text = "Редактировать предложение";
        	this.btnOpenCredit.UseVisualStyleBackColor = true;
        	this.btnOpenCredit.Click += new System.EventHandler(this.btnOpenCredit_Click);
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label7.Location = new System.Drawing.Point(656, 56);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(208, 60);
        	this.label7.TabIndex = 112;
        	this.label7.Text = "Редактируйте выбранное \r\nкредитное предложение, \r\nлибо создайте новое.\r\n";
        	// 
        	// lstCredits
        	// 
        	this.lstCredits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2});
        	this.lstCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.lstCredits.FullRowSelect = true;
        	this.lstCredits.GridLines = true;
        	this.lstCredits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.lstCredits.Location = new System.Drawing.Point(16, 16);
        	this.lstCredits.MultiSelect = false;
        	this.lstCredits.Name = "lstCredits";
        	this.lstCredits.Size = new System.Drawing.Size(632, 296);
        	this.lstCredits.TabIndex = 113;
        	this.lstCredits.UseCompatibleStateImageBehavior = false;
        	this.lstCredits.View = System.Windows.Forms.View.Details;
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
        	// frmCredits
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.lstCredits);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.btnCreateCredit);
        	this.Controls.Add(this.btnDelCredit);
        	this.Controls.Add(this.btnOpenCredit);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "frmCredits";
        	this.Text = "Кредиты";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;

        #endregion

        private System.Windows.Forms.Button btnCreateCredit;
        private System.Windows.Forms.Button btnDelCredit;
        private System.Windows.Forms.Button btnOpenCredit;
        private System.Windows.Forms.ListView lstCredits;
        private System.Windows.Forms.Label label7;
    }
}