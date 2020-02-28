using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DB_DLL;

namespace Scoring
{

    // параметры подлкючения к БД
    public partial class frmDataBaseConnect : Form
    {
        // конструктор
        public frmDataBaseConnect()
        {
            InitializeComponent();

            
            
            // читает из БД
            if (MyClasses.MyDB != null)
            {
                MyMainForm .State = "Данные из файла";
                
                txtDataSource.Text = MyClasses.MyDB.constr.DataSource;
                txtInitialCatalog.Text = MyClasses.MyDB.constr.InitialCatalog;
                txtUser.Text = MyClasses.MyDB.constr.UserID;
                txtPassword.Text = MyClasses.MyDB.constr.Password;
            }
            else MyMainForm.State = "Не найден файл! Данные по умолчанию"; 
            
            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
            
        }

      

        // кнопа Подключение
        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder buf = new SqlConnectionStringBuilder();
            // читает инфу с формы
            buf.DataSource = txtDataSource.Text;
            buf.InitialCatalog = txtInitialCatalog.Text;
            buf.UserID = txtUser.Text;
            buf.Password = txtPassword.Text;
            buf.IntegratedSecurity = true;

            MyClasses.MyDB = new ClassDataBase(buf);
            
            // читает инфу с формы

            // препод
            MyClasses.MyDB.constr.DataSource = txtDataSource.Text;
            MyClasses.MyDB.constr.InitialCatalog = txtInitialCatalog.Text;
            MyClasses.MyDB.constr.UserID = txtUser.Text;
            MyClasses.MyDB.constr.Password = txtPassword.Text;

            // сохраняем
            MyClasses.MyFiles.SaveToFile(MyClasses.MyDB.constr);

            // вывод
            MessageBox.Show("Программа будет перезагружена", "Внимание", MessageBoxButtons.OK);
            Application.Restart();
        }

    }
}