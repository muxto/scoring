using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DB_DLL
{
    // этот класс только для локального администратора
    public class ClassDataBase : ClassSQL
    {
        // имя базы
        SqlConnectionStringBuilder MyDB;

        

        public new SqlConnectionStringBuilder constr
        {
            get
            {
                return MyDB;
            }
        }

        public ClassDataBase(SqlConnectionStringBuilder SQLcon)
            : base(SQLcon)
        {
            // создаем новый экземпляр - настройки для удаленного пользователя
            MyDB = new SqlConnectionStringBuilder(SQLcon.ConnectionString);
            MyDB.IntegratedSecurity = false;


            // очищаем
            base.constr.UserID = "";
            base.constr.Password = "";
            base.constr.InitialCatalog = "";
            // доменный вход
            base.constr.IntegratedSecurity = true;

        }




        // есть база?
        public bool CheckDataBase(out string msgError)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(MyDB.ConnectionString);

            try
            {
                // открывается?
                cn.Open();
                msgError = "Подключение к базе данных выполнено успешно";
                // круто
                return true;
            }
            catch (SqlException ex)
            {

                msgError = ex.Message + " " + ex.Number;
                // не открывается. нет базы
                return false;
            }
            finally
            {
                SqlConnection.ClearPool(cn);
                cn.Close();
                cn.Dispose();
            }
        }

        // есть база?
        public bool CheckDataBaseAdmin()
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(base.constr.ConnectionString);
            try
            {
                // открывается?
                cn.Open();

                // круто
                return true;
            }
            catch (SqlException)
            {
                // не открывается. нет базы
                return false;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

   
    }

}
