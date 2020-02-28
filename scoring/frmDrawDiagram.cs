using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scoring
{
    // класс рисования диаграммы
    public partial class frmDrawDiagram : Form
    {
        // относительные оценки
        int[] Payments;
        
        // есть подписи снизу
        bool HaveLabel;
        // шаг диаграммы
        int dxDiagram ;

        //для заполнения прямоугольников

        // кисточки
        Brush br2 = new SolidBrush(Color.LightBlue);
        Brush br3 = new SolidBrush(Color.Black);
        //шрифт
        Font f1 = new Font("Comic Sans MS", 9, FontStyle.Bold);
        
        Pen Pen_Black = new Pen(Color.Black, 1);
        Pen Pen_Label = new Pen(Color.Black, 1);

        // конструктор
        public frmDrawDiagram(int[] _Payments)
        {
            InitializeComponent();

            Payments = _Payments;
            HaveLabel = false;
            this.pictureBox1.Resize += delegate { pictureBox1.Invalidate(); };
        }

        // конструктор с подписями
        public frmDrawDiagram(int[] _Payments, int  _dx)
        {
            InitializeComponent();

            Payments = _Payments;
            dxDiagram = _dx;
            HaveLabel = true;
            this.pictureBox1.Resize += delegate { pictureBox1.Invalidate(); };
        }


       
        // обработчик рисования
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {   
            /*
            int[] PaymentsDraw = new int[Payments.Length + 2];

            PaymentsDraw[0] = 0;
            PaymentsDraw[PaymentsDraw.Length - 1] = 0;
            for (int i = 1; i < Payments.Length + 1; i++)
            {
                PaymentsDraw[i] = Payments[i - 1];
            }

             */
 
            Graphics gr = e.Graphics;            
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gr.Clear(Color.White);

            //координатная сетка. как давно я ее не делал ^_^
            // слева направо
            for (int i = 0; i < pictureBox1.Width; i += 20)
            {
                gr.DrawLine(new Pen(Color.LightGray), i, 0, i, pictureBox1.Height);
            }
            // снизу вверх
            for (int i = pictureBox1.Height; i >= 0; i -= 20)
            {
                gr.DrawLine(new Pen(Color.LightGray), 0, i, pictureBox1.Width, i);
            }

            // число человеков
            int n = Payments.Length;

            double dx = pictureBox1.Width / (double)(n+1);            
            double dy = pictureBox1.Height / (double)Payments[0] * 0.8;

            Font MyFont = new Font("Comic Sans MS", 9);//шрифт для надписей
            SolidBrush fontbr = new SolidBrush(Color.Black);//цвет надписей                 

            // рисуем 
            for (int i = 0; i < Payments.Length; i++)
            {
                Rectangle rect = new Rectangle(new Point(Convert.ToInt32(i * dx)+20, pictureBox1.Height - Convert.ToInt32(Payments[i] * dy) - 20), new Size(Convert.ToInt32(dx), (Convert.ToInt32(Payments[i] * dy))));
                gr.FillRectangle(br2, rect);
                gr.DrawRectangle(Pen_Black, rect);
                if (Payments[i] != 0)
                    gr.DrawString(Payments[i].ToString(), f1, br3, (float)(i * dx)+20, (float)(pictureBox1.Height - Payments[i] * dy - 40));

                if (HaveLabel )
                    gr.DrawString((dxDiagram * i).ToString (), f1, br3, (float)(i * dx)+20, (float)(pictureBox1.Height - 20));
            }    
        }     
    }
}
