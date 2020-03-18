namespace stock_mangement_system
{
    partial class productmaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productmaster));
            this.productmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_finalDataSet = new stock_mangement_system.management_finalDataSet();
            this.productmasterTableAdapter = new stock_mangement_system.management_finalDataSetTableAdapters.productmasterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addnew = new System.Windows.Forms.Button();
            this.textpdes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textpprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textpcompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textptype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productmasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmasterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productmasterBindingSource
            // 
            this.productmasterBindingSource.DataMember = "productmaster";
            this.productmasterBindingSource.DataSource = this.management_finalDataSet;
            // 
            // management_finalDataSet
            // 
            this.management_finalDataSet.DataSetName = "management_finalDataSet";
            this.management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productmasterTableAdapter
            // 
            this.productmasterTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(-4, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 91);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(241, 168);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 26);
            this.radioButton1.TabIndex = 71;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Product Name";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 70;
            this.label8.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(203, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 36);
            this.textBox1.TabIndex = 69;
            // 
            // butser
            // 
            this.butser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butser.FlatAppearance.BorderSize = 2;
            this.butser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.butser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butser.ForeColor = System.Drawing.Color.Black;
            this.butser.Location = new System.Drawing.Point(149, 231);
            this.butser.Name = "butser";
            this.butser.Size = new System.Drawing.Size(140, 58);
            this.butser.TabIndex = 68;
            this.butser.Text = "Search";
            this.butser.UseVisualStyleBackColor = false;
            this.butser.Click += new System.EventHandler(this.butser_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(894, 732);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 67;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(691, 732);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 66;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addnew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addnew.FlatAppearance.BorderSize = 2;
            this.addnew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnew.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addnew.Location = new System.Drawing.Point(488, 732);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(143, 54);
            this.addnew.TabIndex = 65;
            this.addnew.Text = "Add New";
            this.addnew.UseVisualStyleBackColor = false;
            this.addnew.Click += new System.EventHandler(this.addnew_Click_1);
            // 
            // textpdes
            // 
            this.textpdes.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpdes.ForeColor = System.Drawing.Color.Black;
            this.textpdes.Location = new System.Drawing.Point(749, 611);
            this.textpdes.Multiline = true;
            this.textpdes.Name = "textpdes";
            this.textpdes.Size = new System.Drawing.Size(233, 36);
            this.textpdes.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(491, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 31);
            this.label7.TabIndex = 63;
            this.label7.Text = "Descripation";
            // 
            // textpprice
            // 
            this.textpprice.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpprice.ForeColor = System.Drawing.Color.Black;
            this.textpprice.Location = new System.Drawing.Point(749, 544);
            this.textpprice.Multiline = true;
            this.textpprice.Name = "textpprice";
            this.textpprice.Size = new System.Drawing.Size(233, 36);
            this.textpprice.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(562, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 31);
            this.label6.TabIndex = 61;
            this.label6.Text = "Price";
            // 
            // textpcompany
            // 
            this.textpcompany.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpcompany.ForeColor = System.Drawing.Color.Black;
            this.textpcompany.Location = new System.Drawing.Point(749, 477);
            this.textpcompany.Multiline = true;
            this.textpcompany.Name = "textpcompany";
            this.textpcompany.Size = new System.Drawing.Size(233, 36);
            this.textpcompany.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(519, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 59;
            this.label5.Text = "Company";
            // 
            // textptype
            // 
            this.textptype.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textptype.ForeColor = System.Drawing.Color.Black;
            this.textptype.Location = new System.Drawing.Point(749, 410);
            this.textptype.Multiline = true;
            this.textptype.Name = "textptype";
            this.textptype.Size = new System.Drawing.Size(233, 36);
            this.textptype.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(482, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "Product Type";
            // 
            // textpname
            // 
            this.textpname.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpname.ForeColor = System.Drawing.Color.Black;
            this.textpname.Location = new System.Drawing.Point(749, 343);
            this.textpname.Multiline = true;
            this.textpname.Name = "textpname";
            this.textpname.Size = new System.Drawing.Size(233, 36);
            this.textpname.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(475, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Product Name";
            // 
            // textpID
            // 
            this.textpID.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpID.ForeColor = System.Drawing.Color.Black;
            this.textpID.Location = new System.Drawing.Point(749, 276);
            this.textpID.Multiline = true;
            this.textpID.Name = "textpID";
            this.textpID.Size = new System.Drawing.Size(233, 36);
            this.textpID.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(510, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-659, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3000, 91);
            this.label1.TabIndex = 52;
            this.label1.Text = "Product Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.ptypeDataGridViewTextBoxColumn,
            this.pcompanyDataGridViewTextBoxColumn,
            this.ppriceDataGridViewTextBoxColumn,
            this.pdesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productmasterBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1073, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 204);
            this.dataGridView1.TabIndex = 51;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "pID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "pID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // ptypeDataGridViewTextBoxColumn
            // 
            this.ptypeDataGridViewTextBoxColumn.DataPropertyName = "ptype";
            this.ptypeDataGridViewTextBoxColumn.HeaderText = "ptype";
            this.ptypeDataGridViewTextBoxColumn.Name = "ptypeDataGridViewTextBoxColumn";
            // 
            // pcompanyDataGridViewTextBoxColumn
            // 
            this.pcompanyDataGridViewTextBoxColumn.DataPropertyName = "pcompany";
            this.pcompanyDataGridViewTextBoxColumn.HeaderText = "pcompany";
            this.pcompanyDataGridViewTextBoxColumn.Name = "pcompanyDataGridViewTextBoxColumn";
            // 
            // ppriceDataGridViewTextBoxColumn
            // 
            this.ppriceDataGridViewTextBoxColumn.DataPropertyName = "pprice";
            this.ppriceDataGridViewTextBoxColumn.HeaderText = "pprice";
            this.ppriceDataGridViewTextBoxColumn.Name = "ppriceDataGridViewTextBoxColumn";
            // 
            // pdesDataGridViewTextBoxColumn
            // 
            this.pdesDataGridViewTextBoxColumn.DataPropertyName = "pdes";
            this.pdesDataGridViewTextBoxColumn.HeaderText = "pdes";
            this.pdesDataGridViewTextBoxColumn.Name = "pdesDataGridViewTextBoxColumn";
            // 
            // productmasterBindingSource1
            // 
            this.productmasterBindingSource1.DataMember = "productmaster";
            this.productmasterBindingSource1.DataSource = this.management_finalDataSet;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1086, 732);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 54);
            this.button4.TabIndex = 73;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1752, 835);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.textpdes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textpprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textpcompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textptype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productmaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productmaster";
            this.Load += new System.EventHandler(this.productmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmasterBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private management_finalDataSet management_finalDataSet;
        private System.Windows.Forms.BindingSource productmasterBindingSource;
        private management_finalDataSetTableAdapters.productmasterTableAdapter productmasterTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.TextBox textpdes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textpprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textpcompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textptype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productmasterBindingSource1;
        private System.Windows.Forms.Button button4;
    }
}