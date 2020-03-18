namespace stock_mangement_system
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMasterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMasterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1330, 79);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computerized Stock Management System ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Location = new System.Drawing.Point(1074, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 384);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(321, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(165, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(291, 227);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(219, 37);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(291, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 37);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserName.Location = new System.Drawing.Point(112, 123);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(137, 29);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.userToolStripMenuItem,
            this.reportProductToolStripMenuItem,
            this.reportSaleToolStripMenuItem,
            this.reportStockToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.CheckOnClick = true;
            this.productToolStripMenuItem.DoubleClickEnabled = true;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productMasterToolStripMenuItem,
            this.purchaseOrderDeliveryToolStripMenuItem,
            this.purchaseToolStripMenuItem});
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // productMasterToolStripMenuItem
            // 
            this.productMasterToolStripMenuItem.Name = "productMasterToolStripMenuItem";
            this.productMasterToolStripMenuItem.Size = new System.Drawing.Size(272, 28);
            this.productMasterToolStripMenuItem.Text = "Product Master";
            // 
            // purchaseOrderDeliveryToolStripMenuItem
            // 
            this.purchaseOrderDeliveryToolStripMenuItem.Name = "purchaseOrderDeliveryToolStripMenuItem";
            this.purchaseOrderDeliveryToolStripMenuItem.Size = new System.Drawing.Size(272, 28);
            this.purchaseOrderDeliveryToolStripMenuItem.Text = "Purchase Order Delivery";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(272, 28);
            this.purchaseToolStripMenuItem.Text = "Purchase Order Master";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.CheckOnClick = true;
            this.salesToolStripMenuItem.DoubleClickEnabled = true;
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleOrderEntryToolStripMenuItem});
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // saleOrderEntryToolStripMenuItem
            // 
            this.saleOrderEntryToolStripMenuItem.Name = "saleOrderEntryToolStripMenuItem";
            this.saleOrderEntryToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.saleOrderEntryToolStripMenuItem.Text = "Sale Stock";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.CheckOnClick = true;
            this.customerToolStripMenuItem.DoubleClickEnabled = true;
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMasterToolStripMenuItem1});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // customerMasterToolStripMenuItem1
            // 
            this.customerMasterToolStripMenuItem1.Name = "customerMasterToolStripMenuItem1";
            this.customerMasterToolStripMenuItem1.Size = new System.Drawing.Size(219, 28);
            this.customerMasterToolStripMenuItem1.Text = "Customer Master";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.CheckOnClick = true;
            this.stockToolStripMenuItem.DoubleClickEnabled = true;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(163, 28);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.CheckOnClick = true;
            this.userToolStripMenuItem.DoubleClickEnabled = true;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierMasterToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.userToolStripMenuItem.Text = "Supplier ";
            // 
            // supplierMasterToolStripMenuItem
            // 
            this.supplierMasterToolStripMenuItem.Name = "supplierMasterToolStripMenuItem";
            this.supplierMasterToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.supplierMasterToolStripMenuItem.Text = "Supplier Master";
            // 
            // reportProductToolStripMenuItem
            // 
            this.reportProductToolStripMenuItem.CheckOnClick = true;
            this.reportProductToolStripMenuItem.DoubleClickEnabled = true;
            this.reportProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productMasterReportToolStripMenuItem});
            this.reportProductToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportProductToolStripMenuItem.Name = "reportProductToolStripMenuItem";
            this.reportProductToolStripMenuItem.Size = new System.Drawing.Size(139, 27);
            this.reportProductToolStripMenuItem.Text = "Report Product";
            // 
            // productMasterReportToolStripMenuItem
            // 
            this.productMasterReportToolStripMenuItem.Name = "productMasterReportToolStripMenuItem";
            this.productMasterReportToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.productMasterReportToolStripMenuItem.Text = "Product Master Report";
            // 
            // reportSaleToolStripMenuItem
            // 
            this.reportSaleToolStripMenuItem.CheckOnClick = true;
            this.reportSaleToolStripMenuItem.DoubleClickEnabled = true;
            this.reportSaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockRecordToolStripMenuItem});
            this.reportSaleToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSaleToolStripMenuItem.Name = "reportSaleToolStripMenuItem";
            this.reportSaleToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.reportSaleToolStripMenuItem.Text = "Report Sale";
            // 
            // stockRecordToolStripMenuItem
            // 
            this.stockRecordToolStripMenuItem.Name = "stockRecordToolStripMenuItem";
            this.stockRecordToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.stockRecordToolStripMenuItem.Text = "Stock Record";
            // 
            // reportStockToolStripMenuItem
            // 
            this.reportStockToolStripMenuItem.CheckOnClick = true;
            this.reportStockToolStripMenuItem.DoubleClickEnabled = true;
            this.reportStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMasterReportToolStripMenuItem,
            this.supplierMasterReportToolStripMenuItem,
            this.addStockReportToolStripMenuItem,
            this.saleOrderReportToolStripMenuItem});
            this.reportStockToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportStockToolStripMenuItem.Name = "reportStockToolStripMenuItem";
            this.reportStockToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.reportStockToolStripMenuItem.Text = "Report Stock";
            // 
            // customerMasterReportToolStripMenuItem
            // 
            this.customerMasterReportToolStripMenuItem.Name = "customerMasterReportToolStripMenuItem";
            this.customerMasterReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.customerMasterReportToolStripMenuItem.Text = "Customer Master Report";
            // 
            // supplierMasterReportToolStripMenuItem
            // 
            this.supplierMasterReportToolStripMenuItem.Name = "supplierMasterReportToolStripMenuItem";
            this.supplierMasterReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.supplierMasterReportToolStripMenuItem.Text = "Supplier Master Report";
            // 
            // addStockReportToolStripMenuItem
            // 
            this.addStockReportToolStripMenuItem.Name = "addStockReportToolStripMenuItem";
            this.addStockReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.addStockReportToolStripMenuItem.Text = "Add Stock Report";
            // 
            // saleOrderReportToolStripMenuItem
            // 
            this.saleOrderReportToolStripMenuItem.Name = "saleOrderReportToolStripMenuItem";
            this.saleOrderReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.saleOrderReportToolStripMenuItem.Text = "Sale Order Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.CheckOnClick = true;
            this.exitToolStripMenuItem.DoubleClickEnabled = true;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMasterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierMasterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

