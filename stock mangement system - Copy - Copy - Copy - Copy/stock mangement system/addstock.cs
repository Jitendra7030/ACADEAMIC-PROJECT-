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
    public partial class addstock : Form
    {
        private OleDbConnection add;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        OleDbDataReader rdr;


        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management final.accdb;Persist Security Info=False";
        public addstock()
        {
            //create connection using parameter from mdsaputra.udl
            add = new OleDbConnection(connParam);
            InitializeComponent();
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

        private void addstock_Load(object sender, EventArgs e)
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

                if (textpno.Text == "" || textpname.Text == "" || textpcompanyname.Text == "" || textpsname.Text == "" || textptypeprodct.Text == "" || textpsellamount.Text == "" || textppamount.Text == "" || textpdelarno.Text == "" || textaddressdelar.Text == "")

                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into addstock (pno, pname, pcompanyname, psname, ptypeproduct, psellamount, ppamount, pdelarno, addressdelar) values ('" + this.textpno.Text + "','" + this.textpname.Text + "','" + this.textpcompanyname.Text + "','" + this.textpsname.Text + "','" + this.textptypeprodct.Text + "','" + this.textpsellamount.Text + "','" + this.textppamount.Text + "','" + this.textpdelarno.Text + "','" + this.textaddressdelar.Text + "');";
                    add.Open();
                    oleDbCmd.Connection = add;
                    oleDbCmd.ExecuteNonQuery();
                    add.Close();


                    textpno.Text = "";
                    textpname.Text = "";
                    textpcompanyname.Text = "";
                    textpsname.Text = "";
                    textptypeprodct.Text = "";
                    textpsellamount.Text = "";
                    textppamount.Text = "";
                    textpdelarno.Text = "";
                    textaddressdelar.Text = "";

                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Correct Data Entered...");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void butser_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbno.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from addstock where pdelarno ='" + textser.Text + "'", add);
                    add.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {


                        textpno.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textpcompanyname.Text = rdr[2].ToString();
                        textpsname.Text = rdr[3].ToString();
                        textptypeprodct.Text = rdr[4].ToString();
                        textpsellamount.Text = rdr[5].ToString();
                        textppamount.Text = rdr[6].ToString();
                        textpdelarno.Text = rdr[7].ToString();
                        textaddressdelar.Text = rdr[8].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Records found");
                    }
                    add.Close();
                }




                if (radname.Checked == true)
                {
                    oleDbCmd = new OleDbCommand("select * from addstock where pname ='" + textser.Text + "'", add);
                    add.Open();
                    rdr = oleDbCmd.ExecuteReader();
                    if (rdr.Read())
                    {


                        textpno.Text = rdr[0].ToString();
                        textpname.Text = rdr[1].ToString();
                        textpcompanyname.Text = rdr[2].ToString();
                        textpsname.Text = rdr[3].ToString();
                        textptypeprodct.Text = rdr[4].ToString();
                        textpsellamount.Text = rdr[5].ToString();
                        textppamount.Text = rdr[6].ToString();
                        textpdelarno.Text = rdr[7].ToString();
                        textaddressdelar.Text = rdr[8].ToString();

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
                MessageBox.Show("Wait.....");
            }

        }
        private void textpname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textser_TextChanged(object sender, EventArgs e)
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

        private void textpno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textpno.Text = "";
            textpname.Text = "";
            textpcompanyname.Text = "";
            textpsname.Text = "";
            textptypeprodct.Text = "";
            textpsellamount.Text = "";
            textppamount.Text = "";
            textpdelarno.Text = "";
            textaddressdelar.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textpno.Text == "" || textpname.Text == "" || textpcompanyname.Text == "" || textpsname.Text == "" || textptypeprodct.Text == "" || textpsellamount.Text == "" || textppamount.Text == "" || textpdelarno.Text == "" || textaddressdelar.Text == "")

            {
                MessageBox.Show("Please Fill Required Fields");
                return;
            }
            else
            {
                OleDbCommand command = new OleDbCommand(@"UPDATE addstock
                                                            SET pname = @pname,
                                                          pcompanyname = @pcompanyname,
                                                            psname = @psname,     
                                                             ptypeproduct = @ptypeproduct,
                                                                psellamount = @psellamount,
                                                                     ppamount = @ppamount,
                                                                        pdelarno = @pdelarno,     
                                                                         addressdelar = @addressdelar
                                                       
                                                                            WHERE  pno = @pno", add);

                command.Parameters.AddWithValue("@pname", textpname.Text);
                command.Parameters.AddWithValue("@pcompanyname", textpcompanyname.Text);
                command.Parameters.AddWithValue("@psname", textpsname.Text);

                command.Parameters.AddWithValue("@ptypeproduct", textptypeprodct.Text);

                command.Parameters.AddWithValue("@psellamount", textpsellamount.Text);
                command.Parameters.AddWithValue("@ppamount", textppamount.Text);
                command.Parameters.AddWithValue("@pdelarno", textpdelarno.Text);
                command.Parameters.AddWithValue("@addressdela", textaddressdelar.Text);
                command.Parameters.AddWithValue("@pno", textpno.Text);


                try
                {
                    add.Open();
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
                    add.Close();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radname_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textpname_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}



 

