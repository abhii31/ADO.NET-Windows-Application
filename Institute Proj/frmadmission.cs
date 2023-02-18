using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Institute_Proj
{
    public partial class frmadmission : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmadmission()
        {
            InitializeComponent();
        }

        private void frmadmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet5.admission' table. You can move, or remove it, as needed.
            //this.admissionTableAdapter.Fill(this.institute_ProjDataSet5.admission);

            GetData();

            SqlCommand cm = new SqlCommand("select C_Name from batch ", conn);
            SqlDataReader sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                cmbcnm.Items.Add(sdr[0]);
            }
            sdr.Close();
        }

        private void GetData()
        {
            try
            {
                conn = new SqlConnection("Data Source= RK\\SQLEXPRESS01;database=Institute Proj;integrated security=SSPI");
                conn.Open();
                MessageBox.Show("Connection Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOP'S, Something Went Wrong." + ex);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtaid.Text == "")
                {
                    MessageBox.Show("Please Enter Addmission ID");
                    return;
                }
                else if (dtpadate.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtsnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Email ID");
                    return;
                }
                else if (txtsadd.Text == "")
                {
                    MessageBox.Show("Please Enter Student Address");
                    return;
                }
                else if (txtno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbgender.Text == "")
                {
                    MessageBox.Show("Please Enter Gender");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (cmbbid.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (cmbftype.Text == "")
                {
                    MessageBox.Show("Please Enter Fee Type");
                    return;
                }
                else if (txtfee.Text == "")
                {
                    MessageBox.Show("Please Enter Fee");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_admission", conn);

                    cmd.Parameters.Add("@aid", SqlDbType.VarChar).Value = txtaid.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpadate.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sno", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = cmbbid.Text.ToString();
                    cmd.Parameters.Add("@ftype", SqlDbType.VarChar).Value = cmbftype.Text.ToString();
                    cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = txtfee.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int eid = cmd.ExecuteNonQuery();
                    if (eid > 0)
                    {
                        MessageBox.Show("Record Saved Successfully");
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Saved");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtaid.Text == "")
                {
                    MessageBox.Show("Please Enter Addmission ID");
                    return;
                }
                else if (dtpadate.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtsnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Email ID");
                    return;
                }
                else if (txtsadd.Text == "")
                {
                    MessageBox.Show("Please Enter Student Address");
                    return;
                }
                else if (txtno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbgender.Text == "")
                {
                    MessageBox.Show("Please Enter Gender");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (cmbbid.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (cmbftype.Text == "")
                {
                    MessageBox.Show("Please Enter Fee Type");
                    return;
                }
                else if (txtfee.Text == "")
                {
                    MessageBox.Show("Please Enter Fee");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_admission", conn);

                    cmd.Parameters.Add("@aid", SqlDbType.VarChar).Value = txtaid.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpadate.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sno", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = cmbbid.Text.ToString();
                    cmd.Parameters.Add("@ftype", SqlDbType.VarChar).Value = cmbftype.Text.ToString();
                    cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = txtfee.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int eid = cmd.ExecuteNonQuery();
                    if (eid > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_admission", conn);
                cmd.Parameters.Add("@aid", SqlDbType.VarChar).Value = txtaid.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int aid = cmd.ExecuteNonQuery();
                if (aid > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtaid.Text = "";
            dtpadate.Text = "";
            cmbcid.Text = "";
            txtsnm.Text = "";
            txtemail.Text = "";
            txtsadd.Text = "";
            txtno.Text = "";
            cmbgender.Text = "";
            cmbcid.Text = "";
            cmbbid.Text = "";
            cmbftype.Text = "";
            txtfee.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[admission] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvadmission.DataSource = dt;
                    }
                }
            }
        }

        private void dgvadmission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtaid.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[0].Value.ToString();
            dtpadate.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[1].Value.ToString();
            cmbcid.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[2].Value.ToString();
            txtsnm.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[3].Value.ToString();
            txtemail.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[4].Value.ToString();
            txtsadd.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[5].Value.ToString();
            txtno.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[6].Value.ToString();
            cmbgender.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[7].Value.ToString();
            cmbcid.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[8].Value.ToString();
            cmbbid.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[9].Value.ToString();
            cmbftype.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[10].Value.ToString();
            txtfee.Text = dgvadmission.Rows[dgvadmission.CurrentRow.Index].Cells[11].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select max(A_ID) as aid from admission ", conn);
            SqlDataReader sdr1 = cm.ExecuteReader();

            while (sdr1.Read())
            {
                int cnt = Convert.ToInt32(sdr1[0]);
                cnt++;
                txtaid.Text = Convert.ToString(cnt);
            }
            sdr1.Close();
        }

        private void txtsnm_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtno_TextChanged(object sender, EventArgs e)
        {
            string telno = Convert.ToString(txtno.Text);
            if (Regex.Match(telno, @"^(\+[0-9])$").Success)
            {
                MessageBox.Show("Correctly Entered");
            }
            else
            {
                MessageBox.Show("Please Enter Valid Mobile Number");
            }
        }

        private void txtemail_TextCanged(object sender, EventArgs e)
        {
            string email = Convert.ToString(txtemail.Text);
            if(Regex.Match(email,"\a-z+ ([-+.']\a-z+)*@\a-z+([-.]\a-z+)*.\a-z+([-.]\a-z+)*").Success)
            {
                MessageBox.Show("Correctly Entered");
            }
            else
            {
                MessageBox.Show("Please Enter Vaild Email Address");
            }
        }

        private void txtsadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

