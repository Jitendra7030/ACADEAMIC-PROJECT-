namespace stock_mangement_system
{
    partial class Customermaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customermaster));
            this.customermasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_finalDataSet = new stock_mangement_system.management_finalDataSet();
            this.customermasterTableAdapter = new stock_mangement_system.management_finalDataSetTableAdapters.customermasterTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textcustomernumber = new System.Windows.Forms.TextBox();
            this.textcustomercity = new System.Windows.Forms.TextBox();
            this.textcustomeradd = new System.Windows.Forms.TextBox();
            this.textcustomername = new System.Windows.Forms.TextBox();
            this.textcustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addnew = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customercityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customermasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customermasterBindingSource
            // 
            this.customermasterBindingSource.DataMember = "customermaster";
            this.customermasterBindingSource.DataSource = this.management_finalDataSet;
            // 
            // management_finalDataSet
            // 
            this.management_finalDataSet.DataSetName = "management_finalDataSet";
            this.management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customermasterTableAdapter
            // 
            this.customermasterTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(-1, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 87);
            this.button2.TabIndex = 71;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(357, 187);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(215, 31);
            this.radioButton2.TabIndex = 70;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Customer Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(83, 187);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(243, 31);
            this.radioButton1.TabIndex = 69;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contact Number ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(829, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 66);
            this.button1.TabIndex = 68;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 27);
            this.label7.TabIndex = 67;
            this.label7.Text = "Search  :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(188, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 37);
            this.textBox1.TabIndex = 66;
            // 
            // textcustomernumber
            // 
            this.textcustomernumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomernumber.Location = new System.Drawing.Point(821, 573);
            this.textcustomernumber.Multiline = true;
            this.textcustomernumber.Name = "textcustomernumber";
            this.textcustomernumber.Size = new System.Drawing.Size(243, 42);
            this.textcustomernumber.TabIndex = 65;
            // 
            // textcustomercity
            // 
            this.textcustomercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomercity.Location = new System.Drawing.Point(821, 493);
            this.textcustomercity.Multiline = true;
            this.textcustomercity.Name = "textcustomercity";
            this.textcustomercity.Size = new System.Drawing.Size(243, 42);
            this.textcustomercity.TabIndex = 64;
            // 
            // textcustomeradd
            // 
            this.textcustomeradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomeradd.Location = new System.Drawing.Point(821, 413);
            this.textcustomeradd.Multiline = true;
            this.textcustomeradd.Name = "textcustomeradd";
            this.textcustomeradd.Size = new System.Drawing.Size(243, 42);
            this.textcustomeradd.TabIndex = 63;
            // 
            // textcustomername
            // 
            this.textcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomername.Location = new System.Drawing.Point(821, 333);
            this.textcustomername.Multiline = true;
            this.textcustomername.Name = "textcustomername";
            this.textcustomername.Size = new System.Drawing.Size(243, 42);
            this.textcustomername.TabIndex = 62;
            // 
            // textcustomerID
            // 
            this.textcustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomerID.Location = new System.Drawing.Point(821, 253);
            this.textcustomerID.Multiline = true;
            this.textcustomerID.Name = "textcustomerID";
            this.textcustomerID.Size = new System.Drawing.Size(243, 42);
            this.textcustomerID.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(495, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 31);
            this.label6.TabIndex = 60;
            this.label6.Text = "Contact Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(665, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 59;
            this.label5.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(461, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 31);
            this.label4.TabIndex = 58;
            this.label4.Text = "Customer Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(512, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 31);
            this.label3.TabIndex = 57;
            this.label3.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(546, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "Customer ID :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-596, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3000, 87);
            this.label1.TabIndex = 55;
            this.label1.Text = "Customer Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addnew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.ForeColor = System.Drawing.Color.White;
            this.addnew.Location = new System.Drawing.Point(439, 728);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(158, 66);
            this.addnew.TabIndex = 51;
            this.addnew.Text = "Add New ";
            this.addnew.UseVisualStyleBackColor = false;
            this.addnew.Click += new System.EventHandler(this.addnew_Click_1);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.edit.FlatAppearance.BorderSize = 2;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Location = new System.Drawing.Point(146, 253);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(147, 60);
            this.edit.TabIndex = 52;
            this.edit.Text = "Search";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click_1);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(634, 728);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(158, 66);
            this.update.TabIndex = 53;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(1024, 728);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(158, 66);
            this.back.TabIndex = 54;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customeraddDataGridViewTextBoxColumn,
            this.customercityDataGridViewTextBoxColumn,
            this.customernumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customermasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1194, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 108);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Visible = false;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customername";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customername";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // customeraddDataGridViewTextBoxColumn
            // 
            this.customeraddDataGridViewTextBoxColumn.DataPropertyName = "customeradd";
            this.customeraddDataGridViewTextBoxColumn.HeaderText = "customeradd";
            this.customeraddDataGridViewTextBoxColumn.Name = "customeraddDataGridViewTextBoxColumn";
            // 
            // customercityDataGridViewTextBoxColumn
            // 
            this.customercityDataGridViewTextBoxColumn.DataPropertyName = "customercity";
            this.customercityDataGridViewTextBoxColumn.HeaderText = "customercity";
            this.customercityDataGridViewTextBoxColumn.Name = "customercityDataGridViewTextBoxColumn";
            // 
            // customernumberDataGridViewTextBoxColumn
            // 
            this.customernumberDataGridViewTextBoxColumn.DataPropertyName = "customernumber";
            this.customernumberDataGridViewTextBoxColumn.HeaderText = "customernumber";
            this.customernumberDataGridViewTextBoxColumn.Name = "customernumberDataGridViewTextBoxColumn";
            // 
            // Customermaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1752, 826);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textcustomernumber);
            this.Controls.Add(this.textcustomercity);
            this.Controls.Add(this.textcustomeradd);
            this.Controls.Add(this.textcustomername);
            this.Controls.Add(this.textcustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customermaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customermaster";
            this.Load += new System.EventHandler(this.Customermaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customermasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private management_finalDataSet management_finalDataSet;
        private System.Windows.Forms.BindingSource customermasterBindingSource;
        private management_finalDataSetTableAdapters.customermasterTableAdapter customermasterTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textcustomernumber;
        private System.Windows.Forms.TextBox textcustomercity;
        private System.Windows.Forms.TextBox textcustomeradd;
        private System.Windows.Forms.TextBox textcustomername;
        private System.Windows.Forms.TextBox textcustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customercityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernumberDataGridViewTextBoxColumn;
    }
}