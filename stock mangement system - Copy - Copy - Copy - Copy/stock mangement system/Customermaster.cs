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
    public partial class Customermaster : Form
    {
        private OleDbConnection cus;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;

        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";
        public Customermaster()
        {
            //create connection using parameter from mdsaputra.udl
            cus = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            try
            {


                if (textcustomerID.Text == "" || textcustomername.Text == "" || textcustomeradd.Text == "" || textcustomercity.Text == "" || textcustomernumber.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into customermaster (customerID, customername, customeradd, customercity, customernumber) values ('" + this.textcustomerID.Text + "','" + this.textcustomername.Text + "','" + this.textcustomeradd.Text + "','" + this.textcustomercity.Text + "','" + this.textcustomernumber.Text + "');";
                    cus.Open();
                    oleDbCmd.Connection = cus;
                    oleDbCmd.ExecuteNonQuery();
                    cus.Close();


                    textcustomerID.Text = "";
                    textcustomername.Text = "";
                    textcustomeradd.Text = "";
                    textcustomercity.Text = "";
                    textcustomernumber.Text = "";

                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }



        }

        private void Customermaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_finalDataSet.customermaster' table. You can move, or remove it, as needed.
            this.customermasterTableAdapter.Fill(this.management_finalDataSet.customermaster);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oleDbCmd = new OleDbCommand("select customerID from customermaster where customerID like '%" + textBox1.Text + "%'", cus);
            try
            {


                cus.Open();
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
            cus.Close();
        }



        private void edit_Click(object sender, EventArgs e)
        {
            try
            {



                if (radioButton2.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from customermaster where customername ='" + textBox1.Text + "'", cus);
                    cus.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textcustomerID.Text = rdr[0].ToString();
                        textcustomername.Text = rdr[1].ToString();
                        textcustomeradd.Text = rdr[2].ToString();
                        textcustomercity.Text = rdr[3].ToString();
                        textcustomernumber.Text = rdr[4].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                }
                cus.Close();


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from customermaster where customernumber ='" + textBox1.Text + "'", cus);
                    cus.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textcustomerID.Text = rdr[0].ToString();
                        textcustomername.Text = rdr[1].ToString();
                        textcustomeradd.Text = rdr[2].ToString();
                        textcustomercity.Text = rdr[3].ToString();
                        textcustomernumber.Text = rdr[4].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    cus.Close();

                }
            }
            catch
            {
                MessageBox.Show("Wait...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textcustomerID.Text = "";
            textcustomername.Text = "";
            textcustomeradd.Text = "";
            textcustomercity.Text = "";
            textcustomernumber.Text = "";
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (textcustomerID.Text == "" || textcustomername.Text == "" || textcustomeradd.Text == "" || textcustomercity.Text == "" || textcustomernumber.Text == "")

            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE customermaster
                                                            SET customername = @customername,
                                                          customeradd = @customeradd,
                                                        customercity = @customercity,     
                                                       customernumber = @customernumber
                                                       
                                                    WHERE  customerID = @customerID", cus);

                command.Parameters.AddWithValue("@customername", textcustomername.Text);
                command.Parameters.AddWithValue("@customeradd", textcustomeradd.Text);
                command.Parameters.AddWithValue("@customercity", textcustomercity.Text);
                command.Parameters.AddWithValue("@customernumber", textcustomernumber.Text);
                command.Parameters.AddWithValue("@customerID", textcustomerID.Text);


                try
                {
                    cus.Open();
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
                    cus.Close();
                }

            }
        }

        private void addnew_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (textcustomerID.Text == "" || textcustomername.Text == "" || textcustomeradd.Text == "" || textcustomercity.Text == "" || textcustomernumber.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into customermaster (customerID, customername, customeradd, customercity, customernumber) values ('" + this.textcustomerID.Text + "','" + this.textcustomername.Text + "','" + this.textcustomeradd.Text + "','" + this.textcustomercity.Text + "','" + this.textcustomernumber.Text + "');";
                    cus.Open();
                    oleDbCmd.Connection = cus;
                    oleDbCmd.ExecuteNonQuery();
                    cus.Close();


                    textcustomerID.Text = "";
                    textcustomername.Text = "";
                    textcustomeradd.Text = "";
                    textcustomercity.Text = "";
                    textcustomernumber.Text = "";

                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }

        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (textcustomerID.Text == "" || textcustomername.Text == "" || textcustomeradd.Text == "" || textcustomercity.Text == "" || textcustomernumber.Text == "")

            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE customermaster
                                                            SET customername = @customername,
                                                          customeradd = @customeradd,
                                                        customercity = @customercity,     
                                                       customernumber = @customernumber
                                                       
                                                    WHERE  customerID = @customerID", cus);

                command.Parameters.AddWithValue("@customername", textcustomername.Text);
                command.Parameters.AddWithValue("@customeradd", textcustomeradd.Text);
                command.Parameters.AddWithValue("@customercity", textcustomercity.Text);
                command.Parameters.AddWithValue("@customernumber", textcustomernumber.Text);
                command.Parameters.AddWithValue("@customerID", textcustomerID.Text);


                try
                {
                    cus.Open();
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
                    cus.Close();
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textcustomerID.Text = "";
            textcustomername.Text = "";
            textcustomeradd.Text = "";
            textcustomercity.Text = "";
            textcustomernumber.Text = "";
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            try
            {



                if (radioButton2.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from customermaster where customername ='" + textBox1.Text + "'", cus);
                    cus.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textcustomerID.Text = rdr[0].ToString();
                        textcustomername.Text = rdr[1].ToString();
                        textcustomeradd.Text = rdr[2].ToString();
                        textcustomercity.Text = rdr[3].ToString();
                        textcustomernumber.Text = rdr[4].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                }
                cus.Close();


                if (radioButton1.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from customermaster where customernumber ='" + textBox1.Text + "'", cus);
                    cus.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        textcustomerID.Text = rdr[0].ToString();
                        textcustomername.Text = rdr[1].ToString();
                        textcustomeradd.Text = rdr[2].ToString();
                        textcustomercity.Text = rdr[3].ToString();
                        textcustomernumber.Text = rdr[4].ToString();



                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    cus.Close();

                }
            }
            catch
            {
                MessageBox.Show("Wait...");
            }

        }
    }

}
