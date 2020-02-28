using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DB_DLL;
using System.Threading;

namespace Scoring
{
    public static class MyMainForm
    {


        public static Form MainForm;
        static Form ChildForm = new Form();


        // метка
        public static ToolStripStatusLabel staticlblState, staticlblNameForm;
        public static ToolStripButton btnMainMenu;

//        public static Label ;
        // форма
        public static Form f
        {
            get
            {
                // возвращаем форму
                return ChildForm;
            }
            set
            {
//            	ChildForm.Close ();
                ChildForm = value;
                ShowForm ();
            }
        }

        // состояние
        public static string State
        {
            get
            {
                return staticlblState.Text;
            }
            set
            {

                if (f.InvokeRequired )
                {
                    f.Invoke ((Action ) delegate
                    {
                        staticlblState.Text = value;
                    });
                }
                else
                {
                    staticlblState.Text = value;
                }
            }
        }

        // имя формы
        public static string NameForm
        {
            get
            {
                return staticlblNameForm.Text;
            }
            set
            {
                if (f.InvokeRequired )
                {
                    f.Invoke ((Action ) delegate
                    {
                        staticlblNameForm.Text = value;
                    });
                }
                else
                {
                    staticlblNameForm.Text = value;
                }
            }
        }

        public static void ShowForm ()
        {
            ChildForm .MdiParent = MainForm ;
            ChildForm.ControlBox = false;
            ChildForm .WindowState = FormWindowState.Maximized ;



//            MainForm.Text = "Онлайн-статус";

            ChildForm .Show ();
            ReShow ();
        }

        /// <summary>
        /// метод перерисовывает форму
        /// </summary>
        /// 15.05.2015
        /// метод дико кривой, он определяет отобржается ли кнопка Вернуться
        /// если это начальная форма с кнопками, или форма подключения к БД - тогда нет
        /// под отладчиком не работает, потому что форма не является активной
        public static void ReShow()
        {
            if (Form.ActiveForm != null)
            {
                var frm = Form.ActiveForm.ActiveMdiChild;
                btnMainMenu.Visible = !((frm.Name == "frmButtons") || (frm.Name == "frmDataBaseConnect"));
                staticlblNameForm.Text = frm.Text;
            }

        }
        
        public static void MainMenu ()
        {
        	foreach (var i in Form.ActiveForm.MdiChildren)
        	{
        		i.Close ();
        	}
        	f = new frmButtons ();
        }



    }


    public static class MyClasses
    {

        // класс для работы с файлом подключения
        public static ClassFile MyFiles = new ClassFile("Scoring");

        // класс для SQL
        public static ClassSQL MySQL;

        // класс для БД
        public static ClassDataBase MyDB;

        public static ClassClient NewClient;
        // где нибудь класс банка
        // % от прибыли за месяц которые можно отдавать на кредит = 40
        //
    }
}
