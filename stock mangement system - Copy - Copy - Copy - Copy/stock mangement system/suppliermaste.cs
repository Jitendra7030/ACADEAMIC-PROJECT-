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
    public partial class suppliermaste : Form
    {
        private OleDbConnection supp;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;
        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";
        public suppliermaste()
        {
            //create connection using parameter from mdsaputra.udl
            supp = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textsID.Text == "" || textsname.Text == "" || textsaddress.Text == "" || textscity.Text == "" || textscontact.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into suppliermaster (sID, sname, saddress, scity, scontact) values ('" + this.textsID.Text + "','" + this.textsname.Text + "','" + this.textsaddress.Text + "','" + this.textscity.Text + "','" + this.textscontact.Text + "');";
                    supp.Open();
                    oleDbCmd.Connection = supp;
                    oleDbCmd.ExecuteNonQuery();
                    supp.Close();


                    textsID.Text = "";
                    textsname.Text = "";
                    textsaddress.Text = "";
                    textscity.Text = "";
                    textscontact.Text = "";


                    MessageBox.Show("Data Entered Succssfully...");

                }
            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }
        }

        private void suppliermaste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.suppliermaster' table. You can move, or remove it, as needed.
            this.suppliermasterTableAdapter.Fill(this.management_finalDataSet.suppliermaster);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select sID from suppliermaster where sID like '%" + textBox1.Text + "%'", supp);
            try
            {


                supp.Open();
                AutoCompleteStringCollection srch1 = new AutoCompleteStringCollection();
                rdr = oleDbCmd.ExecuteReader();
                while (rdr.Read())
                {
                    srch1.Add(rdr[0].ToString());
                }

                textBox1.AutoCompleteCustomSource = srch1;
            }
            catch
            {
                MessageBox.Show("refersh....");
            }
            supp.Close();
        }

        private void button5_Click(object sender, EventArgs e)

        {
            try
            {
                if (true)
                {
                    oleDbCmd = new OleDbCommand("select * from suppliermaster where sname ='" + textBox1.Text + "'", supp);
                    supp.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        textsID.Text = rdr[0].ToString();
                        textsname.Text = rdr[1].ToString();
                        textsaddress.Text = rdr[2].ToString();
                        textscity.Text = rdr[3].ToString();
                        textscontact.Text = rdr[4].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                }
                supp.Close();
            }




            catch
            {
                MessageBox.Show("Wait");
            }
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textsID.Text = "";
            textsname.Text = "";
            textsaddress.Text = "";
            textscity.Text = "";
            textscontact.Text = "";
            textBox1.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    oleDbCmd = new OleDbCommand("select * from suppliermaster where sname ='" + textBox1.Text + "'", supp);
                    supp.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        textsID.Text = rdr[0].ToString();
                        textsname.Text = rdr[1].ToString();
                        textsaddress.Text = rdr[2].ToString();
                        textscity.Text = rdr[3].ToString();
                        textscontact.Text = rdr[4].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                }
                supp.Close();
            }




            catch
            {
                MessageBox.Show("Wait");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textsID.Text == "" || textsname.Text == "" || textsaddress.Text == "" || textscity.Text == "" || textscontact.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into suppliermaster (sID, sname, saddress, scity, scontact) values ('" + this.textsID.Text + "','" + this.textsname.Text + "','" + this.textsaddress.Text + "','" + this.textscity.Text + "','" + this.textscontact.Text + "');";
                    supp.Open();
                    oleDbCmd.Connection = supp;
                    oleDbCmd.ExecuteNonQuery();
                    supp.Close();


                    textsID.Text = "";
                    textsname.Text = "";
                    textsaddress.Text = "";
                    textscity.Text = "";
                    textscontact.Text = "";


                    MessageBox.Show("Data Entered Succssfully...");

                }
            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }
    }
}