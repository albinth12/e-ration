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

namespace eration
{
    public partial class eration3 : MetroFramework.Forms.MetroForm
    {
               
       
        public eration3()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");
       // con.Open();
        SqlCommand cm = new SqlCommand();
        private void eration3_Load(object sender, EventArgs e)//page loading function
        {
            cm.Connection = con;    
            panel6.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            textBox1.Text = null;
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            //ENTER button function
            //data entry 
            con.Open();
            cm.CommandText = "update card set cardno='" + textBox1.Text + "' where id=1";
            cm.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);  //used to send query to the database         
             SqlDataReader sdr = cmd.ExecuteReader();           //execute the query in the sqlcommand 

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter the ration card number");               
            }
            else if (sdr.HasRows)
            {
                this.Hide();
                eration4 n = new eration4();//data entry window
                n.Show();
               
             }
             else
             {
                MessageBox.Show("Please check the card number");
                textBox1.Text = null;
            }
                con.Close();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            //no = textBox1.Text;

            if (e.KeyCode == Keys.Enter)  //check enter key is pressed
            {
                button1_Click_1(this, new EventArgs());

            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration5 m = new eration5();//administrator window
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update button
            panel5.Hide();
            panel2.Show();
            panel3.Hide();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();          
           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();           
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Show();//logout button show panel6 for confirmation of logout 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //updating details
            con.Open();
            cm.CommandText = "update card set cardno='" + textBox2.Text + "' where id=1";
            cm.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter the ration card number");
            }
            else if (sdr.HasRows)
            {
                //cm.CommandText = "update card set cardno='" + textBox1.Text + "' where id=1";
                //cm.ExecuteNonQuery();
                
                textBox2.Text = "";
                this.Hide();
                eration6 a = new eration6();
                a.Show();
            }
            else
            {
                MessageBox.Show("Check the ration card number");
            }
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //REMOVING CUSTOMER
            con.Open();
            SqlCommand sd = new SqlCommand("delete from details where cardno=(select cardno from card where id=1)",con);           
            sd.ExecuteNonQuery();
            MessageBox.Show("Successfully removed the customer");
            panel4.Hide();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //remove label button
            con.Open();
            cm.CommandText = "update card set cardno='" + textBox3.Text + "' where id=1";
            cm.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter the ration card number");
            }
            else if (sdr.HasRows)
            {
               // cm.CommandText = "update card set cardno='" + textBox3.Text + "' where id=1";
               // cm.ExecuteNonQuery();                
                textBox3.Text = "";
                panel3.Hide();
                panel5.Hide();
                panel4.Show();
            }
            else
            {
                MessageBox.Show("Check the ration card number");
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //find details button
            panel2.Hide();
            panel3.Hide();
            panel5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //remove button
            panel2.Hide();  //update label
            panel5.Hide(); //find details label
            panel3.Show(); //remove label         
        }

       
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //find details button
            con.Open();
            cm.CommandText = "update card set cardno='" + textBox4.Text + "' where id=1";
            cm.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter the ration card number");
            }
            else if (sdr.HasRows)
            {
                this.Hide();
                eration10 a = new eration10();
                a.Show();
            }
            else
            {
                MessageBox.Show("Check the ration card number");
            }
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //logouting confirmation
            this.Hide();
            eration2 b = new eration2();
            b.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void apply_new_Click(object sender, EventArgs e)
        {
            //apply button
            this.Hide();
            eration5 a = new eration5();
            a.Show();
        }
    }
}
