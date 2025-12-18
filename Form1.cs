using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator__
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool sureopertion = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender ;
            if (textBox1.Text == "0" || sureopertion == true) { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + but.Text ;
            sureopertion = false;
        }

        private void div_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text ;
            result = double.Parse(textBox1.Text) ;
            sureopertion=true ;


        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch(operation)
            {

                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString() ;
                    break;


                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
