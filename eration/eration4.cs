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
using System.IO;
using System.Net;
using System.Web;

namespace eration
{
    public partial class eration4 : MetroFramework.Forms.MetroForm
    {
        public eration4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");       
        private void button1_Click(object sender, EventArgs e)
        {
            //back button
            this.Hide();
            eration3 a = new eration3();//admin window
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //logout button
            panel6.Show();
        }

        private void eration4_Load(object sender, EventArgs e)
        {
            panel6.Hide();

            label23.Text = DateTime.Now.ToString("MMMM");

            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            byte[] img = new byte[0];
            while (sdr.Read())
            {
                string col1Value = sdr[0].ToString();
                label15.Text = col1Value;

                label17.Text = sdr[3].ToString();

                label18.Text = sdr[1].ToString();

                label21.Text = sdr[9].ToString();               
                
                    img = (byte[])(sdr[15]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = Image.FromStream(ms);
                
            }
            sdr.Close();        

            string card = label15.Text;
            SqlCommand cdm = new SqlCommand("select * from sale where cardno=@cardno", con);
            cdm.Parameters.AddWithValue("@cardno", card);
            SqlDataReader srd = cdm.ExecuteReader();
            while(srd.Read())
            {
                    textBox1.Text = srd[2].ToString();
                    textBox2.Text = srd[3].ToString();
                    textBox3.Text = srd[4].ToString();
                    textBox4.Text = srd[6].ToString();
                    textBox5.Text = srd[5].ToString();               
            }
            srd.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //find more details
            this.Hide();
            eration9 a = new eration9();
            a.Show();
        }
        public void sendMessage(string phoneNo, string message)    //messaging fun
        {
                string url = "http://login.bulksmsgateway.in/sendmessage.php";
                string result = "";
                message = HttpUtility.UrlPathEncode(message);
                
                String strPost = "?user=" + HttpUtility.UrlPathEncode("albinth1") + "&password=" + HttpUtility.UrlPathEncode("@kavilpurayidam") + "&sender=" + HttpUtility.UrlPathEncode("xxERxx") + "&mobile=" + HttpUtility.UrlPathEncode(phoneNo) + "&type=" + HttpUtility.UrlPathEncode("3") + "&message=" + message;
            //writes a string to stream
                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url + strPost);//httpwebrequest provides an http implementation of webrequest class
                //webrequest class makes a request to a url (URL)
                objRequest.Method = "POST";  //deffine request methods get or post
                objRequest.ContentLength = Encoding.UTF8.GetByteCount(strPost);
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());//writes character as stream in a particular encoding 
                    myWriter.Write(strPost);
                }
                catch (Exception e)
                {
                   // MessageBox.Show(e.Message);
                }
                finally
                {
                    myWriter.Close();
                }
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    //MessageBox.Show(result);
                    // Close and clean up the StreamReader sr.Close();
                }
            // result;
           // MessageBox.Show("Updated");
           // this.Hide();
           // eration3 a = new eration3();
           //  a.Show();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save button
            //update the data enter into the textbox to the sale table
            string message=null;
            string phoneNo=null;
            con.Open();  //open connection con  
            string month = DateTime.Now.ToString("MMMM");  //assaign current month to variable month

            SqlCommand cdm = new SqlCommand("select * from sale where cardno=@cardno and month=@month",con);
            cdm.Parameters.AddWithValue("@cardno", label15.Text);
            cdm.Parameters.AddWithValue("@month", month);
            SqlDataReader sd = cdm.ExecuteReader();           
            if (sd.HasRows)
            {
                sd.Close();                
                string card = label15.Text;        
                SqlCommand cmd = new SqlCommand("update sale set rice=rice+'"+ textBox1.Text+"', wheats=wheats+'"+textBox2.Text+"',sugar=sugar+'"+textBox3.Text+"',atta=atta+'"+ textBox5.Text+"', kerozine=kerozine+'"+ textBox4.Text+"' where cardno=@cardno and month=@month", con);               
                cmd.Parameters.AddWithValue("@cardno", card);
                cmd.Parameters.AddWithValue("@month", month);
                sd.Close();
                cmd.ExecuteNonQuery();               

                string category = label21.Text;
                string mnth = DateTime.Now.ToString("MMMM");   //assaign current month to variable month

                SqlConnection con2 = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;"); //connection for second sqldatareader of this method
                SqlCommand sdc =new SqlCommand("Select * from quota where category=@category and month=@month",con2);

                //add parameter to the sqlcommand  @categoery and @month   
                            
                sdc.Parameters.AddWithValue("@category", category);  
                sdc.Parameters.AddWithValue("@month", mnth);
                con2.Open(); //opening connection con2
                SqlDataReader smd = sdc.ExecuteReader();

                while (smd.Read())
                {
                    sd.Close();  //closing sd sqldatareader                                               
                    message = "E-ration   Month=" + label23.Text + "   Rice= " + textBox1.Text + "("+smd[1].ToString()+")    Wheats= " + textBox2.Text + "(" + smd[2].ToString() + ")   Sugar= " + textBox3.Text + "(" + smd[3].ToString() + ")   Atta= " + textBox5.Text + "(" + smd[5].ToString() + ")   Kerozine= " + textBox4.Text + "(" + smd[4].ToString() + ")";
                    SqlCommand ssm = new SqlCommand("select phoneno from details where cardno=(select cardno from card where id=1)", con);                   
                    SqlDataReader sr = ssm.ExecuteReader();
                    while (sr.Read())
                    {
                        phoneNo = sr[0].ToString();
                        //MessageBox.Show(sr[0].ToString());
                       
                    }
                    sr.Close();                   
                    MessageBox.Show("Updated");                   
                }
               
                con2.Close();  //closing connection con2
                smd.Close();                
            }
            else
            {
                sd.Close();
                SqlCommand cm = new SqlCommand(@"insert into sale(cardno,month,rice,wheats,sugar,atta,kerozine) values ('"+label15.Text+"',@month,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "')", con);              
                cm.Parameters.AddWithValue("@month", month);
                cm.ExecuteNonQuery();                
                MessageBox.Show("Saved");
                //sendMessage(phoneNo, message);
            }
            SqlCommand cdo = new SqlCommand("select * from ttlsale where month=@month", con);
            cdo.Parameters.AddWithValue("@month", month);           
            SqlDataReader dt = cdo.ExecuteReader();
            if (dt.HasRows)
            {
                SqlCommand cmo = new SqlCommand("update ttlsale set rice=rice+'"+ textBox1.Text+"', wheats=wheats+'"+ textBox2.Text+"', sugar=sugar+'"+ textBox3.Text+"', atta=atta+'"+ textBox5.Text+"', kerozine=kerozine+'"+ textBox4.Text+"' where month=@month", con);
               
                cmo.Parameters.AddWithValue("@month", month);
                dt.Close();
                cmo.ExecuteNonQuery();
            }
            else
            {
                int no = 0;
                dt.Close();
                SqlCommand cc = new SqlCommand("select max(no) from ttlsale", con);
                SqlDataReader da = cc.ExecuteReader();
                while(da.Read())
                {
                    no = Convert.ToInt32(da[0].ToString());
                    no = no + 1;
                }
                SqlCommand cm = new SqlCommand(@"insert into ttlsale(month,rice,wheats,sugar,atta,kerozine,no) values (@month,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "',@no)", con);
                cm.Parameters.AddWithValue("@month", month);
                cm.Parameters.AddWithValue("@no", no);
                da.Close();
                cm.ExecuteNonQuery();
            }
            dt.Close();
            sendMessage(phoneNo, message);    //calling function sendMessage for msg service        
            con.Close();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.ToString("MMMM");                                        
            string category = label21.Text;
            SqlCommand b = new SqlCommand("select rice from quota where category=@category and month=@month", con);
            con.Open();
            b.Parameters.AddWithValue("@category", category);
            b.Parameters.AddWithValue("@month", month);
            SqlDataReader x = b.ExecuteReader();           
            while (x.Read())
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Quota is:"+x[0].ToString());
                }
                else
                {
                    int m = Convert.ToInt32(textBox1.Text);
                    int n = Convert.ToInt32(x[0].ToString());
                   // MessageBox.Show(m.ToString());
                    //if (string.Compare(first, second) == 0)    
                    if (m == n || m > n)
                    {
                        textBox1.ReadOnly = true;
                        MessageBox.Show("Rice quota override");
                    }
                    else
                    {
                        MessageBox.Show("Quota is: " + x[0].ToString());
                    }
                }
              }
               
                
            x.Close();
            con.Close();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.ToString("MMMM");
            string category = label21.Text;

            SqlCommand b = new SqlCommand("select wheats from quota where category=@category and month=@month", con);
            con.Open();
            b.Parameters.AddWithValue("@category", category);
            b.Parameters.AddWithValue("@month", month);
            SqlDataReader y = b.ExecuteReader();
            while (y.Read())
            {
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Quota is:" + y[0].ToString());
                }
                else
                {
                    int m = Convert.ToInt32(textBox2.Text);
                    int n = Convert.ToInt32(y[0].ToString());
                    //MessageBox.Show(m.ToString());
                    //if (string.Compare(first, second) == 0)    
                    if (m == n || m > n)
                    {
                        textBox1.ReadOnly = true;
                        MessageBox.Show("Rice quota override");
                    }
                    else
                    {
                        MessageBox.Show("Quota is: " + y[0].ToString());
                    }
                }               
            }
            y.Close();
            con.Close();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.ToString("MMMM");          
            string category = label21.Text;

            SqlCommand b = new SqlCommand("select sugar from quota where category=@category and month=@month", con);
            con.Open();
            b.Parameters.AddWithValue("@category", category);
            b.Parameters.AddWithValue("@month", month);
            SqlDataReader y = b.ExecuteReader();
            while (y.Read())
            {
                if (String.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Quota is:" + y[0].ToString());
                }
                else
                {
                    int m = Convert.ToInt32(textBox3.Text);
                    int n = Convert.ToInt32(y[0].ToString());                     
                    if (m == n || m > n)
                    {
                        textBox1.ReadOnly = true;
                        MessageBox.Show("Rice quota override");
                    }
                    else
                    {
                        MessageBox.Show("Quota is: " + y[0].ToString());
                    }
                }
            }           
            y.Close();
            con.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.ToString("MMMM");           
            string category = label21.Text;

            SqlCommand b = new SqlCommand("select kerozine from quota where category=@category and month=@month", con);
            con.Open();
            b.Parameters.AddWithValue("@category", category);
            b.Parameters.AddWithValue("@month", month);
            SqlDataReader y = b.ExecuteReader();
            while (y.Read())
            {
                if (String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Quota is:" + y[0].ToString());
                }
                else
                {
                    int m = Convert.ToInt32(textBox4.Text);
                    int n = Convert.ToInt32(y[0].ToString());
                    //MessageBox.Show(m.ToString());
                    //if (string.Compare(first, second) == 0)    
                    if (m == n || m > n)
                    {
                        textBox1.ReadOnly = true;
                        MessageBox.Show("Rice quota override");
                    }
                    else
                    {
                        MessageBox.Show("Quota is: " + y[0].ToString());
                    }
                }
            }

            
            y.Close();
            con.Close();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.ToString("MMMM");           
            string category = label21.Text;

            SqlCommand b = new SqlCommand("select atta from quota where category=@category and month=@month", con);
            con.Open();
            b.Parameters.AddWithValue("@category", category);
            b.Parameters.AddWithValue("@month", month);
            SqlDataReader y = b.ExecuteReader();
            while (y.Read())
            {
                if (String.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Quota is:" + y[0].ToString());
                }
                else
                {
                    int m = Convert.ToInt32(textBox5.Text);
                    int n = Convert.ToInt32(y[0].ToString());
                    //MessageBox.Show(m.ToString());
                    //if (string.Compare(first, second) == 0)    
                    if (m == n || m > n)
                    {
                        textBox1.ReadOnly = true;
                        MessageBox.Show("Rice quota override");
                    }
                    else
                    {
                        MessageBox.Show("Quota is: " + y[0].ToString());
                    }
                }
            }

           
            y.Close();
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //logout confirmation
            this.Hide();
            eration2 b = new eration2();//login window
            b.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
