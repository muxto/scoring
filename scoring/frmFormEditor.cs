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
    // форма изменения и создания анкет
    public partial class frmFormEditor : Form
    {
        // тип вопроса
        enumTypeQuestion TypeQuestion = enumTypeQuestion .Text;
        // анкета
        ClassForm NewForm;

        // ИД файла
        string FileID = "";

        //конструктор - новая анкета
        public frmFormEditor()
        {
            InitializeComponent();
            NewForm = new ClassForm();

            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }

        //конструктор - редактируем старую
        public frmFormEditor(ClassForm _NewForm, string _FileID) : this ()
        {

            NewForm = _NewForm;
            FileID = _FileID;
            // считать из анкеты
            WriteQuestions();

        }

        // забивает из листа ответы на форму
        void WriteQuestions()
        {
            lstQuestions .Items.Clear();
            // выводим все вопросы
            //NewForm.Questions = NewForm.MyForm;
            foreach (var i in NewForm .Questions  )
            {
//                lstQuestions.Items.Add( +"\t"+ i.Question + "\t" + i.Value + "\t" + i.Mark.ToString() + "\t" + i.TypeQuestion .ToString () );

                List <string> x = new List<string> ();
                x.Add (i.Number.ToString ());
                x.Add (i.Question);
                x.Add (i.Value );
                x.Add (i.Mark.ToString ());
                x.Add (i.TypeQuestion.ToString ());


                lstQuestions.Items.Add (new ListViewItem (x.ToArray ()));
            }
            lstQuestions.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );

            // ответ
            txtAnswer.Text = "";
            // балл
            txtMark.Text = "0";
            // в самый низ
            lstQuestions.Focus ();
            lstQuestions.Items[lstQuestions.Items.Count - 1].Selected = true;
            // галки выкл
            chkHumanExpert.Checked = false;
            chkFail.Checked = false;
        }

        // вопрос добавить
        private void btn_AddNewQuestion_Click(object sender, EventArgs e)
        {
            int Mark;
            if (!int.TryParse(txtMark.Text, out Mark))
            {
                MessageBox.Show("количество баллов будет приравнено к нулю", "ошибка в обработке баллов", MessageBoxButtons.OK);
                Mark = 0;
            }

            NewForm.Questions.Add(new ClassQuestion(txtQuestion.Text, txtAnswer.Text, Mark));
            WriteQuestions();
        }

        void LstQuestionsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndices.Count != 0)
            {

                chkHumanExpert.Checked = false;
                chkFail.Checked = false;

                var n = lstQuestions.SelectedIndices[0];
                txtQuestion.Text  = NewForm.Questions[n].Question ;
                txtAnswer.Text = NewForm.Questions[n].Value;
                txtMark.Text = NewForm.Questions[n].Mark.ToString();

                var m = NewForm.Questions[n].Mark;

                if (m == -1)
                    chkHumanExpert.Checked = true ;
                if (m == -10)
                    chkFail.Checked = true;

            }

        }

        // вопрос сохранить измененный
        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndices.Count != 0)
            {
                var n = lstQuestions.SelectedIndices[0];
                NewForm.Questions[n].Question = txtQuestion.Text;
                NewForm.Questions[n].Value = txtAnswer.Text;
                NewForm.Questions[n].Mark = int.Parse(txtMark.Text);

                var m = NewForm.Questions[n].Mark;
                if ((m > 0) && (m != -1) && (m != -10 ))
                {
                    txtMark.Focus ();
                    return ;
                }

                NewForm.Questions[n].TypeQuestion = TypeQuestion;
            }
            WriteQuestions();
        }

        // вопрос удалить
        private void btn_DelQuestion_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndices.Count != 0)
            {
                var n = lstQuestions.SelectedIndices[0];
                NewForm.Questions.RemoveAt(n);
            }
            WriteQuestions();
        }

        // очистить вопросы
        private void btnClearQuestions_Click(object sender, EventArgs e)
        {
            NewForm.Questions .Clear();
            WriteQuestions();
        }

        // только цифры
        private void txtMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        // проверить позднее
        private void chkHumanExpert_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox x = (CheckBox)sender;
            if (x.Checked)
            {
                txtMark.Text = "-1";
                chkFail.Checked = false;
            }
        }

        // отказать в кредите
        private void chkFail_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox x = (CheckBox)sender;
            if (x.Checked)
            {
                txtMark.Text = "-10";
                chkHumanExpert.Checked = false;
            }
        }

        // сохранить анкету
        private void btnSaveForm_Click(object sender, EventArgs e)
        {

            if (NewForm.GetNumberByQuestion ("Среднемесячные доходы") == null)
            {
                MessageBox.Show ("Должен быть вопрос 'Среднемесячные доходы'");
                return;
            }
            if (NewForm.GetNumberByQuestion ("Среднемесячные расходы") == null)
            {
                MessageBox.Show ("Должен быть вопрос 'Среднемесячные расходы'");
                return;
            }

            // если изменяем существующую
            if (FileID != "") NewForm.SaveToDB(FileID);
            // или создаем новую
            else NewForm.SaveToDB();
            MyMainForm.f = new frmForms();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // определяем число раз вопроса
            // определеяем одинаковые и даем им оодинаковые номера
            // опеределяем балл -1

            // число раз вопроса 1  = text
            // больше 1             = list

            // пересчитай
            NewForm.Enumerate();
            WriteQuestions();
            lblMaxSum.Text = NewForm.MaxSum.ToString ();
            lblMinSum.Text = NewForm.MinSum.ToString ();
        }

        // поднять вопрос выше
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndices.Count != 0)
            {
                var n = lstQuestions.SelectedIndices[0];
                if (n == 0)
                    return ;
                NewForm.Questions.Insert(n - 1, NewForm.Questions[n]);
                NewForm.Questions.RemoveAt(n + 1);
                WriteQuestions();

                lstQuestions.Focus ();
                lstQuestions.Items [n - 1].Selected = true ;
                lstQuestions.Items [n - 1].Focused = true ;
                lstQuestions.TopItem = lstQuestions.Items [n - 1];
            }
        }

        void BtnDownClick(object sender, EventArgs e)
        {

            if (lstQuestions.SelectedIndices.Count != 0)
            {

                var n = lstQuestions.SelectedIndices[0];
                if (n == lstQuestions.Items.Count-1)
                    return ;
                NewForm.Questions.Insert(n, NewForm.Questions[n + 1]);
                NewForm.Questions.RemoveAt(n + 2);
                WriteQuestions();
                lstQuestions.Focus ();
                lstQuestions.Items[n + 1].Selected = true;
                lstQuestions.Items [n + 1].Focused = true ;
                lstQuestions .TopItem = lstQuestions.Items [n + 1];
            }

        }































    }
}
