namespace Institute_Proj
{
    partial class frmenquiry
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
            this.dgvenquiry = new System.Windows.Forms.DataGridView();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet2 = new Institute_Proj.Institute_ProjDataSet2();
            this.enquiryTableAdapter = new Institute_Proj.Institute_ProjDataSet2TableAdapters.enquiryTableAdapter();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.lblsnm = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblsadd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcnm = new System.Windows.Forms.Label();
            this.lblbtime = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbcnm = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtbtime = new System.Windows.Forms.TextBox();
            this.txtsnm = new System.Windows.Forms.TextBox();
            this.txtsadd = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvenquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvenquiry
            // 
            this.dgvenquiry.AllowUserToAddRows = false;
            this.dgvenquiry.AllowUserToDeleteRows = false;
            this.dgvenquiry.AutoGenerateColumns = false;
            this.dgvenquiry.BackgroundColor = System.Drawing.Color.White;
            this.dgvenquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvenquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAddDataGridViewTextBoxColumn,
            this.sGenderDataGridViewTextBoxColumn,
            this.sPhNoDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.bTimeDataGridViewTextBoxColumn});
            this.dgvenquiry.DataSource = this.enquiryBindingSource;
            this.dgvenquiry.GridColor = System.Drawing.Color.Black;
            this.dgvenquiry.Location = new System.Drawing.Point(40, 426);
            this.dgvenquiry.Name = "dgvenquiry";
            this.dgvenquiry.ReadOnly = true;
            this.dgvenquiry.RowHeadersWidth = 51;
            this.dgvenquiry.RowTemplate.Height = 24;
            this.dgvenquiry.Size = new System.Drawing.Size(1531, 210);
            this.dgvenquiry.TabIndex = 0;
            this.dgvenquiry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvenquiry_CellContentClick);
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "E_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "E_id";
            this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.ReadOnly = true;
            this.eidDataGridViewTextBoxColumn.Width = 125;
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
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "S_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "S_id";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Width = 125;
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
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "C_Name";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bTimeDataGridViewTextBoxColumn
            // 
            this.bTimeDataGridViewTextBoxColumn.DataPropertyName = "B_Time";
            this.bTimeDataGridViewTextBoxColumn.HeaderText = "B_Time";
            this.bTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bTimeDataGridViewTextBoxColumn.Name = "bTimeDataGridViewTextBoxColumn";
            this.bTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataMember = "enquiry";
            this.enquiryBindingSource.DataSource = this.institute_ProjDataSet2;
            // 
            // institute_ProjDataSet2
            // 
            this.institute_ProjDataSet2.DataSetName = "Institute_ProjDataSet2";
            this.institute_ProjDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enquiryTableAdapter
            // 
            this.enquiryTableAdapter.ClearBeforeFill = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Maroon;
            this.lblid.Location = new System.Drawing.Point(202, 33);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(133, 29);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Enquiry ID";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Maroon;
            this.lbldate.Location = new System.Drawing.Point(857, 33);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(162, 29);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Enquiry Date";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.White;
            this.lblsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.ForeColor = System.Drawing.Color.Maroon;
            this.lblsid.Location = new System.Drawing.Point(202, 97);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(134, 29);
            this.lblsid.TabIndex = 3;
            this.lblsid.Text = "Student ID";
            // 
            // lblsnm
            // 
            this.lblsnm.AutoSize = true;
            this.lblsnm.BackColor = System.Drawing.Color.White;
            this.lblsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblsnm.Location = new System.Drawing.Point(857, 97);
            this.lblsnm.Name = "lblsnm";
            this.lblsnm.Size = new System.Drawing.Size(178, 29);
            this.lblsnm.TabIndex = 4;
            this.lblsnm.Text = "Student Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Maroon;
            this.lblgender.Location = new System.Drawing.Point(857, 167);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(196, 29);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "Student Gender";
            // 
            // lblsadd
            // 
            this.lblsadd.AutoSize = true;
            this.lblsadd.BackColor = System.Drawing.Color.White;
            this.lblsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsadd.ForeColor = System.Drawing.Color.Maroon;
            this.lblsadd.Location = new System.Drawing.Point(202, 167);
            this.lblsadd.Name = "lblsadd";
            this.lblsadd.Size = new System.Drawing.Size(205, 29);
            this.lblsadd.TabIndex = 6;
            this.lblsadd.Text = "Student Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(202, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Student Phone No.";
            // 
            // lblcnm
            // 
            this.lblcnm.AutoSize = true;
            this.lblcnm.BackColor = System.Drawing.Color.White;
            this.lblcnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblcnm.Location = new System.Drawing.Point(857, 245);
            this.lblcnm.Name = "lblcnm";
            this.lblcnm.Size = new System.Drawing.Size(173, 29);
            this.lblcnm.TabIndex = 8;
            this.lblcnm.Text = "Course Name";
            // 
            // lblbtime
            // 
            this.lblbtime.AutoSize = true;
            this.lblbtime.BackColor = System.Drawing.Color.White;
            this.lblbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtime.ForeColor = System.Drawing.Color.Maroon;
            this.lblbtime.Location = new System.Drawing.Point(202, 317);
            this.lblbtime.Name = "lblbtime";
            this.lblbtime.Size = new System.Drawing.Size(145, 29);
            this.lblbtime.TabIndex = 9;
            this.lblbtime.Text = "Batch Time";
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Transgender"});
            this.cmbgender.Location = new System.Drawing.Point(1194, 164);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(200, 37);
            this.cmbgender.TabIndex = 11;
            // 
            // cmbcnm
            // 
            this.cmbcnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcnm.FormattingEnabled = true;
            this.cmbcnm.Items.AddRange(new object[] {
            "Java FullStack Development",
            ".Net FullStack Development",
            "PHP FullStack Development",
            "Python FullStack Development",
            "React JS Web Development",
            "Node JS Web Development",
            "Angular Web Development",
            "Mobile App Development",
            "Software Testing",
            "Data Science",
            "Digital Marketing",
            "Salesforce CRM Training"});
            this.cmbcnm.Location = new System.Drawing.Point(1194, 242);
            this.cmbcnm.Name = "cmbcnm";
            this.cmbcnm.Size = new System.Drawing.Size(200, 28);
            this.cmbcnm.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(490, 30);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(200, 30);
            this.txtid.TabIndex = 13;
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(490, 94);
            this.txtsid.Multiline = true;
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(200, 30);
            this.txtsid.TabIndex = 14;
            // 
            // txtbtime
            // 
            this.txtbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbtime.Location = new System.Drawing.Point(490, 314);
            this.txtbtime.Multiline = true;
            this.txtbtime.Name = "txtbtime";
            this.txtbtime.Size = new System.Drawing.Size(200, 30);
            this.txtbtime.TabIndex = 15;
            this.txtbtime.TextChanged += new System.EventHandler(this.txtbtime_TextChanged);
            // 
            // txtsnm
            // 
            this.txtsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsnm.Location = new System.Drawing.Point(1194, 94);
            this.txtsnm.Multiline = true;
            this.txtsnm.Name = "txtsnm";
            this.txtsnm.Size = new System.Drawing.Size(200, 30);
            this.txtsnm.TabIndex = 16;
            this.txtsnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsnm_TextChanged_1);
            // 
            // txtsadd
            // 
            this.txtsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsadd.Location = new System.Drawing.Point(490, 164);
            this.txtsadd.Multiline = true;
            this.txtsadd.Name = "txtsadd";
            this.txtsadd.Size = new System.Drawing.Size(200, 30);
            this.txtsadd.TabIndex = 17;
            this.txtsadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsadd_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(363, 361);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 50);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(731, 361);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(1076, 361);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(1401, 361);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dtptime
            // 
            this.dtptime.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptime.Location = new System.Drawing.Point(1194, 31);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(200, 30);
            this.dtptime.TabIndex = 24;
            // 
            // txtsno
            // 
            this.txtsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsno.Location = new System.Drawing.Point(490, 242);
            this.txtsno.MaxLength = 10;
            this.txtsno.Multiline = true;
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(200, 30);
            this.txtsno.TabIndex = 25;
            this.txtsno.TextChanged += new System.EventHandler(this.txtsno_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(40, 361);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(170, 50);
            this.btnnew.TabIndex = 26;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // frmenquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1621, 635);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtsno);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsadd);
            this.Controls.Add(this.txtsnm);
            this.Controls.Add(this.txtbtime);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbcnm);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblbtime);
            this.Controls.Add(this.lblcnm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsadd);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblsnm);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dgvenquiry);
            this.Name = "frmenquiry";
            this.Text = "frmenquiry";
            this.Load += new System.EventHandler(this.enquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvenquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvenquiry;
        private Institute_ProjDataSet2 institute_ProjDataSet2;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private Institute_ProjDataSet2TableAdapters.enquiryTableAdapter enquiryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lblsnm;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblsadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcnm;
        private System.Windows.Forms.Label lblbtime;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbcnm;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtbtime;
        private System.Windows.Forms.TextBox txtsnm;
        private System.Windows.Forms.TextBox txtsadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.TextBox txtsno;
        private System.Windows.Forms.Button btnnew;
    }
}