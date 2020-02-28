using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scoring
{
    // кредитный калькулятор
    // данные никуда не идут, просто так считает
    public partial class frmCalculate : Form
    {
        // список кредитов
        List<ClassCreditTitle> Credits;

        // сам кредит
        ClassCredit MyCredit;

        // конструктор
        public frmCalculate(bool _OnlyCalculate)
        {
            InitializeComponent();

            // это смотря кто вызывает форму
            // если главная только считать - то кнопка Далее не выводится
            if (_OnlyCalculate)
            {
                lblMonthPay.Visible = false;
                label5.Visible = false;
//                label6.Visible = false;
                btnNext.Visible = false;
            }
            // если форма вызывается из заполнения анкеты, кнопка далее работает
            else
            {
                ClassParams.ReadFromDB();
                btnNext.Enabled = false;
                lblMonthPay.Text = MyClasses.NewClient.MaxPay .ToString ();
            }


            this.Activated += (sender, e) =>
            {
                // считываем список кредитов
                AddCredits();
                MyMainForm.ReShow ();
            };

        }

        // считываем список кредитов
        void AddCredits()
        {
            // очищаем лст
            cmbCredits.Items.Clear();
            // считываем
            Credits = ClassCredit.AllCreditInDB();

            foreach (var i in Credits )
                // выводим построчно
                cmbCredits.Items.Add(i.CreditName );
        }

        // выводим конкретный кредит
        void WriteCredit()
        {
            lstCredit.Items.Clear();

            lstCredit.Items.Add("----\nКредит");
            lstCredit.Items.Add("От " + MyCredit.minMonth.ToString() + " до " + MyCredit.maxMonth.ToString() + " месяцев");
            lstCredit.Items.Add("Максимальная сумма кредита " + MyCredit.MaxSum.ToString());
            lstCredit.Items.Add("----\nПроцентные ставки");
            foreach (var i in MyCredit.ListSumPercent)
            {
                lstCredit.Items.Add("до " + i.maxSum + " - " + i.Percent + "%");
            }

            // значения в месяцах
            numMonth.Maximum = MyCredit.maxMonth;
            numMonth.Minimum = MyCredit.minMonth;
        }

        // вывод платежей
        void PaymentsOut()
        {
            // сумма платежей
            double sum = 0;
            // очищаем лист
            lstPayments.Items.Clear();
            // выводим
            for (int i = 0; i < MyCredit .ListPayments  . Count; i++)
            {
                lstPayments.Items.Add("месяц " + (i + 1).ToString() +  "\t = \t" + MyCredit .ListPayments  [i]);
                sum += MyCredit .ListPayments  [i];
            }
            lstPayments.Items.Add("итого  \t = \t" + sum);

        }

        // считываем выбранный кредит
        private void cmbCredits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // читаем из БД
            MyCredit = ClassCredit.ReadFromDB(Credits[cmbCredits.SelectedIndex].FileID);
            // выводим
            WriteCredit();
            btnDifferent.Enabled = true;
            btnAnnuity.Enabled = true;
        }

        // изменение суммы кредита
        private void txtCreditSum_TextChanged(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            try
            {
                // максимальная сумма
                if (int.Parse(x.Text) > MyCredit.MaxSum) x.Text = MyCredit.MaxSum.ToString();
                // мин сумма
                if (int.Parse(x.Text) < 0) x.Text = "0";
            }
            catch
            {
                x.Text = "0";
            }
        }

        // только цифры
        private void txtCreditSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtAndPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.OemPeriod))
                e.Handled = true;
        }


        // дифференцированный платеж
        private void btnDifferent_Click(object sender, EventArgs e)
        {
            // считай диф платежи
            MyCredit.CalculateCreditDifferent((int)numMonth.Value, int.Parse(txtCreditSum.Text));
            // вывод процента
            lblPercent.Text = MyCredit.Percent.ToString();
            // вывод платежей
            PaymentsOut ();
            btnGraph.Enabled = true;
            btnNext.Enabled = true;
        }

        // считай аннуитетные платежи
        private void btnAnnuity_Click(object sender, EventArgs e)
        {
            // считай анн платежи
            MyCredit.CalculateCreditAnnuity((int)numMonth.Value, int.Parse(txtCreditSum.Text));
            // вывод процента
            lblPercent.Text = MyCredit.Percent.ToString();
            // вывод платежей
            PaymentsOut ();
            btnGraph.Enabled = true;
            btnNext.Enabled = true;
        }

        // кнопка далее
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MyCredit == null || MyCredit.ListPayments == null)
                return ;

            // кредит присваиваем клиенту
            MyClasses.NewClient.MyCredit = MyCredit;

            bool a;
            // требуем кредит!
            MyClasses.NewClient.GimmeCreditAndSaveToDB(MyClasses.NewClient.Profit, ClassParams .K,DateTime .Now  , out a);
            if (a)
            {
                MessageBox.Show("Кредит одобрен!");
                MyMainForm.f = new frmButtons();
            }
            else MessageBox.Show("В кредите отказано!\nМаксимальный платеж не может превышать {0}", MyClasses.NewClient.MaxPay.ToString ());
        }

        // рисовать диаграмму
        private void btnGraph_Click(object sender, EventArgs e)
        {
            // данные кинул
            frmDrawDiagram x = new frmDrawDiagram(MyCredit.ListPayments.ToArray());
            // вывел
            x.ShowDialog();
        }

        
        
    }
}
