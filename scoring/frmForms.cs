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
    // форма с анкетами
    // добавить, изменить, удалить, пройти
    public partial class frmForms : Form
    {
        // анкеты
        List<ClassFormTitle> Forms;

        // конструктор
        public frmForms()
        {
            InitializeComponent();


            //MyMainForm.MainForm.MdiChildActivate 
            this.Activated 
            += (sender, e) =>
            {
                // читаем с БД список анкет
                ReadFromDB();
                MyMainForm.ReShow ();
            };

        }

        // читаем с БД список анкет
        void ReadFromDB()
        {
            // считываем
            Forms =  ClassForm.AllFormsInDB();

            var i = Forms[0];

            DateTime dt = DateTime .Parse ( i.Date);

            lblCountQuestions.Text = i.Questions.ToString ();
            lblDateOfChange.Text =  dt.ToShortDateString();
        }

        // открыть анкету
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            // читаем из БД анкету и загружаем ее в редактор
            MyMainForm.f = new frmFormEditor(ClassForm.ReadFromDB(Forms[0].FileID), Forms[0].FileID);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MyClasses .NewClient  = new ClassClient();
            MyClasses.NewClient.MyForm = ClassForm.ReadFromDB( Forms [0].FileID);
            // читаем из БД анкету и проходим ее
            MyMainForm.f = new frmFormGenerate();
        }

       

    }
}