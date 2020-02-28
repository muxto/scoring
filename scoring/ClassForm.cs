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
    // сама анкета с функциями пересчета
    // входит в классклиент, а может быть отдельно

    // тип ответа
    public enum enumTypeQuestion
    {
        // один
        Text,
        // несколько вариантов
        List
    }
   
    // вопрос
    [Serializable]
    public class ClassQuestion
    {
        // уникальный номер вопроса с ответом - по порядку
        public int n;
        // номер вопроса, возможно с несколькими ответами
        public int Number;
        // сам вопрос
        public string Question;
        // вариант ответа
        public string Value;
        // балл
        public int Mark;
        // тип ответа
        public enumTypeQuestion TypeQuestion;

        // конструктор
        public ClassQuestion(string _Question, string _Value, int _Mark)
        {
            Question = _Question;
            Value = _Value;
            Mark = _Mark;
        }
    }

    // строка для списка анкет
    public class ClassFormTitle
    {
        // ИД файла
        public string FileID;
        // количество вопросов
        public int Questions;
        // дата
        public string Date;

        // конструктор
        public ClassFormTitle(string _FileID, string _Questions, string _Date)
        {
            FileID = _FileID;
            Questions = int.Parse (_Questions);
            Date = _Date;
        }
    }

    // класс анкета
    [Serializable]
    public class ClassForm
    {
        // баллы 
        // 0 = 0
        // -1 = уточните
        // - 10 - отказ

        // анкета
        public List<ClassQuestion> Questions;

        //public List<ClassQuestion> MyForm;

        // лист с уникальными вопросами
        public List<string> ListUniqueQuestions;

        // число вопросов = числу ответов, где в вопросе несколько вариантов ответа
        public int CountUniqueQuestions = 0;

        // максимальная сумма баллов за данную анкету
        public int MaxSum = 0;
        // минимальная сумма баллов за данную анкету
        public int MinSum = 0;

        // как то хитро что конструктор никогда не вызывается
        // потому что я сериализую обьект 
        // потому и не вызывается
        // только если новую анкету
        public ClassForm()
        {
            Questions = new List<ClassQuestion>();
        }

        // пересчитать вопросы и выдать их тип
        public void Enumerate()
        {
            // номер вопроса
            int n = 0;
            // подсчет числа раз повторений
            int k;
            // миниммум баллов в данном вопросе
            int Min;
            // максимум баллов в данном вопросе
            int Max;
            // обнуляем общий максимум и минимум
            MaxSum = 0;
            MinSum = 0;

            // униакальные вопросы
            ListUniqueQuestions = new List<string>();

            k = 0;

            foreach (var i in Questions)
            {
                // задаем номер для каждого вопроса
                i.n = n;
                n++;

                // если вопрос не добавлялся еще
                if (!ListUniqueQuestions.Contains(i.Question))
                    // добавляем
                    ListUniqueQuestions.Add(i.Question);
            }

            // это количество ответов
            CountUniqueQuestions = ListUniqueQuestions.Count();

            // присваиваем повторяющимся вопросам одинаковые номера
            // это значит вопросы с вариантами ответов
            // каждый вопрос
            n = 0;
            foreach (var i in ListUniqueQuestions)
            {
                foreach (var j in Questions)
                    // присваиваем ему номер
                    if (j.Question == i) j.Number = n;
                n++;
            }
            // считаем сколько раз каждый вопрос повторяется
            // каждый вопрос
            foreach (var i in Questions)
            {
                // обнуляем счетчик
                k = 0;
                // внутренний цикл
                foreach (var j in Questions)
                {
                    // повторился 
                    if (i.Question == j.Question)
                        // увеличили счетчик
                        k++;
                }
                // вопрос один раз
                if (k == 1)
                {
                    // значит текстбокс
                    i.TypeQuestion = enumTypeQuestion.Text;
                }
                // больше 1 раза
                else
                {
                    // значит с вариантами ответов
                    i.TypeQuestion = enumTypeQuestion.List;
                }
            }            

            // считаем максимальную и минимальную сумму
            for (int i = 1; i < n; i++)
            {
                Max = 0;
                Min = 10000;
                // каждый вопрос
                foreach (var j in Questions)
                {
                    // по номерам
                    // балл не уточняется 
                    // и не отказ
                    if ((j.Number == i) && (j.Mark != -10) && (j.Mark != -1))
                    {
                        if (j.Mark > Max)                        
                            Max = j.Mark;                                                    
                        if (j.Mark < Min)
                            Min = j.Mark;
                        
                    }

                }
                // доплюсовали минимум
                if (Min != 10000)
                MinSum += Min;
                // доплюсовали максимум
                MaxSum += Max;
                // следующий вопрос
            }
        }

        // вернуть номер по вопросу
        public ClassQuestion GetNumberByQuestion(string _Question)
        {
            foreach (var i in Questions)
                if (i.Question == _Question) return i;
            return null;
        }

        // вернуть вопрос по номеру
        public ClassQuestion GetQuestionByNumber(int _Number)
        {
            foreach (var i in Questions)
                if (i.Number == _Number) 
                    return i;
            return new ClassQuestion("", "", 0);
        }

        // возвращает вопрос с несколькими вариантами ответов
        public List<ClassQuestion> GetQuestionList(int _Number)
        {
            List<ClassQuestion> OutList = new List<ClassQuestion>();
            foreach (var i in Questions)
                if (i.Number == _Number) OutList.Add(i);
            return OutList;

        }

        public static List <ClassFormTitle> AllFormsInDB()
        {
            // лист заголовков анкет в БД
            List <ClassFormTitle> x = new List<ClassFormTitle> ();
            
            // строка запроса
            string strSQL = "SELECT FileID, Questions, Date FROM tbFiles where filetype= 'Анкета' ORDER BY Date ASC;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            // иницализуем массив ИД
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
            x.Add (new ClassFormTitle (ds.Tables[0].Rows[i].ItemArray[0].ToString(),ds.Tables[0].Rows[i].ItemArray[1].ToString (), ds.Tables[0].Rows[i].ItemArray[2].ToString ()));               
            }
            return x;
        }

        // читаем анкету из БД
        public static ClassForm ReadFromDB(string _FileID)
        {
            byte[] NewFormByte = MyClasses.MySQL.ReadFileFromDB(_FileID, "tbFiles");

            Stream FileStream = new MemoryStream(NewFormByte);
            // сам десериализатор
            BinaryFormatter deserializer = new BinaryFormatter();

            // десереализуем поток в объект
            object x = deserializer.Deserialize(FileStream);
            // явное преобразование в класс
            ClassForm _MyClass = (ClassForm)x;
            FileStream.Close();

            return _MyClass;            
        }

        // сохранить новую анкету в БД
        public void SaveToDB()
        {
            string strSQL;
            string strOut;

            string FileID = Guid.NewGuid().ToString();

            // сохраняем в поток
            Stream FileStream = new MemoryStream();
            // сам сериализатор
            BinaryFormatter serializer = new BinaryFormatter();

            // сериализуем экземпляр MySubject в поток FileStream
            serializer.Serialize(FileStream, this );

            // добавление файла
            strSQL = "INSERT INTO tbFiles  (FileType, FileID,  Date, Questions, FileBinary) " +
            "values ('Анкета', '" + FileID + "','" + DateTime.Today + "', '" + this.Questions . Count + "', @FileBinary);";


            // переводим поток в байты
            byte[] byteArray = new byte[FileStream.Length];
            FileStream.Position = 0;
            FileStream.Read(byteArray, 0, (int)FileStream.Length);

            // добавляем
            MyClasses.MySQL.AddFileToDB(strSQL, byteArray, out strOut);

            FileStream.Close();

            MyMainForm.State = strOut;
        }

        // изменить существующую анкету в БД
        public void SaveToDB(string _FileID)
        {
            string strOut;
            // сохраняем в поток
            Stream FileStream = new MemoryStream();
            // сам сериализатор
            BinaryFormatter serializer = new BinaryFormatter();

            // сериализуем экземпляр MySubject в поток FileStream
            serializer.Serialize(FileStream, this );

            // добавление файла
            string strSQL = "UPDATE tbFiles  SET Date = '" + DateTime.Today + "', Questions = '" + this.Questions.Count
                + "', FileBinary = @FileBinary  WHERE FileID = '" + _FileID + "';";

            // переводим поток в байты
            byte[] byteArray = new byte[FileStream.Length];
            FileStream.Position = 0;
            FileStream.Read(byteArray, 0, (int)FileStream.Length);

            // добавляем
            MyClasses.MySQL.AddFileToDB(strSQL, byteArray, out strOut);
            FileStream.Close();

            MyMainForm.State = strOut;            

        }
    }
}
