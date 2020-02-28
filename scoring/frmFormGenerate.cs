using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Scoring
{
    // форма для прохождения анкеты
    // сначала генерятся кнопки CreateControls()
    //
    // можно сгенерить значения btnGenerate_Click(object sender, EventArgs e)
    // и вывести их на кнопки WriteControls()
    //
    // потом с них считываются значения ReadFromControls()
    // кнопка далее btnNext_Click(object sender, EventArgs e) и кнопка сохранить btnSave_Click(object sender, EventArgs e)
    // или!
    // если есть ответы с уточнениями, генерятся еще кнопки на них (там же)
    // и с них опять считывются значения ReadFromControlsMore()
    // кнопка сохранить btnSaveMore_Click(object sender, EventArgs e)


    public partial class frmFormGenerate : Form
    {
        Button btnGenerate;

        // конструктор
        // надо думать что новый клиент с его анкетой уже лежат в статической переменной
        // поэтому нафиг тут аргументы
        // хотя опасно, вывалится все
        // вызывать надо правильно, тогда не вывалится
        public frmFormGenerate( )
        {
            InitializeComponent();
            // рисуем кнопки
            CreateControls();
            
            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }

        // рисуем кнопки
        void CreateControls()
        {
            // столбец
            int y = 0;

            // для каждого вопроса
            // каждый уникальный вопрос
            for (int i = 0; i < MyClasses.NewClient .MyForm.CountUniqueQuestions; i++)
            {
                // получаем вопрос
                var x = MyClasses.NewClient .MyForm.GetQuestionByNumber(i);

                // расположение надписи
                Point LabelPoint = new Point(10, y * 27 + 17);
                // новая надпись
                Label NewLabel = new Label();
                NewLabel.AutoSize = true;
                // ее текст - название вопроса
                NewLabel.Text = x.Question;
                // ее расположение
                NewLabel.Location = LabelPoint;
                // добавили
                this.pnlControls.Controls.Add(NewLabel);

                // сижу на сковороде, он нудит про котограф
                // охохо как я буду его сдавать
                // ирка рядом, привет

                // выбираем вариант вопроса
                switch (x.TypeQuestion)
                {
                    // один ответ
                case enumTypeQuestion.Text:
                {
                    // новый текстбокс
                    // текстбокс естесственно мой наследованный - добавлены поля
                    ClassControlTextBox NewControl = new ClassControlTextBox(x.n, new Point(300, y * 27 + 17));
                    // добавляем на форму
                    this.pnlControls.Controls.Add(NewControl);
                }
                break;

                // несколько вариантов ответа
                case enumTypeQuestion.List:
                {
                    // новый комбобокс
                    // комбобокс естесственно мой наследованный - добавлены поля
                    ClassControlComboBox NewControl = new ClassControlComboBox(new Point(300, y * 27 + 17));

                    // адский код - цикл внутри цикла
                    // прости меня, ктулху
                    // смотрим все вопросы
                    foreach (var j in MyClasses.NewClient .MyForm.GetQuestionList(i))
                    {
                        // добавляем  номер и вариант
                        NewControl.AddItem(j.n, j.Value);
                    }
                    // добавляем комбобокс
                    this.pnlControls.Controls.Add(NewControl);
                }
                break;
                }
                // следующая строка
                y++;
            }

            y = 2;
            // кнопа генерить
            // случайно выбирает ответы
            // заполняет нужные поля
            btnGenerate = new Button();
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Location = new Point(540, y * 27 + 17);
            btnGenerate.Size = new Size (140,40);
            btnGenerate.Click += new EventHandler(btnGenerate_Click);
            btnGenerate.Text = "Заполнить автоматически";
            this.Controls.Add(btnGenerate);
            y++;


        }


        // читаем с формы в ответы
        void ReadFromControls()
        {

            // обчищаем ответы
            MyClasses .NewClient .ClientForm.Clear();

            // каждую кнопу
            foreach (var i in this.pnlControls.Controls)
            {
                // если текстбокс
                if (i.ToString().Contains("TextBox"))
                {
                    // мой текстбокс
                    ClassControlTextBox x = (ClassControlTextBox)i;
                    // находим ответ
                    MyClasses .NewClient .ClientForm.Add(x.ReturnAnswer());
                }
                // если комбобокс
                if (i.ToString().Contains("ComboBox"))
                {
                    // мой комбобокс
                    ClassControlComboBox x = (ClassControlComboBox)i;
                    // находим ответ
                    MyClasses .NewClient .ClientForm.Add(x.ReturnAnswer());
                }
            }
            // посчитали балл
            MyClasses .NewClient .ProcessAnswers();
        }





        // кнопа Генерить
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MyClasses .NewClient .GenerateClient(MyClasses .NewClient  .MyForm);
            WriteControls();
        }

        // заполнить кнопки
        public void WriteControls()
        {
            // каждую кнопу
            foreach (var i in this.pnlControls.Controls)
            {
                // если текстбокс
                if (i.ToString().Contains("TextBox"))
                {
                    // мой текстбокс
                    ClassControlTextBox x = (ClassControlTextBox)i;
                    // выводим в текстбокс ответ
                    // ужас какой то
                    x.Text = MyClasses .NewClient .GetAnswerByN(x.n).Answer;
                }
                // если комбобокс
                if (i.ToString().Contains("ComboBox"))
                {
                    // мой комбобокс
                    ClassControlComboBox x = (ClassControlComboBox)i;

                    // ужасный код
                    for (int j = 0; j < x.nList.Count; j++)
                    {
                        bool ok = false;

                        foreach (var a in MyClasses .NewClient .ClientForm)
                            if (x.nList[j] == a.n)
                            {
                                x.SelectedIndex = j;
                                ok = true;
                                break;
                            }
                        if (ok) break;
                    }
                }
            }
        }

        // кнопа далее - для уточнения
        void btnNext_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;

            // считываем значения
            ReadFromControls();

            // если есть ответы с уточнениями
            if (MyClasses.NewClient.CountOfQuestionsMore != 0)
            {
                MyMainForm.f = new frmFormGenerate2 ();
            }
            else
            {
                MyMainForm.f = new frmOutClient();
            }
        }


    }
}
