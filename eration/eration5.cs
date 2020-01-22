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
    public partial class eration5 : MetroFramework.Forms.MetroForm
    {
        public eration5()
        {
            InitializeComponent();
        }

        
        string imgloc;
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            eration3 c = new eration3();
            c.Show();
        }

        private void eration5_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration2 b = new eration2();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //image browse buttin
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog(); 
                openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG";  //filtering images
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgloc = openFileDialog1.FileName.ToString();
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.ImageLocation = imgloc;
                    textBox11.Text = imgloc.ToString();
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
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //save button function
            try
            {
                byte[] img = null;

                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter name");
                }
                else if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Enter address");
                }
                else if (String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Enter gender");
                }
                else if (String.IsNullOrEmpty(textBox13.Text))
                {
                    MessageBox.Show("Enter date of birth");
                }
                else if (String.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Enter Name of panchayath/Muncipality");
                }
                else if (String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Enter ward number");
                }
                else if (String.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Enter house number");
                }
                else if (String.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Enter job");
                }
                else if (String.IsNullOrEmpty(textBox7.Text))
                {
                    MessageBox.Show("Enter income");
                }
                else if (String.IsNullOrEmpty(textBox8.Text))
                {
                    MessageBox.Show("Enter number of person");
                }
                else if (String.IsNullOrEmpty(textBox9.Text))
                {
                    MessageBox.Show("Enter vehicle type");
                }
                else if (String.IsNullOrEmpty(textBox12.Text))
                {
                    MessageBox.Show("Enter phone number");
                }
                else if (String.IsNullOrEmpty(textBox11.Text))
                {
                    MessageBox.Show("Browse a picture");
                }

                else
                {
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read); //create a stream contain information of the image
                    BinaryReader br = new BinaryReader(fs);  //convert stream into binary 
                    img = br.ReadBytes((int)fs.Length);
                    // br.Close();

                    this.Hide();
                    SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");  //creating connection
                    try
                    {
                        con.Open();//connection open
                        string query = "insert into apply(name,address,panchayath,ward,house,no,income,phoneno,gender,dob,job,wheel,image) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox12.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox6.Text + "','" + textBox9.Text + "',@img)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@img", img); //provide a value to the @img parameter
                        cmd.ExecuteNonQuery();  //query excecuting
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Sucesfully applied for new ration card");
                    eration3 a = new eration3();
                    a.Show();
                }

            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
