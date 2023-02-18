namespace Institute_Proj
{
    partial class frmcourse
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcdur = new System.Windows.Forms.TextBox();
            this.txtcfee1 = new System.Windows.Forms.TextBox();
            this.txtcfee = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.lbldur = new System.Windows.Forms.Label();
            this.lblcfee1 = new System.Windows.Forms.Label();
            this.lblcfee = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFee1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet = new Institute_Proj.Institute_ProjDataSet();
            this.courseTableAdapter = new Institute_Proj.Institute_ProjDataSetTableAdapters.courseTableAdapter();
            this.btnnew = new System.Windows.Forms.Button();
            this.cmbcnm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(600, 35);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(200, 30);
            this.txtid.TabIndex = 0;
            // 
            // txtcdur
            // 
            this.txtcdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdur.Location = new System.Drawing.Point(600, 161);
            this.txtcdur.Multiline = true;
            this.txtcdur.Name = "txtcdur";
            this.txtcdur.Size = new System.Drawing.Size(200, 30);
            this.txtcdur.TabIndex = 2;
            // 
            // txtcfee1
            // 
            this.txtcfee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfee1.Location = new System.Drawing.Point(600, 222);
            this.txtcfee1.Multiline = true;
            this.txtcfee1.Name = "txtcfee1";
            this.txtcfee1.Size = new System.Drawing.Size(200, 30);
            this.txtcfee1.TabIndex = 3;
            // 
            // txtcfee
            // 
            this.txtcfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfee.Location = new System.Drawing.Point(600, 287);
            this.txtcfee.Multiline = true;
            this.txtcfee.Name = "txtcfee";
            this.txtcfee.Size = new System.Drawing.Size(200, 30);
            this.txtcfee.TabIndex = 4;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Maroon;
            this.lblid.Location = new System.Drawing.Point(220, 38);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(129, 29);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Course ID";
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.BackColor = System.Drawing.Color.White;
            this.lblcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.ForeColor = System.Drawing.Color.Maroon;
            this.lblcn.Location = new System.Drawing.Point(220, 100);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(173, 29);
            this.lblcn.TabIndex = 6;
            this.lblcn.Text = "Course Name";
            // 
            // lbldur
            // 
            this.lbldur.AutoSize = true;
            this.lbldur.BackColor = System.Drawing.Color.White;
            this.lbldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldur.ForeColor = System.Drawing.Color.Maroon;
            this.lbldur.Location = new System.Drawing.Point(220, 164);
            this.lbldur.Name = "lbldur";
            this.lbldur.Size = new System.Drawing.Size(202, 29);
            this.lbldur.TabIndex = 7;
            this.lbldur.Text = "Course Duration";
            // 
            // lblcfee1
            // 
            this.lblcfee1.AutoSize = true;
            this.lblcfee1.BackColor = System.Drawing.Color.White;
            this.lblcfee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfee1.ForeColor = System.Drawing.Color.Maroon;
            this.lblcfee1.Location = new System.Drawing.Point(220, 225);
            this.lblcfee1.Name = "lblcfee1";
            this.lblcfee1.Size = new System.Drawing.Size(266, 29);
            this.lblcfee1.TabIndex = 8;
            this.lblcfee1.Text = "Course OneTime Fee";
            // 
            // lblcfee
            // 
            this.lblcfee.AutoSize = true;
            this.lblcfee.BackColor = System.Drawing.Color.White;
            this.lblcfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfee.ForeColor = System.Drawing.Color.Maroon;
            this.lblcfee.Location = new System.Drawing.Point(220, 290);
            this.lblcfee.Name = "lblcfee";
            this.lblcfee.Size = new System.Drawing.Size(283, 29);
            this.lblcfee.TabIndex = 9;
            this.lblcfee.Text = "Course Installment Fee";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(225, 342);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 50);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(438, 342);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(657, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(870, 342);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvcourse
            // 
            this.dgvcourse.AllowUserToAddRows = false;
            this.dgvcourse.AllowUserToDeleteRows = false;
            this.dgvcourse.AutoGenerateColumns = false;
            this.dgvcourse.BackgroundColor = System.Drawing.Color.White;
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cDurationDataGridViewTextBoxColumn,
            this.cFee1DataGridViewTextBoxColumn,
            this.cFeeDataGridViewTextBoxColumn});
            this.dgvcourse.DataSource = this.courseBindingSource;
            this.dgvcourse.GridColor = System.Drawing.Color.DarkGray;
            this.dgvcourse.Location = new System.Drawing.Point(86, 420);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.ReadOnly = true;
            this.dgvcourse.RowHeadersWidth = 51;
            this.dgvcourse.RowTemplate.Height = 24;
            this.dgvcourse.Size = new System.Drawing.Size(876, 217);
            this.dgvcourse.TabIndex = 14;
            this.dgvcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcourse_CellContentClick);
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
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "C_Name";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cDurationDataGridViewTextBoxColumn
            // 
            this.cDurationDataGridViewTextBoxColumn.DataPropertyName = "C_Duration";
            this.cDurationDataGridViewTextBoxColumn.HeaderText = "C_Duration";
            this.cDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDurationDataGridViewTextBoxColumn.Name = "cDurationDataGridViewTextBoxColumn";
            this.cDurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDurationDataGridViewTextBoxColumn.Width = 125;
            // 
            // cFee1DataGridViewTextBoxColumn
            // 
            this.cFee1DataGridViewTextBoxColumn.DataPropertyName = "C_Fee1";
            this.cFee1DataGridViewTextBoxColumn.HeaderText = "C_Fee1";
            this.cFee1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFee1DataGridViewTextBoxColumn.Name = "cFee1DataGridViewTextBoxColumn";
            this.cFee1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cFee1DataGridViewTextBoxColumn.Width = 125;
            // 
            // cFeeDataGridViewTextBoxColumn
            // 
            this.cFeeDataGridViewTextBoxColumn.DataPropertyName = "C_Fee";
            this.cFeeDataGridViewTextBoxColumn.HeaderText = "C_Fee";
            this.cFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFeeDataGridViewTextBoxColumn.Name = "cFeeDataGridViewTextBoxColumn";
            this.cFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.institute_ProjDataSet;
            // 
            // institute_ProjDataSet
            // 
            this.institute_ProjDataSet.DataSetName = "Institute_ProjDataSet";
            this.institute_ProjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(25, 342);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(170, 50);
            this.btnnew.TabIndex = 16;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // cmbcnm
            // 
            this.cmbcnm.BackColor = System.Drawing.Color.White;
            this.cmbcnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcnm.ForeColor = System.Drawing.Color.Black;
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
            this.cmbcnm.Location = new System.Drawing.Point(600, 100);
            this.cmbcnm.Name = "cmbcnm";
            this.cmbcnm.Size = new System.Drawing.Size(200, 28);
            this.cmbcnm.TabIndex = 17;
            // 
            // frmcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1070, 649);
            this.Controls.Add(this.cmbcnm);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.dgvcourse);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblcfee);
            this.Controls.Add(this.lblcfee1);
            this.Controls.Add(this.lbldur);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtcfee);
            this.Controls.Add(this.txtcfee1);
            this.Controls.Add(this.txtcdur);
            this.Controls.Add(this.txtid);
            this.Name = "frmcourse";
            this.Text = "frmcourse";
            this.Load += new System.EventHandler(this.frmcourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcdur;
        private System.Windows.Forms.TextBox txtcfee1;
        private System.Windows.Forms.TextBox txtcfee;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lbldur;
        private System.Windows.Forms.Label lblcfee1;
        private System.Windows.Forms.Label lblcfee;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dgvcourse;
        private Institute_ProjDataSet institute_ProjDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Institute_ProjDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFee1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ComboBox cmbcnm;
    }
}