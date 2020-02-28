using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Data;

namespace Scoring
{
    // класс кредит
    // структура для описания кредита и вычисляет платежи
    // входит в классклиент, а может быть отдельно

    [Serializable]
    // класс проценты до опр. суммы
    public class ClassSumPercent
    {
        // сумма
        public int maxSum;
        // проценты
        public double Percent;

        // конструктор
        public ClassSumPercent(int _maxSum, double _Percent)
        {
            maxSum = _maxSum;
            Percent = _Percent;
        }
    }


    // строка для списка кредтов
    public class ClassCreditTitle
    {
        // ИД файла
        public string FileID;
        // название
        public string CreditName;
        // дата
        public string Date;

        // конструктор
        public ClassCreditTitle(string _FileID, string _CreditName, string _Date)
        {
            FileID = _FileID;
            CreditName = _CreditName;
            Date = _Date;
        }
    }

    [Serializable]
    // класс обработки кредита
    public class ClassCredit
    {
        // название кредита
        public string Name;

        // месяцы
        // мин
        public int minMonth;
        // макс
        public int maxMonth;

        // максимальная сумма
        public int MaxSum;

        // процентные ставки
        public List<ClassSumPercent> ListSumPercent;

        // на самом деле сумма
        double RealSum;

        // сумма кредита
        public double CreditSum
        {
            get
            {
                return RealSum;
            }
            set
            {
                // меньше максимальной
                if (value > MaxSum) RealSum = MaxSum;
                // меньше рубля
                if (value < 1) RealSum = 1;
                else RealSum = value;
            }
        }

        // процент кредита
        public double Percent
        {
            get
            {
                double buf = 100;
                foreach (var i in ListSumPercent)
                {
                    // вычисляется по процентным ставкам
                    if ((RealSum <= i.maxSum) && (i.Percent < buf))
                        buf = i.Percent;
                }
                return buf;
            }
        }

        // лист платежей
        public List<int> ListPayments;

        // месяцы
        public int Months
        {
            get
            {
                return ListPayments.Count;
            }
        }

        // конструктор
        public ClassCredit()
        {
            ListSumPercent = new List<ClassSumPercent>();
        }

        // считать все кредиты из БД
        public static List<ClassCreditTitle> AllCreditInDB()
        {
            // лист заголовков анкет в БД
            List<ClassCreditTitle> x = new List<ClassCreditTitle>();

            // запрос
            string strSQL = "SELECT FileID, Name, Date FROM tbFiles where filetype= 'Кредит';";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            // иницализуем массив ИД

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // в список
                x.Add(new ClassCreditTitle(ds.Tables[0].Rows[i].ItemArray[0].ToString(), ds.Tables[0].Rows[i].ItemArray[1].ToString(), ds.Tables[0].Rows[i].ItemArray[2].ToString()));
            }
            return x;
        }

        // читаем кредит из БД
        public static ClassCredit ReadFromDB(string _FileID)
        {
            // как обычно, сериализация
            byte[] NewFormByte = MyClasses.MySQL.ReadFileFromDB(_FileID, "tbFiles");

            Stream FileStream = new MemoryStream(NewFormByte);
            // сам десериализатор
            BinaryFormatter deserializer = new BinaryFormatter();

            // десереализуем поток в объект
            object x = deserializer.Deserialize(FileStream);
            // явное преобразование в класс
            ClassCredit _MyClass = (ClassCredit)x;
            FileStream.Close();

            return _MyClass;
        }

        // считать аннуитетные платежи
        public void CalculateCreditAnnuity(int _Month, int _Sum)
        {
            // лист платежей
            ListPayments = new List<int>();
            // сумма
            RealSum = _Sum;

            // процент за месяц = годовой / 12 месяцев
            double i = Percent / 12 / 100;

            // хитрая формула
            // это настоящая формула да
            double k = (i * Math.Pow((1 + i), _Month)) / (Math.Pow((1 + i), _Month) - 1);

            // платежи в лист
            for (int j = 0; j < _Month; j++)
            {
                // округляем
                double a = Math.Round(k * RealSum, MidpointRounding.ToEven);
                // добавляем
                ListPayments.Add(Convert.ToInt32(a));
            }
        }

        // дифференцированные платежи
        public void CalculateCreditDifferent(int _Month, int _Sum)
        {
            // лист платежей
            ListPayments = new List<int>();
            // сумма
            RealSum = _Sum;
            // оставшаяся сумма кредита
            double dSum = _Sum;
            // месячный процент
            double i = Percent / 12 / 100;
            // ежемесячный основной платеж 
            double l = RealSum / _Month;

            // считаем
            for (int j = 0; j < _Month; j++)
            {
                // начисленные проценты на оставшуюся сумму
                double x = dSum * i;
                // складываем основной платеж и проценты, сумму округляем                                
                double a = Math.Round((x) + l, MidpointRounding.ToEven);
                // добавили
                ListPayments.Add(Convert.ToInt32(a));
                // уменьшили оставшуюся сумму
                dSum -= l;
            }
        }

        // дадите кредит?
        public bool GimmeCredit(int _Salary, double _k)
        {
            // первый платеж в дифференцированных платежах самый большой
            // а в аннуитетных все одинаковые
            // заплатит первый - запалатит и остальные
            // если чистая прибыль * коэф < платежа

            if (_Salary * _k < ListPayments[0])
            {
                // не дадим кредит
                return false;
            }
            // дадим кредит
            return true;
        }
    }
}
