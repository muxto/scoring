using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Scoring
{
    // сам клиент
    // у него есть анкета, ответы на нее и кредит

    // ответ
    // по сути есть таблица
    // ИД клиента | вопрос | ответ | балл
    public class ClassAnswer
    {
        public int n;
        // сам вопрос
        public string Question;
        // сам ответ
        public string Answer;
        // балл
        public int Mark;

        // конструктор
        public ClassAnswer(int _n, string _Question, string _Answer, int _Mark)
        {
            n = _n;
            Question = _Question;
            Answer = _Answer;
            Mark = _Mark;
        }
    }

    // клиент
    public class ClassClient
    {
        // мужские имена
        List<string> NamesMale;
        // женские имена
        List<string> NamesFemale;
        // фамилии
        List<string> Surname;
        // населенные пункты рф
        List<string> Address;
        // мужчина или женщина
        bool Male;

        // у клиента есть анкета
        public ClassForm MyForm;
        // кредит
        public ClassCredit MyCredit;
        // договор
        // ответы
        public List<ClassAnswer> ClientForm;

        // сумма баллов за ответы
        public int MarkSum = 0;
        // число ответов с уточнениями
        public int CountOfQuestionsMore;

        // чистая прибыль
        public int Profit
        {
            get
            {

                // доходы
                int Profit = int.Parse(GetAnswerByQuestion("Среднемесячные доходы").Answer);
                // расходы
                int Expense = int.Parse(GetAnswerByQuestion("Среднемесячные расходы").Answer);
                // чистая прибыль
                return (Profit - Expense);
            }
        }

        // одобрен ли кредит
        public  bool StatusCredit
        {
            get
            {
                // анкета норм
                return  !((MarkSum == -10) || (MarkSum < (ClassParams.LowPercent/100 * MyForm.MaxSum)) || (MarkSum > (ClassParams.HighPercent/100  * MyForm.MaxSum)) || (Profit <= 0));
            }
        }

        // максимальный месячный платеж
        public int MaxPay
        {
            get
            {
            	return (int)(Profit * ClassParams.K);
            }
        }


        // конструктор
        public ClassClient()
        {
            ClientForm = new List<ClassAnswer>();
            ClassParams.ReadFromDB();
        }

        // читает файлы для генерации
        void ReadFiles()
        {
            // мужские имена
            NamesMale.AddRange(File.ReadAllLines("name_male.txt", Encoding.Default));
            // женские имена
            // да, женские потом. да, я шовинист
            NamesFemale.AddRange(File.ReadAllLines("name_female.txt", Encoding.Default));
            // фамилии
            Surname.AddRange(File.ReadAllLines("surname.txt", Encoding.Default));
            // адреса
            Address.AddRange(File.ReadAllLines("address.txt", Encoding.Default));
        }

        // даем незаполненную анкету
        // и получаем заполненную
        // всемогущий ранодом создает клиента!
        // узри истинное могущество!
        public void GenerateClient(ClassForm _newForm)
        {
            // анкетка
            MyForm = _newForm;
            // ответы
            ClientForm = new List<ClassAnswer>();

            // инициируем листы
            NamesMale = new List<string>();
            NamesFemale = new List<string>();
            Surname = new List<string>();
            Address = new List<string>();

            // читаем файлы для генерации
            ReadFiles();
            // генератор подключили
            Random r = new Random();
            // дата рождеиния
            DateTime BirthDay = new DateTime();
            // год выдачи паспорта
            int PassportYear = new int();

            // 40% что женщина, 60 % что мужчина
            // это я сам так решил что мужики чаще кредит берут
            if (r.NextDouble() > 0.4) Male = true;
            else Male = false;

            // каждый уникальный вопрос
            for (int i = 0; i < MyForm.CountUniqueQuestions; i++)
            {
                // получаем вопрос
                var x = MyForm.GetQuestionByNumber(i);
                string Answer = "";

                // если один ответ
                if (x.TypeQuestion == enumTypeQuestion.Text)

                    switch (x.Question)
                    {
                    case "Фамилия":
                    {
                        // генерим фамилию
                        Answer = Surname[r.Next(Surname.Count)];
                        if (!Male)
                            Answer = Answer + "а";
                    }
                    break;
                    case "Имя":
                    {
                        // генерим имя
                        if (Male)
                            Answer = NamesMale[r.Next(NamesMale.Count)];
                        else
                            Answer = NamesFemale[r.Next(NamesFemale.Count)];
                    }
                    break;
                    case "Отчество":
                    {
                        // генерим имя + окончание
                        if (Male)
                            Answer = NamesMale[r.Next(NamesMale.Count)] + "ович";
                        else
                            Answer = NamesMale[r.Next(NamesMale.Count)] + "овна";
                    }
                    break;
                    case "Дата рождения":
                    {
                        // генерим дату рождения
                        int Year;
                        int Month;
                        int Day;

                        // от 1940 до 2000
                        Year = r.Next(1940, 1997);
                        Month = r.Next(1, 12);
                        Day = r.Next(1, DateTime.DaysInMonth(Year, Month));
                        BirthDay = new DateTime(Year, Month, Day);

                        Answer = Day.ToString() + "." + Month.ToString() + "." + Year.ToString();
                    }
                    break;
                    case "Место рождения":
                    {
                        // генерим город
                        Answer = Address[r.Next(Address.Count)];
                    }
                    break;
                    case "Документ, подтверждающий личность":
                    {
                        // адский генератор
                        Answer = "Паспорт";
                    }
                    break;

                    case "Кем выдан":
                    {
                        // генерим город
                        Answer = "ОУФМС РФ по городу " + Address[r.Next(Address.Count)];
                    }
                    break;

                    case "Серия, номер":
                    {
                        // минимум год рождения + 14 лет
                        PassportYear = r.Next(BirthDay.Year + 14, DateTime.Now.Year);
                        // первые 2 цифры генерятся, потом 2 цифры года выдачи, остальное генерится
                        Answer = r.Next(00, 99) + PassportYear.ToString().Substring(2, 2) + " " + r.Next(000000, 999999);
                    }
                    break;

                    case "Дата выдачи":
                    {
                        int Year;
                        int Month;
                        int Day;
                        // год - уже есть
                        Year = PassportYear;
                        Month = r.Next(1, 12);
                        Day = r.Next(1, DateTime.DaysInMonth(Year, Month));

                        Answer = Day.ToString() + "." + Month.ToString() + "." + Year.ToString();
                    }
                    break;

                    case "Телефон":
                    {
                        // телефон
                        Answer = "89" + r.Next(000000000, 999999999);
                    }
                    break;

                    case "Адрес":
                    {
                        // генерим город
                        Answer = Address[r.Next(Address.Count)];
                    }
                    break;

                    case "Среднемесячные доходы":
                    {
                        // доход от 4к до 60к
                        Answer = r.Next(4000, 60000).ToString();
                    }
                    break;

                    case "Среднемесячные расходы":
                    {
                        // расход от 2к до 30к
                        Answer = r.Next(2000, 30000).ToString();
                    }
                    break;
                    }
                // несколько вариантов ответа
                else
                {
                    // если это пол, то он задан
                    if (x.Question == "Пол")
                    {
                        // список вопросов
                        List<ClassQuestion> SomeQuestions = MyForm.GetQuestionList(i);

                        x = SomeQuestions[0];
                        if (Male)
                        {
                            Answer = "Мужской";
                            if (x.Value != "Мужской")
                                x = SomeQuestions[1];
                        }
                        else
                        {
                            Answer = "Женский";
                            if (x.Value != "Женский")
                                x = SomeQuestions[1];
                        }

                    }
                    // иначе будем выбирать варианты
                    else
                    {
                        // список вопросов
                        List<ClassQuestion> SomeQuestions = MyForm.GetQuestionList(i);
                        // выбираем случайный
                        x = SomeQuestions[r.Next(0, SomeQuestions.Count)];
                        Answer = x.Value;
                    }
                }
                // добавляем ответ
                ClientForm.Add(new ClassAnswer(x.n, x.Question, Answer, x.Mark));
            }
        }


        // вернуть вопрос по номеру
        public ClassAnswer GetAnswerByN(int _n)
        {
            foreach (var i in ClientForm)
                if (i.n == _n) return i;
            return new ClassAnswer(-1, "", "", 0);
        }

        // вернуть вопрос по номеру
        public ClassAnswer GetAnswerByQuestion(string _Question)
        {
            foreach (var i in ClientForm)
                if (i.Question == _Question) return i;
            return new ClassAnswer(-1, "", "", 0);
        }

        // посчитать баллы за ответы
        public void ProcessAnswers()
        {
            // обнуляем счетчики
            // общая сумма
            MarkSum = 0;
            // число ответов с уточнениями
            CountOfQuestionsMore = 0;

            bool Fail = false;
            // в каждом ответе
            foreach (var i in ClientForm)
            {
                // если ответ -10
                if (i.Mark == -10)
                {
                    // отказано в кредите полюбому
                    Fail = true;
                    // нафиг дальше считать
                    continue;
                }
                // если уточняется, то пропускаем
                if (i.Mark == -1)
                {
                    CountOfQuestionsMore++;
                    continue;
                }
                MarkSum += i.Mark;
            }
            if (Fail) MarkSum = -10;

        }

        // дайте кредит
        // выдает тру, если дадим
        public  bool GimmeCredit(int _Salary, double  _k)
        {
            // анкета норм
            // тут еще добавить минимальный и максимальный процент прохождения по анкете
            if ((MarkSum == -10) || (MarkSum < (ClassParams.LowPercent/100 * MyForm.MaxSum)) || (MarkSum > (ClassParams.HighPercent/100  * MyForm.MaxSum)))
                return false;
            // если по деньгам норм
            if (MyCredit.GimmeCredit(_Salary, _k) == false) return false;
            // конечно дадим!
            return true;
        }




        // ну дайте кредит
        // сохраняет клиента и заявку
        // если даем кредит, создает договор
        public void GimmeCreditAndSaveToDB(int _Salary, double _k, DateTime _Date, out bool _out)
        {
            bool IHaveCredit = GimmeCredit(_Salary, _k);
            // ID заявки
            string RequestID = Guid.NewGuid().ToString();

            _out = false;
            // нет кредита
            if (!IHaveCredit)
                // создаем заявку и все
                SaveToDBRequest(RequestID, false, _Date);
            // есть кредит
            else
            {
                SaveToDBRequest(RequestID, true, _Date );
                SaveToDBContract(RequestID, _Date);
                _out = true;
            }
        }

        // сохранять в табличку
        // клиента, ответ на анкету и заявку
        void SaveToDBRequest(string _RequestID, bool _Credit, DateTime _Date)
        {
            // буферная переменная
            string buf;
            string ClientStatus;
            string RequestStatus;
            if (_Credit)
            {
                ClientStatus = "Хороший";
                RequestStatus = "Одобрено";
            }
            else
            {
                ClientStatus = "Злой";
                RequestStatus = "Отказано";
            }

            // ID клиента
            string ClientID = Guid.NewGuid().ToString();

            // SQL
            string strSQL = "";

            strSQL = "INSERT INTO tbClient "
                     + "(ID_Client, Total_Mark, Max_Sum, Min_Sum, Delay, Status)"
                     + " VALUES ('" + ClientID + "', " + MarkSum + ", " + MyForm.MaxSum + ", " + MyForm.MinSum + ", 0, '" + ClientStatus + "' );";


            foreach (var i in ClientForm)
            {
                strSQL += "INSERT INTO tbClientForm "
                          + "(ID_Client, Question, Answer, Mark)"
                          + " VALUES ('" + ClientID + "', '" + i.Question + "', '" + i.Answer + "', '" + i.Mark.ToString() + "'); ";
            }



            strSQL += "INSERT INTO tbRequest "
                      + "(ID_Client, Credit_Sum, Credit_Percent, Credit_Period, Request_Status, ID_Request, Request_Date)"
                      + " VALUES ('" + ClientID + "', '" + MyCredit.CreditSum + "', '" + MyCredit.Percent + "', '" + MyCredit .Months + "', '" + RequestStatus  + "', '" + _RequestID + "', '" + _Date + "');";


            // выполнение
            MyClasses.MySQL.MakeSQL(strSQL, out buf);
            // выводим результат на главную форму
            if (buf == "Успешно")
                MyMainForm.State = "Запись успешно добавлена";
            else MyMainForm.State = buf;
        }

        // сохраняем в БД договор
        public void SaveToDBContract( string _RequestID, DateTime _Date)
        {
            Random r = new Random ();
            // буферная переменная
            string buf;

            // ID договора
            string ContractID = Guid.NewGuid().ToString();

            // номер счета
            string NumberAccount = ClassContracts .GenerateNAccount ();
            // номер договора
            string NumberContract = ClassContracts .GenerateNContract ();



            // SQL
            string strSQL = "";

            strSQL = "INSERT INTO tbContract "
                     + "(N_Contract, N_Account, Contract_Date_Begin, Contract_Date_End, ID_Request)"
                     + " VALUES ('" +NumberContract  + "', '" + NumberAccount + "', '" + _Date .ToShortDateString () + "', '" + _Date .AddMonths (MyCredit .Months).ToShortDateString ()+ "','"+_RequestID +"'"+");";

            for (int i = 0; i < MyCredit.Months; i++)
            {
                strSQL += "INSERT INTO tbPayments "
                          + "(N_Account, Date, Payment)"
                          + " VALUES ('" + NumberAccount  + "', '" + _Date.AddMonths (i).ToShortDateString () + "', '" + bool .FalseString+ "');";
            }

            // выполнение
            MyClasses.MySQL.MakeSQL(strSQL, out buf);
            // выводим результат на главную форму
            if (buf == "Успешно")
                MyMainForm.State = "Запись успешно добавлена";
            else MyMainForm.State = buf;
        }



    }

}
