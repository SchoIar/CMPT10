using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double C;
            double Asqr;
            double Bsqr;
            double Csqr;
       

            bool isNumberA;
            isNumberA = double.TryParse(textBox1.Text, out A);
            if (isNumberA == true)
            {
                bool isNumberB;
                isNumberB = double.TryParse(textBox2.Text, out B);
                if (isNumberB == true)

                {
                    Asqr = A * A;

                    Bsqr = B * B;

                    Csqr = Asqr + Bsqr;

                    C = Math.Sqrt(Csqr);
                    textBox3.Text = C.ToString();


                }
                else
                    textBox3.Text = "ERROR";
            }
            else
                textBox3.Text = "ERROR";

        }
    }
}
