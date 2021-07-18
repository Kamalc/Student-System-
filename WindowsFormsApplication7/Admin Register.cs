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

namespace WindowsFormsApplication7
{
    public partial class Admin_Register : Form
    {
        public Admin_Register()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }
        int count(TextBox a, TextBox b)
        {
            int cnt = 0;
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Group96;Integrated Security=True");
            con.Open();
            string command = "Select Count(username) from Supervisor where username='" + a.Text + "'or password='" + b.Text + "'";
            SqlCommand cmd = new SqlCommand(command, con);
            cnt = (int)cmd.ExecuteScalar();
            con.Close();
            return cnt;
        }
        void update()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Group96;Integrated Security=True");
            con.Open();
            string command = "Insert into Supervisor(username, email, password, name) values ('"+textBox1.Text+"', '"+ textBox5.Text+"','"+textBox2.Text+"', '"+textBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(command, con);
            con.Close();
            return;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cnt = count(textBox1, textBox2);
            if (cnt > 0)
            {
                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "*This user name was entered before";
                button5.Enabled = false;
            }
            else
            {
                label7.Visible = true;
                label7.ForeColor = Color.Green;
                label7.Text = "*Ok";
                button5.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
                MessageBox.Show("You have successfully registered !!!","Success");
                Form3 NewForm = new Form3();
                NewForm.Show();
                this.Hide();
                MessageBox.Show(count(textBox1, textBox2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Mode reg = new Admin_Mode();
            reg.Show();
            this.Hide();
        }
    }
}
