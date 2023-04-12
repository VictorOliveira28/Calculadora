using System.Globalization;
using System;

namespace MinhaCalculadora {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        decimal value1 = 0, value2 = 0, percent = 0, Result = 0;
        string operation = "", PreviousOperation = "";
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }


        private void button1_Click(object sender, EventArgs e) {

        }

        private void button11_Click(object sender, EventArgs e) {
            if (txtResult.Text != "") {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);


                txtResult.Text = "";
                operation = "SUM";
                PreviousOperation = "SUM";

            }


        }

        private void button17_Click(object sender, EventArgs e) {
            txtResult.Text += "0";
        }


        private void button16_Click(object sender, EventArgs e) {

            if (txtResult.Text != "") {                
                value2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                switch (operation)
                {
                    case "SUM":
                        txtResult.Text = Convert.ToString(value1 + value2, CultureInfo.InvariantCulture);
                        break;
                }

                /*if (operation == "SUM") {

                    txtResult.Text = Convert.ToString(value1 + value2, CultureInfo.InvariantCulture);
                }

                else if (operation == "DIVISION") {
                    if (value2 != 0) {
                        txtResult.Text = Convert.ToString(value1 / value2, CultureInfo.InvariantCulture);
                    }
                    else {
                        txtResult.Text = Convert.ToString(0, CultureInfo.InvariantCulture);
                    }
                }
                else if (operation == "SUBTRACTION") {
                    txtResult.Text = Convert.ToString(value1 - value2, CultureInfo.InvariantCulture);
                }
                else if (operation == "MULTIPLICATION") {
                    txtResult.Text = Convert.ToString(value1 * value2, CultureInfo.InvariantCulture);
                }
                else if (operation == "SQUAREROOT") {


                    double result = Math.Sqrt(Convert.ToDouble(txtResult.Text, CultureInfo.InvariantCulture));
                    txtResult.Text = Convert.ToString(result);*/

                    switch (PreviousOperation) {
                        case "SUM":
                            value2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                            double sqrtResult = Math.Sqrt(Convert.ToDouble(value2));
                            double sumResult = Convert.ToDouble(value1) + sqrtResult;
                            txtResult.Text = Convert.ToString(sumResult);
                            break;
                    }
                    

                }


            }

            else {
                percent = value2 / 100;
                switch (PreviousOperation) {
                    case "SUM":
                        decimal sumResult = value1 + (value1 * percent);
                        txtResult.Text = sumResult.ToString(sumResult == decimal.Truncate(sumResult) ? "0" : "0.00", CultureInfo.InvariantCulture);
                        Result = decimal.Parse(txtResult.Text + value2);
                        break;

                    case "SUBTRACTION":
                        decimal subResult = value1 - (value1 * percent);
                        txtResult.Text = subResult.ToString(subResult == decimal.Truncate(subResult) ? "0" : "0.00", CultureInfo.InvariantCulture);
                        Result = decimal.Parse(txtResult.Text) - value2;
                        break;

                    case "MULTIPLICATION":
                        decimal multResult = value1 * (value1 * percent);
                        txtResult.Text = multResult.ToString(multResult == decimal.Truncate(multResult) ? "0" : "0.00", CultureInfo.InvariantCulture);
                        Result = decimal.Parse(txtResult.Text) * value2;
                        break;

                    case "DIVISION":
                        decimal divResult = value1 / (value1 * percent);
                        txtResult.Text = divResult.ToString(divResult == decimal.Truncate(divResult) ? "0" : "0.00", CultureInfo.InvariantCulture);
                        Result = decimal.Parse(txtResult.Text) / value2;
                        break;

                    default:
                        txtResult.Text = "";
                        break;

                }
            }
        }

        private void button12_Click(object sender, EventArgs e) {

            if (txtResult.Text != "") {

                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                txtResult.Text = "";

                operation = "DIVISION";
                PreviousOperation = "DIVISION";
            }
        }
        private void button20_Click(object sender, EventArgs e) {
            txtResult.Text += "1";
        }
        private void button19_Click(object sender, EventArgs e) {
            txtResult.Text += "2";
        }
        private void button18_Click(object sender, EventArgs e) {
            txtResult.Text += "3";
        }
        private void button15_Click(object sender, EventArgs e) {
            txtResult.Text += "4";
        }
        private void button14_Click(object sender, EventArgs e) {
            txtResult.Text += "5";
        }
        private void button13_Click_1(object sender, EventArgs e) {
            txtResult.Text += "6";
        }
        private void button10_Click(object sender, EventArgs e) {
            txtResult.Text += "7";
        }
        private void button9_Click(object sender, EventArgs e) {
            txtResult.Text += "8";
        }
        private void button8_Click(object sender, EventArgs e) {
            txtResult.Text += "9";
        }
        private void button7_Click(object sender, EventArgs e) {
            if (!txtResult.Text.Contains("."))
                txtResult.Text += ".";
        }
        private void button6_Click_1(object sender, EventArgs e) {

            if (txtResult.Text != "") {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                txtResult.Text = "";
                operation = "SUBTRACTION";
                PreviousOperation = "SUBTRACTION";
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (txtResult.Text != "") {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                txtResult.Text = "";
                operation = "MULTIPLICATION";
                PreviousOperation = "MULTIPLICATION";
            }
        }
        private void button4_Click(object sender, EventArgs e) {
            if (txtResult.Text != "") {

                operation = "PERCENT";

            }
        }
        private void button21_Click(object sender, EventArgs e) {
            if (txtResult.Text != "") {

                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

                operation = "SQUAREROOT";
                
            }

        }
        private void button3_Click(object sender, EventArgs e) {
            txtResult.Text = "";
            value1 = 0;
            value2 = 0;

        }
        private void button1_Click_1(object sender, EventArgs e) {
            txtResult.Text = "";
        }
    }
}