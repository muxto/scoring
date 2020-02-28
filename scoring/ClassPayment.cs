using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Scoring
{
    // класс платежей
    // для клиента на весь срок договора создаются записи на каждый месяц
    // платеж true или false - лень и некогда было делать бухгалтерскую систему дебета =)
    // соотвественно тру - вовремя, фальш - невовремя.
    // потом пересчет и если больше classparams.delayforbad то клиент плохой

    // заголовок одного платежа
     public class ClassPaymentTitle        
    {
         // номер счета 20 цифр
        public string N_Account;
         // дата
        public DateTime Date;
         // платеж
        public bool Payment;
         // номер транзакции 10 цифр
        public string N_Transaction;
        
         // конструктор
        public ClassPaymentTitle (string _N_Account, string  _Date, string _Payment, string _N_Transaction)
        {
            N_Account = _N_Account ;
            N_Transaction = _N_Transaction ;
            Date = DateTime .Parse (_Date ) ;
            Payment = bool .Parse (_Payment ) ;
        }
    }

    // расчеты платежей
    public class ClassPayment
    {
        // выбор платежей по номеру счета
        public static List<ClassPaymentTitle> GetPaymentsByNAccount(string _N_Account)
        {
            List<ClassPaymentTitle> x = new List<ClassPaymentTitle>();
            // считываем 
            string strSQL = "SELECT N_Account, Date, Payment, N_Transaction FROM tbPayments where N_Account = '" + _N_Account + "' ;";
            // запрос выдает столбец
            DataSet  ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)                          
                x.Add( new  ClassPaymentTitle ( ds.Tables[0].Rows[i].ItemArray[0].ToString(), ds.Tables[0].Rows[i].ItemArray[1].ToString(), ds.Tables[0].Rows[i].ItemArray[2].ToString(), ds.Tables[0].Rows[i].ItemArray[3].ToString()));            
            return x;
        }
        
        // номера счета по номеру договора
        public static string GetNAccountByNContract(string _N_Contract)
        {
            
            // считываем 
            string strSQL = "SELECT tbPayments.N_Account FROM tbPayments, tbContract where tbContract.N_Account= tbPayments.N_Account AND  tbContract.ID_Request = '" + _N_Contract + "' ;";            
            // запрос выдает столбец
            DataSet  ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);           
            return ds.Tables [0].Rows [0].ItemArray [0].ToString ();
        }

        // номеру договора по номеру счета
        public static string GetNContractByNAccount(string _N_Account)
        {
            // считываем 
            string strSQL = "SELECT tbContract.N_Contract FROM tbPayments, tbContract where tbContract.N_Account= tbPayments.N_Account AND  tbPayments.N_Account = '" + _N_Account + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return ds.Tables[0].Rows[0].ToString();
        }
                
        // создание нового платежа
        // все генерятся автоматом, все фальш
        // клиент не оплатил (плохой), пока не оплатил - презумпция невиновности не работает
        public static void  ToPay(string _N_Account, DateTime _Data, bool _Pay )
        {            
            // новая транзакция
            string NewTransaction = ClassPayment.GenerateNTransaction();            

            string buf;
            string strSQL = "INSERT INTO tbPayments"
                              + "(N_Account, Date, Payment, N_Transaction)" 
                 +" VALUES ('" + _N_Account  + "', '" + _Data.ToShortDateString()  + "', '" + _Pay .ToString ()+ "', '"+NewTransaction +"');";

             MyClasses.MySQL.MakeSQL (strSQL, out buf );
             
             // выводим результат на главную форму
             if (buf == "Успешно")
                 MyMainForm.State = "Запись успешно добавлена";
             else MyMainForm.State = buf;
             
        }
    
        // проводка платежа - изменение
        public static void  ToPayChange(string _N_Account,DateTime _Date, bool _Pay )
        {
            // изменение платежа
            string buf;
            string strSQL = "UPDATE tbPayments set Payment = '" + _Pay.ToString() + "', N_Transaction= "+ClassPayment .GenerateNTransaction ()+" from tbPayments where N_Account = '" + _N_Account + "' and Date = '" + _Date.ToShortDateString() + "';";
            MyClasses.MySQL.MakeSQL(strSQL, out buf);

            // выводим результат на главную форму
            if (buf == "Успешно")
                MyMainForm.State = "Запись успешно добавлена";
            else MyMainForm.State = buf;             
        }

        // генерим номер транзакции
        public static string GenerateNTransaction()
        {
            Random r = new Random();
            string N_Transaction = "";

            // генерим 10 цифр
            for (int i = 0; i < 10; i++)
                N_Transaction += r.Next(0, 9).ToString();
            return N_Transaction;
        }
       
    }
}
