﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagemant
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker3.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into loans values(@loan_id,@loan_type,@amount,@interest_rate,@loan_date,@customer_name)", con);
            cnn.Parameters.AddWithValue("@Loan_ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Loan_Type", textBox2.Text);
            cnn.Parameters.AddWithValue("@Amount", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Interest_Rate", textBox4.Text);
            cnn.Parameters.AddWithValue("@Loan_Date", dateTimePicker3.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }
    }
}
