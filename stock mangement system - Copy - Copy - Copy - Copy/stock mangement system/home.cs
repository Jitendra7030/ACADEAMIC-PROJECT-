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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void productMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productmaster pr  = new productmaster();
            pr.Show();
            this.Hide();
        }

        private void purchaseOrderDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseorderdelivery p = new purchaseorderdelivery();
            p.Show();
            this.Hide();
        }

        private void saleOrderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesorderentry j = new salesorderentry();
            j.Show();
            this.Hide();
        }

        private void customerMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customermaster pk = new Customermaster();
            pk.Show();
            this.Hide();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstock jp = new addstock();
            jp.Show();
            this.Hide();
        }

        private void supplierMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suppliermaste qw = new suppliermaste();
            qw.Show();
            this.Hide();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            addstock jp = new addstock();
            jp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addstock jp = new addstock();
            jp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            salesorderentry j = new salesorderentry();
            j.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            salesorderentry j = new salesorderentry();
            j.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            addstockreport L = new addstockreport();
            L.Show();
            this.Hide();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstockreport L = new addstockreport();
            L.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            billpayment k = new billpayment();
            k.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            billpayment k = new billpayment();
            k.Show();
            this.Hide();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseordemaster k = new purchaseordemaster();
            k.Show();
            this.Hide();
        }

        private void saleOrderMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            addstockreport L = new addstockreport();
            L.Show();
            this.Hide();
        }

        private void addStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstockreport L = new addstockreport();
            L.Show();
            this.Hide();
        }

        private void supplierMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplierreport o = new supplierreport();
            o.Show();
            this.Hide();
        }

        private void saleOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleorderreport l = new saleorderreport();
            l.Show();
            this.Hide();
        }

        private void customerMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTcustomer Q = new REPORTcustomer();
            Q.Show();
            this.Hide();
        }

        private void productMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productmasterreport a = new productmasterreport();
            a.Show();

            this.Hide();
        }
    }
}
