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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into accounts values(@account_id,@account_type,@balance,@date_opened,@customer_name)", con);
            cnn.Parameters.AddWithValue("@Account_ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Account_Type", textBox2.Text);
            cnn.Parameters.AddWithValue("@Balance", textBox3.Text);
            cnn.Parameters.AddWithValue("@Date_Opened", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", textBox4.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                dateTimePicker1.CustomFormat = "";
            }
        }
    }
}
