using System.Data;
using System.Data.SqlClient;

namespace Employee_2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = SAMA-NEMKUL\SQLEXPRESS;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
<<<<<<< HEAD
            string query = "Insert into emp" + "(name,address ,salary)" + "values('" + txtUserName.Text
                + "','" + txtUserName.Text + "','" + txtUserSalary.Text + "')";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
=======
            // string query = "Insert into emp values('" + txtUserName.Text
            // SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
>>>>>>> d840932802ac2a051c7db1b8f549c318991682fc
            MessageBox.Show("saved successfully");
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into emp" + "(name,address,salary)" + "values('" + txtUserName.Text + "','" + txtUserAddr.Text + "','" + txtUserSalary.Text + "')";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from emp";
            SqlCommand command = new SqlCommand(query, con);    
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();  
            adapter.Fill(table);
            int sn = 1;
            for(int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["name"].ToString();
                string address = table.Rows[i]["address"].ToString();
                string salary = table.Rows[i]["salary"].ToString ();
                dataGridView1.Rows.Add(sn++, name, address, salary);
            }
        }
    }
}