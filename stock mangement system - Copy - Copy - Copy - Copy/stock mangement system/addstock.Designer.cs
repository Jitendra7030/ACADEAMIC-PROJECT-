namespace stock_mangement_system
{
    partial class addstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstock));
            this.textser = new System.Windows.Forms.TextBox();
            this.radname = new System.Windows.Forms.RadioButton();
            this.rdbno = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcompanynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptypeproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psellamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdelarnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressdelarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_finalDataSet = new stock_mangement_system.management_finalDataSet();
            this.addstockTableAdapter = new stock_mangement_system.management_finalDataSetTableAdapters.addstockTableAdapter();
            this.textaddressdelar = new System.Windows.Forms.TextBox();
            this.textpdelarno = new System.Windows.Forms.TextBox();
            this.textppamount = new System.Windows.Forms.TextBox();
            this.textpsellamount = new System.Windows.Forms.TextBox();
            this.textptypeprodct = new System.Windows.Forms.TextBox();
            this.textpsname = new System.Windows.Forms.TextBox();
            this.textpcompanyname = new System.Windows.Forms.TextBox();
            this.textpname = new System.Windows.Forms.TextBox();
            this.textpno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textser
            // 
            this.textser.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textser.ForeColor = System.Drawing.Color.Black;
            this.textser.Location = new System.Drawing.Point(151, 103);
            this.textser.Multiline = true;
            this.textser.Name = "textser";
            this.textser.Size = new System.Drawing.Size(288, 37);
            this.textser.TabIndex = 27;
            this.textser.TextChanged += new System.EventHandler(this.textser_TextChanged);
            this.textser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // radname
            // 
            this.radname.AutoSize = true;
            this.radname.BackColor = System.Drawing.Color.Transparent;
            this.radname.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radname.ForeColor = System.Drawing.Color.White;
            this.radname.Location = new System.Drawing.Point(26, 170);
            this.radname.Name = "radname";
            this.radname.Size = new System.Drawing.Size(175, 27);
            this.radname.TabIndex = 26;
            this.radname.TabStop = true;
            this.radname.Text = "Product Name";
            this.radname.UseVisualStyleBackColor = false;
            this.radname.CheckedChanged += new System.EventHandler(this.radname_CheckedChanged);
            // 
            // rdbno
            // 
            this.rdbno.AutoSize = true;
            this.rdbno.BackColor = System.Drawing.Color.Transparent;
            this.rdbno.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbno.ForeColor = System.Drawing.Color.White;
            this.rdbno.Location = new System.Drawing.Point(268, 170);
            this.rdbno.Name = "rdbno";
            this.rdbno.Size = new System.Drawing.Size(187, 27);
            this.rdbno.TabIndex = 25;
            this.rdbno.TabStop = true;
            this.rdbno.Text = "Delar Mob No.";
            this.rdbno.UseVisualStyleBackColor = false;
            this.rdbno.CheckedChanged += new System.EventHandler(this.rdbno_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1060, 826);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 74);
            this.button4.TabIndex = 22;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(841, 826);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 74);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butser
            // 
            this.butser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butser.FlatAppearance.BorderSize = 2;
            this.butser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.butser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butser.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butser.ForeColor = System.Drawing.Color.Black;
            this.butser.Location = new System.Drawing.Point(149, 218);
            this.butser.Name = "butser";
            this.butser.Size = new System.Drawing.Size(134, 58);
            this.butser.TabIndex = 20;
            this.butser.Text = "Search";
            this.butser.UseVisualStyleBackColor = false;
            this.butser.Click += new System.EventHandler(this.butser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 826);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 74);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pnoDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.pcompanynameDataGridViewTextBoxColumn,
            this.psnameDataGridViewTextBoxColumn,
            this.ptypeproductDataGridViewTextBoxColumn,
            this.psellamountDataGridViewTextBoxColumn,
            this.ppamountDataGridViewTextBoxColumn,
            this.pdelarnoDataGridViewTextBoxColumn,
            this.addressdelarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addstockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1141, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnoDataGridViewTextBoxColumn
            // 
            this.pnoDataGridViewTextBoxColumn.DataPropertyName = "pno";
            this.pnoDataGridViewTextBoxColumn.HeaderText = "pno";
            this.pnoDataGridViewTextBoxColumn.Name = "pnoDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // pcompanynameDataGridViewTextBoxColumn
            // 
            this.pcompanynameDataGridViewTextBoxColumn.DataPropertyName = "pcompanyname";
            this.pcompanynameDataGridViewTextBoxColumn.HeaderText = "pcompanyname";
            this.pcompanynameDataGridViewTextBoxColumn.Name = "pcompanynameDataGridViewTextBoxColumn";
            // 
            // psnameDataGridViewTextBoxColumn
            // 
            this.psnameDataGridViewTextBoxColumn.DataPropertyName = "psname";
            this.psnameDataGridViewTextBoxColumn.HeaderText = "psname";
            this.psnameDataGridViewTextBoxColumn.Name = "psnameDataGridViewTextBoxColumn";
            // 
            // ptypeproductDataGridViewTextBoxColumn
            // 
            this.ptypeproductDataGridViewTextBoxColumn.DataPropertyName = "ptypeproduct";
            this.ptypeproductDataGridViewTextBoxColumn.HeaderText = "ptypeproduct";
            this.ptypeproductDataGridViewTextBoxColumn.Name = "ptypeproductDataGridViewTextBoxColumn";
            // 
            // psellamountDataGridViewTextBoxColumn
            // 
            this.psellamountDataGridViewTextBoxColumn.DataPropertyName = "psellamount";
            this.psellamountDataGridViewTextBoxColumn.HeaderText = "psellamount";
            this.psellamountDataGridViewTextBoxColumn.Name = "psellamountDataGridViewTextBoxColumn";
            // 
            // ppamountDataGridViewTextBoxColumn
            // 
            this.ppamountDataGridViewTextBoxColumn.DataPropertyName = "ppamount";
            this.ppamountDataGridViewTextBoxColumn.HeaderText = "ppamount";
            this.ppamountDataGridViewTextBoxColumn.Name = "ppamountDataGridViewTextBoxColumn";
            // 
            // pdelarnoDataGridViewTextBoxColumn
            // 
            this.pdelarnoDataGridViewTextBoxColumn.DataPropertyName = "pdelarno";
            this.pdelarnoDataGridViewTextBoxColumn.HeaderText = "pdelarno";
            this.pdelarnoDataGridViewTextBoxColumn.Name = "pdelarnoDataGridViewTextBoxColumn";
            // 
            // addressdelarDataGridViewTextBoxColumn
            // 
            this.addressdelarDataGridViewTextBoxColumn.DataPropertyName = "addressdelar";
            this.addressdelarDataGridViewTextBoxColumn.HeaderText = "addressdelar";
            this.addressdelarDataGridViewTextBoxColumn.Name = "addressdelarDataGridViewTextBoxColumn";
            // 
            // addstockBindingSource
            // 
            this.addstockBindingSource.DataMember = "addstock";
            this.addstockBindingSource.DataSource = this.management_finalDataSet;
            // 
            // management_finalDataSet
            // 
            this.management_finalDataSet.DataSetName = "management_finalDataSet";
            this.management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addstockTableAdapter
            // 
            this.addstockTableAdapter.ClearBeforeFill = true;
            // 
            // textaddressdelar
            // 
            this.textaddressdelar.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaddressdelar.Location = new System.Drawing.Point(776, 730);
            this.textaddressdelar.Name = "textaddressdelar";
            this.textaddressdelar.Size = new System.Drawing.Size(284, 38);
            this.textaddressdelar.TabIndex = 46;
            // 
            // textpdelarno
            // 
            this.textpdelarno.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpdelarno.Location = new System.Drawing.Point(776, 665);
            this.textpdelarno.Name = "textpdelarno";
            this.textpdelarno.Size = new System.Drawing.Size(284, 38);
            this.textpdelarno.TabIndex = 45;
            // 
            // textppamount
            // 
            this.textppamount.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textppamount.Location = new System.Drawing.Point(776, 600);
            this.textppamount.Name = "textppamount";
            this.textppamount.Size = new System.Drawing.Size(284, 38);
            this.textppamount.TabIndex = 44;
            // 
            // textpsellamount
            // 
            this.textpsellamount.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpsellamount.Location = new System.Drawing.Point(776, 535);
            this.textpsellamount.Name = "textpsellamount";
            this.textpsellamount.Size = new System.Drawing.Size(284, 38);
            this.textpsellamount.TabIndex = 43;
            // 
            // textptypeprodct
            // 
            this.textptypeprodct.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textptypeprodct.Location = new System.Drawing.Point(776, 470);
            this.textptypeprodct.Name = "textptypeprodct";
            this.textptypeprodct.Size = new System.Drawing.Size(284, 38);
            this.textptypeprodct.TabIndex = 42;
            // 
            // textpsname
            // 
            this.textpsname.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpsname.Location = new System.Drawing.Point(776, 405);
            this.textpsname.Name = "textpsname";
            this.textpsname.Size = new System.Drawing.Size(284, 38);
            this.textpsname.TabIndex = 41;
            // 
            // textpcompanyname
            // 
            this.textpcompanyname.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpcompanyname.Location = new System.Drawing.Point(776, 340);
            this.textpcompanyname.Name = "textpcompanyname";
            this.textpcompanyname.Size = new System.Drawing.Size(284, 38);
            this.textpcompanyname.TabIndex = 40;
            // 
            // textpname
            // 
            this.textpname.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpname.Location = new System.Drawing.Point(776, 275);
            this.textpname.Name = "textpname";
            this.textpname.Size = new System.Drawing.Size(284, 38);
            this.textpname.TabIndex = 39;
            this.textpname.TextChanged += new System.EventHandler(this.textpname_TextChanged_1);
            // 
            // textpno
            // 
            this.textpno.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpno.Location = new System.Drawing.Point(776, 210);
            this.textpno.Name = "textpno";
            this.textpno.Size = new System.Drawing.Size(284, 38);
            this.textpno.TabIndex = 38;
            this.textpno.TextChanged += new System.EventHandler(this.textpno_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(492, 733);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 31);
            this.label10.TabIndex = 37;
            this.label10.Text = "Address Delar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(428, 668);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 31);
            this.label9.TabIndex = 36;
            this.label9.Text = "Delar contact no :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(428, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 31);
            this.label8.TabIndex = 35;
            this.label8.Text = "Purchases Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(508, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sell Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(444, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "Type Of Product :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(476, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "Supplier Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(492, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = " Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(524, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product No: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-653, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3000, 93);
            this.label1.TabIndex = 28;
            this.label1.Text = "Add Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(622, 826);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 74);
            this.button2.TabIndex = 47;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 27);
            this.label11.TabIndex = 24;
            this.label11.Text = "Search :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkMagenta;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(-1, -3);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(101, 91);
            this.back.TabIndex = 48;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1767, 909);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textaddressdelar);
            this.Controls.Add(this.textpdelarno);
            this.Controls.Add(this.textppamount);
            this.Controls.Add(this.textpsellamount);
            this.Controls.Add(this.textptypeprodct);
            this.Controls.Add(this.textpsname);
            this.Controls.Add(this.textpcompanyname);
            this.Controls.Add(this.textpname);
            this.Controls.Add(this.textpno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbno);
            this.Controls.Add(this.radname);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addstock";
            this.Text = "addstock";
            this.Load += new System.EventHandler(this.addstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private management_finalDataSet management_finalDataSet;
        private System.Windows.Forms.BindingSource addstockBindingSource;
        private management_finalDataSetTableAdapters.addstockTableAdapter addstockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcompanynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptypeproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psellamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdelarnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressdelarDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radname;
        private System.Windows.Forms.RadioButton rdbno;
        private System.Windows.Forms.TextBox textser;
        private System.Windows.Forms.TextBox textaddressdelar;
        private System.Windows.Forms.TextBox textpdelarno;
        private System.Windows.Forms.TextBox textppamount;
        private System.Windows.Forms.TextBox textpsellamount;
        private System.Windows.Forms.TextBox textptypeprodct;
        private System.Windows.Forms.TextBox textpsname;
        private System.Windows.Forms.TextBox textpcompanyname;
        private System.Windows.Forms.TextBox textpname;
        private System.Windows.Forms.TextBox textpno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label11;
    }
}