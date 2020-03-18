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
    public partial class purchaseordemaster : Form
    {
        private OleDbConnection prod2;
        private OleDbCommand oleDbCmd = new OleDbCommand();
       

        //parameter from mdsaputra.udl
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management 2.accdb;Persist Security Info=False";

        public purchaseordemaster()
        {
            //create connection using parameter from mdsaputra.udl
            prod2 = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void purchaseordemaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'management_2DataSet.purchaseordermaster' table. You can move, or remove it, as needed.
            this.purchaseordermasterTableAdapter.Fill(this.management_2DataSet.purchaseordermaster);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpID.Text == "" || dateTimePicker1.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    oleDbCmd.CommandText = "insert into purchaseordermaster (pono, pdate, sid, sname, scity, totalbill) values ('" + this.textpID.Text + "','" + this.dateTimePicker1.Text + "','" + this.textptype.Text + "','" + this.textpcompany.Text + "','" + this.textpprice.Text + "','" + this.textpdes.Text + "');";
                    prod2.Open();
                    oleDbCmd.Connection = prod2;
                    oleDbCmd.ExecuteNonQuery();

                    prod2.Close();


                    textpID.Text = "";
                    dateTimePicker1.Text = "";
                    textptype.Text = "";
                    textpcompany.Text = "";
                    textpprice.Text = "";
                    textpdes.Text = "";
                    MessageBox.Show("Data Entered Succssfully...");

                }

            }
            catch
            {
                MessageBox.Show("Enter Correct Value");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (textpID.Text == "" || dateTimePicker1.Text == "" || textptype.Text == "" || textpcompany.Text == "" || textpprice.Text == "" || textpdes.Text == "")
                {
                    MessageBox.Show("Please Fill Required Fields");
                    return;
                }
                else
                {
                    OleDbCommand command = new OleDbCommand(@"UPDATE productmaster
                                                    SET pdate = @pdate,
                                                         sid = @sid,
                                                       sname = @sname,     
                                                        scity = @scity,
                                                        pdes = @pdes
                                                    WHERE  pono = @pono", prod2);

                    command.Parameters.AddWithValue("@pdate", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@sid", textptype.Text);
                    command.Parameters.AddWithValue("@sname", textptype.Text);
                    command.Parameters.AddWithValue("@scity", textpprice.Text);
                    command.Parameters.AddWithValue("@totalbill", textpdes.Text);
                    command.Parameters.AddWithValue("@pono", textpID.Text);

                    try
                    {
                        prod2.Open();
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
                        prod2.Close();
                    }
                }
            }
                
            
            




        private void button4_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home pk = new home();
            pk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textpID.Text = "";
            dateTimePicker1.Text = "";
            textptype.Text = "";
            textpcompany.Text = "";
            textpprice.Text = "";
            textpdes.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
