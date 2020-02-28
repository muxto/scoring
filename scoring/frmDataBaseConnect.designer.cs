namespace Scoring
{
    partial class frmDataBaseConnect
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
        	this.label11 = new System.Windows.Forms.Label();
        	this.btnConnect = new System.Windows.Forms.Button();
        	this.label10 = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label14 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.txtUser = new System.Windows.Forms.TextBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.label9 = new System.Windows.Forms.Label();
        	this.txtInitialCatalog = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtDataSource = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.groupBox2.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label11.Location = new System.Drawing.Point(13, 9);
        	this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(536, 20);
        	this.label11.TabIndex = 60;
        	this.label11.Text = "Введите параметры подключения к уже существующей базе данных.";
        	// 
        	// btnConnect
        	// 
        	this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.btnConnect.Location = new System.Drawing.Point(691, 304);
        	this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
        	this.btnConnect.Name = "btnConnect";
        	this.btnConnect.Size = new System.Drawing.Size(187, 49);
        	this.btnConnect.TabIndex = 55;
        	this.btnConnect.Text = "Подключиться";
        	this.btnConnect.UseVisualStyleBackColor = true;
        	this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
        	// 
        	// label10
        	// 
        	this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.label10.AutoSize = true;
        	this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label10.Location = new System.Drawing.Point(684, 284);
        	this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(198, 16);
        	this.label10.TabIndex = 59;
        	this.label10.Text = "Подключиться к базе данных";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.label6);
        	this.groupBox2.Controls.Add(this.label14);
        	this.groupBox2.Controls.Add(this.label4);
        	this.groupBox2.Controls.Add(this.label2);
        	this.groupBox2.Controls.Add(this.txtPassword);
        	this.groupBox2.Controls.Add(this.txtUser);
        	this.groupBox2.Location = new System.Drawing.Point(16, 125);
        	this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox2.Size = new System.Drawing.Size(573, 113);
        	this.groupBox2.TabIndex = 65;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Редактирует записи";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(8, 20);
        	this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(216, 16);
        	this.label6.TabIndex = 29;
        	this.label6.Text = "Имя пользователя базы данных";
        	// 
        	// label14
        	// 
        	this.label14.AutoSize = true;
        	this.label14.Location = new System.Drawing.Point(8, 84);
        	this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label14.Name = "label14";
        	this.label14.Size = new System.Drawing.Size(136, 16);
        	this.label14.TabIndex = 39;
        	this.label14.Text = "Роль пользователя";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(8, 48);
        	this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(57, 16);
        	this.label4.TabIndex = 30;
        	this.label4.Text = "Пароль";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(241, 84);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(103, 16);
        	this.label2.TabIndex = 46;
        	this.label2.Text = "Пользователь";
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Location = new System.Drawing.Point(245, 48);
        	this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(319, 22);
        	this.txtPassword.TabIndex = 28;
        	this.txtPassword.Text = "94mjb8^nvghs$mnf643";
        	// 
        	// txtUser
        	// 
        	this.txtUser.Location = new System.Drawing.Point(245, 16);
        	this.txtUser.Margin = new System.Windows.Forms.Padding(4);
        	this.txtUser.Name = "txtUser";
        	this.txtUser.Size = new System.Drawing.Size(319, 22);
        	this.txtUser.TabIndex = 27;
        	this.txtUser.Text = "ScoringUser";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.label9);
        	this.groupBox1.Controls.Add(this.txtInitialCatalog);
        	this.groupBox1.Controls.Add(this.label7);
        	this.groupBox1.Controls.Add(this.txtDataSource);
        	this.groupBox1.Location = new System.Drawing.Point(16, 33);
        	this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Size = new System.Drawing.Size(573, 84);
        	this.groupBox1.TabIndex = 64;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "База данных";
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(8, 20);
        	this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(177, 16);
        	this.label9.TabIndex = 23;
        	this.label9.Text = "Имя или IP-адрес сервера";
        	// 
        	// txtInitialCatalog
        	// 
        	this.txtInitialCatalog.Location = new System.Drawing.Point(245, 48);
        	this.txtInitialCatalog.Margin = new System.Windows.Forms.Padding(4);
        	this.txtInitialCatalog.Name = "txtInitialCatalog";
        	this.txtInitialCatalog.Size = new System.Drawing.Size(319, 22);
        	this.txtInitialCatalog.TabIndex = 26;
        	this.txtInitialCatalog.Text = "Scoring";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(8, 48);
        	this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(120, 16);
        	this.label7.TabIndex = 25;
        	this.label7.Text = "Имя базы данных";
        	// 
        	// txtDataSource
        	// 
        	this.txtDataSource.Location = new System.Drawing.Point(245, 16);
        	this.txtDataSource.Margin = new System.Windows.Forms.Padding(4);
        	this.txtDataSource.Name = "txtDataSource";
        	this.txtDataSource.Size = new System.Drawing.Size(319, 22);
        	this.txtDataSource.TabIndex = 24;
        	this.txtDataSource.Text = ".\\SQLExpress";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.label1.Location = new System.Drawing.Point(24, 256);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(451, 60);
        	this.label1.TabIndex = 67;
        	this.label1.Text = "Будьте осторожны при изменении имен пользователей и \r\nпараметров подключения!\r\nБа" +
        	"за данных может оказаться недоступной!";
        	// 
        	// frmDataBaseConnect
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(892, 366);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.label11);
        	this.Controls.Add(this.btnConnect);
        	this.Controls.Add(this.label10);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "frmDataBaseConnect";
        	this.Text = "Подключение к БД";
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInitialCatalog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label1;
    }
}