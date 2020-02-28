using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace DB_DLL
{
    // одна строчка описывает connection 

    public class cSQL
    {

        public SqlConnectionStringBuilder constr;

        public cSQL(SqlConnectionStringBuilder _constr)
        {
            constr = _constr;

        }

         // есть база?
        public bool CheckDataBase(out string msgError)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(constr.ToString ());

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
        
        // выполнение sql-команды
        public void MakeSQL(string strSQL)
        {
            // соединение с БД
            using (SqlConnection cn = new SqlConnection(constr.ConnectionString))
            {
                // открываем
                cn.Open();
                SqlCommand cmd = new SqlCommand(strSQL, cn);

                cmd = cn.CreateCommand();
                cmd.CommandText = strSQL;

                // выполняем команду
                int i = cmd.ExecuteNonQuery();
            }
        }

        // выполнение sql-команды с описанием ошибки
        public void MakeSQL(string strSQL, out string _state)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(constr.ConnectionString);
            try
            {
                // открываем
                cn.Open();
                SqlCommand cmd = new SqlCommand(strSQL, cn);

                cmd = cn.CreateCommand();
                cmd.CommandText = strSQL;

                // выполняем команду
                int i = cmd.ExecuteNonQuery();
                _state = "Успешно";
            }
            catch (SqlException ex)
            {
                _state = ex.Message + " №" + ex.Number;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        public SqlDataReader MakeSQLReturn(string strSQL)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(constr.ConnectionString);
            // открываем
            cn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, cn);

            cmd = cn.CreateCommand();
            cmd.CommandText = strSQL;

            // выполняем команду
            SqlDataReader rdr = cmd.ExecuteReader();
            cn.Close();
            cn.Dispose();
            // возвращаем ридер
            return rdr;
        }


        public DataSet MakeSQLReturnDataSet(string strSQL)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(constr.ConnectionString);
            // адаптер
            SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
            // создаем DataSet
            DataSet ds = new DataSet();
            //  вставляем в него данные
            da.Fill(ds);
            cn.Close();
            cn.Dispose();
            da.Dispose();
            return ds;
        }

        
        // перегружен
        public void AddFileToDB(string strSQL, byte[] MyFile, out string _state)
        {
            // соединение с БД
            SqlConnection cn = new SqlConnection(constr.ConnectionString);
            try
            {
                // открываем
                cn.Open();
                SqlCommand cmd = new SqlCommand(strSQL, cn);

                cmd = cn.CreateCommand();
                cmd.CommandText = strSQL;

                cmd.Parameters.Add("@FileBinary", SqlDbType.VarBinary).Value = MyFile;

                // выполняем команду
                int i = cmd.ExecuteNonQuery();
                _state = "Успешно";
            }
            catch (SqlException ex)
            {
                _state = ex.Message + " №" + ex.Number;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        public byte[] ReadFileFromDB(string FileID, string Table)
        {

           string  strSQL = "Select FileBinary from " + Table + " where FileId = '" + FileID + " ';";
           DataSet  ds = MakeSQLReturnDataSet(strSQL);
            byte[] byteArray = (byte[])ds.Tables[0].Rows[0].ItemArray[0];
            return byteArray;
        }
    }

}



