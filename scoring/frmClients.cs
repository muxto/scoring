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
    // на этой форме выводятся все заявки
    // основной ид - ID_Client
    public partial class frmClients : Form
    {
        // массив ИД
        string[] ArrayID;

        // ИД заявки по клиенту
        string ThisRequestID;

        // конструктор
        public frmClients()
        {
            InitializeComponent();
            lblClientsCount.Text = ClassRequest.GetCountOfRequests().ToString();
            AddQuestions();


            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };



        }

        // конструктор - вывод конкретного клиента
        public frmClients(string _ClientID) : this ()
        {
            // показать клиента
            ShowClientByID(_ClientID);
        }

        // добавление вопросов
        void AddQuestions()
        {
            cmbCategory.Items.Clear();
            // считываем
            string strSQL = "SELECT distinct Question FROM tbClientForm order by Question ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                // выводим построчно
                cmbCategory.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
        }

        // поиск по вопросу
        void FindByQuestion(string Question)
        {
            lstFound . Items.Clear();
            // считываем
            string strSQL = "SELECT ID_Client, Answer FROM tbClientForm where Question = '"+Question +"' order by Answer ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            ArrayID = new string[ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ArrayID [i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                // выводим построчно
                lstFound . Items.Add(ds.Tables[0].Rows[i].ItemArray[1].ToString());
            }
        }

        // поиск по ответу
        void FindByAnswer(string Answer)
        {
            lstFound . Items.Clear();
            // считываем
            string strSQL = "SELECT ID_Client, Answer FROM tbClientForm where Answer like '%"+Answer  +"%' order by Answer ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            ArrayID = new string[ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ArrayID [i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                // выводим построчно
                lstFound . Items.Add(ds.Tables[0].Rows[i].ItemArray[1].ToString());
            }
        }

        // показать клиента по ИД клиента
        void ShowClientByID(string _ID_Client)
        {
            lstClient.Items.Clear();
            lstRequest.Items.Clear();

            // считываем
            string strSQL = "SELECT Question, Answer   FROM tbClientForm where ID_Client = '" +_ID_Client  + "' ;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            
            List <string> l = new List<string> ();
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                // выводим анкету
                l.Add (ds.Tables[0].Rows[i].ItemArray[0].ToString());
                l.Add (ds.Tables[0].Rows[i].ItemArray[1].ToString());

                lstClient.Items.Add (new ListViewItem (l.ToArray ()));
                l.Clear ();

            }

            lstClient.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );

            string ID_Request = ClassRequest.GetIDRequestByIDClient(_ID_Client);
            // выводим заявку
            ClassRequestTitle x = ClassRequest.GetRequestByIDRequest(ID_Request );


            
            l.Add ("Сумма кредита");
            l.Add (x.Credit_Sum.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Процент");
            l.Add (x.Credit_Percent.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Период кредита, мес.");
            l.Add (x.Credit_Period.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Статус");
            l.Add (x.Request_Status.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();
            
            lstRequest.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );

            if (x.Request_Status == "Одобрено")
            {
                // включаем кнопку
                btnContracts.Enabled = true;
                ThisRequestID  = ID_Request ;
            }

        }

        // выбор категории
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox x = (ComboBox)sender;
            // ищем по вопросу
            FindByQuestion(x.SelectedItem.ToString());
        }

        // выбор среди найденных
        private void lstFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFound.SelectedIndex != -1)
            {
                btnContracts.Enabled = false;
                // показать клиента по ИД
                ShowClientByID(ArrayID[lstFound.SelectedIndex]);
            }
        }



        // показать договор этого клиента
        private void btnContracts_Click(object sender, EventArgs e)
        {
        	this.Close ();
            MyMainForm.f = new frmContracts(ThisRequestID );
        }

        // найти по ответу
        private void btnFindByAnswer_Click(object sender, EventArgs e)
        {
            FindByAnswer(txtAnswer.Text);
        }










    }
}
