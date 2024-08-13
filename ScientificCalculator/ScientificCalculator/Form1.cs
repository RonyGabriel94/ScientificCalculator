using System;
using System.ComponentModel;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (TxtResult.Text == "0")
                TxtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!TxtResult.Text.Contains("."))
                    {
                        TxtResult.Text = TxtResult.Text + num.Text;
                    }
                }
                else
                {
                    TxtResult.Text = TxtResult.Text + num.Text;
                }
            }
        }

        private void OperationsEnter(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            num1 = Convert.ToDouble(TxtResult.Text);
            result = operation.Text;
            TxtResult.Text = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(TxtResult.Text);
            switch (result)
            {
                case "+":
                    TxtResult.Text = (num1 + num2).ToString();
                    break;

                case "-":
                    TxtResult.Text = (num1 - num2).ToString();
                    break;

                case "*":
                    TxtResult.Text = (num1 * num2).ToString();
                    break;

                case "/":
                    TxtResult.Text = (num1 / num2).ToString();
                    break;

                case "Mod":
                    TxtResult.Text = (num1 % num2).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(TxtResult.Text);
                    double j;
                    j = num2;
                    TxtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:

                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "0";

            string f, s;

            f = Convert.ToString(num1);
            s = Convert.ToString(num2);

            f = "";
            s = "";
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(x * -1);
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text.Length > 0)
            {
                TxtResult.Text = TxtResult.Text.Remove(TxtResult.Text.Length - 1);
            }

            if (TxtResult.Text == "")
            {
                TxtResult.Text = "0";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 320;  //816
            TxtResult.Width = 254;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 320;  //816
            TxtResult.Width = 254;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            TxtResult.Width = 540;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ExitCal;

            ExitCal = MessageBox.Show("Do you want to exit?", "Scientific Calculator", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ExitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "3.141592653589793238462643383279502884197";
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(TxtResult.Text);
            logg = Math.Log10(logg);
            TxtResult.Text = Convert.ToString(logg);
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            double square = Convert.ToDouble(TxtResult.Text);
            square = Math.Sqrt(square);
            TxtResult.Text = Convert.ToString(square);
        }

        private void Exponencial2Button_Click(object sender, EventArgs e)
        {
            double exponential2;

            exponential2 = Convert.ToDouble(TxtResult.Text) * Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(exponential2);
        }

        private void Exponential3Button_Click(object sender, EventArgs e)
        {
            double exponential3;

            exponential3 = Convert.ToDouble(TxtResult.Text) * Convert.ToDouble(TxtResult.Text) * Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(exponential3);
        }

        private void SineHButton_Click(object sender, EventArgs e)
        {
            double sineH = Convert.ToDouble(TxtResult.Text);
            sineH = Math.Sinh(sineH);
            TxtResult.Text = Convert.ToString(sineH);
        }

        private void SineButton_Click(object sender, EventArgs e)
        {
            double sine = Convert.ToDouble(TxtResult.Text);
            sine = Math.Sin(sine);
            TxtResult.Text = Convert.ToString(sine);
        }

        private void CosineHButton_Click(object sender, EventArgs e)
        {
            double cosH = Convert.ToDouble(TxtResult.Text);
            cosH = Math.Cosh(cosH);
            TxtResult.Text = Convert.ToString(cosH);
        }

        private void CosineButton_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(TxtResult.Text);
            cos = Math.Cos(cos);
            TxtResult.Text = Convert.ToString(cos);
        }

        private void TangentHButton_Click(object sender, EventArgs e)
        {
            double tanH = Convert.ToDouble(TxtResult.Text);
            tanH = Math.Tanh(tanH);
            TxtResult.Text = Convert.ToString(tanH);
        }

        private void TangentButton_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(TxtResult.Text);
            tan = Math.Tan(tan);
            TxtResult.Text = Convert.ToString(tan);
        }

        private void OneOverXButton_Click(object sender, EventArgs e)
        {
            double oneoverx;

            oneoverx = Convert.ToDouble(1.0 / Convert.ToDouble(TxtResult.Text));

            TxtResult.Text = Convert.ToString(oneoverx);
        }

        private void InXButton_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(TxtResult.Text);
            log = Math.Log(log);
            TxtResult.Text = Convert.ToString(log);
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            double percentage;

            percentage = Convert.ToDouble(TxtResult.Text) / Convert.ToDouble(100);

            TxtResult.Text = Convert.ToString(percentage);
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(TxtResult.Text);

            int iDec1 = Convert.ToInt32(dec);
            int iDec2 = (int)dec;
            TxtResult.Text = Convert.ToString(iDec2);
        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {
            int bin = int.Parse(TxtResult.Text);
            TxtResult.Text = Convert.ToString(bin, 2);
        }

        private void HexadecimalButton_Click(object sender, EventArgs e)
        {
            int hex = int.Parse(TxtResult.Text);
            TxtResult.Text = Convert.ToString(hex, 16);
        }

        private void OctalButton_Click(object sender, EventArgs e)
        {
            int oct = int.Parse(TxtResult.Text);
            TxtResult.Text = Convert.ToString(oct, 8);
        }
    }
}
