using System.Globalization;

namespace MinhaCalculadora
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal value1 = 0, value2 = 0;
        string operation = "";
        private void sum_Button(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value1 += decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "SUM";
            }
        }
        private void number0_Button(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }
        private void equal_Button(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            }

            switch (operation)
            {
                case "SUM":
                    txtResult.Text = Convert.ToString(value1 + value2, CultureInfo.InvariantCulture);
                    break;

                case "DIVISION":
                    if (value2 != 0)
                    {
                        txtResult.Text = Convert.ToString(value1 / value2, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        txtResult.Text = "ERRO";
                    }
                    break;

                case "SUBTRACTION":
                    txtResult.Text = Convert.ToString(value1 - value2, CultureInfo.InvariantCulture);
                    break;

                case "MULTIPLICATION":
                    txtResult.Text = Convert.ToString(value1 * value2, CultureInfo.InvariantCulture);
                    break;
                default:
                    txtResult.Text = "SELECIONE UMA OPERAÇÃO!";
                    break;
            }
        }
        private void divide_Button(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                decimal currentValue = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                if (value1 == 0)
                {
                    value1 = currentValue;
                }
                else
                {
                    value1 /= currentValue;
                }

                txtResult.Text = "";

                operation = "DIVISION";
            }
        }
        private void number1_Button(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }
        private void number2_Button(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }
        private void number3_Button(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }
        private void number4_Button(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }
        private void number5_Button(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }
        private void number6_Button(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }
        private void number7_Button(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }
        private void number8_Button(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }
        private void number9_Button(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }
        private void dot_Button(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
                txtResult.Text += ".";
        }
        private void sub_Button(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                if (value1 == 0)
                {
                    value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                }
                else
                {
                    value1 -= decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                }
                txtResult.Text = "";
                operation = "SUBTRACTION";
            }
        }
        private void mult_Button(object sender, EventArgs e)
        {
            if (value1 == 0)
                value1 = 1;
            if (txtResult.Text != "")
            {
                value1 *= decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "MULTIPLICATION";
            }
        }
        private void c_Button(object sender, EventArgs e)
        {
            txtResult.Text = "";
            value1 = 0;
            value2 = 0;
        }
        private void ce_Button(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}