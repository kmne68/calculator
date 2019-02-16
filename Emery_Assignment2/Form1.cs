using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emery_Assignment2
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double leftOperand = 0f;
            double rightOperand = 0f;
            bool haveValidOperand = false;
                
            try
            {
                haveValidOperand = IsOperandSelected();
                MessageBox.Show("is valid? " + haveValidOperand);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Operand required!", "Operand Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (haveValidOperand)
            {
                try
                {
                    if (!rb_sqrt.Checked)
                    {
                        leftOperand = Convert.ToDouble(txt_leftOperand.Text);
                        rightOperand = Convert.ToDouble(txt_rightOperand.Text);
                    }
                    else
                    {
                        leftOperand = Convert.ToDouble(txt_leftOperand.Text);
                    }

                    txt_result.Text = (DoCalculate(leftOperand, rightOperand));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid number format. Please check your entries.", "Entry Error");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Numbers are too long. Please enter numbers with fewer digits.", "Entry Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Be sure that all required operands are available", "Entry Error");
                }
            }
        }


        private string DoCalculate(double leftOperand, double rightOperand)
        {
            string mathOperator = "";
            string output = "";

            clearForm();

            if (rb_add.Checked == true)
            {
                mathOperator = "+";
            }
            else if (rb_div.Checked == true)
            {
                mathOperator = "/";
            }
            else if (rb_mult.Checked == true)
            {
                mathOperator = "*";
            }
            else if (rb_rp.Checked == true)
            {
                mathOperator = "^";
            }
            else if (rb_sqrt.Checked == true)
            {
                mathOperator = "SQRT";
            }
            else if (rb_sub.Checked == true)
            {
                mathOperator = "-";
            }
           

            switch (mathOperator)
            {
                case "+":
                    output = AddValues(leftOperand, rightOperand); 
                    break;
                case "-":
                    output = SubtractValues(leftOperand, rightOperand);
                    break;
                case "*":
                    output = MultiplyValues(leftOperand, rightOperand);
                    break;
                case "/":
                    output = DivideValues(leftOperand, rightOperand);
                    break;
                case "SQRT":
                    output = SquareRootValues(leftOperand);
                    break;
                case "^":
                    output = RaisePowerValues(leftOperand, rightOperand);
                    break;
                
            }

            if (!mathOperator.Equals("SQRT") && !mathOperator.Equals("^"))
            {
                txt_expression.Text = leftOperand + " " + mathOperator + " " + rightOperand;
            }
            else if(mathOperator.Equals("SQRT"))
            {
                txt_expression.Text = "The squre root of " + leftOperand + " is:";
            }
            else if(mathOperator.Equals("^"))
            {
                txt_expression.Text = leftOperand + " raised to the power of " + rightOperand + " is:";
            }
            return output;
        }


        private void clearForm()
        {
            
        }


        private bool IsOperandSelected()
        {
            bool operandSelected = false;

            if (gb_operations.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                operandSelected = true;
            }

            return operandSelected;
        }


        private string AddValues(double leftOperand, double rightOperand)
        {
            string result = "";

            result = (leftOperand + rightOperand).ToString();

            return result;
        }


        private string DivideValues(double leftOperand, double rightOperand)
        {
            string result = "";

            result = (leftOperand / rightOperand).ToString();

            return result;
        }


        private string SubtractValues(double leftOperand, double rightOperand)
        {
            string result = "";

            result = (leftOperand - rightOperand).ToString();

            return result;
        }


        private string MultiplyValues(double leftOperand, double rightOperand)
        {
            string result = "";

            result = (leftOperand * rightOperand).ToString();

            return result;
        }


        private string SquareRootValues(double leftOperand)
        {
            string result = "";

            result = Math.Sqrt(leftOperand).ToString();

            return result;
        }


        private string RaisePowerValues(double leftOperand, double rightOperand)
        {
            string result = "";

            result = Math.Pow(leftOperand, rightOperand).ToString();

            return result;
        }
    }
}
