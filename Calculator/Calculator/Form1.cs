namespace Calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void GetResultValue()
        {
            if (Result.Text != "" && Result.Text != "+" && Result.Text != "-" && Result.Text != "*" && Result.Text != "/") ;
            {
                calculation = Convert.ToDecimal(Result.Text);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string data1 = textBox1.Text;
            //string data2 = textBox1.Text;
            // string data3 = textBox1.Text;
            //int ans1 = Convert.ToInt32(data1);
            //int ans2 = Convert.ToInt32(data2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Result.Text =="+"|| Result.Text =="-" || Result.Text=="*"|| Result.Text=="/")
            {
                Result.Text = "1";  
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "1";
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "2";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "3";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "4";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "5";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "6";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "7";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "8";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "9";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "0";
            }
            else
            {
                string data = Result.Text;
                Result.Text = data + "0";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(Result.Text);
            switch(operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);   
                    Result.Text = calculation.ToString();
                    break;
                case "-":
                    calculation = (firstNum - secondNum);
                    Result.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    Result.Text = calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    Result.Text = calculation.ToString();
                    break;
            }
             
        }
        private void button12_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            Result.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            Result.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            Result.Text = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            Result.Text = "/";
        }
    }
}