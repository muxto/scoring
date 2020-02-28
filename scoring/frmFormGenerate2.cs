/*
 * Сделано в SharpDevelop.
 * Пользователь: Михто
 * Дата: 28.06.2014
 * Время: 15:41
 *
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scoring
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class frmFormGenerate2 : Form
    {
        public frmFormGenerate2()
        {
            InitializeComponent();

            CreateControls ();
            
            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }

        // рисуем кнопки
        void CreateControls()
        {
            // обчищаем форму
            this.pnlControls.VerticalScroll.Value = 0;
            this.pnlControls.Controls.Clear();

            // строка
            int y = 0;

            // каждый ответ
            foreach (var i in MyClasses .NewClient .ClientForm)
            {
                // если уточняется
                if (i.Mark == -1)
                {
                    // надпись
                    Point LabelPoint = new Point(10, y * 27 + 17);

                    Label NewLabel = new Label();
                    NewLabel.AutoSize = true;
                    NewLabel.Text = i.Question;
                    NewLabel.Location = LabelPoint;
                    this.pnlControls.Controls.Add(NewLabel);

                    // вариант для ответа
                    ClassControlTextBox ControlAnswer = new ClassControlTextBox(i.n, new Point(300, y * 27 + 17));
                    ControlAnswer.Me = enumTypeTextBox.Answer;
                    this.pnlControls.Controls.Add(ControlAnswer);
                    y++;
                    // вариант для балла
                    ClassControlTextBox ControlMark = new ClassControlTextBox(i.n, new Point(300, y * 27 + 17));
                    ControlMark.Me = enumTypeTextBox.Mark;
                    ControlMark.Text = "0";
                    ControlMark.KeyPress += Program.txt_KeyPress ;
                    this.pnlControls.Controls.Add(ControlMark);
                    y++;
                }
            }

            
        }

        // читаем с формы в ответы
        void ReadFromControlsMore()
        {
            // каждую кнопу
            foreach (var i in this.pnlControls.Controls)
            {
                // если текстбокс
                if (i.ToString().Contains("TextBox"))
                {
                    // мой текстбокс
                    ClassControlTextBox x = (ClassControlTextBox)i;
                    // для ответа
                    if (x.Me == enumTypeTextBox.Answer)
                    {
                        // находим вопрос
                        ClassQuestion q = MyClasses .NewClient  .MyForm.Questions[x.n];
                        // вставляем ответ
                        MyClasses .NewClient .ClientForm[q.Number].Answer = x.Text;
                    }
                    // для балла
                    if (x.Me == enumTypeTextBox.Mark)
                    {
                        // находим вопрос
                        ClassQuestion q = MyClasses .NewClient  .MyForm.Questions[x.n];
                        // вставляем балл
                        int.TryParse(x.Text, out MyClasses .NewClient .ClientForm[q.Number].Mark);
                    }
                }
            }
            // пересчитали балл
            MyClasses .NewClient .ProcessAnswers();
        }


        void BtnNextClick(object sender, EventArgs e)
        {
            ReadFromControlsMore();
            MyMainForm.f = new frmOutClient();
        }
    }
}
