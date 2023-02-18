namespace Institute_Proj
{
    partial class frmresult
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
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institute_ProjDataSet4 = new Institute_Proj.Institute_ProjDataSet4();
            this.resultTableAdapter = new Institute_Proj.Institute_ProjDataSet4TableAdapters.resultTableAdapter();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtenm = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsnm = new System.Windows.Forms.Label();
            this.lblenm = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvresult
            // 
            this.dgvresult.AllowUserToAddRows = false;
            this.dgvresult.AllowUserToDeleteRows = false;
            this.dgvresult.AutoGenerateColumns = false;
            this.dgvresult.BackgroundColor = System.Drawing.Color.White;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dgvresult.DataSource = this.resultBindingSource;
            this.dgvresult.GridColor = System.Drawing.Color.Black;
            this.dgvresult.Location = new System.Drawing.Point(142, 376);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.RowHeadersWidth = 51;
            this.dgvresult.RowTemplate.Height = 24;
            this.dgvresult.Size = new System.Drawing.Size(688, 228);
            this.dgvresult.TabIndex = 0;
            this.dgvresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvresult_CellContentClick);
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
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "E_Name";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "E_Name";
            this.eNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            this.eNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "result";
            this.resultBindingSource.DataSource = this.institute_ProjDataSet4;
            // 
            // institute_ProjDataSet4
            // 
            this.institute_ProjDataSet4.DataSetName = "Institute_ProjDataSet4";
            this.institute_ProjDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(230, 56);
            this.txtsid.Multiline = true;
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(200, 30);
            this.txtsid.TabIndex = 1;
            this.txtsid.TextChanged += new System.EventHandler(this.txtsid_TextChanged);
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(760, 56);
            this.txtnm.Multiline = true;
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(200, 30);
            this.txtnm.TabIndex = 2;
            this.txtnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnm_TextChanged);
            // 
            // txtenm
            // 
            this.txtenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenm.Location = new System.Drawing.Point(230, 149);
            this.txtenm.Multiline = true;
            this.txtenm.Name = "txtenm";
            this.txtenm.Size = new System.Drawing.Size(200, 30);
            this.txtenm.TabIndex = 3;
            this.txtenm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtenm_TextChanged);
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(760, 149);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(200, 30);
            this.txtresult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID";
            // 
            // lblsnm
            // 
            this.lblsnm.AutoSize = true;
            this.lblsnm.BackColor = System.Drawing.Color.White;
            this.lblsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnm.ForeColor = System.Drawing.Color.Maroon;
            this.lblsnm.Location = new System.Drawing.Point(504, 59);
            this.lblsnm.Name = "lblsnm";
            this.lblsnm.Size = new System.Drawing.Size(178, 29);
            this.lblsnm.TabIndex = 6;
            this.lblsnm.Text = "Student Name";
            // 
            // lblenm
            // 
            this.lblenm.AutoSize = true;
            this.lblenm.BackColor = System.Drawing.Color.White;
            this.lblenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenm.ForeColor = System.Drawing.Color.Maroon;
            this.lblenm.Location = new System.Drawing.Point(29, 152);
            this.lblenm.Name = "lblenm";
            this.lblenm.Size = new System.Drawing.Size(113, 29);
            this.lblenm.TabIndex = 7;
            this.lblenm.Text = "E_Name";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.White;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.Maroon;
            this.lblresult.Location = new System.Drawing.Point(504, 152);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(87, 29);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "Result";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(43, 218);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 50);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(230, 303);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 50);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(563, 303);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(170, 50);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Blue;
            this.btncancel.Location = new System.Drawing.Point(774, 218);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 50);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(998, 616);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblenm);
            this.Controls.Add(this.lblsnm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtenm);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.dgvresult);
            this.Name = "frmresult";
            this.Text = "result";
            this.Load += new System.EventHandler(this.result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institute_ProjDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvresult;
        private Institute_ProjDataSet4 institute_ProjDataSet4;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private Institute_ProjDataSet4TableAdapters.resultTableAdapter resultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtenm;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsnm;
        private System.Windows.Forms.Label lblenm;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
    }
}