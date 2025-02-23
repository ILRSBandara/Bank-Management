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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
        }

        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmm = new SqlCommand("SELECT COUNT(*) FROM customers", con);
            Int32 count = Convert.ToInt32(cmm.ExecuteScalar());
            if (count > 0)
            {
                lblCount1.Text = count.ToString(count.ToString());
            }
            else
            {
                lblCount1.Text = "0";
            }
            con.Close();
        }

        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmm = new SqlCommand("SELECT COUNT(*) FROM employees", con);
            Int32 count = Convert.ToInt32(cmm.ExecuteScalar());
            if (count > 0)
            {
                lblCount2.Text = count.ToString(count.ToString());
            }
            else
            {
                lblCount2.Text = "0";
            }
            con.Close();
        }

        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=RASH\RASH;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmm = new SqlCommand("SELECT COUNT(*) FROM loans", con);
            Int32 count = Convert.ToInt32(cmm.ExecuteScalar());
            if (count > 0)
            {
                lblCount3.Text = count.ToString(count.ToString());
            }
            else
            {
                lblCount3.Text = "0";
            }
            con.Close();
        }
    }
}
