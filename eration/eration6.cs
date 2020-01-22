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

namespace eration
{
    public partial class eration6 :MetroFramework.Forms.MetroForm
    {
        public eration6()
        {
            InitializeComponent();            

        }
        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");

       public string imgloc=null;       
       public byte[] img = null;



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //image browsing button function
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgloc = openFileDialog1.FileName.ToString();
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.ImageLocation = imgloc;
                    textBox9.Text = imgloc.ToString();
                }
                
            }
            catch (System.ArgumentException ae)
            {                
                MessageBox.Show(ae.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           // byte[] img = null;
           // FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
           // BinaryReader br = new BinaryReader(fs);
          //  img = br.ReadBytes((int)fs.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //back button fun
            this.Hide();            
            eration3 a = new eration3();//admin window
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //log out button
            panel1.Show();
                         
        }

        private void eration6_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            textBox9.Text = null;
            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
        

            while (sdr.Read())
            {

                string col1Value = sdr[0].ToString();
                // string cardno = sdr.GetString(0);
                label17.Text = col1Value;
               
                textBox1.Text = sdr[1].ToString();

                textBox2.Text = sdr[2].ToString();

                textBox13.Text = sdr[11].ToString();

                textBox3.Text = sdr[3].ToString();

                textBox4.Text = sdr[4].ToString();

                textBox5.Text = sdr[5].ToString();

                textBox6.Text = sdr[13].ToString();
               
                textBox7.Text = sdr[7].ToString();

                textBox8.Text = sdr[6].ToString();

                textBox10.Text = sdr[14].ToString();

                textBox11.Text = sdr[10].ToString();

                textBox12.Text = sdr[12].ToString();

               
                //displaying image
               
                img = (byte[])(sdr[15]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = Image.FromStream(ms);
             
                
                
               
            }
            sdr.Close();          
            con.Close();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //logout confirmation button
                    this.Hide();
                    eration2 b = new eration2();
                    b.Show();                            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //update button function
            if (textBox9.Text != null)
            {
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
            try
            {                
                    string query = "update details set head=@head,address=@address,panchayath=@panchayath,ward=@ward,house=@house,no=@no,income=@income,phoneno=@phoneno,gender=@gender,dob=@dob,job=@job,wheel=@wheel,image=@img where cardno=@cardno";//upadate details in details table
                    SqlCommand cmd = new SqlCommand(query, con);
                
               
                con.Open();
                //provides value to the parameters of the query
                cmd.Parameters.Add(new SqlParameter("@cardno", label17.Text));
                cmd.Parameters.Add(new SqlParameter("@head", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@address", textBox2.Text));
                cmd.Parameters.Add(new SqlParameter("@panchayath", textBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@ward", textBox4.Text));
                cmd.Parameters.Add(new SqlParameter("@house", textBox5.Text));
                cmd.Parameters.Add(new SqlParameter("@no", textBox8.Text));
                cmd.Parameters.Add(new SqlParameter("@income", textBox7.Text));
                cmd.Parameters.Add(new SqlParameter("@phoneno", textBox11.Text));
                cmd.Parameters.Add(new SqlParameter("@gender", textBox13.Text));
                cmd.Parameters.Add(new SqlParameter("@dob", textBox12.Text));
                cmd.Parameters.Add(new SqlParameter("@job", textBox6.Text));
                cmd.Parameters.Add(new SqlParameter("@wheel", textBox10.Text));               
                cmd.Parameters.Add(new SqlParameter("@img", img));
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Sucesfully Updated");
            this.Hide();
            eration3 b = new eration3();//admin window
            b.Show();
        }

       
    }
}
