using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagemant
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into customers values(@customer_id,@customer_name,@phone,@email,@address)", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Customer_Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update customers set customer_name=@customer_name,phone=@phone,email=@email,address=@address where customer_id=@customer_id", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Customer_Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Successfully!");

        }
    }
}
