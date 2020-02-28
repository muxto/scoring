using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scoring
{
    /* 15.05.2015
     * привет 
     * большая часть кода писалась минимум 3 года назад, поэтому сильно не ругайтесь
     * посмотрел код - часть трюков я сам уже не понял, но общий смысл такой:
     
     * отрисовка
     * главная форма - frmMain
     * есть класс с глобальными объектами - MyClasses. названия так себе, конечно)
     * в MyClasses лежат static объекты:
     *      public static Form MainForm - основная отображаемая форма
     *      static Form ChildForm  - mdi-форма
     * в любой момент существует максимум одна mdi-форма. для перехода к следующей или предыдущей в конструктор формы передается глобальный объект, 
     * предыдущая уничтожается
     * 
     * База
     * проект DB_DLL
     * статичный объект базы тоже в MyClasses
     * 
     * // подключения не закрываются, поэтому при промышленной нагрузке все бы упало, но мне было пофиг, все равно это игрушка)
     * 
     * остальное вроде должно быть понятно
     * Удачи!)
     * 
     */


    public static class Program
    {


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            
            
           // ScoringObjectContext g = new ScoringObjectContext();
            
        }
        
         // только цифры
        public static  void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        // цифры и зпт
        public static  void txtAndPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 44))
                e.Handled = true;
        }
    }
}
