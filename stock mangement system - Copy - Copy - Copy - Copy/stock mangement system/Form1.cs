using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mangement_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);



            label3.Text = System.DateTime.Now.ToString();
            label4.Text = System.DateTime.Now.DayOfWeek.ToString();
            productToolStripMenuItem.Enabled = false;
            salesToolStripMenuItem.Enabled = false;
            customerToolStripMenuItem.Enabled = false;
            stockToolStripMenuItem.Enabled = false;
            userToolStripMenuItem.Enabled = false;
            reportProductToolStripMenuItem.Enabled = false;
            reportSaleToolStripMenuItem.Enabled = false;
            reportStockToolStripMenuItem.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = "jitu";
              String password = "1234";

              if ((textBox1.Text == username) && (textBox2.Text == password))
              {
                  MessageBox.Show("Welcome back, Guest!");

                  home h = new home();
                  h.Show();
                  this.Hide();


              }
              else
              {
                  MessageBox.Show("Enter A login Details", "Login", MessageBoxButtons.OKCancel ,MessageBoxIcon.Error);
              }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {

            }
        }
    }
}