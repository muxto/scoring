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
    // форма статистики
    // пересчитывает хороших/плохих клиентов
    // выводит табличку
    public partial class frmStat : Form
    {
        // ответы
        string[] Answers;

        // конструктор
        public frmStat()
        {
            InitializeComponent();
            // получить вопросы
            GetQuestions();
        }

        // получить вопросы
        public void GetQuestions()
        {
            string strSQL = "select distinct tbClientForm .Question from  tbClientForm  ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            Answers = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Answers[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                checkedListBox1.Items.Add(Answers [i],false );
            }
        }

        // пересчитать статус клиента на опр дату
        void CalculateStatToDate(DateTime _ToDate)
        {
            // сначала получаем число неплатежей на дату
            string strSQL = "select distinct tbPayments .N_Account , COUNT (tbPayments .Payment) from tbPayments, tbContract  where tbPayments .Payment = 'False' and tbContract .N_Account = tbPayments .N_Account and CONVERT(date, tbPayments.Date, 104) <  CONVERT(DATE, '" + _ToDate.ToShortDateString() + "', 104) group by tbPayments .Payment, tbPayments .N_Account;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ID_Request;
                string ID_Client;
                string N_Account = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                ID_Request = ClassContracts.GetIDRequestByNAccount(N_Account);
                ID_Client = ClassRequest.GetIDClientByIDRequest(ID_Request);

                strSQL = "update tbclient set Delay = '" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "' where id_client = '" + ID_Client + "';";
                MyClasses.MySQL.MakeSQL(strSQL);
            }

            // затем находим неплательщиков
            strSQL = "select ID_Client, Delay from tbClient where Delay >0 ;";
            // запрос выдает столбец
            ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ID_Client = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                int Delay = int.Parse(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                // сравниваем число задолженностей с числом в параметрах
                if (Delay >= ClassParams.DelaysForBad)
                    strSQL = "update tbclient set Status = 'Плохой' where id_client = '" + ID_Client + "';";
                MyClasses.MySQL.MakeSQL(strSQL);
            }
        }


        // вывести табличку
        public void CreateTable()
        {
            listView1.Items.Clear();
            foreach (var i in checkedListBox1.CheckedItems)
            {
                string strSQL = "declare @Q varchar(50)  set @q = '" + i + "' select f.Question , f.Answer , isnull (count (c .ID_Client ) ,0), isnull (count (d .ID_Client ) ,0) from tbClientForm f left outer join tbClient c on (f.ID_Client = c.ID_Client  and c.Status = 'хороший') left outer join tbClient d on (f.ID_Client = d.ID_Client  and d.Status = 'плохой') group by f.Question , f.Answer having  f.Question = @Q ";
                // запрос выдает столбец
                DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {

                    string[] ff = new string[6];
                    ff[0] = ds.Tables[0].Rows[j].ItemArray[0].ToString();
                    ff[1] = ds.Tables[0].Rows[j].ItemArray[1].ToString();
                    // хорошие клиенты
                    int goods = int.Parse(ds.Tables[0].Rows[j].ItemArray[2].ToString());
                    // плохие клиенты
                    int bads = int.Parse(ds.Tables[0].Rows[j].ItemArray[3].ToString());

                    ff[2] = goods.ToString();
                    ff[3] = bads.ToString();
                    ff[4] = (goods + bads).ToString();
                    // соотношение хорошие/плохие
                    double Per;
                    if ((goods + bads) > 0) 
                        Per = (double )bads / (double)(goods + bads)*100;
                    else Per = 0;
                    
                    ff[5] = Per.ToString();

                    listView1.Items.Add(new ListViewItem(ff));

                }
            }
        }

        
        

        private void btnStat_Click(object sender, EventArgs e)
        {
            DateTime ToDate = dtPick.Value;
            CalculateStatToDate(ToDate);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            int[] a;
            // считываем 
            string strSQL = "SELECT Total_Mark, Max_Sum, Min_Sum FROM tbClient;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            a = new int[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // сумма баллов этого клиента
                int total = int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                // ему отказано, значит 0
                if (total == -10)
                    total = 0;
                // находим максум за анкету
                int max = int.Parse(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                // находим минум за анкету
                int min = int.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                // считаем коэф
                a[i] = 100 * total / (max - min);
            }

            // разбиваем все данные на 20 столбиков
            int mini = 100;
            int maxi = 0;

            foreach (var i in a)
            {
                if (mini > i) mini = i;
                if (maxi < i) maxi = i;
            }

            int[] count = new int[20];

            int dx = (maxi - mini) / 20;

            // формируем данные про 20 столбиков
            for (int i = 0; i < 20; i++)
            {
                foreach (var j in a)
                    if ((j >= i * dx) && (j <= (i + 1) * dx))
                        count[i]++;
            }
            // выводим табличку
            new frmDrawDiagram(count, dx).ShowDialog();


        }

        // вывод таблички
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            CreateTable();
        }


    }
}
