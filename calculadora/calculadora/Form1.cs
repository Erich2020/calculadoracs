namespace calculadora
{
    public partial class Form1 : Form
    {
        private bool isActivetBxNum1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.inputNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inputNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.inputNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inputNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inputNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inputNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.inputNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inputNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.inputNumber("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cleanInputs();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.inputNumber("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.inputNumber(".");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.opMinus();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            this.opSum();
            
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            this.opMultiply();
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            this.opDivision();
            
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            this.opFactorial();
            
        }

        private void inputNumber(string number)
        {
            if (this.isActivetBxNum1)
            {
                this.tBxNum1.Text = this.tBxNum1.Text + number;
            } else
            {
                this.tBxNum2.Text = this.tBxNum2.Text + number;
            }
        }

        private bool isNumberOrDot(decimal number)
        {
            return number.GetType() == Type.GetType("System.Decimal");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.OemMinus | Keys.Subtract:
                    this.opMinus();
                    break;
                case Keys.Oemplus | Keys.Add:
                    this.opSum();
                    break;
                case Keys.Divide:
                    this.opDivision();
                    break;
                case Keys.Multiply:
                    this.opMultiply();
                    break;
            }
        }

        private void tBxNum1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tBxNum1_Enter(object sender, EventArgs e)
        {
            this.isActivetBxNum1 = true;
        }

        private void tBxNum2_Enter(object sender, EventArgs e)
        {
            this.isActivetBxNum1 = false;
        }

        private void cleanInputs()
        {
            this.tBxNum1.Text = "";
            this.tBxNum2.Text = "";
            this.lblResultOperation.Text = "0";
        }

        private void opMinus()
        {
            try
            {
                this.isEmptyInput();
                decimal num1 = Decimal.Parse(this.tBxNum1.Text);
                decimal num2 = Decimal.Parse(this.tBxNum2.Text);
                this.cleanInputs();
                this.lblResultOperation.Text = Operations.minus(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void opSum()
        {
            try
            {
                this.isEmptyInput();
                decimal num1 = Decimal.Parse(this.tBxNum1.Text);
                decimal num2 = Decimal.Parse(this.tBxNum2.Text);
                this.cleanInputs();
                this.lblResultOperation.Text = Operations.sum(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void opMultiply()
        {
            try
            {
                this.isEmptyInput();
                decimal num1 = Decimal.Parse(this.tBxNum1.Text);
                decimal num2 = Decimal.Parse(this.tBxNum2.Text);
                this.cleanInputs();
                this.lblResultOperation.Text = Operations.multiply(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void opDivision()
        {
            try
            {
                this.isEmptyInput();
                decimal num1 = Decimal.Parse(this.tBxNum1.Text);
                decimal num2 = Decimal.Parse(this.tBxNum2.Text);
                this.cleanInputs();
                this.lblResultOperation.Text = Operations.division(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void opFactorial()
        {
            try
            {
                if (this.tBxNum1.Text == "") return;
                decimal num1 = Decimal.Parse(this.tBxNum1.Text);
                this.cleanInputs();
                this.lblResultOperation.Text = Operations.factorial(num1).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void tBxNum2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.OemMinus | Keys.Subtract:
                    this.opMinus();
                    break;
                case Keys.Oemplus | Keys.Add:
                    this.opSum();
                    break;
                case Keys.Divide:
                    this.opDivision();
                    break;
                case Keys.Multiply:
                    this.opMultiply();
                    break;
            }
        }
        private void isEmptyInput()
        {
            this.tBxNum2.BackColor = Color.White;
            this.tBxNum1.BackColor = Color.White;
            if (this.tBxNum2.Text == "")
            {
                this.tBxNum2.BackColor = Color.Red;
            }
            if(this.tBxNum1.Text == "")
            {
                this.tBxNum1.BackColor = Color.Red;
            }
        }
    }
}