using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eration
{
    public partial class eration11 : MetroFramework.Forms.MetroForm
    {
        public eration11()
        {
            InitializeComponent();
        }
        // SqlConnection con = new SqlConnection(@"Data Source=ATHIRA-PC\SQLEXPRESS;Initial Catalog=eration;Integrated Security=True;");
        private void eration11_Load(object sender, EventArgs e)
        {
            using (erationEntities28 db = new erationEntities28())
            {
                ttlsaleBindingSource.DataSource = db.ttlsales.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Sale Deatils";
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            print.SubTitle = datevalue.Year.ToString();
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "e-ration"; //footer
            print.FooterSpacing = 25;
            print.PrintDataGridView(dataGridView1);
            this.Hide();
            eration7 a = new eration7();
            a.Show();
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration7 a = new eration7();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            eration2 b = new eration2();
            b.Show();
        }
    }
}
