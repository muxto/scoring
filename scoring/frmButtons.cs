using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Scoring
{
    // эта форма просто хранит кнопки
    public partial class frmButtons : Form
    {
        public frmButtons()
        {
            InitializeComponent();



           // MyMainForm.MainForm.MdiChildActivate 
                this.Activated 
                += (sender, e) =>
            {
                FormOpen ();
                MyMainForm.ReShow ();
            };

        }

        void FormOpen()
        {
            // количество заявок
            lblClientsCount.Text = ClassRequest.GetCountOfRequests().ToString();
            // количество договоров
            lblContractsCount.Text = ClassContracts.GetCountOfContracts().ToString();
        }

        // анкеты
        private void btnForms_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmForms();
        }

        // кредитный калькулятор
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmCalculate(true);
        }

        // клиенты
        private void btnClients_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmClients();
        }

        // договора
        private void btnContracts_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmContracts();
        }

        // редактор кредитов
        private void btnCredits_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmCredits();
        }

        // статистика
        private void btnStat_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmStat();
        }

        // параметры
        private void btnParams_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmParams();
        }


        void GenerateNewClient()
        {

            try
            {
                // что получит кредит
                bool a = false;
                Random r = new Random();

                // массив с ИД файлов анкет в БД
                string[] ArrayID;

                // считываем
                string strSQL = "SELECT FileID from tbFiles where filetype= 'Кредит';";
                // запрос выдает столбец
                DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
                // иницализуем массив ИД
                ArrayID = new string[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    // ИД
                    ArrayID[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();


                // новый кредит выбираем случайно
                ClassCredit MyCredit = ClassCredit.ReadFromDB(ArrayID[r.Next(0, ArrayID.Length)]);

                // считываем
                strSQL = "SELECT FileID from tbFiles where filetype= 'Анкета';";
                // запрос выдает столбец
                ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
                // иницализуем массив ИД
                ArrayID = new string[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    // ИД
                    ArrayID[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();

                // анкета случайная
                ClassForm MyForm = ClassForm.ReadFromDB(ArrayID[r.Next(0, ArrayID.Length)]);

                // клиент
                ClassClient NewClient = new ClassClient();

                // генерим клиента по анкете
                NewClient.GenerateClient(MyForm);
                // обрабатываем ответы
                NewClient.ProcessAnswers();

                // нет ответов с уточнениями?
                if (NewClient.CountOfQuestionsMore == 0)
                {
                    // сумма кредита
                    MyCredit.CreditSum = r.Next(1000, MyCredit.MaxSum);
                    // месяцы
                    int month = r.Next(MyCredit.minMonth, MyCredit.maxMonth);

                    // аннуитетные или дифференцированные платежи?
                    // всемогущий рандом поможет определить
                    if (r.NextDouble() < 0.5)
                        MyCredit.CalculateCreditAnnuity(month, Convert.ToInt32(MyCredit.CreditSum));
                    else
                        MyCredit.CalculateCreditDifferent(month, Convert.ToInt32(MyCredit.CreditSum));

                    // привязываем кредит к человеку
                    NewClient.MyCredit = MyCredit;

                    // генерим год
                    string g = "200" + r.Next(0, 10).ToString() + "." + r.Next(1, 13).ToString() + ".1";
                    // требуем кредит!

                    NewClient.GimmeCreditAndSaveToDB(NewClient.Profit, ClassParams.K, DateTime.Parse(g), out a);
                }
                else
                {
                    MyMainForm.State = "Невозможно сгенерировать ответ с уточненем.";
                }
            }
            catch
            {
            	MyMainForm.State = "Невозможно сгенерировать заявку.";

            }



        }

        async Task GenerateNewClientAsync ()
        {
            Action act = () =>
            {
                GenerateNewClient ();
            };

            await Task .Run (act);

            FormOpen ();
        }


        // генерим новую заявку
        private async void btnGenerateClient_Click(object sender, EventArgs e)
        {
            await GenerateNewClientAsync  ();
//            this.FormOpen ();
        }

        // генерить 200 человек
        // можно больше
        private async void btnGenerateMore_Click(object sender, EventArgs e)
        {
            // что тут непонятно?
            for (int i = 0; i < 200; i++)
            {
                await GenerateNewClientAsync  ();
//                this.FormOpen ();
            }
        }

        // генерим платежи
        private void btnGeneratePays_Click(object sender, EventArgs e)
        {
            // там все понятно кроме вероятности неплатежа
            Random r = new Random();
            List<string> Accounts = new List<string>();
            string strSQL = "SELECT distinct N_Account FROM tbPayments ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                Accounts.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());


            foreach (var i in Accounts)
            {
                var x = ClassPayment.GetPaymentsByNAccount(i);
                foreach (var j in x)
                {
                    // в общем тут вероятность неплатежа 0.05
                    if (r.NextDouble() < 0.05) ClassPayment.ToPayChange(j.N_Account, j.Date, false);
                    else ClassPayment.ToPayChange(j.N_Account, j.Date, true);
                }

            }
        }



















    }
}
