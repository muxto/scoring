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
    // на этой форме выводятся все договора
    // основной ид - ID_Request
    public partial class frmContracts : Form
    {
        // массив ИД
        string[] ArrayID;
        // категория
        string Category;

        // ИД клиента
        string ThisClientID;
        // ИД заявки
        string ThisRequestID;

        // конструктор
        public frmContracts()
        {
            InitializeComponent();

            lblContractsCount.Text = ClassContracts.GetCountOfContracts().ToString ();

            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }

        // конструктор - вывести заявку
        public frmContracts(string _ID_Request)  : this()
        {
            // вывод заявки
            ShowContractByID(_ID_Request);
            ThisClientID = ClassRequest .GetIDClientByIDRequest ( _ID_Request);
            ThisRequestID = _ID_Request;

            btnClient.Enabled = true ;
            btnPayments.Enabled = true;
        }

        // найти по ответу
        void FindByAnswer(string Answer)
        {
            lstFound . Items.Clear();
            // считываем
            string strSQL = "SELECT ID_Request, " + Category + " FROM tbContract where " + Category + " like '%" + Answer + "%' order by " + Category + " ;";
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

        // показать договор по ИД заявки
        void ShowContractByID(string _ID_Request)
        {
            ThisRequestID = _ID_Request;
            lstRequest.Items.Clear();
            lstContracts.Items.Clear();
            // считываем
            ClassRequestTitle Req = ClassRequest.GetRequestByIDRequest(_ID_Request);

            List<string > l = new List<string> ();
            
            l.Add ("Сумма кредита");
            l.Add (Req.Credit_Sum.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Процент");
            l.Add (Req.Credit_Percent.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Период кредита, мес.");
            l.Add (Req.Credit_Period.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Статус");
            l.Add (Req.Request_Status.ToString ());
            lstRequest.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();
            
            lstRequest.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );

            ClassContractTitle Cont = ClassContracts.GetContractByIDRequest(_ID_Request);

            // выводим построчно
            
              
            l.Add ("Номер договора");
            l.Add (Cont.N_Contract.ToString ());
            lstContracts.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Номер счета");
            l.Add (Cont.N_Account.ToString ());
            lstContracts.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Начало действия договора");
            l.Add (Cont.Contract_Date_Begin.ToShortDateString ());
            lstContracts.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();

            l.Add ("Окончание действия договора");
            l.Add (Cont.Contract_Date_End.ToShortDateString ());
            lstContracts.Items.Add (new ListViewItem (l.ToArray ()));
            l.Clear ();
            
            lstContracts.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );
            
            
            ThisClientID = ClassRequest.GetIDClientByIDRequest(_ID_Request);

        }

        // выбор категории
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox x = (ComboBox)sender;

            switch (x.SelectedItem.ToString())
            {
            case "Номер договора":
                Category = "N_Contract";
                break;
            case "Номер счета":
                Category = "N_Account";
                break;
            case "Дата начала контракта":
                Category = "Contract_Date_Begin";
                break;
            case "Дата окончания контракта":
                Category = "Contract_Date_End";
                break;
            }
            btnClient.Enabled = true;
            btnPayments.Enabled = true;

            lstFound.Items.Clear();
            // считываем
            string strSQL = "SELECT ID_Request, " + Category + " FROM tbContract;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            ArrayID = new string[ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {


                ArrayID[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();

                var str = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                // выводим построчно

                DateTime dt = new DateTime ();
                if (DateTime.TryParse (str, out dt ))
                    lstFound.Items.Add(dt.ToShortDateString ());
                
                else lstFound.Items.Add(str);
            }
        }


        // выбор найденных
        private void lstFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFound.SelectedIndex != -1)
            {
                ShowContractByID(ArrayID[lstFound.SelectedIndex]);
            }
        }



        // кнопа найти ответ
        private void btnFindByAnswer_Click(object sender, EventArgs e)
        {
            FindByAnswer(txtAnswer.Text);
        }

        // кнопа Клиент
        private void btnClient_Click(object sender, EventArgs e)
        {
        	this.Close ();
            MyMainForm.f = new frmClients(ThisClientID);
        }

        // кнопа платежи
        private void btnPayments_Click(object sender, EventArgs e)
        {
        	this.Close ();
            MyMainForm.f = new frmPayments(ThisRequestID);
        }






    }
}