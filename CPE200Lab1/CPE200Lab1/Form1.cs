using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1() //constructor
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            clear = 0;
        }
        int dot = 0;
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (dot == 0)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                dot = 1;
            }
           
                
        }

        double first = 0;
        double second = 0;
        double result = 0;
        int clear = 0;
 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(lblDisplay.Text);
            if (collect == "+")
            {
                result = first + second;
               
             }
            if (collect == "-")
            {
                result = first - second;
                
            }
            if (collect == "X")
            {
                result = first * second;
                
            }
            if (collect == "÷")
            {
                if (first == 0 && second == 0)
                {
                    first = 1;
                }
          
                result = first / second;
               
            }
            result = Math.Round(result, 6);
            string ans = Convert.ToString(result);
            if (ans.Length > 8)
            {
                lblDisplay.Text = "ERROR";
            }
            else
            {
                
                lblDisplay.Text = Convert.ToString(result);
            }
            clear = 1;
            dot = 0;
            
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (clear == 1)
            {
                clear = 0;
                lblDisplay.Text = " ";
            }
            if (lblDisplay.Text.Length < 8)
            {
                   if (lblDisplay.Text == "0")
                   {
                       lblDisplay.Text = ((Button)sender).Text;
                   }
                   else
                   {
                        lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                   }
            }
        }

        string collect;
        private void btnOperator_Click(object sender, EventArgs e)
        {
            collect = ((Button)sender).Text;
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = " ";
            dot = 0;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double ans=0;
            if(lblDisplay.Text==" ")
            {
                ans = first * (first / 100);
                lblDisplay.Text = Convert.ToString(ans);
            }
            else
            {
                second = Convert.ToDouble(lblDisplay.Text);
                ans = first * second / 100;
                lblDisplay.Text = Convert.ToString(ans);
            }
        }
    }
}
