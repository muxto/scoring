using System.Drawing ;

namespace Scoring
{
    partial class frmMain
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        	this.label2 = new System.Windows.Forms.Label();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.btnMainMenu = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.lblNameForm = new System.Windows.Forms.ToolStripStatusLabel();
        	this.statusStrip1.SuspendLayout();
        	this.toolStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(251, 95);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(0, 13);
        	this.label2.TabIndex = 10;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.lblState});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 404);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(918, 22);
        	this.statusStrip1.TabIndex = 19;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// lblState
        	// 
        	this.lblState.Name = "lblState";
        	this.lblState.Size = new System.Drawing.Size(41, 17);
        	this.lblState.Text = "статус";
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(908, 24);
        	this.menuStrip1.TabIndex = 21;
        	this.menuStrip1.Text = "menuStrip1";
        	this.menuStrip1.Visible = false;
        	// 
        	// toolStrip1
        	// 
        	this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
        	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.btnMainMenu,
        	        	        	this.toolStripSeparator1,
        	        	        	this.lblNameForm});
        	this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.Size = new System.Drawing.Size(918, 25);
        	this.toolStrip1.TabIndex = 26;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// btnMainMenu
        	// 
        	this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
        	this.btnMainMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        	this.btnMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.btnMainMenu.Name = "btnMainMenu";
        	this.btnMainMenu.Size = new System.Drawing.Size(97, 34);
        	this.btnMainMenu.Text = "Вернуться";
        	this.btnMainMenu.Visible = false;
        	this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
        	// 
        	// lblNameForm
        	// 
        	this.lblNameForm.Name = "lblNameForm";
        	this.lblNameForm.Size = new System.Drawing.Size(127, 20);
        	this.lblNameForm.Text = "Скоринговая система";
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.Control;
        	this.ClientSize = new System.Drawing.Size(918, 426);
        	this.Controls.Add(this.toolStrip1);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.menuStrip1);
        	this.Controls.Add(this.label2);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.IsMdiContainer = true;
        	this.MainMenuStrip = this.menuStrip1;
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(924, 435);
        	this.Name = "frmMain";
        	this.Text = "Скоринговая система";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.toolStrip1.ResumeLayout(false);
        	this.toolStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton btnMainMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripStatusLabel lblNameForm;
    }
}