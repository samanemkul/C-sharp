namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            string data = Result.Text;
            Result.Text = data + "1";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string data1 = Result.Text;
            Result.Text = data1 + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data2 = Result.Text;
            Result.Text = data2 + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data3 = Result.Text;
            Result.Text = data3 + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data4 = Result.Text;
            Result.Text = data4 + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data5 = Result.Text;
            Result.Text = data5 + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string data6 = Result.Text;
            Result.Text = data6 + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string data7 = Result.Text;
            Result.Text = data7 + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data8 = Result.Text;
            Result.Text = data8 + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data9 = Result.Text;
            Result.Text = data9 +"0";
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Result.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result.Text = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Result.Text = "/";
        }
    }
}