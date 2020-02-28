using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Scoring
{
    // тут лежат параметры для расчетов
    // коэф. платежа от чистой прибыли - сколько денег из прыбыли клиент теоретично может отдавать
    // нижняя планка балла по анкете - ниже кредит не дадут
    // верхняя планка балла по анкете - выше кредит не дадут
    // количество неплатежей или задержек платежей, чтобы стать плохим клиентом


    // сам класс
    static class ClassParams
    {
        // коэф. платежа
        static public double K = 0;
        // нижняя планка
        static public double LowPercent = 0;
        // верхняя планка
        static public double HighPercent = 0;
        // количество неплатежей
        static public int DelaysForBad = 0;

        // читаем все с БД
        public static void ReadFromDB()
        {
            // строка запроса
            string strSQL = "SELECT * FROM tbParams";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            // заносим данные
            K = double.Parse (ds.Tables[0].Rows[0].ItemArray[0].ToString());
            LowPercent = double.Parse (ds.Tables[0].Rows[0].ItemArray[1].ToString());
            HighPercent= double.Parse (ds.Tables[0].Rows[0].ItemArray[2].ToString());
            DelaysForBad = int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString());
        }

        // сохраняем в БД
        static public void SaveToDB()
        { 
            string buf;

            // записываем
            string strSQL = "UPDATE tbParams  SET Koefficient = '" + K.ToString ()+
                "',  LowPercent= '" + LowPercent.ToString() + "', HighPercent= '" + HighPercent.ToString() + "', DelaysForBad = '"+DelaysForBad+"';";
            // выполнение
            MyClasses.MySQL.MakeSQL(strSQL, out buf);
            // выводим результат на главную форму
            if (buf == "Успешно")
                MyMainForm.State = "Запись успешно добавлена";
            else MyMainForm.State = buf;

        }

    }
}
