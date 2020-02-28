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
    // форма
    // основной ид - ID_Request
    public partial class frmPayments : Form
    {
        // лист платежей
        List<ClassPaymentTitle> Pays;

        // ИД заявки
        string ID_Request;

        // конструктор
        public frmPayments(string _ID_Request)
        {
            InitializeComponent();

            lblPaymentsCountInDB.Text  = PaymentsCountInDB();
            ID_Request = _ID_Request;
            // показать платежи по ИД заявки
            ShowPaymentsByID();
            ShowContractByID(_ID_Request);

        }


        string PaymentsCountInDB()
        {
            // считываем
            string strSQL = "SELECT COUNT (N_Transaction) FROM tbPayments;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }




        // показать платежи по ИД заявки
        void ShowPaymentsByID()
        {
            lstPayments .Items.Clear();
            string N_Account = ClassPayment.GetNAccountByNContract(ID_Request );
            // считываем

            Pays =  ClassPayment.GetPaymentsByNAccount(N_Account);
            foreach (var i in Pays)
            {

                List <string> x = new List<string> ();
                x.Add (i.N_Account.ToString ());
                x.Add (i.Date.ToShortDateString());

                string paym = i.Payment ? "Оплачено" : "Неоплачено";

                x.Add (paym);
                x.Add (i.N_Transaction.ToString ());

                lstPayments.Items.Add (new ListViewItem (x.ToArray ()));

            }

            lstPayments.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );
            // число платежей
            lblCountPaymentsInContract.Text = Pays.Count.ToString();
        }


        // показать договор по ИД заявки
        void ShowContractByID(string _ID_Request)
        {
            lstContracts.Items.Clear();

            ClassContractTitle Cont = ClassContracts.GetContractByIDRequest(_ID_Request);

            List<string> l = new List<string> ();

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

        }

        // показать договор
        private void btnContract_Click(object sender, EventArgs e)
        {
        	this.Close ();
            MyMainForm.f = new frmContracts(ID_Request);
        }



        // выбор платежа
        private void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPayments.SelectedIndices.Count != 0)
            {
                var n = lstPayments.SelectedIndices[0];
                if (Pays[n].Payment)
                    cmbPay.SelectedItem = "Оплачено";
                else
                    cmbPay.SelectedItem = "Неоплачено";
            }
        }

        // сохранить изменение платежа
        private void btnSavePayment_Click(object sender, EventArgs e)
        {
             if (lstPayments.SelectedIndices.Count != 0)
            {
                var n = lstPayments.SelectedIndices[0];

                bool Pay;
                if (cmbPay.SelectedItem.ToString() == "Оплачено") Pay = true;
                else Pay = false;
                ClassPayment.ToPayChange(Pays[n].N_Account, Pays[n].Date, Pay);
                ShowPaymentsByID();
            }
        }




    }
}
