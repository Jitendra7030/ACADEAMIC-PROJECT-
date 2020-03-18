﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;

namespace stock_mangement_system
{
    public partial class saleorderreport : Form
    {
        OleDbConnection sale = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =E:\stock mangement system - Copy - Copy - Copy\stock mangement system\management final.accdb");
        ReportDocument cryrpt = new ReportDocument();
        public saleorderreport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                OleDbDataAdapter da = new OleDbDataAdapter("select * from saleorderentry where [scustomername]='" + textBox1.Text + "'", sale);
                DataSet ds = new DataSet();
                da.Fill(ds, "saleorderentry");
                cryrpt.Load(@"E:\stock mangement system - Copy - Copy\stock mangement system\saleorder.rpt");
                //cryrpt.Load(Application.StartupPath + @"\E:\stock mangement system - Copy\stock mangement system\addreport.rpt");
                cryrpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = cryrpt;
                ds.Dispose();

            }
            catch
            {
                MessageBox.Show("Wait");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from saleorderentry  ", sale);
                DataSet ds = new DataSet();
                da.Fill(ds, "saleorderentry");
                cryrpt.Load(@"E:\stock mangement system - Copy - Copy\stock mangement system\saleorder.rpt");
                //cryrpt.Load(Application.StartupPath + @"\E:\stock mangement system - Copy\stock mangement system\addreport.rpt");
                cryrpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = cryrpt;
                ds.Dispose();
            }
            catch
            {
                MessageBox.Show("Wait");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            home l = new home();
            l.Show();
            this.Hide();
        }

        private void saleorderreport_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
