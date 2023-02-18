namespace Institute_Proj
{
    partial class frmadmission
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
            this.dgvadmission = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet5 = new Institute_Proj.Institute_ProjDataSet5();
            this.admissionTableAdapter = new Institute_Proj.Institute_ProjDataSet5TableAdapters.admissionTableAdapter();
            this.lblaid = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsnm = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsadd = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblbid = new System.Windows.Forms.Label();
            this.lblftype = new System.Windows.Forms.Label();
            this.lblfee = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsnm = new System.Windows.Forms.TextBox();
            this.txtaid = new System.Windows.Forms.TextBox();
            this.txtsadd = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.lblsid = new System.Windows.Forms.Label();
            this.dtpadate = new System.Windows.Forms.DateTimePicker();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.cmbbid = new System.Windows.Forms.ComboBox();
            this.cmbftype = new System.Windows.Forms.ComboBox();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.cmbcnm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvadmission
            // 
            this.dgvadmission.AllowUserToAddRows = false;
            this.dgvadmission.AllowUserToDeleteRows = false;
            this.dgvadmission.AutoGenerateColumns = false;
            this.dgvadmission.BackgroundColor = System.Drawing.Color.White;
            this.dgvadmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.sAddDataGridViewTextBoxColumn,
            this.sPhNoDataGridViewTextBoxColumn,
            this.sGenderDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn,
            this.feeTypeDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.dgvadmission.DataSource = this.admissionBindingSource;
            this.dgvadmission.Location = new System.Drawing.Point(36, 447);
            this.dgvadmission.Name = "dgvadmission";
            this.dgvadmission.ReadOnly = true;
            this.dgvadmission.RowHeadersWidth = 51;
            this.dgvadmission.RowTemplate.Height = 24;
            this.dgvadmission.Size = new System.Drawing.Size(1842, 270);
            this.dgvadmission.TabIndex = 0;
            this.dgvadmission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadmission_CellContentClick);
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "A_ID";
            this.aIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn.Width = 125;
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
            // sPhNoDataGridViewTextBoxColumn
            // 
            this.sPhNoDataGridViewTextBoxColumn.DataPropertyName = "S_Ph_No";
            this.sPhNoDataGridViewTextBoxColumn.HeaderText = "S_Ph_No";
            this.sPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPhNoDataGridViewTextBoxColumn.Name = "sPhNoDataGridViewTextBoxColumn";
            this.sPhNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPhNoDataGridViewTextBoxColumn.Width = 125;
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
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // feeTypeDataGridViewTextBoxColumn
            // 
            this.feeTypeDataGridViewTextBoxColumn.DataPropertyName = "Fee_Type";
            this.feeTypeDataGridViewTextBoxColumn.HeaderText = "Fee_Type";
            this.feeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeTypeDataGridViewTextBoxColumn.Name = "feeTypeDataGridViewTextBoxColumn";
            this.feeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.feeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            this.feeDataGridViewTextBoxColumn.ReadOnly = true;
            this.feeDataGridViewTextBoxColumn.Width = 125;
            // 
            // admissionBindingSource
            // 
            this.admissionBindingSource.DataMember = "admission";
            this.admissionBindingSource.DataSource = this.institute_ProjDataSet5;
            // 
            // institute_ProjDataSet5
            // 
            this.institute_ProjDataSet5.DataSetName = "Institute_ProjDataSet5";
            this.institute_ProjDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admissionTableAdapter
            // 
            this.admissionTableAdapter.ClearBeforeFill = true;
            // 
            // lblaid
            // 
            this.lblaid.AutoSize = true;
            this.lblaid.BackColor = System.Drawing.Color.White;
            this.lblaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaid.ForeColor = System.Drawing.Color.Maroon;
            this.lblaid.Location = new System.Drawing.Point(90, 56);
            this.lblaid.Name = "lblaid";
            this.lblaid.Size = new System.Drawing.Size(166, 29);
            this.lblaid.TabIndex = 1;
            this.lblaid.Text = "Admission ID";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Maroon;
            this.lbldate.Location = new System.Drawing.Point(705, 56);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(195, 29);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Admission Date";
            // 
            // lblsnm
            // 
            this.lblsnm.AutoSize = true;
            this.lblsnm.BackColor = System.Drawing.Color.White;
            this.lblsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblsnm.Location = new System.Drawing.Point(90, 134);
            this.lblsnm.Name = "lblsnm";
            this.lblsnm.Size = new System.Drawing.Size(178, 29);
            this.lblsnm.TabIndex = 4;
            this.lblsnm.Text = "Student Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Maroon;
            this.lblemail.Location = new System.Drawing.Point(705, 134);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(111, 29);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email ID";
            // 
            // lblsadd
            // 
            this.lblsadd.AutoSize = true;
            this.lblsadd.BackColor = System.Drawing.Color.White;
            this.lblsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsadd.ForeColor = System.Drawing.Color.Maroon;
            this.lblsadd.Location = new System.Drawing.Point(1332, 134);
            this.lblsadd.Name = "lblsadd";
            this.lblsadd.Size = new System.Drawing.Size(205, 29);
            this.lblsadd.TabIndex = 6;
            this.lblsadd.Text = "Student Address";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.White;
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.Maroon;
            this.lblno.Location = new System.Drawing.Point(90, 204);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(232, 29);
            this.lblno.TabIndex = 7;
            this.lblno.Text = "Student Phone No.";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Maroon;
            this.lblgender.Location = new System.Drawing.Point(705, 204);
            this.lblgender.Name = "lblgender";
            this.lblgender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblgender.Size = new System.Drawing.Size(100, 29);
            this.lblgender.TabIndex = 8;
            this.lblgender.Text = "Gender";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.BackColor = System.Drawing.Color.White;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.ForeColor = System.Drawing.Color.Maroon;
            this.lblcid.Location = new System.Drawing.Point(1332, 204);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(129, 29);
            this.lblcid.TabIndex = 9;
            this.lblcid.Text = "Course ID";
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.BackColor = System.Drawing.Color.White;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.ForeColor = System.Drawing.Color.Maroon;
            this.lblbid.Location = new System.Drawing.Point(90, 278);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(110, 29);
            this.lblbid.TabIndex = 10;
            this.lblbid.Text = "Batch ID";
            // 
            // lblftype
            // 
            this.lblftype.AutoSize = true;
            this.lblftype.BackColor = System.Drawing.Color.White;
            this.lblftype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblftype.ForeColor = System.Drawing.Color.Maroon;
            this.lblftype.Location = new System.Drawing.Point(705, 278);
            this.lblftype.Name = "lblftype";
            this.lblftype.Size = new System.Drawing.Size(125, 29);
            this.lblftype.TabIndex = 11;
            this.lblftype.Text = "Fee Type";
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.BackColor = System.Drawing.Color.White;
            this.lblfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfee.ForeColor = System.Drawing.Color.Maroon;
            this.lblfee.Location = new System.Drawing.Point(1332, 278);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(59, 29);
            this.lblfee.TabIndex = 12;
            this.lblfee.Text = "Fee";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(991, 131);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 30);
            this.txtemail.TabIndex = 13;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextCanged);
            // 
            // txtsnm
            // 
            this.txtsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsnm.Location = new System.Drawing.Point(354, 131);
            this.txtsnm.Multiline = true;
            this.txtsnm.Name = "txtsnm";
            this.txtsnm.Size = new System.Drawing.Size(200, 30);
            this.txtsnm.TabIndex = 16;
            this.txtsnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsnm_TextChanged);
            // 
            // txtaid
            // 
            this.txtaid.Location = new System.Drawing.Point(354, 53);
            this.txtaid.Multiline = true;
            this.txtaid.Name = "txtaid";
            this.txtaid.ReadOnly = true;
            this.txtaid.Size = new System.Drawing.Size(200, 30);
            this.txtaid.TabIndex = 17;
            // 
            // txtsadd
            // 
            this.txtsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsadd.Location = new System.Drawing.Point(1610, 131);
            this.txtsadd.Multiline = true;
            this.txtsadd.Name = "txtsadd";
            this.txtsadd.Size = new System.Drawing.Size(200, 30);
            this.txtsadd.TabIndex = 18;
            this.txtsadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsadd_KeyPress);
            // 
            // txtfee
            // 
            this.txtfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfee.Location = new System.Drawing.Point(1610, 285);
            this.txtfee.Multiline = true;
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(200, 30);
            this.txtfee.TabIndex = 24;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(470, 375);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 50);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(870, 375);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(1262, 375);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(1640, 375);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 28;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(354, 201);
            this.txtno.MaxLength = 10;
            this.txtno.Multiline = true;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(200, 30);
            this.txtno.TabIndex = 29;
            this.txtno.TextChanged += new System.EventHandler(this.txtno_TextChanged);
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.White;
            this.lblsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.ForeColor = System.Drawing.Color.Maroon;
            this.lblsid.Location = new System.Drawing.Point(1332, 56);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(173, 29);
            this.lblsid.TabIndex = 30;
            this.lblsid.Text = "Course Name";
            // 
            // dtpadate
            // 
            this.dtpadate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpadate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpadate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpadate.Location = new System.Drawing.Point(991, 54);
            this.dtpadate.Name = "dtpadate";
            this.dtpadate.Size = new System.Drawing.Size(200, 30);
            this.dtpadate.TabIndex = 31;
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.cmbgender.Location = new System.Drawing.Point(991, 208);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(200, 28);
            this.cmbgender.TabIndex = 32;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(98, 375);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(170, 50);
            this.btnnew.TabIndex = 33;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // cmbbid
            // 
            this.cmbbid.BackColor = System.Drawing.Color.White;
            this.cmbbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbbid.Location = new System.Drawing.Point(354, 282);
            this.cmbbid.Name = "cmbbid";
            this.cmbbid.Size = new System.Drawing.Size(200, 28);
            this.cmbbid.TabIndex = 34;
            // 
            // cmbftype
            // 
            this.cmbftype.BackColor = System.Drawing.Color.White;
            this.cmbftype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbftype.FormattingEnabled = true;
            this.cmbftype.Items.AddRange(new object[] {
            "Installment",
            "One Time"});
            this.cmbftype.Location = new System.Drawing.Point(991, 282);
            this.cmbftype.Name = "cmbftype";
            this.cmbftype.Size = new System.Drawing.Size(200, 28);
            this.cmbftype.TabIndex = 35;
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
            this.cmbcid.Location = new System.Drawing.Point(1610, 211);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(200, 28);
            this.cmbcid.TabIndex = 36;
            // 
            // cmbcnm
            // 
            this.cmbcnm.BackColor = System.Drawing.Color.White;
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
            this.cmbcnm.Location = new System.Drawing.Point(1610, 60);
            this.cmbcnm.Name = "cmbcnm";
            this.cmbcnm.Size = new System.Drawing.Size(200, 28);
            this.cmbcnm.TabIndex = 37;
            // 
            // frmadmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1914, 746);
            this.Controls.Add(this.cmbcnm);
            this.Controls.Add(this.cmbcid);
            this.Controls.Add(this.cmbftype);
            this.Controls.Add(this.cmbbid);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.dtpadate);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtsadd);
            this.Controls.Add(this.txtaid);
            this.Controls.Add(this.txtsnm);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.lblftype);
            this.Controls.Add(this.lblbid);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.lblsadd);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsnm);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblaid);
            this.Controls.Add(this.dgvadmission);
            this.Name = "frmadmission";
            this.Text = "frmadmission";
            this.Load += new System.EventHandler(this.frmadmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvadmission;
        private Institute_ProjDataSet5 institute_ProjDataSet5;
        private System.Windows.Forms.BindingSource admissionBindingSource;
        private Institute_ProjDataSet5TableAdapters.admissionTableAdapter admissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblaid;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsnm;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsadd;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.Label lblftype;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsnm;
        private System.Windows.Forms.TextBox txtaid;
        private System.Windows.Forms.TextBox txtsadd;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.DateTimePicker dtpadate;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ComboBox cmbbid;
        private System.Windows.Forms.ComboBox cmbftype;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.ComboBox cmbcnm;
    }
}