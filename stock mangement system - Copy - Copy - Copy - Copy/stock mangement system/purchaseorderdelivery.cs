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
    public partial class purchaseorderdelivery : Form
    {
        private OleDbConnection proddel;


        OleDbDataReader rdr;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=C:\Users\hp\Desktop\stock mangement system - Copy - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";

        public purchaseorderdelivery()
        {
            //create connection using parameter from mdsaputra.udl
            proddel = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void purchaseorderdelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.purchrchaseorderdelivary' table. You can move, or remove it, as needed.
            this.purchrchaseorderdelivaryTableAdapter.Fill(this.management_finalDataSet.purchrchaseorderdelivary);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpd.Text == "" || datepdate.Text == "" || textpno.Text == "" || textsupp.Text == "" || textpsuppname.Text == "" || textpID.Text == "" || textPpurchaseno.Text == "" || textpname.Text == "" || textquantity.Text == "" || textptype.Text == "" || textpprice.Text == "" || textpamount.Text == "" || textpdel.Text == "" || textpremark.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into purchrchaseorderdelivary (pd, pdate, pno, psupp, psuppname, pID, ppurchaseno,  pname, pquantity, ptype, pprice, pamount, pdel, premark)  values ('" + this.textpd.Text + "', '" + this.datepdate.Text + "', '" + this.textpno.Text + "','" + this.textsupp.Text + "','" + this.textpsuppname.Text + "','" + this.textpID.Text + "', '" + this.textPpurchaseno.Text + "', '" + this.textpname.Text + "','" + this.textquantity.Text + "','" + this.textptype.Text + "', '" + this.textpprice.Text + "','" + this.textpamount.Text + "','" + this.textpdel.Text + "','" + this.textpremark.Text + "');";

                    proddel.Open();
                    oleDbCmd.Connection = proddel;
                    oleDbCmd.ExecuteNonQuery();

                    proddel.Close();


                    textpd.Text = "";
                    datepdate.Text = "";
                    textpno.Text = "";
                    textsupp.Text = "";
                    textpsuppname.Text = "";
                    textpID.Text = "";

                    textPpurchaseno.Text = "";

                    textpname.Text = "";

                    textquantity.Text = "";
                    textptype.Text = "";
                    textpprice.Text = "";
                    textpamount.Text = "";
                    textpdel.Text = "";
                    textpremark.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }
            }
            catch
            {
                MessageBox.Show("Correct Data Enter...");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select pd from purchrchaseorderdelivary where pd like '%" + textBox1.Text + "%'", proddel);
            try
            {


                proddel.Open();
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
            proddel.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from purchrchaseorderdelivary where pd ='" + textBox1.Text + "'", proddel);
                    proddel.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textpd.Text = rdr[0].ToString();
                        datepdate.Text = rdr[1].ToString();
                        textpno.Text = rdr[2].ToString();
                        textsupp.Text = rdr[3].ToString();
                        textpsuppname.Text = rdr[4].ToString();
                        textpID.Text = rdr[5].ToString();

                        textPpurchaseno.Text = rdr[6].ToString();

                        textpname.Text = rdr[8].ToString();

                        textquantity.Text = rdr[9].ToString();
                        textptype.Text = rdr[10].ToString();
                        textpprice.Text = rdr[11].ToString();
                        textpamount.Text = rdr[12].ToString();
                        textpdel.Text = rdr[13].ToString();
                        textpremark.Text = rdr[14].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    proddel.Close();
                }
                if (radioButton2.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from purchrchaseorderdelivary where psupp ='" + textBox1.Text + "'", proddel);
                    proddel.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textpd.Text = rdr[0].ToString();
                        datepdate.Text = rdr[1].ToString();
                        textpno.Text = rdr[2].ToString();
                        textsupp.Text = rdr[3].ToString();
                        textpsuppname.Text = rdr[4].ToString();
                        textpID.Text = rdr[5].ToString();

                        textPpurchaseno.Text = rdr[6].ToString();

                        textpname.Text = rdr[8].ToString();

                        textquantity.Text = rdr[9].ToString();
                        textptype.Text = rdr[10].ToString();
                        textpprice.Text = rdr[11].ToString();
                        textpamount.Text = rdr[12].ToString();
                        textpdel.Text = rdr[13].ToString();
                        textpremark.Text = rdr[14].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    proddel.Close();
                }
            }
            catch
            {
                MessageBox.Show("wait....");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textpd.Text = "";
            datepdate.Text = "";
            textpno.Text = "";
            textsupp.Text = "";
            textpsuppname.Text = "";
            textpID.Text = "";

            textPpurchaseno.Text = "";

            textpname.Text = "";

            textquantity.Text = "";
            textptype.Text = "";
            textpprice.Text = "";
            textpamount.Text = "";
            textpdel.Text = "";
            textpremark.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textpd.Text == "" || datepdate.Text == "" || textpno.Text == "" || textsupp.Text == "" || textpsuppname.Text == "" || textpID.Text == "" || textPpurchaseno.Text == "" || textpname.Text == "" || textquantity.Text == "" || textptype.Text == "" || textpprice.Text == "" || textpamount.Text == "" || textpdel.Text == "" || textpremark.Text == "")
            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }

            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE purchrchaseorderdelivary
                                                    SET pd = @pd,
                                                         pdate = @pdate,
                                                        pno = @pno,     
                                                        psuppname = @psuppname,
                                                        ppurchaseno = @ppurchaseno, 
                                                        pname = @pname,     
                                                        pquantity = @pquantity,
                                                        ptype = @ptype,
                                                        pprice = @pprice, 
                                                        pamount = @pamount,     
                                                        pdel = @pdel,
                                                        premark = @premark
                                                    WHERE  pID = @pID", proddel);

                command.Parameters.AddWithValue("@pd", textpd.Text);
                command.Parameters.AddWithValue("@pdate", Convert.ToDateTime(datepdate.Text));
                command.Parameters.AddWithValue("@pno", textpno.Text);
                command.Parameters.AddWithValue("@psuppname", textsupp.Text);
                command.Parameters.AddWithValue("@ppurchaseno", textPpurchaseno.Text);
                command.Parameters.AddWithValue("@pname", textpname.Text);
                command.Parameters.AddWithValue("@pquantity", textquantity.Text);
                command.Parameters.AddWithValue("@ptype", textptype.Text);

                command.Parameters.AddWithValue("@pprice", textpprice.Text);
                command.Parameters.AddWithValue("@pamount", textpamount.Text);
                command.Parameters.AddWithValue("@pdel", textpdel.Text);
                command.Parameters.AddWithValue("@premark", textpremark.Text);

                command.Parameters.AddWithValue("@pID", textpID.Text);

                try
                {
                    proddel.Open();
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
                    proddel.Close();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textpd.Text == "" || datepdate.Text == "" || textpno.Text == "" || textsupp.Text == "" || textpsuppname.Text == "" || textpID.Text == "" || textPpurchaseno.Text == "" || textpname.Text == "" || textquantity.Text == "" || textptype.Text == "" || textpprice.Text == "" || textpamount.Text == "" || textpdel.Text == "" || textpremark.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into purchrchaseorderdelivary (pd, pdate, pno, psupp, psuppname, pID, ppurchaseno,  pname, pquantity, ptype, pprice, pamount, pdel, premark)  values ('" + this.textpd.Text + "', '" + this.datepdate.Text + "', '" + this.textpno.Text + "','" + this.textsupp.Text + "','" + this.textpsuppname.Text + "','" + this.textpID.Text + "', '" + this.textPpurchaseno.Text + "', '" + this.textpname.Text + "','" + this.textquantity.Text + "','" + this.textptype.Text + "', '" + this.textpprice.Text + "','" + this.textpamount.Text + "','" + this.textpdel.Text + "','" + this.textpremark.Text + "');";

                    proddel.Open();
                    oleDbCmd.Connection = proddel;
                    oleDbCmd.ExecuteNonQuery();

                    proddel.Close();


                    textpd.Text = "";
                    datepdate.Text = "";
                    textpno.Text = "";
                    textsupp.Text = "";
                    textpsuppname.Text = "";
                    textpID.Text = "";

                    textPpurchaseno.Text = "";

                    textpname.Text = "";

                    textquantity.Text = "";
                    textptype.Text = "";
                    textpprice.Text = "";
                    textpamount.Text = "";
                    textpdel.Text = "";
                    textpremark.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }
            }
            catch
            {
                MessageBox.Show("Correct Data Enter...");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textpd.Text == "" || datepdate.Text == "" || textpno.Text == "" || textsupp.Text == "" || textpsuppname.Text == "" || textpID.Text == "" || textPpurchaseno.Text == "" || textpname.Text == "" || textquantity.Text == "" || textptype.Text == "" || textpprice.Text == "" || textpamount.Text == "" || textpdel.Text == "" || textpremark.Text == "")
            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }

            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE purchrchaseorderdelivary
                                                    SET pd = @pd,
                                                         pdate = @pdate,
                                                        pno = @pno,     
                                                        psuppname = @psuppname,
                                                        ppurchaseno = @ppurchaseno, 
                                                        pname = @pname,     
                                                        pquantity = @pquantity,
                                                        ptype = @ptype,
                                                        pprice = @pprice, 
                                                        pamount = @pamount,     
                                                        pdel = @pdel,
                                                        premark = @premark
                                                    WHERE  pID = @pID", proddel);

                command.Parameters.AddWithValue("@pd", textpd.Text);
                command.Parameters.AddWithValue("@pdate", Convert.ToDateTime(datepdate.Text));
                command.Parameters.AddWithValue("@pno", textpno.Text);
                command.Parameters.AddWithValue("@psuppname", textsupp.Text);
                command.Parameters.AddWithValue("@ppurchaseno", textPpurchaseno.Text);
                command.Parameters.AddWithValue("@pname", textpname.Text);
                command.Parameters.AddWithValue("@pquantity", textquantity.Text);
                command.Parameters.AddWithValue("@ptype", textptype.Text);

                command.Parameters.AddWithValue("@pprice", textpprice.Text);
                command.Parameters.AddWithValue("@pamount", textpamount.Text);
                command.Parameters.AddWithValue("@pdel", textpdel.Text);
                command.Parameters.AddWithValue("@premark", textpremark.Text);

                command.Parameters.AddWithValue("@pID", textpID.Text);

                try
                {
                    proddel.Open();
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
                    proddel.Close();
                }

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textpd.Text = "";
            datepdate.Text = "";
            textpno.Text = "";
            textsupp.Text = "";
            textpsuppname.Text = "";
            textpID.Text = "";

            textPpurchaseno.Text = "";

            textpname.Text = "";

            textquantity.Text = "";
            textptype.Text = "";
            textpprice.Text = "";
            textpamount.Text = "";
            textpdel.Text = "";
            textpremark.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from purchrchaseorderdelivary where pd ='" + textBox1.Text + "'", proddel);
                    proddel.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textpd.Text = rdr[0].ToString();
                        datepdate.Text = rdr[1].ToString();
                        textpno.Text = rdr[2].ToString();
                        textsupp.Text = rdr[3].ToString();
                        textpsuppname.Text = rdr[4].ToString();
                        textpID.Text = rdr[5].ToString();

                        textPpurchaseno.Text = rdr[6].ToString();

                        textpname.Text = rdr[8].ToString();

                        textquantity.Text = rdr[9].ToString();
                        textptype.Text = rdr[10].ToString();
                        textpprice.Text = rdr[11].ToString();
                        textpamount.Text = rdr[12].ToString();
                        textpdel.Text = rdr[13].ToString();
                        textpremark.Text = rdr[14].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    proddel.Close();
                }
                if (radioButton2.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from purchrchaseorderdelivary where psupp ='" + textBox1.Text + "'", proddel);
                    proddel.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textpd.Text = rdr[0].ToString();
                        datepdate.Text = rdr[1].ToString();
                        textpno.Text = rdr[2].ToString();
                        textsupp.Text = rdr[3].ToString();
                        textpsuppname.Text = rdr[4].ToString();
                        textpID.Text = rdr[5].ToString();

                        textPpurchaseno.Text = rdr[6].ToString();

                        textpname.Text = rdr[8].ToString();

                        textquantity.Text = rdr[9].ToString();
                        textptype.Text = rdr[10].ToString();
                        textpprice.Text = rdr[11].ToString();
                        textpamount.Text = rdr[12].ToString();
                        textpdel.Text = rdr[13].ToString();
                        textpremark.Text = rdr[14].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    proddel.Close();
                }
            }
            catch
            {
                MessageBox.Show("wait....");
            }

        }
    }
}