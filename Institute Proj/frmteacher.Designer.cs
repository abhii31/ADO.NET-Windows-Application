namespace Institute_Proj
{
    partial class frmteacher
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
            this.dgvteacher = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet3 = new Institute_Proj.Institute_ProjDataSet3();
            this.teacherTableAdapter = new Institute_Proj.Institute_ProjDataSet3TableAdapters.teacherTableAdapter();
            this.txttnm = new System.Windows.Forms.TextBox();
            this.txttadd = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnm = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblbid = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.cmbbid = new System.Windows.Forms.ComboBox();
            this.cmbtid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvteacher
            // 
            this.dgvteacher.AllowUserToAddRows = false;
            this.dgvteacher.AllowUserToDeleteRows = false;
            this.dgvteacher.AutoGenerateColumns = false;
            this.dgvteacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tAddDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.tPhNoDataGridViewTextBoxColumn,
            this.tGenderDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.bIdDataGridViewTextBoxColumn});
            this.dgvteacher.DataSource = this.teacherBindingSource;
            this.dgvteacher.GridColor = System.Drawing.Color.Black;
            this.dgvteacher.Location = new System.Drawing.Point(35, 417);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.ReadOnly = true;
            this.dgvteacher.RowHeadersWidth = 51;
            this.dgvteacher.RowTemplate.Height = 24;
            this.dgvteacher.Size = new System.Drawing.Size(1368, 264);
            this.dgvteacher.TabIndex = 0;
            this.dgvteacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteacher_CellContentClick);
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "T_Name";
            this.tNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAddDataGridViewTextBoxColumn
            // 
            this.tAddDataGridViewTextBoxColumn.DataPropertyName = "T_Add";
            this.tAddDataGridViewTextBoxColumn.HeaderText = "T_Add";
            this.tAddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAddDataGridViewTextBoxColumn.Name = "tAddDataGridViewTextBoxColumn";
            this.tAddDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAddDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tPhNoDataGridViewTextBoxColumn
            // 
            this.tPhNoDataGridViewTextBoxColumn.DataPropertyName = "T_Ph_No";
            this.tPhNoDataGridViewTextBoxColumn.HeaderText = "T_Ph_No";
            this.tPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tPhNoDataGridViewTextBoxColumn.Name = "tPhNoDataGridViewTextBoxColumn";
            this.tPhNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPhNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGenderDataGridViewTextBoxColumn
            // 
            this.tGenderDataGridViewTextBoxColumn.DataPropertyName = "T_Gender";
            this.tGenderDataGridViewTextBoxColumn.HeaderText = "T_Gender";
            this.tGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGenderDataGridViewTextBoxColumn.Name = "tGenderDataGridViewTextBoxColumn";
            this.tGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.tGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bIdDataGridViewTextBoxColumn
            // 
            this.bIdDataGridViewTextBoxColumn.DataPropertyName = "B_Id";
            this.bIdDataGridViewTextBoxColumn.HeaderText = "B_Id";
            this.bIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIdDataGridViewTextBoxColumn.Name = "bIdDataGridViewTextBoxColumn";
            this.bIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.institute_ProjDataSet3;
            // 
            // institute_ProjDataSet3
            // 
            this.institute_ProjDataSet3.DataSetName = "Institute_ProjDataSet3";
            this.institute_ProjDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // txttnm
            // 
            this.txttnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttnm.Location = new System.Drawing.Point(1134, 53);
            this.txttnm.Multiline = true;
            this.txttnm.Name = "txttnm";
            this.txttnm.Size = new System.Drawing.Size(200, 30);
            this.txttnm.TabIndex = 2;
            this.txttnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttnm_TextChanged);
            // 
            // txttadd
            // 
            this.txttadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttadd.Location = new System.Drawing.Point(483, 128);
            this.txttadd.Multiline = true;
            this.txttadd.Name = "txttadd";
            this.txttadd.Size = new System.Drawing.Size(200, 30);
            this.txttadd.TabIndex = 3;
            this.txttadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttadd_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(1134, 128);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 30);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(483, 200);
            this.txtno.MaxLength = 10;
            this.txtno.Multiline = true;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(200, 30);
            this.txtno.TabIndex = 5;
            this.txtno.TextChanged += new System.EventHandler(this.txtno_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Maroon;
            this.lblid.Location = new System.Drawing.Point(143, 56);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(142, 29);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "Teacher ID";
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.BackColor = System.Drawing.Color.White;
            this.lblnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblnm.Location = new System.Drawing.Point(853, 56);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(186, 29);
            this.lblnm.TabIndex = 10;
            this.lblnm.Text = "Teacher Name";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.White;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.ForeColor = System.Drawing.Color.Maroon;
            this.lbladd.Location = new System.Drawing.Point(143, 131);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(213, 29);
            this.lbladd.TabIndex = 11;
            this.lbladd.Text = "Teacher Address";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Maroon;
            this.lblemail.Location = new System.Drawing.Point(853, 131);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(111, 29);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "Email ID";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.White;
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.Maroon;
            this.lblno.Location = new System.Drawing.Point(143, 203);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(240, 29);
            this.lblno.TabIndex = 13;
            this.lblno.Text = "Teacher Phone No.";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Maroon;
            this.lblgender.Location = new System.Drawing.Point(853, 203);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(100, 29);
            this.lblgender.TabIndex = 14;
            this.lblgender.Text = "Gender";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.BackColor = System.Drawing.Color.White;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.ForeColor = System.Drawing.Color.Maroon;
            this.lblcid.Location = new System.Drawing.Point(143, 275);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(129, 29);
            this.lblcid.TabIndex = 15;
            this.lblcid.Text = "Course ID";
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.BackColor = System.Drawing.Color.White;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.ForeColor = System.Drawing.Color.Maroon;
            this.lblbid.Location = new System.Drawing.Point(853, 275);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(110, 29);
            this.lblbid.TabIndex = 16;
            this.lblbid.Text = "Batch ID";
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Blue;
            this.btsave.Location = new System.Drawing.Point(70, 342);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(170, 50);
            this.btsave.TabIndex = 17;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(433, 342);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(843, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(1233, 342);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.cmbgender.Location = new System.Drawing.Point(1134, 207);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(200, 28);
            this.cmbgender.TabIndex = 21;
            // 
            // cmbcid
            // 
            this.cmbcid.BackColor = System.Drawing.Color.White;
            this.cmbcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcid.ForeColor = System.Drawing.Color.Black;
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.cmbcid.Location = new System.Drawing.Point(483, 279);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(200, 28);
            this.cmbcid.TabIndex = 22;
            // 
            // cmbbid
            // 
            this.cmbbid.BackColor = System.Drawing.Color.White;
            this.cmbbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbid.ForeColor = System.Drawing.Color.Black;
            this.cmbbid.FormattingEnabled = true;
            this.cmbbid.Items.AddRange(new object[] {
            "1001",
            "1002",
            "1003",
            "1004",
            "1005",
            "1006",
            "1007",
            "1008",
            "1009",
            "1010"});
            this.cmbbid.Location = new System.Drawing.Point(1134, 279);
            this.cmbbid.Name = "cmbbid";
            this.cmbbid.Size = new System.Drawing.Size(200, 28);
            this.cmbbid.TabIndex = 25;
            // 
            // cmbtid
            // 
            this.cmbtid.BackColor = System.Drawing.Color.White;
            this.cmbtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtid.ForeColor = System.Drawing.Color.Black;
            this.cmbtid.FormattingEnabled = true;
            this.cmbtid.Items.AddRange(new object[] {
            "1101",
            "1102",
            "1103",
            "1104",
            "1105",
            "1106",
            "1107",
            "1108",
            "1109",
            "1110"});
            this.cmbtid.Location = new System.Drawing.Point(483, 60);
            this.cmbtid.Name = "cmbtid";
            this.cmbtid.Size = new System.Drawing.Size(200, 28);
            this.cmbtid.TabIndex = 26;
            // 
            // frmteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1475, 702);
            this.Controls.Add(this.cmbtid);
            this.Controls.Add(this.cmbbid);
            this.Controls.Add(this.cmbcid);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.lblbid);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblnm);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttadd);
            this.Controls.Add(this.txttnm);
            this.Controls.Add(this.dgvteacher);
            this.Name = "frmteacher";
            this.Text = "teacher";
            this.Load += new System.EventHandler(this.teacher_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttadd_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvteacher;
        private Institute_ProjDataSet3 institute_ProjDataSet3;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Institute_ProjDataSet3TableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txttnm;
        private System.Windows.Forms.TextBox txttadd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.ComboBox cmbbid;
        private System.Windows.Forms.ComboBox cmbtid;
    }
}