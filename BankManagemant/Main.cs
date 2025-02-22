using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagemant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account at = new Account();
            at.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cr = new Customer();
            cr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaction tn = new Transaction();
            tn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loan ln = new Loan();
            ln.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }
    }
}
