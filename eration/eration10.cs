using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace eration
{
    public partial class eration10 : MetroFramework.Forms.MetroForm
    {
        public eration10()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");
        private void eration10_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            SqlCommand cmd = new SqlCommand("select * from details where cardno=(select cardno from card where id=1)", con);
            con.Open();  //make connection open
            SqlDataReader sdr = cmd.ExecuteReader();
            byte[] img = null;  //declaring byte type array to store image in binary format
            while (sdr.Read())
            {

                string col1Value = sdr[0].ToString(); //assigning 1st column name to col1Value

                textBox1.Text = col1Value;
                //toString is used to convert data into string type

                textBox2.Text = sdr[1].ToString();   //assigning value to the textbox

                textBox3.Text = sdr[2].ToString();

                textBox4.Text = sdr[11].ToString();

                textBox5.Text = sdr[12].ToString();

                textBox6.Text = sdr[4].ToString();

                textBox7.Text = sdr[5].ToString();

                textBox8.Text = sdr[13].ToString();

                //dateTimePicker1. = sdr[13];

                textBox9.Text = sdr[7].ToString();

                textBox10.Text = sdr[6].ToString();

                // textBox11.Text = sdr[10].ToString();

                textBox12.Text = sdr[3].ToString();

                textBox13.Text = sdr[8].ToString();

                textBox15.Text = sdr[10].ToString();

                textBox14.Text = sdr[9].ToString();

                //display image   
                if (sdr[15] !=DBNull.Value)
                {
                    img = (byte[])(sdr[15]);
                    MemoryStream ms = new MemoryStream(img);
                    imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagebox.Image = Image.FromStream(ms);
                }
            }
            sdr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration2 b = new eration2();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration3 a = new eration3();
            a.Show();
        }
    }
}
