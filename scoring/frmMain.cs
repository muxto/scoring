using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DB_DLL;


namespace Scoring
{
    public partial class frmMain : Form
    {

        // конструктор формы
        public frmMain()
        {
            InitializeComponent();


            MyMainForm.MainForm = this;
            // передаем ссылку на данную форму в статическую переменную
//            MyMainForm.staticPanelControls = this.panelControls;

            MyMainForm.btnMainMenu = btnMainMenu ;
            MyMainForm.staticlblState = this.lblState;
            MyMainForm.staticlblNameForm = this.lblNameForm;

            // проверка БД
            this.CheckDataBase();
        }

        // проверяем БД и включаем кнопки
        public void CheckDataBase()
        {

            string buf;
            // считываем настройки
            MyClasses.MySQL = new ClassSQL(MyClasses.MyFiles.LoadConnectionString());
            // настройки пользователя
            MyClasses.MyDB = new ClassDataBase(MyClasses.MyFiles.LoadConnectionString());

            // подключение пользователя
            if (MyClasses.MyDB.CheckDataBase(out buf))
            {
                // работает

                // форма с кнопками
                MyMainForm.f = new frmButtons();
                // считали основные параметры
                ClassParams.ReadFromDB();

            }
            // не подключается к базе
            else
            {
                // форма с ошибкой
                MyMainForm.f = new frmDataBaseConnect();
            }
            // выводим состояние подключения
            lblState.Text = buf;

        }


        // при закрытии формы выходим из программы
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        // кнопка На главную
        private void btnMainMenu_Click(object sender, System.EventArgs e)
        {
            Form.ActiveForm.ActiveMdiChild.Close ();
        }



        private void btnConnectDataBase_Click(object sender, System.EventArgs e)
        {
            MyMainForm.f = new frmDataBaseConnect();
            //MessageBox.Show(MyMainForm.f.Controls[1].Parent.Text);

        }






    }
}
