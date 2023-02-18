namespace Institute_Proj
{
    partial class frmbill
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
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.bNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet6 = new Institute_Proj.Institute_ProjDataSet6();
            this.billTableAdapter = new Institute_Proj.Institute_ProjDataSet6TableAdapters.billTableAdapter();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblbid = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblsnm = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsadd = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lbltfee = new System.Windows.Forms.Label();
            this.lblpfee = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtsnm = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsadd = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txttfee = new System.Windows.Forms.TextBox();
            this.txtpfee = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtbno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToAddRows = false;
            this.dgvbill.AllowUserToDeleteRows = false;
            this.dgvbill.AutoGenerateColumns = false;
            this.dgvbill.BackgroundColor = System.Drawing.Color.White;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.addIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.sAddDataGridViewTextBoxColumn,
            this.sGenderDataGridViewTextBoxColumn,
            this.sPhNoDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.totalFeeDataGridViewTextBoxColumn,
            this.paidFeeDataGridViewTextBoxColumn});
            this.dgvbill.DataSource = this.billBindingSource;
            this.dgvbill.Location = new System.Drawing.Point(12, 442);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.ReadOnly = true;
            this.dgvbill.RowHeadersWidth = 51;
            this.dgvbill.RowTemplate.Height = 24;
            this.dgvbill.Size = new System.Drawing.Size(1873, 277);
            this.dgvbill.TabIndex = 0;
            this.dgvbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellContentClick);
            // 
            // bNoDataGridViewTextBoxColumn
            // 
            this.bNoDataGridViewTextBoxColumn.DataPropertyName = "B_No";
            this.bNoDataGridViewTextBoxColumn.HeaderText = "B_No";
            this.bNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bNoDataGridViewTextBoxColumn.Name = "bNoDataGridViewTextBoxColumn";
            this.bNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "S_ID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // addIDDataGridViewTextBoxColumn
            // 
            this.addIDDataGridViewTextBoxColumn.DataPropertyName = "Add_ID";
            this.addIDDataGridViewTextBoxColumn.HeaderText = "Add_ID";
            this.addIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addIDDataGridViewTextBoxColumn.Name = "addIDDataGridViewTextBoxColumn";
            this.addIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.addIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNameDataGridViewTextBoxColumn.Width = 125;
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
            // sAddDataGridViewTextBoxColumn
            // 
            this.sAddDataGridViewTextBoxColumn.DataPropertyName = "S_Add";
            this.sAddDataGridViewTextBoxColumn.HeaderText = "S_Add";
            this.sAddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sAddDataGridViewTextBoxColumn.Name = "sAddDataGridViewTextBoxColumn";
            this.sAddDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAddDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGenderDataGridViewTextBoxColumn
            // 
            this.sGenderDataGridViewTextBoxColumn.DataPropertyName = "S_Gender";
            this.sGenderDataGridViewTextBoxColumn.HeaderText = "S_Gender";
            this.sGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGenderDataGridViewTextBoxColumn.Name = "sGenderDataGridViewTextBoxColumn";
            this.sGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPhNoDataGridViewTextBoxColumn
            // 
            this.sPhNoDataGridViewTextBoxColumn.DataPropertyName = "S_Ph_No";
            this.sPhNoDataGridViewTextBoxColumn.HeaderText = "S_Ph_No";
            this.sPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPhNoDataGridViewTextBoxColumn.Name = "sPhNoDataGridViewTextBoxColumn";
            this.sPhNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPhNoDataGridViewTextBoxColumn.Width = 125;
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
            // totalFeeDataGridViewTextBoxColumn
            // 
            this.totalFeeDataGridViewTextBoxColumn.DataPropertyName = "Total_Fee";
            this.totalFeeDataGridViewTextBoxColumn.HeaderText = "Total_Fee";
            this.totalFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalFeeDataGridViewTextBoxColumn.Name = "totalFeeDataGridViewTextBoxColumn";
            this.totalFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // paidFeeDataGridViewTextBoxColumn
            // 
            this.paidFeeDataGridViewTextBoxColumn.DataPropertyName = "Paid_Fee";
            this.paidFeeDataGridViewTextBoxColumn.HeaderText = "Paid_Fee";
            this.paidFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidFeeDataGridViewTextBoxColumn.Name = "paidFeeDataGridViewTextBoxColumn";
            this.paidFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.institute_ProjDataSet6;
            // 
            // institute_ProjDataSet6
            // 
            this.institute_ProjDataSet6.DataSetName = "Institute_ProjDataSet6";
            this.institute_ProjDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(449, 360);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 50);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(875, 360);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(1253, 360);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(1630, 360);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.BackColor = System.Drawing.Color.White;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.ForeColor = System.Drawing.Color.Maroon;
            this.lblbid.Location = new System.Drawing.Point(124, 65);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(151, 29);
            this.lblbid.TabIndex = 5;
            this.lblbid.Text = "Bill Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Maroon;
            this.lbldate.Location = new System.Drawing.Point(724, 66);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(67, 29);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Date";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.White;
            this.lblsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.ForeColor = System.Drawing.Color.Maroon;
            this.lblsid.Location = new System.Drawing.Point(1304, 65);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(134, 29);
            this.lblsid.TabIndex = 7;
            this.lblsid.Text = "Student ID";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.White;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.ForeColor = System.Drawing.Color.Maroon;
            this.lbladd.Location = new System.Drawing.Point(124, 139);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(166, 29);
            this.lbladd.TabIndex = 8;
            this.lbladd.Text = "Admission ID";
            // 
            // lblsnm
            // 
            this.lblsnm.AutoSize = true;
            this.lblsnm.BackColor = System.Drawing.Color.White;
            this.lblsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblsnm.Location = new System.Drawing.Point(724, 139);
            this.lblsnm.Name = "lblsnm";
            this.lblsnm.Size = new System.Drawing.Size(178, 29);
            this.lblsnm.TabIndex = 9;
            this.lblsnm.Text = "Student Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Maroon;
            this.lblemail.Location = new System.Drawing.Point(1304, 139);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(111, 29);
            this.lblemail.TabIndex = 10;
            this.lblemail.Text = "Email ID";
            // 
            // lblsadd
            // 
            this.lblsadd.AutoSize = true;
            this.lblsadd.BackColor = System.Drawing.Color.White;
            this.lblsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsadd.ForeColor = System.Drawing.Color.Maroon;
            this.lblsadd.Location = new System.Drawing.Point(124, 213);
            this.lblsadd.Name = "lblsadd";
            this.lblsadd.Size = new System.Drawing.Size(205, 29);
            this.lblsadd.TabIndex = 11;
            this.lblsadd.Text = "Student Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Maroon;
            this.lblgender.Location = new System.Drawing.Point(724, 213);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(100, 29);
            this.lblgender.TabIndex = 12;
            this.lblgender.Text = "Gender";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.White;
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.Maroon;
            this.lblno.Location = new System.Drawing.Point(1304, 213);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(232, 29);
            this.lblno.TabIndex = 13;
            this.lblno.Text = "Student Phone No.";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.BackColor = System.Drawing.Color.White;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.ForeColor = System.Drawing.Color.Maroon;
            this.lblcid.Location = new System.Drawing.Point(124, 288);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(129, 29);
            this.lblcid.TabIndex = 14;
            this.lblcid.Text = "Course ID";
            // 
            // lbltfee
            // 
            this.lbltfee.AutoSize = true;
            this.lbltfee.BackColor = System.Drawing.Color.White;
            this.lbltfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltfee.ForeColor = System.Drawing.Color.Maroon;
            this.lbltfee.Location = new System.Drawing.Point(724, 288);
            this.lbltfee.Name = "lbltfee";
            this.lbltfee.Size = new System.Drawing.Size(126, 29);
            this.lbltfee.TabIndex = 15;
            this.lbltfee.Text = "Total Fee";
            // 
            // lblpfee
            // 
            this.lblpfee.AutoSize = true;
            this.lblpfee.BackColor = System.Drawing.Color.White;
            this.lblpfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpfee.ForeColor = System.Drawing.Color.Maroon;
            this.lblpfee.Location = new System.Drawing.Point(1304, 288);
            this.lblpfee.Name = "lblpfee";
            this.lblpfee.Size = new System.Drawing.Size(119, 29);
            this.lblpfee.TabIndex = 16;
            this.lblpfee.Text = "Paid Fee";
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(1587, 62);
            this.txtsid.Multiline = true;
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(200, 30);
            this.txtsid.TabIndex = 19;
            this.txtsid.TextChanged += new System.EventHandler(this.txtsid_TextChanged);
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(382, 136);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(200, 30);
            this.txtadd.TabIndex = 20;
            // 
            // txtsnm
            // 
            this.txtsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsnm.Location = new System.Drawing.Point(979, 136);
            this.txtsnm.Multiline = true;
            this.txtsnm.Name = "txtsnm";
            this.txtsnm.Size = new System.Drawing.Size(200, 30);
            this.txtsnm.TabIndex = 21;
            this.txtsnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsnm_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(1587, 136);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 30);
            this.txtemail.TabIndex = 22;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtsadd
            // 
            this.txtsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsadd.Location = new System.Drawing.Point(382, 210);
            this.txtsadd.Multiline = true;
            this.txtsadd.Name = "txtsadd";
            this.txtsadd.Size = new System.Drawing.Size(200, 30);
            this.txtsadd.TabIndex = 23;
            this.txtsadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsadd_TextChanged);
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(1587, 210);
            this.txtno.MaxLength = 10;
            this.txtno.Multiline = true;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(200, 30);
            this.txtno.TabIndex = 25;
            this.txtno.TextChanged += new System.EventHandler(this.txtno_TextChanged);
            // 
            // txttfee
            // 
            this.txttfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttfee.Location = new System.Drawing.Point(979, 285);
            this.txttfee.Multiline = true;
            this.txttfee.Name = "txttfee";
            this.txttfee.Size = new System.Drawing.Size(200, 30);
            this.txttfee.TabIndex = 27;
            // 
            // txtpfee
            // 
            this.txtpfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpfee.Location = new System.Drawing.Point(1587, 285);
            this.txtpfee.Multiline = true;
            this.txtpfee.Name = "txtpfee";
            this.txtpfee.Size = new System.Drawing.Size(200, 30);
            this.txtpfee.TabIndex = 28;
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Transgender"});
            this.cmbgender.Location = new System.Drawing.Point(979, 213);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(200, 33);
            this.cmbgender.TabIndex = 29;
            // 
            // dtpdate
            // 
            this.dtpdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(979, 63);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 30);
            this.dtpdate.TabIndex = 30;
            // 
            // cmbcid
            // 
            this.cmbcid.BackColor = System.Drawing.Color.White;
            this.cmbcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Items.AddRange(new object[] {
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
            this.cmbcid.Location = new System.Drawing.Point(382, 288);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(200, 28);
            this.cmbcid.TabIndex = 32;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(83, 360);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(170, 50);
            this.btnnew.TabIndex = 33;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtbno
            // 
            this.txtbno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbno.Location = new System.Drawing.Point(382, 65);
            this.txtbno.Multiline = true;
            this.txtbno.Name = "txtbno";
            this.txtbno.ReadOnly = true;
            this.txtbno.Size = new System.Drawing.Size(200, 30);
            this.txtbno.TabIndex = 34;
            // 
            // frmbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1897, 731);
            this.Controls.Add(this.txtbno);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.cmbcid);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtpfee);
            this.Controls.Add(this.txttfee);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtsadd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsnm);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.lblpfee);
            this.Controls.Add(this.lbltfee);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblsadd);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsnm);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblbid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvbill);
            this.Name = "frmbill";
            this.Text = "frmbill";
            this.Load += new System.EventHandler(this.frmbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbill;
        private Institute_ProjDataSet6 institute_ProjDataSet6;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Institute_ProjDataSet6TableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblsnm;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsadd;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lbltfee;
        private System.Windows.Forms.Label lblpfee;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtsnm;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsadd;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txttfee;
        private System.Windows.Forms.TextBox txtpfee;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtbno;
    }
}