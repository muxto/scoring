using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Scoring
{

    // на этой форме добавляются и редактируются кредиты
    public partial class frmCreditEditor : Form
    {
        // сам кредит
        ClassCredit MyCredit;
        // ИД файла кредита
        string FileID = "";

        //конструктор - создание
        public frmCreditEditor()
        {
            InitializeComponent();
            MyCredit = new ClassCredit();

            this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };

        }

        //конструктор - изменение
        public frmCreditEditor(ClassCredit _MyCredit, string _FileID) : this()
        {
            MyCredit = _MyCredit;
            WriteCredit();
            FileID = _FileID;

            txtName.Text = MyCredit.Name;
            txtMaxSum.Text = MyCredit.MaxSum.ToString();
            numMaxMonth.Value = MyCredit.maxMonth;
            numMinMonth.Value = MyCredit.minMonth;
        }

        // забивает из листа ответы на форму
        void WriteCredit()
        {
            lstSumPercent.Items.Clear();

            foreach (var i in MyCredit.ListSumPercent)
            {
                List <string> x = new List<string> ();
                x.Add (i.Percent.ToString ());
                x.Add (i.maxSum.ToString ());

                lstSumPercent.Items.Add (new ListViewItem (x.ToArray ()));
            }
            lstSumPercent.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );
        }

        // добавить процентную ставку
        private void btn_AddNewSumPercent_Click(object sender, EventArgs e)
        {
            MyCredit.ListSumPercent.Add(new ClassSumPercent(int.Parse (txtSum.Text ), double .Parse(txtPercent .Text )));
            WriteCredit();
        }



        // сохранить процентную ставку
        private void btnSaveSumPercent_Click(object sender, EventArgs e)
        {
            if (lstSumPercent.SelectedIndices.Count != 0)
            {
                var n = lstSumPercent.SelectedIndices[0];
                MyCredit.ListSumPercent[n].Percent = double.Parse (txtPercent .Text );
                MyCredit.ListSumPercent[n].maxSum = int.Parse (txtSum.Text );
            }
            WriteCredit();
        }

        // изменение
        void LstSumPercentSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSumPercent.SelectedIndices.Count != 0)
            {
                var n = lstSumPercent.SelectedIndices[0];
                txtPercent .Text  = MyCredit.ListSumPercent[n].Percent.ToString ();
                txtSum .Text  = MyCredit.ListSumPercent[n].maxSum.ToString () ;

            }

        }

        // поднять запись вверх
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstSumPercent.SelectedIndices.Count != 0)
            {
                var n = lstSumPercent.SelectedIndices[0];
                if (n == 0)
                    return ;
                MyCredit.ListSumPercent.Insert(n - 1, MyCredit.ListSumPercent[n]);
                MyCredit.ListSumPercent.RemoveAt(n + 1);
                WriteCredit();
                lstSumPercent.Focus ();
                lstSumPercent.Items[n-1].Selected = true;
                lstSumPercent.Items [n - 1].Focused = true ;
                lstSumPercent .TopItem = lstSumPercent.Items [n - 1];
            }
        }

        // опустить вниз
        void BtnDownClick(object sender, EventArgs e)
        {

            if (lstSumPercent.SelectedIndices.Count != 0)
            {

                var n = lstSumPercent.SelectedIndices[0];
                if (n == lstSumPercent.Items.Count-1)
                    return ;
                MyCredit.ListSumPercent.Insert(n, MyCredit.ListSumPercent[n + 1]);
                MyCredit.ListSumPercent.RemoveAt(n + 2);
                WriteCredit();
                lstSumPercent.Focus ();
                lstSumPercent.Items[n + 1].Selected = true;
                lstSumPercent.Items [n + 1].Focused = true ;
                lstSumPercent .TopItem = lstSumPercent.Items [n + 1];
            }
        }

        // удалить процентную ставку
        private void btn_DelSumPercent_Click(object sender, EventArgs e)
        {
            if (lstSumPercent.SelectedIndices.Count != 0)
            {
                var n = lstSumPercent.SelectedIndices[0];
                MyCredit.ListSumPercent.RemoveAt(n);
                lstSumPercent.Items.RemoveAt(n);
            }

        }

        // очистить процентные ставки
        private void btnClearSumPercent_Click(object sender, EventArgs e)
        {
            MyCredit.ListSumPercent.Clear();
            WriteCredit();
        }

        // сохранить кредит
        private void btnSaveCredit_Click(object sender, EventArgs e)
        {
            string strSQL;
            string strOut;


            MyCredit.Name = txtName.Text;
            MyCredit.MaxSum = int.Parse(txtMaxSum.Text);
            MyCredit.maxMonth = (int)numMaxMonth.Value;
            MyCredit.minMonth = (int)numMinMonth.Value;

            if (FileID == "")
            {
                FileID = Guid.NewGuid().ToString();

                // сохраняем в поток
                Stream FileStream = new MemoryStream();
                // сам сериализатор
                BinaryFormatter serializer = new BinaryFormatter();

                // сериализуем экземпляр MySubject в поток FileStream
                serializer.Serialize(FileStream, MyCredit);

                // добавление файла
                strSQL = "INSERT INTO tbFiles  (FileType, FileID,  Name, Date, FileBinary) " +
                         "values ('Кредит', '" + FileID + "','" + MyCredit.Name + "','" + DateTime.Today + "', @FileBinary);";


                // переводим поток в байты
                byte[] byteArray = new byte[FileStream.Length];
                FileStream.Position = 0;
                FileStream.Read(byteArray, 0, (int)FileStream.Length);

                // добавляем
                MyClasses.MySQL.AddFileToDB(strSQL, byteArray, out strOut);

                FileStream.Close();
            }
            else
            {
                // сохраняем в поток
                Stream FileStream = new MemoryStream();
                // сам сериализатор
                BinaryFormatter serializer = new BinaryFormatter();

                // сериализуем экземпляр MySubject в поток FileStream
                serializer.Serialize(FileStream, MyCredit);

                // добавление файла
                strSQL = "UPDATE tbFiles  SET Date = '" + DateTime.Today +
                         "', Name = '" + MyCredit.Name + "', FileBinary = @FileBinary  WHERE FileID = '" + FileID + "';";


                // переводим поток в байты
                byte[] byteArray = new byte[FileStream.Length];
                FileStream.Position = 0;
                FileStream.Read(byteArray, 0, (int)FileStream.Length);

                // добавляем
                MyClasses.MySQL.AddFileToDB(strSQL, byteArray, out strOut);

                FileStream.Close();

            }

            MyMainForm.State = strOut;
            this.Close ();

        }

        // макс сумма
        private void txtMaxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;

        }

        // сумма процентной ставки
        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        // сумма процентной ставки
        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSum.Text) > int.Parse(txtMaxSum.Text)) txtSum.Text = txtMaxSum.Text;
            }
            catch { }
        }

        // значение процента
        private void txtPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 44))
                e.Handled = true;
        }


















    }
}
