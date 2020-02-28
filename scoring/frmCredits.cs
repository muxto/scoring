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
    // отображаются кредиты для редактирования
    public partial class frmCredits : Form
    {
        // список ИД кредитов
        string [] ArrayID;

        // конструктор
        public frmCredits()
        {
            InitializeComponent();
            
            this.Activated += (sender, e) =>
            {
            	ReadFromDB ();
            	MyMainForm.ReShow ();
            };
            
            
        }

        // читать заголовки кредитов с БД
        void ReadFromDB()
        {
            lstCredits . Items.Clear();
            // считываем
            string strSQL = "SELECT FileID, Name, Date FROM tbFiles where filetype= 'Кредит' ORDER BY Date ASC;";
            // запрос выдает столбец
            DataSet ds = MyClasses.MySQL.MakeSQLReturnDataSet(strSQL);

            ArrayID = new string [ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ArrayID[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                DateTime DateCredit = (DateTime)ds.Tables[0].Rows[i].ItemArray[2];

                List <string> x = new List<string> ();
                x.Add (DateCredit.ToShortDateString());
                x.Add (ds.Tables[0].Rows[i].ItemArray[1].ToString ());

                lstCredits.Items.Add (new ListViewItem (x.ToArray ()));

            }

            lstCredits.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize );

        }

        // кнопа Новый кредит
        private void btnCreateCredit_Click(object sender, EventArgs e)
        {
            MyMainForm.f = new frmCreditEditor();
        }

        // кнопа Редактировать кредит
        private void btnOpenCredit_Click(object sender, EventArgs e)
        {
            if (lstCredits.SelectedIndices.Count != 0)
            {
            	var n = lstCredits.SelectedIndices[0];
                byte[] NewCreditByte = MyClasses.MySQL.ReadFileFromDB(ArrayID[n], "tbFiles");

                Stream FileStream = new MemoryStream(NewCreditByte);
                // сам десериализатор
                BinaryFormatter deserializer = new BinaryFormatter();

                // десереализуем поток в объект
                object x = deserializer.Deserialize(FileStream);
                //object x = deserializer.UnsafeDeserialize (FileStream, null);
                // явное преобразование в класс
                ClassCredit _MyClass = (ClassCredit)x;
                FileStream.Close();
                MyMainForm.f = new frmCreditEditor  (_MyClass, ArrayID[n]);
            }
        }

        // кнопа Удаление кредита
        private void btnDelCredit_Click(object sender, EventArgs e)
        {
            if (lstCredits.SelectedIndices.Count != 0)
            {
            	var n = lstCredits.SelectedIndices[0];
                // удаляем в БД
                string strSQL = "delete FROM tbFiles where FileID = '" + ArrayID [n]+ "';";
                // выполняем
                MyClasses.MySQL.MakeSQL(strSQL);
                // удаляем в лст
                lstCredits.Items.RemoveAt(n);
            }
        }
    }
}
