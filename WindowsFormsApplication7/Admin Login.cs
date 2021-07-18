using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        bool isAdmin(TextBox a, TextBox b)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Group96;Integrated Security=True");
            con.Open();
            string command = "Select Count(username) from Supervisor where username='" + a.Text + "'and password='" + b.Text + "'";
            SqlCommand cmd = new SqlCommand(command, con);
            int x = (int)cmd.ExecuteScalar();
            con.Close();
            return (x > 0);
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isAdmin(textBox1, textBox2))
            {
                Admin_Mode Log = new Admin_Mode();
                Log.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Either username or password is wrong", "Try again",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Close();
        }
    }
}
