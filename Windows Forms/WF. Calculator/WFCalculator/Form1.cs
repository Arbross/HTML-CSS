using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCalculator
{
    public partial class Form1 : Form
    {
        private CalcCounter calcCounter;
        public Form1()
        {
            InitializeComponent();
            calcCounter = new CalcCounter();
            tbOutput.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Zero
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            // One
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            // Two
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            // Three
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            // Four
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            // Five
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            // Six
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            // Seven
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            // Eight
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            // Nine
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            // Equeal
            btnEqueal.FlatAppearance.BorderSize = 0;
            btnEqueal.FlatStyle = FlatStyle.Flat;
            // Addition
            btnAddition.FlatAppearance.BorderSize = 0;
            btnAddition.FlatStyle = FlatStyle.Flat;
            // Substraction
            btnSubtraction.FlatAppearance.BorderSize = 0;
            btnSubtraction.FlatStyle = FlatStyle.Flat;
            // Division
            btnDivision.FlatAppearance.BorderSize = 0;
            btnDivision.FlatStyle = FlatStyle.Flat;
            // Multiplication
            btnMultiplication.FlatAppearance.BorderSize = 0;
            btnMultiplication.FlatStyle = FlatStyle.Flat;
            // Clear
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            // Clear again
            btnClearAgain.FlatAppearance.BorderSize = 0;
            btnClearAgain.FlatStyle = FlatStyle.Flat;
            // RemoveOneSymbolFromTheEnd
            btnRemoveOneSymbolFromTheEnd.FlatAppearance.BorderSize = 0;
            btnRemoveOneSymbolFromTheEnd.FlatStyle = FlatStyle.Flat;
            // Coma
            btnComa.FlatAppearance.BorderSize = 0;
            btnComa.FlatStyle = FlatStyle.Flat;
            // Plus minus
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            // Sin
            btnSin.FlatAppearance.BorderSize = 0;
            btnSin.FlatStyle = FlatStyle.Flat;
            // Cos
            btnCos.FlatAppearance.BorderSize = 0;
            btnCos.FlatStyle = FlatStyle.Flat;
            // Tg
            btnTg.FlatAppearance.BorderSize = 0;
            btnTg.FlatStyle = FlatStyle.Flat;

            msSimple_MouseClick(null, null);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Count(1);
        }

        private void btnClearAgain_Click(object sender, EventArgs e)
        {
            calcCounter.First = 0;
            calcCounter.Second = 0;
            calcCounter.ChangeState = false;
            tbOutput.Text = "0";
        }

        private void btnRemoveOneSymbolFromTheEnd_Click(object sender, EventArgs e)
        {
            if (calcCounter.ChangeState)
            {
                Int64 number = (Int64)calcCounter.First / 10;
                calcCounter.Second = number;
                tbOutput.Text = Convert.ToString(calcCounter.Second);
            }
            else
            {
                Int64 number = (Int64)calcCounter.First / 10;
                calcCounter.First = number;
                tbOutput.Text = Convert.ToString(calcCounter.First);
            }
        }
        private void Count(decimal number)
        {
            if (calcCounter.ChangeState)
            {
                calcCounter.Second *= 10;
                calcCounter.Second += number;
                if (tbOutput.Text.Contains(","))
                {
                    decimal nNumber = Convert.ToDecimal(tbOutput.Text.Replace(",", "."));
                    calcCounter.Second = nNumber;
                }
                tbOutput.Text = Convert.ToString(calcCounter.Second);
            }
            else
            {
                
                if (tbOutput.Text.Contains(","))
                {
                    decimal nNumber = Convert.ToDecimal(tbOutput.Text.Replace(",", ".") + number);
                    calcCounter.First = nNumber;
                    tbOutput.Text = Convert.ToString(calcCounter.First);
                }
                else
                {
                    calcCounter.First *= 10;
                    calcCounter.First += number;
                    tbOutput.Text = Convert.ToString(calcCounter.First);
                }
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Count(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Count(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Count(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Count(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Count(6);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Count(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Count(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Count(9);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text != null)
            {
                Count(0);
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "+";
            calcCounter.Symbol = '+';
            calcCounter.ChangeState = true;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (calcCounter.ChangeState)
            {
                calcCounter.Second *= -1;
                tbOutput.Text = Convert.ToString(calcCounter.Second);
            }
            else
            {
                calcCounter.First *= -1;
                tbOutput.Text = Convert.ToString(calcCounter.First);
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!tbOutput.Text.Contains(","))
            {
                tbOutput.Text += ",";
            }
        }

        private void btnEqueal_Click(object sender, EventArgs e)
        {
            if (calcCounter.Symbol == '+')
            {
                tbOutput.Text = Convert.ToString(calcCounter.First + calcCounter.Second);
                calcCounter.First = calcCounter.First + calcCounter.Second;
            }
            if (calcCounter.Symbol == '-')
            {
                tbOutput.Text = Convert.ToString(calcCounter.First - calcCounter.Second);
                calcCounter.First = calcCounter.First - calcCounter.Second;
            }
            if (calcCounter.Symbol == '*')
            {
                tbOutput.Text = Convert.ToString(calcCounter.First * calcCounter.Second);
                calcCounter.First = calcCounter.First * calcCounter.Second;
            }
            if (calcCounter.Symbol == '/')
            {
                tbOutput.Text = Convert.ToString(calcCounter.First / calcCounter.Second);
                calcCounter.First = calcCounter.First / calcCounter.Second;
            }
            calcCounter.Second = 0;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "-";
            calcCounter.Symbol = '-';
            calcCounter.ChangeState = true;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "*";
            calcCounter.Symbol = '*';
            calcCounter.ChangeState = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "/";
            calcCounter.Symbol = '/';
            calcCounter.ChangeState = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (calcCounter.ChangeState)
            {
                calcCounter.Second = 0;
                tbOutput.Text = "";
            }
            else
            {
                calcCounter.First = 0;
                tbOutput.Text = "";
            }
        }

        private void btnTg_Click(object sender, EventArgs e)
        {
            calcCounter.First = (decimal)Math.Tan((double)calcCounter.First);
            tbOutput.Text = $"{calcCounter.First}";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            calcCounter.First = (decimal)Math.Cos((double)calcCounter.First);
            tbOutput.Text = $"{calcCounter.First}";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (calcCounter.StateChangeDegreesRadians)
            {
                calcCounter.First = (decimal)Math.Sin((180 / Math.PI) * Math.Sin((Math.PI / 180) * (double)calcCounter.First));
                tbOutput.Text = $"{calcCounter.First}";
            }
            else
            {
                calcCounter.First = (decimal)Math.Sin((Math.PI / 180) * (double)calcCounter.First);
                tbOutput.Text = $"{calcCounter.First}";
            }
        }
        private void msSimple_MouseClick(object sender, MouseEventArgs e)
        {
            btnSin.Visible = false;
            btnCos.Visible = false;
            btnTg.Visible = false;
        }

        private void msExpert_MouseClick(object sender, MouseEventArgs e)
        {
            btnSin.Visible = true;
            btnCos.Visible = true;
            btnTg.Visible = true;
        }

        private void msDegrees_MouseClick(object sender, MouseEventArgs e)
        {
            calcCounter.StateChangeDegreesRadians = false;
        }

        private void msRadians_MouseClick(object sender, MouseEventArgs e)
        {
            calcCounter.StateChangeDegreesRadians = true;
        }
    }
}
