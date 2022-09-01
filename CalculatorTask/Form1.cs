namespace CalculatorTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool numberText = true;
        string calculate;
        double num1, num2, total;

        private void btn2_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "2";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "3";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "4";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "5";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "5";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "7";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "8";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "9";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (txtNum.Text == "")
            {
               txtNum.Clear();
            }
            else
            {
                if (numberText)
                {

                    txtNum.Text = "";
                    txtNum.Text = "0";
                    numberText = false;

                }
                else
                {
                    txtNum.Text = txtNum.Text + "0";
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculate = "+";
            numberText = true;
            num1 = double.Parse(txtNum.Text);
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            calculate = "-";
            numberText = true;
            num1 = double.Parse(txtNum.Text);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calculate = "*";
            numberText = true;
            num1 = double.Parse(txtNum.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculate = "/";
            numberText = true;
            num1 = double.Parse(txtNum.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtNum.Text);
            numberText = true;
            
            switch (calculate)
            {
                case "+":
                    total = num1 + num2;
                    txtNum.Text = total.ToString();
                    break;
                case "-":
                    total = num1 - num2;
                    txtNum.Text = total.ToString();
                    break;
                case "*":
                    total = num1 * num2;
                    txtNum.Text = total.ToString();
                    break;
                case "/":
                    total = num1 / num2;
                    txtNum.Text = total.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "1";
                numberText = false;
            }
         else
            {
                txtNum.Text = txtNum.Text + "1";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (numberText)
            {
                txtNum.Text = "";
                txtNum.Text = "6";
                numberText = false;
            }
            else
            {
                txtNum.Text = txtNum.Text + "6";
            }
        }
    }
}