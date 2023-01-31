using System;
using System.Windows.Forms;

namespace PZ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        public void Form1_DoubleClick(object sender, EventArgs e)
        {
            double v;
            double b;
            if (textBox3.Text == "" && textBox4.Text == "")
            {
                v = 0;
                b = 0;
            }
            else if (textBox3.Text != "" && textBox4.Text == "")
            {
                v = Convert.ToDouble(textBox3.Text);
                b = 0;
            }
            else if (textBox3.Text == "" && textBox4.Text != "")
            {
                v = 0;
                b = Convert.ToDouble(textBox4.Text);
            }
            else
            {
                v = Convert.ToDouble(textBox3.Text);
                b = Convert.ToDouble(textBox4.Text);
            }
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double F = Math.Sin((v * x) / v) * x + Math.Sqrt(Math.Abs(Math.Pow(b, 3))) - Math.Abs(Math.Pow(x,2) + Math.Cos(y));
            textBox5.Text = Math.Round(F, 4).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
