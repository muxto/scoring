/*
 * Сделано в SharpDevelop.
 * Пользователь: Михто
 * Дата: 28.06.2014
 * Время: 15:41
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Scoring
{
	partial class frmFormGenerate2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblStudents = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblStudents
			// 
			this.lblStudents.AutoSize = true;
			this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStudents.Location = new System.Drawing.Point(537, 9);
			this.lblStudents.Name = "lblStudents";
			this.lblStudents.Size = new System.Drawing.Size(317, 40);
			this.lblStudents.TabIndex = 13;
			this.lblStudents.Text = "Ответьте на вопросы анкеты и нажмите\r\nкнопку Далее";
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNext.Location = new System.Drawing.Point(746, 314);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(140, 40);
			this.btnNext.TabIndex = 12;
			this.btnNext.Text = "Далее";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.BtnNextClick);
			// 
			// pnlControls
			// 
			this.pnlControls.AutoScroll = true;
			this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlControls.Location = new System.Drawing.Point(0, 0);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(525, 366);
			this.pnlControls.TabIndex = 11;
			// 
			// frmFormGenerate2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 366);
			this.Controls.Add(this.lblStudents);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.pnlControls);
			this.Name = "frmFormGenerate2";
			this.Text = "Прохождение анкеты";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblStudents;
	}
}
