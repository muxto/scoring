using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Scoring
{
    // договор создается когда подана заявка и она одобрена
    // тогда создается таблица платежей на номер счета

    // заголовок договора
    public class ClassContractTitle
    {
        // номер договора
        public string N_Contract;
        // номер счета
        public string N_Account;
        // начало действия договора
        public DateTime Contract_Date_Begin;
        // дата окончания договора
        public DateTime Contract_Date_End;
        // ИД заявки
        public string ID_Request;

        // конструктор
        public ClassContractTitle(string _N_Contract, string _N_Account, string _Contract_Date_Begin, string _Contract_Date_End, string _ID_Request)
        {
            ID_Request = _ID_Request;
            N_Contract = _N_Contract;
            N_Account = _N_Account;
            Contract_Date_Begin = DateTime .Parse (_Contract_Date_Begin );
            Contract_Date_End = DateTime .Parse ( _Contract_Date_End);
        }
    }

    // действия над договором
    public class ClassContracts
    {

        // вернуть число заявок
        public static int GetCountOfContracts()
        {
            // запрос
            string strSQL = "SELECT  count (N_Contract) FROM tbContract;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        }

        // получить договор по ИД заявки
        public static ClassContractTitle GetContractByIDRequest(string _ID_Request)
        {
            // договор
            ClassContractTitle  x;
            // запрос
            string strSQL = "SELECT  N_Contract, N_Account, Contract_Date_Begin, Contract_Date_End FROM tbContract where ID_Request = '" + _ID_Request + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);            
            x = new ClassContractTitle(ds.Tables[0].Rows[0].ItemArray[0].ToString(), ds.Tables[0].Rows[0].ItemArray[1].ToString(), ds.Tables[0].Rows[0].ItemArray[2].ToString(), ds.Tables[0].Rows[0].ItemArray[3].ToString(), _ID_Request);            
            return x;
        }

        // получить номер договора по ИД заявки
        public static string GetNContractByIDRequest(string _ID_Request)
        {
            // запрос
            string strSQL = "SELECT N_Account FROM tbContract where ID_Request= '" + _ID_Request + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return ds.Tables[0].Rows[0].ToString();
        }

        // получить ИД заявки по номеру договора
        public static string GetIDRequestByNAccount(string _N_Account)
        {
            // запрос
            string strSQL = "SELECT  ID_Request FROM tbContract where N_Account= '" + _N_Account + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        // создать номер счета
        public static string GenerateNAccount()
        {
            Random r = new Random();
            string N_Account = "";

            // генерим 20 цифр
            for (int i = 0; i < 20; i++)
                N_Account  += r.Next(0, 9).ToString();
            return N_Account;
        }

        // создать номер договора
        public static string GenerateNContract()
        {
            Random r = new Random();
            string N_Contract = "";

            // генерим 8 цифр
            for (int i = 0; i < 8; i++)
                N_Contract += r.Next(0, 9).ToString();
            return N_Contract;
        }
    }
}
