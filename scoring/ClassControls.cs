using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows .Forms ;
using System.Drawing;

namespace Scoring
{
    // тип текстбокса - для вопроса или балла
    // это на форме уточнения
    public enum enumTypeTextBox
    {
        Answer,
        Mark
    }

    // мой текстбокс
    // с блэкджеком и шлюхами
    public  class ClassControlTextBox :TextBox
    {
        // номер вопроса - его ИД
        public int n;
        // для ответа или числа
        public enumTypeTextBox Me;

        // конструктор
        public ClassControlTextBox(int _n, Point _locat)
        {
            // уникальный номер вопроса
            n = _n;
            // расположение элемента
            this.Location = _locat;
        }

        // вернуть ответ
        public  ClassAnswer ReturnAnswer ()
        {
            ClassAnswer x = new ClassAnswer(n, MyClasses.NewClient .MyForm .Questions[n].Question, this.Text, MyClasses.NewClient  .MyForm.Questions [n].Mark);
            return x;
        }
    }

    // мой комбобокс
    public class ClassControlComboBox : ComboBox
    {
        // массив номеров вопросов
        public List<int> nList;

        // конструктор
        public ClassControlComboBox( Point _locat)
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Location = _locat;
            nList = new List<int>();
        }

        // добавляем варианты
        public void AddItem(int _n, string _Answer)
        {
            this.Items.Add(_Answer);
            nList.Add(_n);
        }

        // возвращаем ответ
        public  ClassAnswer ReturnAnswer ()
        {
            int n = nList [this .SelectedIndex] ;
            ClassAnswer x = new ClassAnswer(n, MyClasses.NewClient .MyForm.Questions[n].Question, this.SelectedItem .ToString (), MyClasses.NewClient .MyForm.Questions [n].Mark);
            return x;
        }
    }
}
