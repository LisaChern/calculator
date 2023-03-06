using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            Button b = (Button )sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text==","){
                return;
            }
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 == 0) 
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        String action;
        String number1;
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            else
            {
                Button b = (Button)sender;
                action = b.Text;
                number1 = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (action == "+")
                textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
            if (action == "-")
                textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "*")
                textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
            if (action == "/")
                textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "%")
                textBox1.Text = (Convert.ToDouble(number1) / 100 * Convert.ToDouble(textBox1.Text)).ToString();

            action = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1/ Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action = "%";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }
    }
    }
