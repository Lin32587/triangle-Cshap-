using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle_Cshap
{
    public partial class TgFrm : Form
    {
        public TgFrm()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ResultText.Text = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text))
            {
                this.ResultText.Text = "请输入三个整数！";
            }
            else
            {
                int a = 0, b = 0, c = 0;
                a = int.Parse(textBox1.Text.Trim());
                b = int.Parse(textBox2.Text.Trim());
                c = int.Parse(textBox3.Text.Trim());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    this.ResultText.Text = "请输入大于零的整数！";
                }
                else
                {
                    if((a + b > c) && (a + c > b) && (b + c > a))
                    {
                        if(a==b||a==c||b==c)
                        {
                            if (a==b&&b==c&&a==c)
                            {
                                this.ResultText.Text = "这是一个等边三角形！";
                            }
                            else
                            {
                                this.ResultText.Text = "这是一个等腰三角形！";
                            }
                            
                        }
                        else if (a*a==b*b+c*c||b*b==a*a+c*c||c*c==a*a+b*b)
                        {
                            this.ResultText.Text = "这是直角三角形！";
                        }
                        else
                        {
                            this.ResultText.Text = "这是不等边三角形！";
                        }
                    }
                    else
                    {
                        this.ResultText.Text = "Please！这tm不是三角形！";
                    }
                }

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            this.ResultText.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.pictureBox3.Visible = true;
        }
    }
}
