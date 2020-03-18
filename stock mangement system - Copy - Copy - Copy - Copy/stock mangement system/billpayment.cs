using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace stock_mangement_system
{
    public partial class billpayment : Form
    {
        private OleDbConnection add;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;

        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";
        public billpayment()
        {
            //create connection using parameter from mdsaputra.udl
            add = new OleDbConnection(connParam);
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void billpayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.addstock' table. You can move, or remove it, as needed.
            this.addstockTableAdapter.Fill(this.management_finalDataSet.addstock);

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                if (textpno.Text == "" || textpname.Text == "" || textpcompanyname.Text == "" || textptypeprodct.Text == "" || textpsellamount.Text == "" || textBox1.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else

                {


                    Graphics g = this.CreateGraphics();
                    bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                    Graphics mg = Graphics.FromImage(bmp);
                    mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                    printPreviewDialog1.ShowDialog();
                }

            }
            catch
            {
                MessageBox.Show("WAIT");
            }
        } 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textpno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpname.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else if (true)
                {
                    oleDbCmd = new OleDbCommand("select * from addstock where pname ='" + textpname.Text + "'", add);
                    add.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {


                        textpno.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textpcompanyname.Text = rdr[2].ToString();

                        textptypeprodct.Text = rdr[4].ToString();
                        textpsellamount.Text = rdr[5].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    add.Close();
                }
            }
            catch
            {
                MessageBox.Show("WAIT");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void textpname_TextChanged(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select pno from addstock where pno like '%" + textpname.Text + "%'", add);
            try
            {


                add.Open();
                AutoCompleteStringCollection srch1 = new AutoCompleteStringCollection();
                rdr = oleDbCmd.ExecuteReader();
                while (rdr.Read())
                {
                    srch1.Add(rdr[0].ToString());
                }

                textpname.AutoCompleteCustomSource = srch1;
            }
            catch
            {
                MessageBox.Show("refersh....");
            }
            add.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textpcompanyname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
