using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiSuanQi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str, opp, opp1;
        double num1, num2, result;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number(sender,e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number(sender,e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number(sender,e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            operation(sender, e);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operation(sender, e);
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            operational(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operational(sender,e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operational(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            operational(sender, e);
        }

        private void number(object sender,EventArgs e)
        {
            Button b = (Button)(sender);
            str = b.Text;
            if (textBox1.Text == "0")
            {
                textBox1.Text = str;
            }
            else
                textBox1.Text = textBox1.Text + str;
                
        }

        private void operational(object sender,EventArgs e)
        {
            Button b = (Button)(sender);
            if(b.Text == "+")
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opp = "+";
                opp1 = "";
            }
            else if (b.Text == "-")
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opp = "-";
                opp1 = "";
            }
            else if(b.Text == "*")
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opp = "*";
                opp1 = "";
            }
            else if (b.Text == "/")
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opp = "/";
                opp1 = "";
            }
            else if (b.Text == "=")
            {
                if(opp1 != "=")
                {
                    num2 = double.Parse(textBox1.Text);
                }
                if(opp == "+")
                {
                    num1 = num1 + num2;
                    textBox1.Text = "" + num1.ToString();
                }
                else if (opp == "-")
                {
                    num1 = num1 - num2;
                    textBox1.Text = "" + num1.ToString();
                }
                else if (opp == "*")
                {
                    num1 = num1 * num2;
                    textBox1.Text = "" + num1.ToString();
                }
                else if (opp == "/")
                {
                    if (num2 == 0)
                    {
                        textBox1.Text = "除数不能为0";
                    }
                    else
                    {
                        num1 = num1 / num2;
                        textBox1.Text = "" + num1.ToString();
                    }
                    opp1 = "=";

                }
            }
        }

        private void operation(object sender,EventArgs e)
        {
            Button b = (Button)(sender);
            if(b.Text == "+/-")
            {
                num1 = double.Parse(textBox1.Text);
                result = num1 * (-1);
                textBox1.Text = result.ToString();
            }
            else if(b.Text == ".")
            {
                str = textBox1.Text;
                int index = str.IndexOf(".");
                if(index == -1)
                {
                    textBox1.Text = str + ".";
                }

            }

            else if (b.Text == "退格")
            {
                if(textBox1.Text != "")
                {
                    str = textBox1.Text;
                    str = str.Substring(0, str.Length - 1);
                    textBox1.Text = str;


                }
            }
            else if (b.Text == "CE")
            {
                textBox1.Text = "0";
            }
            else if (b.Text == "C")
            {
                result = num1 = num2 = 0;
                str = null;
                opp = null;
                textBox1.Text = "0";
            }
            else if(b.Text == "sqrt")
            {
                num1 = double.Parse((string)textBox1.Text);
                result = Math.Sqrt(num1);
                textBox1.Text = result.ToString();

            }
            else if(b.Text == "1/x")
            {
                num1 = double.Parse(textBox1.Text);
                result = 1 / num1;
                textBox1.Text = result.ToString();
            }
            else if (b.Text == "%")
            {
                num1 = double.Parse(textBox1.Text);
                result = num1 / 100;
                textBox1.Text = result.ToString();

            }
            opp1 = ""; 



        }







        private void button1_Click(object sender, EventArgs e)
        {
            number(sender, e);
        }
    }
}
