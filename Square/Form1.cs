using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area;
            // area = double.Parse(textBox2.Text);

            bool isNUmber;
            isNUmber = double.TryParse(textBox2.Text, out area);

            if (isNUmber == true) {
                double side;
                side = Math.Sqrt(area);
                textBox1.Text = side.ToString();
            }
            else
            {
                textBox1.Text = " Just Nu ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double side;
            // area = double.Parse(textBox1.Text);

            bool isNUmber;
            isNUmber = double.TryParse(textBox1.Text, out side);

            if (isNUmber == true)
            {
                double area;
                area = side * side;
                textBox2.Text = area.ToString();
            }
            
        }
    }
}
