namespace Scoring
{
    partial class frmStat
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
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.btnStat = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Вопрос";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ответ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Хорошие";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Плохие";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Всего";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "% плохих";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(509, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 342);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(312, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(191, 289);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(312, 314);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(191, 40);
            this.btnShowTable.TabIndex = 2;
            this.btnShowTable.Text = "Вывести таблицу";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // dtPick
            // 
            this.dtPick.Location = new System.Drawing.Point(16, 153);
            this.dtPick.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(221, 20);
            this.dtPick.TabIndex = 4;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(17, 102);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(220, 44);
            this.btnStat.TabIndex = 3;
            this.btnStat.Text = "Рассчитать статистику на";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudents.Location = new System.Drawing.Point(12, 12);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(274, 80);
            this.lblStudents.TabIndex = 28;
            this.lblStudents.Text = "Рассчитайте статусы клиентов на \r\nопределенную дату.\r\nВыберите нужные категории и" +
                " \r\nнажмите Вывести таблицу.";
            // 
            // btnGraph
            // 
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraph.Location = new System.Drawing.Point(17, 314);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(140, 40);
            this.btnGraph.TabIndex = 29;
            this.btnGraph.Text = "График заявок по баллам";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // frmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 366);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.dtPick);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listView1);
            this.Name = "frmStat";
            this.Text = "Статистика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.DateTimePicker dtPick;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnGraph;

    }
}