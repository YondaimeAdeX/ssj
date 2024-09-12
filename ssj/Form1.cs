using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            label1.Text = "Ahmet";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            label1.Text = "Erkul";
            label1.ForeColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            label1.Text = "Bilişim";
            label1.ForeColor = Color.LimeGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label4.Text = "Merhaba " + textBox3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label8.Text = textBox4.Text + " " + textBox5.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
