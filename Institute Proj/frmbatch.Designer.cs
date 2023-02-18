namespace Institute_Proj
{
    partial class frmbatch
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
            this.dgvbatch = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet1 = new Institute_Proj.Institute_ProjDataSet1();
            this.batchTableAdapter = new Institute_Proj.Institute_ProjDataSet1TableAdapters.batchTableAdapter();
            this.lblbid = new System.Windows.Forms.Label();
            this.lblnm = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblbtime = new System.Windows.Forms.Label();
            this.btnid = new System.Windows.Forms.Button();
            this.btnnm = new System.Windows.Forms.Button();
            this.btndate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cmbnm = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.cmbbtime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbatch
            // 
            this.dgvbatch.AllowUserToAddRows = false;
            this.dgvbatch.AllowUserToDeleteRows = false;
            this.dgvbatch.AutoGenerateColumns = false;
            this.dgvbatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvbatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dgvbatch.DataSource = this.batchBindingSource;
            this.dgvbatch.GridColor = System.Drawing.Color.Black;
            this.dgvbatch.Location = new System.Drawing.Point(156, 359);
            this.dgvbatch.Name = "dgvbatch";
            this.dgvbatch.ReadOnly = true;
            this.dgvbatch.RowHeadersWidth = 51;
            this.dgvbatch.RowTemplate.Height = 24;
            this.dgvbatch.Size = new System.Drawing.Size(745, 227);
            this.dgvbatch.TabIndex = 0;
            this.dgvbatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbatch_CellContentClick);
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
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "C_Name";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 125;
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
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataMember = "batch";
            this.batchBindingSource.DataSource = this.institute_ProjDataSet1;
            // 
            // institute_ProjDataSet1
            // 
            this.institute_ProjDataSet1.DataSetName = "Institute_ProjDataSet1";
            this.institute_ProjDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchTableAdapter
            // 
            this.batchTableAdapter.ClearBeforeFill = true;
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.BackColor = System.Drawing.Color.White;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.ForeColor = System.Drawing.Color.Maroon;
            this.lblbid.Location = new System.Drawing.Point(223, 34);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(110, 29);
            this.lblbid.TabIndex = 1;
            this.lblbid.Text = "Batch ID";
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.BackColor = System.Drawing.Color.White;
            this.lblnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblnm.Location = new System.Drawing.Point(223, 92);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(173, 29);
            this.lblnm.TabIndex = 2;
            this.lblnm.Text = "Course Name";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Maroon;
            this.lbldate.Location = new System.Drawing.Point(223, 155);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(159, 29);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Joining Date";
            // 
            // lblbtime
            // 
            this.lblbtime.AutoSize = true;
            this.lblbtime.BackColor = System.Drawing.Color.White;
            this.lblbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtime.ForeColor = System.Drawing.Color.Maroon;
            this.lblbtime.Location = new System.Drawing.Point(223, 211);
            this.lblbtime.Name = "lblbtime";
            this.lblbtime.Size = new System.Drawing.Size(145, 29);
            this.lblbtime.TabIndex = 4;
            this.lblbtime.Text = "Batch Time";
            // 
            // btnid
            // 
            this.btnid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnid.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnid.ForeColor = System.Drawing.Color.Blue;
            this.btnid.Location = new System.Drawing.Point(54, 286);
            this.btnid.Name = "btnid";
            this.btnid.Size = new System.Drawing.Size(170, 50);
            this.btnid.TabIndex = 9;
            this.btnid.Text = "Save";
            this.btnid.UseVisualStyleBackColor = false;
            this.btnid.Click += new System.EventHandler(this.btnid_Click);
            // 
            // btnnm
            // 
            this.btnnm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnm.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnm.ForeColor = System.Drawing.Color.Blue;
            this.btnnm.Location = new System.Drawing.Point(311, 286);
            this.btnnm.Name = "btnnm";
            this.btnnm.Size = new System.Drawing.Size(170, 50);
            this.btnnm.TabIndex = 10;
            this.btnnm.Text = "Update";
            this.btnnm.UseVisualStyleBackColor = false;
            this.btnnm.Click += new System.EventHandler(this.btnnm_Click);
            // 
            // btndate
            // 
            this.btndate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndate.ForeColor = System.Drawing.Color.Blue;
            this.btndate.Location = new System.Drawing.Point(576, 286);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(170, 50);
            this.btndate.TabIndex = 11;
            this.btndate.Text = "Delete";
            this.btndate.UseVisualStyleBackColor = false;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(838, 286);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cmbnm
            // 
            this.cmbnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnm.FormattingEnabled = true;
            this.cmbnm.Items.AddRange(new object[] {
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
            this.cmbnm.Location = new System.Drawing.Point(593, 92);
            this.cmbnm.Name = "cmbnm";
            this.cmbnm.Size = new System.Drawing.Size(200, 28);
            this.cmbnm.TabIndex = 13;
            // 
            // dtpdate
            // 
            this.dtpdate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(593, 154);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 30);
            this.dtpdate.TabIndex = 14;
            // 
            // cmbid
            // 
            this.cmbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Items.AddRange(new object[] {
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
            this.cmbid.Location = new System.Drawing.Point(593, 34);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(200, 33);
            this.cmbid.TabIndex = 15;
            // 
            // cmbbtime
            // 
            this.cmbbtime.BackColor = System.Drawing.Color.White;
            this.cmbbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbtime.FormattingEnabled = true;
            this.cmbbtime.Items.AddRange(new object[] {
            "7 To 8 AM",
            "8 To 9 AM",
            "9 To 10 AM",
            "10 To 11 AM",
            "11 To 12 PM",
            "12 To 1 PM",
            "4 To 5 PM",
            "5 To 6 PM",
            "6 To 7 PM",
            "7 To 8 PM",
            "8 To 9 PM"});
            this.cmbbtime.Location = new System.Drawing.Point(593, 218);
            this.cmbbtime.Name = "cmbbtime";
            this.cmbbtime.Size = new System.Drawing.Size(200, 28);
            this.cmbbtime.TabIndex = 16;
            // 
            // frmbatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1060, 598);
            this.Controls.Add(this.cmbbtime);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cmbnm);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndate);
            this.Controls.Add(this.btnnm);
            this.Controls.Add(this.btnid);
            this.Controls.Add(this.lblbtime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblnm);
            this.Controls.Add(this.lblbid);
            this.Controls.Add(this.dgvbatch);
            this.Name = "frmbatch";
            this.Text = "frmbatch";
            this.Load += new System.EventHandler(this.batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbatch;
        private Institute_ProjDataSet1 institute_ProjDataSet1;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private Institute_ProjDataSet1TableAdapters.batchTableAdapter batchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblbtime;
        private System.Windows.Forms.Button btnid;
        private System.Windows.Forms.Button btnnm;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cmbnm;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.ComboBox cmbbtime;
    }
}