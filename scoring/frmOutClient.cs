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
    // форма заявки
    // тут клиент выберет кредит, даст заявку
    // а система его одобрит или нет
    public partial class frmOutClient       : Form
    {

        bool CreditStatus = true;

        // конструктор
        public frmOutClient()
        {
            InitializeComponent();
            // вывести в лист данные о клиенте
            WriteToLst();
            
            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }


        // выводим в лист
        void WriteToLst()
        {
            // данные о клиенте которые он только что ввел
            foreach (var i in MyClasses . NewClient.ClientForm)
            {
                List <string> x = new List<string> ();
                x.Add (i.Question);
                x.Add (i.Answer );
                lstClient.Items.Add (new ListViewItem (x.ToArray ()));
            }
            
            lstClient.AutoResizeColumns (ColumnHeaderAutoResizeStyle.ColumnContent);
            
            lblMarkSum.Text = MyClasses.NewClient.MarkSum.ToString();
            lblProfit.Text = MyClasses.NewClient.Profit.ToString();

            var credit = MyClasses.NewClient.StatusCredit;

            lblCreditStatus.Text =  credit ? "Одобрен" : "Отказ";
            lblMonthPay.Text = credit ? MyClasses.NewClient.MaxPay.ToString () : "Нет";
            if (!credit)
                btnNext .Text = "В главное меню";
        }


        // назад
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmFormGenerate  x =  new frmFormGenerate();
            x.WriteControls();
            MyMainForm.f = x;
        }

        // кнопа Далее
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (MyClasses.NewClient.StatusCredit )
                // переход к кредитному калькулятору
                MyMainForm.f = new frmCalculate (false );
            else
                // выход в главное меню
                MyMainForm.MainMenu ();
        }


    }
}

