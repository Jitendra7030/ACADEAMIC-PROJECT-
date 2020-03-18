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

    public partial class productmaster : Form
    {
        private OleDbConnection prod;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;

        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=C:\Users\hp\Desktop\stock mangement system - Copy - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";

        public productmaster()
        {
            //create connection using parameter from mdsaputra.udl
            prod = new OleDbConnection(connParam);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            try
            {
                if (textpID.Text == "" || textpname.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into productmaster (pID, pname, ptype, pcompany, pprice, pdes) values ('" + this.textpID.Text + "','" + this.textpname.Text + "','" + this.textptype.Text + "','" + this.textpcompany.Text + "','" + this.textpprice.Text + "','" + this.textpdes.Text + "');";
                    prod.Open();
                    oleDbCmd.Connection = prod;
                    oleDbCmd.ExecuteNonQuery();

                    prod.Close();


                    textpID.Text = "";
                    textpname.Text = "";
                    textptype.Text = "";
                    textpcompany.Text = "";
                    textpprice.Text = "";
                    textpdes.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Enter..");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void productmaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.productmaster' table. You can move, or remove it, as needed.
            this.productmasterTableAdapter.Fill(this.management_finalDataSet.productmaster);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void stockmangementDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void textpdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select pID from productmaster where pID like '%" + textBox1.Text + "%'", prod);
            try
            {


                prod.Open();
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
            prod.Close();
        }

        private void butser_Click(object sender, EventArgs e)
        {
            try
            {


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from productmaster where pname ='" + textBox1.Text + "'", prod);
                    prod.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {



                        textpID.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textptype.Text = rdr[2].ToString();
                        textpcompany.Text = rdr[3].ToString();
                        textpprice.Text = rdr[4].ToString();
                        textpdes.Text = rdr[5].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    prod.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wait......");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butser_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from productmaster where pname ='" + textBox1.Text + "'", prod);
                    prod.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {



                        textpID.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textptype.Text = rdr[2].ToString();
                        textpcompany.Text = rdr[3].ToString();
                        textpprice.Text = rdr[4].ToString();
                        textpdes.Text = rdr[5].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    prod.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wait......");
            }
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpID.Text == "" || textpname.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into productmaster (pID, pname, ptype, pcompany, pprice, pdes) values ('" + this.textpID.Text + "','" + this.textpname.Text + "','" + this.textptype.Text + "','" + this.textpcompany.Text + "','" + this.textpprice.Text + "','" + this.textpdes.Text + "');";
                    prod.Open();
                    oleDbCmd.Connection = prod;
                    oleDbCmd.ExecuteNonQuery();

                    prod.Close();


                    textpID.Text = "";
                    textpname.Text = "";
                    textptype.Text = "";
                    textpcompany.Text = "";
                    textpprice.Text = "";
                    textpdes.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Enter..");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select pname from productmaster where pname like '%" + textBox1.Text + "%'", prod);
            try
            {


                prod.Open();
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
            prod.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textpID.Text == "" || textpname.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE productmaster
                                                    SET pname = @pname,
                                                         ptype = @ptype,
                                                        pcompany = @pcompany,     
                                                        pprice = @pprice,
                                                        pdes = @pdes
                                                    WHERE  pID = @pID", prod);

                command.Parameters.AddWithValue("@pname", textpname.Text);
                command.Parameters.AddWithValue("@ptype", textptype.Text);
                command.Parameters.AddWithValue("@pcompany", textpcompany.Text);
                command.Parameters.AddWithValue("@pprice", textpprice.Text);
                command.Parameters.AddWithValue("@pdese", textpdes.Text);
                command.Parameters.AddWithValue("@pID", textpID.Text);

                try
                {
                    prod.Open();
                }
                catch (Exception expe)
                {
                    MessageBox.Show(expe.Source);
                }
                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("DATA UPDATED");
                }
                catch (Exception expe)
                {
                    MessageBox.Show(expe.Source);
                }
                finally
                {
                    prod.Close();
                }

            }
        }

        private void addnew_Click_1(object sender, EventArgs e)
        {
            try {
                if (textpID.Text == "" || textpname.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into productmaster (pID, pname, ptype, pcompany, pprice, pdes) values ('" + this.textpID.Text + "','" + this.textpname.Text + "','" + this.textptype.Text + "','" + this.textpcompany.Text + "','" + this.textpprice.Text + "','" + this.textpdes.Text + "');";
                    prod.Open();
                    oleDbCmd.Connection = prod;
                    oleDbCmd.ExecuteNonQuery();

                    prod.Close();


                    textpID.Text = "";
                    textpname.Text = "";
                    textptype.Text = "";
                    textpcompany.Text = "";
                    textpprice.Text = "";
                    textpdes.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct data enter");
            }
        }    
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textpID.Text == "" || textpname.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE productmaster
                                                             SET pname = @pname,
                                                         ptype = @ptype,
                                                     pcompany = @pcompany,     
                                                 pprice = @pprice,
                                             pdes = @pdes
                                        WHERE  pID = @pID", prod);

                command.Parameters.AddWithValue("@pname", textpname.Text);
                command.Parameters.AddWithValue("@ptype", textptype.Text);
                command.Parameters.AddWithValue("@pcompany", textpcompany.Text);
                command.Parameters.AddWithValue("@pprice", textpprice.Text);
                command.Parameters.AddWithValue("@pdese", textpdes.Text);
                command.Parameters.AddWithValue("@pID", textpID.Text);

                try
                {
                    prod.Open();
                }
                catch (Exception expe)
                {
                    MessageBox.Show(expe.Source);
                }
                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("DATA UPDATED");
                }
                catch (Exception expe)
                {
                    MessageBox.Show(expe.Source);
                }
                finally
                {
                    prod.Close();
                }

            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void butser_Click_2(object sender, EventArgs e)
        {
            try
            {


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from productmaster where pname ='" + textBox1.Text + "'", prod);
                    prod.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {



                        textpID.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textptype.Text = rdr[2].ToString();
                        textpcompany.Text = rdr[3].ToString();
                        textpprice.Text = rdr[4].ToString();
                        textpdes.Text = rdr[5].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    prod.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wait......");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textpID.Text = "";
            textpname.Text = "";
            textptype.Text = "";
            textpcompany.Text = "";
            textpprice.Text = "";
            textpdes.Text = "";
        }
    }


}