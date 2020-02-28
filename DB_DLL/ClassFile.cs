using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace DB_DLL
{
    // файлов 2 - 
    // ConnectionString.txt хранит инфу о базе данных (сервер, бд, логин, пароль)
    public class ClassFile
    {
        // путь до файла
        string PathConnectionString;

        public ClassFile(string ProductName)
        {
            PathConnectionString = Application.StartupPath + "\\ConStr" + ProductName + ".txt";
        }
        // есть файлы?
        public bool CheckFile()
        {
            // открывается?
            if (File.Exists(PathConnectionString)) return true;
            else return false;
        }      

        // читает файл с инфой БД
        public SqlConnectionStringBuilder LoadConnectionString()
        {
            // подключение 
            SqlConnectionStringBuilder buf = new SqlConnectionStringBuilder();
            
            //Загружаю из файла строку для подключения к БД
            if (File.Exists(PathConnectionString))
            {
                StreamReader sr = new StreamReader(PathConnectionString, Encoding.Default);

                // присваиваем подключению
                // имя бд и сервера общие
                buf.DataSource = sr.ReadLine();
                buf.InitialCatalog = sr.ReadLine();
                
                // логин и пароль
                buf.UserID = sr.ReadLine();
                buf.Password = sr.ReadLine();
                
                sr.Close();
        
            }
            return buf;
        }

        // сохраняем в файл
        public void SaveToFile(SqlConnectionStringBuilder _MySettings)
        {
            // пишет в файл инфу про БД
            StreamWriter sw = new StreamWriter(PathConnectionString, false, Encoding.Default);
            sw.WriteLine(_MySettings.DataSource);
            sw.WriteLine(_MySettings.InitialCatalog);
            sw.WriteLine(_MySettings.UserID);
            sw.WriteLine(_MySettings.Password);
            sw.Close();
        }        
    }
}
