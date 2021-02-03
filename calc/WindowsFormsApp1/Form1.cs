using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double DN, res;
            DN = Convert.ToDouble(textBox1.Text);
                res = -DN;
            textBox1.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text == "0")
            textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double DN1, DN2, res;
            res = 0;
            DN1 = Convert.ToDouble(N1);
            DN2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = DN1 + DN2;
            }
            if (D == "-")
            {
                res = DN1 - DN2;
            }
            if (D == "×")
            {
                res = DN1 * DN2;
            }
            if (D == "÷")
            {
                res = DN1 / DN2;
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double DN, res;
            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(DN);
            textBox1.Text = res.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double DN, res;
            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(DN, 2);
            textBox1.Text = res.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
