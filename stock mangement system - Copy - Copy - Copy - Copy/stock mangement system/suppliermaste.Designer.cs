namespace stock_mangement_system
{
    partial class suppliermaste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliermaste));
            this.suppliermasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_finalDataSet = new stock_mangement_system.management_finalDataSet();
            this.suppliermasterTableAdapter = new stock_mangement_system.management_finalDataSetTableAdapters.suppliermasterTableAdapter();
            this.back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textscontact = new System.Windows.Forms.TextBox();
            this.textscity = new System.Windows.Forms.TextBox();
            this.textsaddress = new System.Windows.Forms.TextBox();
            this.textsname = new System.Windows.Forms.TextBox();
            this.textsID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.suppliermasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliermasterBindingSource
            // 
            this.suppliermasterBindingSource.DataMember = "suppliermaster";
            this.suppliermasterBindingSource.DataSource = this.management_finalDataSet;
            // 
            // management_finalDataSet
            // 
            this.management_finalDataSet.DataSetName = "management_finalDataSet";
            this.management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliermasterTableAdapter
            // 
            this.suppliermasterTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkMagenta;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(-3, -1);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 70);
            this.back.TabIndex = 68;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 31);
            this.label8.TabIndex = 67;
            this.label8.Text = "Search Name :";
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(109, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 57);
            this.button5.TabIndex = 66;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 37);
            this.textBox1.TabIndex = 65;
            // 
            // textscontact
            // 
            this.textscontact.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textscontact.ForeColor = System.Drawing.Color.White;
            this.textscontact.Location = new System.Drawing.Point(864, 596);
            this.textscontact.Multiline = true;
            this.textscontact.Name = "textscontact";
            this.textscontact.Size = new System.Drawing.Size(237, 33);
            this.textscontact.TabIndex = 64;
            // 
            // textscity
            // 
            this.textscity.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textscity.ForeColor = System.Drawing.Color.White;
            this.textscity.Location = new System.Drawing.Point(864, 519);
            this.textscity.Multiline = true;
            this.textscity.Name = "textscity";
            this.textscity.Size = new System.Drawing.Size(237, 33);
            this.textscity.TabIndex = 63;
            // 
            // textsaddress
            // 
            this.textsaddress.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsaddress.ForeColor = System.Drawing.Color.White;
            this.textsaddress.Location = new System.Drawing.Point(864, 442);
            this.textsaddress.Multiline = true;
            this.textsaddress.Name = "textsaddress";
            this.textsaddress.Size = new System.Drawing.Size(237, 33);
            this.textsaddress.TabIndex = 62;
            // 
            // textsname
            // 
            this.textsname.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsname.ForeColor = System.Drawing.Color.White;
            this.textsname.Location = new System.Drawing.Point(864, 365);
            this.textsname.Multiline = true;
            this.textsname.Name = "textsname";
            this.textsname.Size = new System.Drawing.Size(237, 33);
            this.textsname.TabIndex = 61;
            // 
            // textsID
            // 
            this.textsID.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsID.ForeColor = System.Drawing.Color.White;
            this.textsID.Location = new System.Drawing.Point(864, 288);
            this.textsID.Multiline = true;
            this.textsID.Name = "textsID";
            this.textsID.Size = new System.Drawing.Size(237, 33);
            this.textsID.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(504, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 33);
            this.label6.TabIndex = 59;
            this.label6.Text = "Contact Person :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(684, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 33);
            this.label5.TabIndex = 58;
            this.label5.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(468, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 33);
            this.label4.TabIndex = 57;
            this.label4.Text = "Supplier Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(522, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 33);
            this.label3.TabIndex = 56;
            this.label3.Text = "Supplier Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(558, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 33);
            this.label2.TabIndex = 55;
            this.label2.Text = "Supplier ID :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-597, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3000, 70);
            this.label1.TabIndex = 54;
            this.label1.Text = "Supplier Master ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(474, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 61);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(722, 731);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 61);
            this.button2.TabIndex = 52;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(970, 731);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 61);
            this.button4.TabIndex = 53;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.saddressDataGridViewTextBoxColumn,
            this.scityDataGridViewTextBoxColumn,
            this.scontactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suppliermasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1230, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 338);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Visible = false;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // saddressDataGridViewTextBoxColumn
            // 
            this.saddressDataGridViewTextBoxColumn.DataPropertyName = "saddress";
            this.saddressDataGridViewTextBoxColumn.HeaderText = "saddress";
            this.saddressDataGridViewTextBoxColumn.Name = "saddressDataGridViewTextBoxColumn";
            // 
            // scityDataGridViewTextBoxColumn
            // 
            this.scityDataGridViewTextBoxColumn.DataPropertyName = "scity";
            this.scityDataGridViewTextBoxColumn.HeaderText = "scity";
            this.scityDataGridViewTextBoxColumn.Name = "scityDataGridViewTextBoxColumn";
            // 
            // scontactDataGridViewTextBoxColumn
            // 
            this.scontactDataGridViewTextBoxColumn.DataPropertyName = "scontact";
            this.scontactDataGridViewTextBoxColumn.HeaderText = "scontact";
            this.scontactDataGridViewTextBoxColumn.Name = "scontactDataGridViewTextBoxColumn";
            // 
            // suppliermaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1831, 842);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textscontact);
            this.Controls.Add(this.textscity);
            this.Controls.Add(this.textsaddress);
            this.Controls.Add(this.textsname);
            this.Controls.Add(this.textsID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "suppliermaste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppliermaste";
            this.Load += new System.EventHandler(this.suppliermaste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliermasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private management_finalDataSet management_finalDataSet;
        private System.Windows.Forms.BindingSource suppliermasterBindingSource;
        private management_finalDataSetTableAdapters.suppliermasterTableAdapter suppliermasterTableAdapter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textscontact;
        private System.Windows.Forms.TextBox textscity;
        private System.Windows.Forms.TextBox textsaddress;
        private System.Windows.Forms.TextBox textsname;
        private System.Windows.Forms.TextBox textsID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scontactDataGridViewTextBoxColumn;
    }
}