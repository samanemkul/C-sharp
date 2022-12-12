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
        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            // string query = "Insert into emp values('" + txtUserName.Text
            // SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            // con.Close();

            string query = "Insert into emp" +
                "(name,address,salary)" +
                "values(@name,@address,@salary)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name",txtUserName.Text);
            cmd.Parameters.AddWithValue("@address",txtUserAddr.Text);
            cmd.Parameters.AddWithValue("@salary",txtUserSalary.Text);
            cmd. ExecuteNonQuery();
            con.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Button Display
        private void button2_Click(object sender, EventArgs e)
        {
            /*string ConnectionString = (@"Data Source =DESKTOP-M895AMJ\SQLEXPRESS ;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
            con.Open();
            string Query = "select * from emp";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
            */
            /*string ConnectionString = (@"Data Source =.\SQLEXPRESS ;
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

            con.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update emp set name='" + txtUserName.Text + "', address='" + txtUserAddr.Text + "' ,salary ='" + txtUserSalary.Text + "' where id = '" + txtUserID.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from emp where id = '" + txtUserID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            con.Close();
            DisplayData();
        }

        //Display
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            dataGridView1.Rows.Clear();
            string query = "select * from emp";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int sn = 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {

                string id = table.Rows[i]["id"].ToString();
                string name = table.Rows[i]["name"].ToString();
                string address = table.Rows[i]["address"].ToString();
                string salary = table.Rows[i]["salary"].ToString ();
                dataGridView1.Rows.Add(sn++, name, address, salary);
            }
        }
    }
}