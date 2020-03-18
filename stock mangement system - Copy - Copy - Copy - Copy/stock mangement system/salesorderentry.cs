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
    public partial class salesorderentry : Form
    {

        private OleDbConnection sale;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;
        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";
        public salesorderentry()
        {
            //create connection using parameter from mdsaputra.udl
            sale = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salesorderentry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.saleorderentry' table. You can move, or remove it, as needed.
            this.saleorderentryTableAdapter.Fill(this.management_finalDataSet.saleorderentry);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (textsono.Text == "" || datesdate.Text == "" || textscustomerid.Text == "" || textscustomername.Text == "" || textscity.Text == "" || textspd.Text == "" || textspname.Text == "" || textsptype.Text == "" || textspcompany.Text == "" || textspprice.Text == "" || textsquantity.Text == "" || textsamount.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into saleorderentry (sono, sdate, scustomerid, scustomername, scity, spd, spname, sptype, spcompany, sprice, squantity, samount) values ('" + this.textsono.Text + "','" + this.datesdate.Text + "','" + this.textscustomerid.Text + "','" + this.textscustomername.Text + "','" + this.textscity.Text + "','" + this.textspd.Text + "','" + this.textspname.Text + "','" + this.textsptype.Text + "','" + this.textspcompany.Text + "','" + this.textspprice.Text + "','" + this.textsquantity.Text + "','" + this.textsamount.Text + "');";
                    sale.Open();
                    oleDbCmd.Connection = sale;
                    oleDbCmd.ExecuteNonQuery();
                    sale.Close();


                    textsono.Text = "";
                    datesdate.Text = "";
                    textscustomerid.Text = "";
                    textscustomername.Text = "";
                    textscity.Text = "";
                    textspd.Text = "";
                    textspname.Text = "";
                    textsptype.Text = "";
                    textspcompany.Text = "";
                    textspprice.Text = "";
                    textsquantity.Text = "";
                    textsamount.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textsono.Text = "";
            datesdate.Text = "";
            textscustomerid.Text = "";
            textscustomername.Text = "";
            textscity.Text = "";
            textspd.Text = "";
            textspname.Text = "";
            textsptype.Text = "";
            textspcompany.Text = "";
            textspprice.Text = "";
            textsquantity.Text = "";
            textsamount.Text = "";
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from saleorderentry where scustomername ='" + textBox1.Text + "'", sale);
                    sale.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textsono.Text = rdr[0].ToString();
                        datesdate.Text = rdr[1].ToString();
                        textscustomerid.Text = rdr[2].ToString();
                        textscustomername.Text = rdr[3].ToString();
                        textscity.Text = rdr[4].ToString();
                        textspd.Text = rdr[5].ToString();
                        textspname.Text = rdr[6].ToString();
                        textsptype.Text = rdr[7].ToString();
                        textspcompany.Text = rdr[8].ToString();
                        textspprice.Text = rdr[9].ToString();
                        textsquantity.Text = rdr[10].ToString();
                        textsamount.Text = rdr[11].ToString();




                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                }
                sale.Close();

                if (radioButton2.Checked == true  )
                {
                    oleDbCmd = new OleDbCommand("select * from saleorderentry where scustomerid ='" + textBox1.Text + "'", sale);
                    sale.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textsono.Text = rdr[0].ToString();
                        datesdate.Text = rdr[1].ToString();
                        textscustomerid.Text = rdr[2].ToString();
                        textscustomername.Text = rdr[3].ToString();
                        textscity.Text = rdr[4].ToString();
                        textspd.Text = rdr[5].ToString();
                        textspname.Text = rdr[6].ToString();
                        textsptype.Text = rdr[7].ToString();
                        textspcompany.Text = rdr[8].ToString();
                        textspprice.Text = rdr[9].ToString();
                        textsquantity.Text = rdr[10].ToString();
                        textsamount.Text = rdr[11].ToString();




                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    sale.Close();
                }
            }
            catch
            {
                MessageBox.Show("plz correct value enter..");
            }
        }

           

        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            oleDbCmd = new OleDbCommand("select sono from saleorderentry where sono like '%" + textBox1.Text + "%'", sale);
            try
            {


                sale.Open();
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
            sale.Close();
        }
    

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select sono from saleorderentry where sono like '%" + textBox1.Text + "%'", sale);
            try
            {


                sale.Open();
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
            sale.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textsono.Text == "" || datesdate.Text == "" || textscustomerid.Text == "" || textscustomername.Text == "" || textscity.Text == "" || textspd.Text == "" || textspname.Text == "" || textsptype.Text == "" || textspcompany.Text == "" || textspprice.Text == "" || textsquantity.Text == "" || textsamount.Text == "")

            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else {

                    OleDbCommand command = new OleDbCommand(@"UPDATE  saleorderentry
                                                    SET sdate = @sdate,
                                                         scustomerid = @scustomerid,
                                                        scustomername = @scustomername,     
                                                        scity = @scity,
                                                       spd = @spd, 
                                                        spname = @spname,     
                                                       sptype = @sptype,
                                                        spcompany = @spcompany,
                                                        sprice = @sprice, 
                                                        squantity = @squantity,     
                                                        samount = @samount
                                                       
                                                    WHERE  sono = @sono", sale);

            command.Parameters.AddWithValue("@sdate", Convert.ToDateTime(datesdate.Text));
            command.Parameters.AddWithValue("@scustomerid", textscustomerid.Text);
            command.Parameters.AddWithValue("@scustomername", textscustomername.Text);
            command.Parameters.AddWithValue("@scity", textscity.Text);
            command.Parameters.AddWithValue("@spd", textspd.Text);
            command.Parameters.AddWithValue("@spname", textspname.Text);
            command.Parameters.AddWithValue("@sptype", textsptype.Text);

            command.Parameters.AddWithValue("@spcompany", textspcompany.Text);
            command.Parameters.AddWithValue("@sprice", textspprice.Text);
            command.Parameters.AddWithValue("@squantity", textsquantity.Text);
            command.Parameters.AddWithValue("@samount", textsamount.Text);

            command.Parameters.AddWithValue("sono", textsono.Text);

            try
            {
                sale.Open();
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
                sale.Close();
            }

            }
        }

        private void textscustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textscity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textspcompany_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
      

    


