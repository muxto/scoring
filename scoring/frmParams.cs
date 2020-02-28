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

    // форма с параметрами скоринга
    public partial class frmParams : Form
    {
        // конструктор
        public frmParams()
        {
            InitializeComponent();
            // читаем с БД
           ClassParams.ReadFromDB();
            // заполняем форму
           txtK.Text = ClassParams.K.ToString();
           txtLowPercent.Text = ClassParams.LowPercent.ToString();
           txtHighPercent.Text = ClassParams.HighPercent.ToString();
           txtDelayForBad.Text = ClassParams.DelaysForBad.ToString();
           
           this.Activated += (sender, e) =>
            {
                MyMainForm.ReShow ();
            };
        }

     
        // сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassParams.K = double.Parse(txtK.Text);
            ClassParams.LowPercent = double.Parse(txtLowPercent.Text);
            ClassParams.HighPercent = double.Parse(txtHighPercent.Text);
            ClassParams.DelaysForBad = int.Parse(txtDelayForBad.Text);

            ClassParams.SaveToDB();
            this.Close ();
        }



       

    

   
    }
}
