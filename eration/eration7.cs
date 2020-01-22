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
    public partial class eration7 : MetroFramework.Forms.MetroForm
    {
        public eration7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");

        private void eration7_Load(object sender, EventArgs e)
        {
            //hiding all panels in the window on startig
            panel10.Hide();
            panel6.Hide();
            panel3.Hide();
            panel5.Hide();
            panel2.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check stock button
            panel10.Hide();
            panel2.Hide();
            panel7.Hide();
            panel6.Show();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check quota button
            panel10.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel2.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // checke sale button function
            panel10.Hide();
            panel2.Hide();
            panel3.Hide();
            panel6.Hide();
            panel7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
        }

        private void eration7_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel2.Hide();
            panel6.Hide();
            panel7.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel9.Show();            

        }

        //checking each month stock information
        private void button6_Click(object sender, EventArgs e)
        {
            //panel6.Hide();
            panel5.Hide();
            string month = "January";            
            SqlCommand cms = new SqlCommand("select * from stock where month=@month",con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)//check sqldatareader contain any row
            {
                while (sdr.Read())//advances the sqldatareader(here sdr) to read next record
                {
                    if (sdr[1] != DBNull.Value) //check the second row of the sdr is null
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            panel5.Hide();
            //panel6.Hide();
            string month = "February";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)//check sqldatareader contain ny row
            {
                while (sdr.Read())//advances the sqldatareader to read next record (sdr)
                {
                    if (sdr[1] != DBNull.Value) //check value of sdr[1] is null
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            panel5.Hide();
            string month = "March";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "April";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)//check sdr contains any row
            {
                while (sdr.Read())  //advances the sqldatareader to read next record
                {
                    if (sdr[1] != DBNull.Value)//check sdr[1] value is null
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "May";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "June";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if(sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value) //check sdr[1] value is null
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
                }
                else
                {
                    MessageBox.Show("No stock information available");
                }
            
            sdr.Close();
            con.Close();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "July";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())//advances the sdr to read next record
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "August";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "September";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            } 
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "October";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            string month = "November";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cms.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[1] != DBNull.Value)
                    {
                        label48.Text = sdr[1].ToString();
                        label43.Text = sdr[2].ToString();
                        label42.Text = sdr[3].ToString();
                        label40.Text = sdr[4].ToString();
                        label41.Text = sdr[5].ToString();
                        panel5.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // panel5.Hide();
            string month = "December";
            SqlCommand cms = new SqlCommand("select * from stock where month=@month", con);
            cms.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sr = cms.ExecuteReader();
            if (sr.HasRows)
            {
                while (sr.Read())
                {
                    if (sr[0] != DBNull.Value)
                    {

                        label48.Text = sr[1].ToString();
                        label43.Text = sr[2].ToString();
                        label42.Text = sr[3].ToString();
                        label40.Text = sr[4].ToString();
                        label41.Text = sr[5].ToString();
                        panel5.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("No stock information available");
            }
           
            sr.Close();
            con.Close();
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }


        //checking quota information of each month
        private void button30_Click(object sender, EventArgs e)
        {
            string month = "January";           
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter(); //sqldataadapeter make a communication b/w datacommands and database
            sda.SelectCommand = cmd;           
            DataTable dt = new DataTable(); //datatable store a entire table
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text =   dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text =dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();                 
                }            
                panel3.Show();
            }
            con.Close();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string month = "February";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");
               
            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "March";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            //another form
            //sqlDatAadapter sda=new SqlDataAdapter("select * from quota where month=@month", con);

            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "April";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "May";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "June";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "July";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }

                panel3.Show();
            }
            con.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            panel3.Hide();
            string month = "August";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "September";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "October";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "November";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            string month = "December";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from quota where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No quota information available");

            }
            else
            {
                if (String.Compare(dt.Rows[0][0].ToString(), "priority") == 0)
                {
                    label3.Text = "Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                else if (String.Compare(dt.Rows[0][0].ToString(), "nonpriority") == 0)
                {
                    label3.Text = "Non Priority";

                    label9.Text = dt.Rows[0][1].ToString();

                    label10.Text = dt.Rows[0][2].ToString();

                    label11.Text = dt.Rows[0][3].ToString();

                    label12.Text = dt.Rows[0][4].ToString();

                    label13.Text = dt.Rows[0][5].ToString();
                }
                if (String.Compare(dt.Rows[1][0].ToString(), "nonpriority") == 0)
                {
                    label19.Text = "Non Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                else if (String.Compare(dt.Rows[1][0].ToString(), "Priority") == 0)
                {
                    label19.Text = "Priority";

                    label29.Text = dt.Rows[1][1].ToString();

                    label28.Text = dt.Rows[1][2].ToString();

                    label27.Text = dt.Rows[1][3].ToString();

                    label26.Text = dt.Rows[1][4].ToString();

                    label25.Text = dt.Rows[1][5].ToString();
                }
                panel3.Show();
            }
            con.Close();
        }

        //check total sale information of each month
        private void button42_Click(object sender, EventArgs e)
        {
            string month = "January";
            label1.Text = month.ToString();
            panel8.Hide();
            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)//checking sdr conain any row
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel8.Hide();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "February";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "March";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {

            panel8.Hide();
            string month = "April";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "May";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "June";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "July";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from sale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "August";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from sale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)  //check any row available in sqldatareader after excecution of the query
            {
                while (sdr.Read())
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "September";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows) //check any row available in sqldatareader after excecution of the query
            {
                while (sdr.Read()) //advances the sqldatareader to read record
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "October";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)   //check any row available in sqldatareader after excecution of the query
            {
                while (sdr.Read())//advances the sqldatareader to read next record
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "November";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)  //check any row available in sqldatareader after excecution of the query
            {
                while (sdr.Read())    //advances the sqldatareader to read next record
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();//sqldatareader sdr closing
            con.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            string month = "December";
            label1.Text = month.ToString();

            SqlCommand cmd = new SqlCommand("select rice,wheats,sugar,atta,kerozine from ttlsale where month=@month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())    //advances the sqldatareader(sdr) to read next record
                {
                    if (sdr[0] != DBNull.Value)
                    {
                        label78.Text = sdr[0].ToString();
                        label73.Text = sdr[1].ToString();
                        label72.Text = sdr[2].ToString();
                        label70.Text = sdr[3].ToString();
                        label71.Text = sdr[4].ToString();
                        panel8.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("No sale details or till no sale is occured");
            }
            
            sdr.Close();
            con.Close();
        }

       

        private void button45_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration2 a = new eration2();
            a.Show();
        }
         
        private void button44_Click(object sender, EventArgs e)
        {
            panel9.Hide();
        }             
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
            panel6.Hide();
            panel7.Hide();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //print button function
            panel7.Hide();
            panel2.Hide();
            panel3.Hide();
            panel6.Hide();
            panel10.Show();            
        }       

        private void button48_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration12 c = new eration12();//print qouta details window
            c.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration13 d = new eration13();//print sale details window
            d.Show();
        }

        private void Print_sale_Click(object sender, EventArgs e)
        {           
            this.Hide();
            eration11 a = new eration11();//print stock details window
            a.Show();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
