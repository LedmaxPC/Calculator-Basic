using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp4
{
    public partial class Form1 : Form
    {
        bool click;
        bool sqrtOperation = false;

        char operand;
        double a;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "1";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "2";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "3";
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "4";
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "5";
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "6";
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "7";
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "8";
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "9";
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "0";
        }

        
        private void button11_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }

       
        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";

            click = false;
            sqrtOperation = false;
            operand = '\0';
            a = 0;
        }

        
        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text =
                    richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        
        private void button16_Click(object sender, EventArgs e)
        {
            
            if (sqrtOperation)
            {
                if (a < 0)
                {
                    richTextBox1.Text = "Invalid value";
                }
                else
                {
                    richTextBox1.Text = Math.Sqrt(a).ToString();
                }

                sqrtOperation = false;
                click = true;

                return;
            }

            
            switch (operand)
            {
                case '+':
                    richTextBox1.Text =
                        (a + Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '-':
                    richTextBox1.Text =
                        (a - Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '*':
                    richTextBox1.Text =
                        (a * Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '/':
                    if (Convert.ToDouble(richTextBox1.Text) == 0)
                    {
                        richTextBox1.Text = "Divide by zero error";
                    }
                    else
                    {
                        richTextBox1.Text =
                            (a / Convert.ToDouble(richTextBox1.Text)).ToString();
                    }
                    break;
            }

            click = true;
        }

        
        private void button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '+';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
            }
        }

        
        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '-';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
            }
        }

       
        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '*';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
            }
        }

        
        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '/';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
            }
        }

        
        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                a = Convert.ToDouble(richTextBox1.Text);
                sqrtOperation = true;
                click = true;
            }
        }

        
        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                a = Convert.ToDouble(richTextBox1.Text);
                sqrtOperation = true;
                click = true;
            }
        }

        
        private void button21_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                a = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text = (a * a).ToString();
                click = true;
            }
        }
    }
}
