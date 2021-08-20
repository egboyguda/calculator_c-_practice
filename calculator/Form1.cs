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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.main_window.ResetText();
            this.num_label.ResetText();
            this.operato1_label.ResetText();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.operato1_label.Text = "+";
            this.num_label.Text += this.main_window.Text + "+";
            this.main_window.ResetText();
            //this.operator_label.Text = this.main_num_label.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.operato1_label.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operato1_label.Text = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.operato1_label.Text = "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_window.Text += "7";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num_label_Click(object sender, EventArgs e)
        {

        }
    }
}
