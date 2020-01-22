using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace eration
{
    public partial class eration2 : MetroFramework.Forms.MetroForm
    {
        public eration2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //LOGIN BUTTON
        {
            SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");  //establish connection to database
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select username,password from login", con);       //sqldataadapter provide a coonection b/w dataset and database
            DataTable dt = new DataTable();  // to store a table
            da.Fill(dt);
            if ((string)dt.Rows[0][0] == textBox2.Text && (string)dt.Rows[0][1] == textBox1.Text)
            {               
                    this.Hide();
                    eration3 a = new eration3();//administrator window
                    a.Show();                
            }
            else if(dt.Rows[1][0].ToString() == textBox2.Text && (string)dt.Rows[1][1] == textBox1.Text)
            {               
                    this.Hide();
                    eration8 b = new eration8();//stock keeper window
                    b.Show();               
            }
            else if(dt.Rows[2][0].ToString() == textBox2.Text && (string)dt.Rows[2][1] == textBox1.Text)
            {               
                    this.Hide();
                    eration7 c = new eration7();//inspector window
                    c.Show();               
            }
            else
            {
                MessageBox.Show("check your username and password");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//checks whether the enter key is pressed and call button2_click fun for login
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Administrator Login";
            label7.Hide();
            label1.Visible = true;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "StockKeeper Login";
            label7.Hide();
            label7.Hide();
            label1.Show();           
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Inspector Login";
            label1.Show();           
            panel2.Visible = true;
        }

        private void eration2_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }
        private void eration2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }       

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }      

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            label7.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
