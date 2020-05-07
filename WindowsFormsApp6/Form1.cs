using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Nn.Text);
                int i = 10;
                string str1 = "";
                string str2 = "";
                string str3 = "";
                if (n > 0 && n >= 10)
                {
                    for (i = 10; i <= n && i <= 99; i++)
                        if (i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        {
                            str1 += i + ", ";
                            For.Text = Convert.ToString(str1);
                        }

                    i = 9;
                    while (i < n)
                    {
                        i++;
                        if (i <= 99 && i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        {
                            str2 += i + ", ";
                            While.Text = Convert.ToString(str2);
                        }
                    }

                    i = 9;
                    do
                    {
                        i++;
                        if (i <= 99 && i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        {
                            str3 += i + ", ";
                            Do_while.Text = Convert.ToString(str3);
                        }
                    }
                    while (i < n);
                    Attention.Clear();
                    
                } 
                else { Attention.Text = Convert.ToString("Неккоректный ввод!");
                    For.Clear();
                    While.Clear();
                    Do_while.Clear();
                }
            }
            catch { Attention.Text = Convert.ToString("Неккоректный ввод!");
                For.Clear();
                While.Clear();
                Do_while.Clear();
            }  
              
                
           
        }
    }
}
