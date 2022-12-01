using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_2
{
    public partial class Form2 : Form
    {
        SqlConnection data = new SqlConnection(@"Data Source=SAMA-NEMKUL\SQLEXPRESS;Initial Catalog=emp_details;user id=sa;password=kist@123;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //data.Open();
            string query = "Select * from employeeData";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            //adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //data.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /* string uName = getName.Text;
                 string uAddress = getAddress.Text;
                 string uSalary = getSalary.Text;*/
                data.Open();
                string query = "Insert into emp values('" + this.name.Text +
                    "','" + this.address.Text + "','" + this.salary.Text + "')";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Rows.Add(getId.Text,getName.Text, getAddress.Text, getSalary.Text);*/
            data.Open();
            string query = "Select * from emp";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            data.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
               // data.Open();
                //string query = "delete from employeeData where id = '" + this.getId.Text + "'";
               // SqlCommand cmd = new SqlCommand(query, data);
               // cmd.ExecuteNonQuery();
               // MessageBox.Show("Saved Sucessfully");
                //data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                /* string uName = getName.Text;
                 string uAddress = getAddress.Text;
                 string uSalary = getSalary.Text;*/
                data.Open();
                string query = "INSERT INTO emp (name,address,salary)  VALUES(@name,@address,@salary )";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }
    }
}
