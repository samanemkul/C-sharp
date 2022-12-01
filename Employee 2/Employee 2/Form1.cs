using System.Data;
using System.Data.SqlClient;

namespace Employee_2
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-M895AMJ\SQLEXPRESS;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into emp values('" + txtUserName.Text
                + "','" + txtUserName.Text + "','" + txtUserSalary.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = (@"Data Source =DESKTOP-M895AMJ\SQLEXPRESS ;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "select * from emp";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update emp set name='" + txtUserName.Text + "', address='" + txtUserAddr.Text + "' ,salary ='" + txtUserSalary.Text + "' where id = '" + txtUserID.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from emp where id = '" + txtUserID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            con.Close();
        }
    }
}