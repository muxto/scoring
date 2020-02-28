using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Scoring
{
    // класс заявок
    // клиент подал заявку - пошло вычисление, прошла она или нет
    // если прошла, создается договор и платежи
    // если нет, то просто так валяется

    // заголовок одной заявки
    public class ClassRequestTitle
    {
        // ИД клиента
        public string ID_Client;
        // сумма кредита
        public int Credit_Sum;
        // процент кредита - назначается классом кредита
        public double Credit_Percent;
        // период кредита
        public int Credit_Period;
        // дата заявки
        public DateTime Request_Date;
        // статус - одобрено/отказано
        public string Request_Status;
        // ИД заявки
        public string ID_Request;

        // конструктор
        public ClassRequestTitle(string _ID_Client, string _Credit_Sum, string _Credit_Percent, string _Credit_Period, string _Request_Date, string _Request_Status, string _ID_Request)
        {
            ID_Client = _ID_Client;
            ID_Request = _ID_Request;
            Credit_Sum = int.Parse(_Credit_Sum);
            Credit_Percent = double.Parse(_Credit_Percent);
            Credit_Period = int.Parse(_Credit_Period);
            Request_Date = DateTime.Parse(_Request_Date);
            Request_Status = _Request_Status;
        }
    }

    // обработка заявок
    public class ClassRequest
    {


        // вернуть число заявок
        public static int GetCountOfRequests()
        {            
            // запрос
            string strSQL = "SELECT  count (ID_Request) FROM tbRequest ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);            
            return int.Parse (ds.Tables[0].Rows[0].ItemArray[0].ToString());
        }

        // вернуть заявку по ее ИД
        public static ClassRequestTitle  GetRequestByIDRequest(string _ID_Request)
        {
            ClassRequestTitle x;
            // запрос
            string strSQL = "SELECT  ID_Client, Credit_Sum, Credit_Percent, Credit_Period, Request_Date, Request_Status FROM tbRequest where ID_Request = '" + _ID_Request + "' ;";
            // запрос выдает столбец
            DataSet  ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);            
            x = new ClassRequestTitle(ds.Tables[0].Rows[0].ItemArray[0].ToString(), ds.Tables[0].Rows[0].ItemArray[1].ToString(), ds.Tables[0].Rows[0].ItemArray[2].ToString(), ds.Tables[0].Rows[0].ItemArray[3].ToString(), ds.Tables[0].Rows[0].ItemArray[4].ToString(), ds.Tables[0].Rows[0].ItemArray[5].ToString(), _ID_Request);            
            return x;
        }
        
        // вернуть ИД заявки по ИД клиента
        public static string GetIDRequestByIDClient(string _ID_Client)
        {            
            // считываем 
            string strSQL = "SELECT ID_Request FROM tbRequest where ID_Client = '" + _ID_Client + "' ;";            
            // запрос выдает столбец
            DataSet  ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);           
            return ds.Tables [0].Rows [0].ItemArray [0].ToString ();
        }

        // вернуть ИД клиента по ИД заявки
        public static string GetIDClientByIDRequest(string _ID_Request)
        {
            // считываем 
            string strSQL = "SELECT ID_Client FROM tbRequest where ID_Request = '" + _ID_Request  + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }     
    }
}
