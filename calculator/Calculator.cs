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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            lbl_mainScreen.Text = "0";
            lbl_formulaScreen.Text = string.Empty;
        }

        private void lbl_mainScreen_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            enterNum("9");
        }

        private void enterFormula(string operationSign)
        {

            decimal firstOperand;
            if (lbl_formulaScreen.Text.Length < 1)
            {
                firstOperand = decimal.Parse(lbl_mainScreen.Text);
                lbl_mainScreen.Text = string.Empty;
                lbl_formulaScreen.Text = firstOperand + operationSign;
            }
            else
            {
                if (lbl_formulaScreen.Text.Contains("+"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('+');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand + secondOperand;
                    lbl_mainScreen.Text = total.ToString();
                    enterFormula(operationSign);
                }
                else if (lbl_formulaScreen.Text.Contains("-"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('-');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand - secondOperand;
                    lbl_mainScreen.Text = total.ToString();
                    enterFormula(operationSign);

                }
                else if (lbl_formulaScreen.Text.Contains("/"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('/');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand / secondOperand;
                    lbl_mainScreen.Text = total.ToString();
                    enterFormula(operationSign);

                }
                else if (lbl_formulaScreen.Text.Contains("*"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('*');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand * secondOperand;
                    lbl_mainScreen.Text = total.ToString();
                    enterFormula(operationSign);

                }
            }

        }

    


        private void btn_add_Click(object sender, EventArgs e)
        {
            enterFormula("+");
        }


        private void enterNum(string num)
        {
            if(lbl_mainScreen.Text == "0")
            {
                if(num == "0")
                {
                    lbl_mainScreen.Text = num;

                }
                lbl_mainScreen.Text = num;

            }

            else
            {
                lbl_mainScreen.Text+=num;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            enterNum("8");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            enterNum("7");

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            enterNum("6");

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            enterNum("5");

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            enterNum("4");

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            enterNum("3");

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            enterNum("2");

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            enterNum("1");

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            enterNum("0");

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            lbl_mainScreen.Text = "0";
            lbl_formulaScreen.Text = string.Empty;

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            enterFormula("-");

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            enterFormula("*");

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            enterFormula("/");

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            decimal firstOperand;
            if (lbl_formulaScreen.Text.Length>1)
            {

                if (lbl_formulaScreen.Text.Contains("+"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('+');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand + secondOperand;
                    lbl_mainScreen.Text = total.ToString();
                }
                else if (lbl_formulaScreen.Text.Contains("-"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('-');
                    if (formula.Length<3)
                    {

                        firstOperand = decimal.Parse(formula[0]);
                        decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                        lbl_formulaScreen.Text = string.Empty;
                        decimal total = firstOperand - secondOperand;
                        lbl_mainScreen.Text = total.ToString();
                    }

                }
                else if (lbl_formulaScreen.Text.Contains("/"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('/');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand / secondOperand;
                    lbl_mainScreen.Text = total.ToString();

                }
                else if (lbl_formulaScreen.Text.Contains("*"))
                {
                    string[] formula = lbl_formulaScreen.Text.Split('*');
                    firstOperand = decimal.Parse(formula[0]);
                    decimal secondOperand = decimal.Parse(lbl_mainScreen.Text);
                    lbl_formulaScreen.Text = string.Empty;
                    decimal total = firstOperand * secondOperand;
                    lbl_mainScreen.Text = total.ToString();

                }
            }

        }
    }
}
