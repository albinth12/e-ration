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
    public partial class eration8 : MetroFramework.Forms.MetroForm
    {
        public eration8()
        {
            InitializeComponent();
        }       
        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel7.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///current stock button function
            panel9.Hide();           
            string month =  DateTime.Now.ToString("MMMM");
            label18.Text = month.ToString();         
            
            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from stock where month=@month",con);            
            cmd.Parameters.AddWithValue("@month",month);             
            //cmd.ExecuteNonQuery();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                if (sdr.HasRows)
                {
                    panel3.Hide();
                    panel1.Show();
                    textBox1.Text= sdr[0].ToString();
                    textBox2.Text = sdr[1].ToString();
                    textBox4.Text = sdr[2].ToString();
                    textBox5.Text = sdr[3].ToString();
                    textBox3.Text = sdr[4].ToString();
                    label15.Text = month.ToString();



                }
                else
                {
                    panel1.Hide();
                    
                }
            }

            con.Close();
                             
        }

        private void eration8_Load(object sender, EventArgs e)
        {
            //loading fun.
            panel1.Hide();
            panel2.Hide();        
            panel3.Hide();
            panel9.Hide();
            panel7.Hide();
            panel10.Hide();
            panel11.Hide();

            string month = DateTime.Now.ToString("MMMM");
            label18.Text = month.ToString();
            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from stock where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            //cmd.ExecuteNonQuery();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                if (sdr.HasRows)
                {

                    textBox10.Text = sdr[0].ToString();
                    textBox8.Text = sdr[1].ToString();
                    textBox6.Text = sdr[2].ToString();
                    textBox9.Text = sdr[3].ToString();
                    textBox7.Text = sdr[4].ToString();
                    label18.Text = month.ToString();



                }
                else
                {
                    panel1.Hide();                   
                }
            }                     
           
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //update stock button fun.
            panel1.Hide();
            panel9.Hide();
            panel10.Hide();
            panel3.Show();                                           
        }


      
        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button6_Click_1(Object sender, EventArgs e)
        {
            //update stock details
            string month = DateTime.Now.ToString("MMMM");
            con.Open();            
            int no =0;
            SqlCommand cmo = new SqlCommand("select max(no) from stock", con);
            SqlDataReader sdr = cmo.ExecuteReader(); 
            while(sdr.Read())
            {
                no = Convert.ToInt32(sdr[0].ToString());
                no += 1;
            }
            string mnth = label18.Text;
            SqlCommand cm = new SqlCommand("update stock set rice=rice+'"+ textBox10.Text+"', wheats=wheats+'"+ textBox8.Text+"', sugar=sugar+'"+ textBox6.Text+"', atta=atta+'"+ textBox9.Text+"', kerozine=kerozine+'"+ textBox7.Text+"',no=@no where month=@month ",con);                    
            
            cm.Parameters.AddWithValue("@no", no);
            cm.Parameters.AddWithValue("@month", month);
            sdr.Close();
            cm.ExecuteNonQuery();         
            con.Close();
            MessageBox.Show("Successfully updated");
            panel3.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //update quota button fun.
            panel1.Hide();
            panel3.Hide();          
            panel9.Show();
        }
               
        private void button8_Click(object sender, EventArgs e)
        {
            //update quota-> priority button fun.
            string m= DateTime.Now.ToString("MMMM");

            SqlCommand cn = new SqlCommand("select * from quota where category=@category and month=@month",con);
            string cate = "priority";
            cn.Parameters.AddWithValue("@category", cate);
            cn.Parameters.AddWithValue("@month", m);
            con.Open();
            SqlDataReader sr = cn.ExecuteReader();
            while(sr.Read())
            {
                textBox15.Text = sr[1].ToString();
                textBox13.Text = sr[2].ToString();
                textBox11.Text = sr[3].ToString();
                textBox12.Text = sr[4].ToString();
                textBox14.Text = sr[5].ToString();
            }
            panel9.Hide();

            string month = DateTime.Now.ToString("MMMM");
            label40.Text = month.ToString();

            panel10.Show();
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //update priority quota details
            int no=0;      
            string mnth = label40.Text;
            SqlCommand cmd = new SqlCommand("select * from quota where month=@mnth", con);
            cmd.Parameters.AddWithValue("@mnth", mnth);
            con.Open();
            SqlDataReader sd = cmd.ExecuteReader();
           // string categ = sd[0].ToString();                       
            if (sd.HasRows)
            {           
                sd.Close();
                SqlCommand cmo = new SqlCommand("Update quota set rice=@rice,wheats=@wheats,sugar=@sugar,kerozine=@kerozine,atta=@atta where month=@month and category=@category", con);                
                cmo.Parameters.AddWithValue("@rice", textBox15.Text);
                cmo.Parameters.AddWithValue("@wheats", textBox13.Text);
                cmo.Parameters.AddWithValue("@sugar", textBox11.Text);
                cmo.Parameters.AddWithValue("@kerozine", textBox12.Text);
                cmo.Parameters.AddWithValue("@atta", textBox14.Text);
                cmo.Parameters.AddWithValue("@month", label40.Text);
                cmo.Parameters.AddWithValue("@category", label38.Text);                
                cmo.ExecuteNonQuery();               
                MessageBox.Show("Successfully updated");
                panel10.Hide();
            }
            else
            {
                
                sd.Close();
                SqlCommand cm = new SqlCommand("select MAX(no) from quota", con);
                SqlDataReader dn = cm.ExecuteReader();
                while (dn.Read())
                {
                    string a = dn[0].ToString();
                    no = Convert.ToInt16(a.ToString());
                    no = no+1;
                   
                }
                SqlCommand cmo = new SqlCommand(@"insert into quota(category,rice,wheats,sugar,kerozine,atta,month,no) values ('" + label38.Text + "','" + textBox15.Text + "','" + textBox13.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox14.Text + "','" + label40.Text + "',@no)", con);
               
                cmo.Parameters.AddWithValue("@no",no);
                dn.Close();
                cmo.ExecuteNonQuery();               
                MessageBox.Show("Successfully updated");
                panel10.Hide();
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //update quota->nonpriority button fun.
            int no = 0;
            //panel11.Show();
            string month = DateTime.Now.ToString("MMMM");
            SqlCommand cn = new SqlCommand("select * from quota where category=@category and month=@month", con);
            string cate = "Nonpriority";
            cn.Parameters.AddWithValue("@category", cate);
            cn.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sr = cn.ExecuteReader();
            while (sr.Read())
            {
                textBox20.Text = sr[1].ToString();
                textBox18.Text = sr[2].ToString();
                textBox16.Text = sr[3].ToString();
                textBox17.Text = sr[4].ToString();
                textBox19.Text = sr[5].ToString();
            }
            panel9.Hide();

           // string month = DateTime.Now.ToString("MMMM");
            label41.Text = month.ToString(); 
                                 
            panel11.Show();
            con.Close();           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //update non priority button fun.
            int no=0;
            string mnth = DateTime.Now.ToString("MMMM");
            string cate = "Nonpriority";
            SqlCommand cmd = new SqlCommand("select * from quota where month=@mnth and category=@category", con);
            cmd.Parameters.AddWithValue("@mnth", mnth);
            cmd.Parameters.AddWithValue("@category", cate);
            con.Open();
            SqlDataReader sd = cmd.ExecuteReader();
            
            if (sd.HasRows)
            {
                sd.Close();              
                SqlCommand cmo = new SqlCommand("Update quota set rice=@rice,wheats=@wheats,sugar=@sugar,kerozine=@kerozine,atta=@atta where month=@month and category=@category", con);
                cmo.Parameters.AddWithValue("@rice", textBox20.Text);
                cmo.Parameters.AddWithValue("@wheats", textBox18.Text);
                cmo.Parameters.AddWithValue("@sugar", textBox16.Text);
                cmo.Parameters.AddWithValue("@kerozine", textBox17.Text);
                cmo.Parameters.AddWithValue("@atta", textBox19.Text);
                cmo.Parameters.AddWithValue("@month", label41.Text);
                cmo.Parameters.AddWithValue("@category", label43.Text);
                cmo.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                panel11.Hide();
            }
            else
            {
                sd.Close();
                SqlCommand cm = new SqlCommand("select MAX(no) from quota", con);
                SqlDataReader dn = cm.ExecuteReader();
                while (dn.Read())
                {
                    string a = dn[0].ToString();
                    no = Convert.ToInt16(a.ToString());
                    no = no + 1;

                }               
                SqlCommand cmo = new SqlCommand(@"insert into quota(category,rice,wheats,sugar,kerozine,atta,month,no) values ('" + label43.Text + "','" + textBox20.Text + "','" + textBox18.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox19.Text + "','" + label41.Text + "',@no)", con);
                cmo.Parameters.AddWithValue("@no", no);
                dn.Close();
                cmo.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                panel11.Hide();
            }
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration2 b = new eration2();
            b.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }
}
