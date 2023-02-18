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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Institute_Proj
{
    public partial class frmbill : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmbill()
        {
            InitializeComponent();
        }

        private void frmbill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet6.bill' table. You can move, or remove it, as needed.
            //this.billTableAdapter.Fill(this.institute_ProjDataSet6.bill);

            GetData();

            SqlCommand cm = new SqlCommand("select S_ID from enquiry ", conn);
            SqlDataReader sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                txtsid.Text = Convert.ToString(sdr[2]);
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
                if (txtbno.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (dtpdate.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtadd.Text == "")
                {
                    MessageBox.Show("Please Enter Student Address");
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
                else if (cmbgender.Text == "")
                {
                    MessageBox.Show("Please Enter Gender");
                    return;
                }
                else if (txtno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (txttfee.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (txtpfee.Text == "")
                {
                    MessageBox.Show("Please Enter Fee Type");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_bill", conn);

                    cmd.Parameters.Add("@bno", SqlDbType.VarChar).Value = txtbno.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpdate.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@addid", SqlDbType.VarChar).Value = txtadd.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@sno", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@tfee", SqlDbType.VarChar).Value = txttfee.Text.ToString();
                    cmd.Parameters.Add("@pfee", SqlDbType.VarChar).Value = txtpfee.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int bno = cmd.ExecuteNonQuery();
                    if (bno > 0)
                    {
                        MessageBox.Show("Record Saved Successfully");
                        SqlCommand cm = new SqlCommand("update admission set Fee = Fee -'" + txtpfee.Text + "'  Where S_ID='" + txtsid.Text + "' ", conn);
                        cm.ExecuteNonQuery();
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
                if (txtbno.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (dtpdate.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtadd.Text == "")
                {
                    MessageBox.Show("Please Enter Student Address");
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
                else if (cmbgender.Text == "")
                {
                    MessageBox.Show("Please Enter Gender");
                    return;
                }
                else if (txtno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbcid.Text == "")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (txttfee.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (txtpfee.Text == "")
                {
                    MessageBox.Show("Please Enter Fee Type");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_bill", conn);

                    cmd.Parameters.Add("@bno", SqlDbType.VarChar).Value = txtbno.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpdate.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@addid", SqlDbType.VarChar).Value = txtadd.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@sno", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@tfee", SqlDbType.VarChar).Value = txttfee.Text.ToString();
                    cmd.Parameters.Add("@pfee", SqlDbType.VarChar).Value = txtpfee.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int bno = cmd.ExecuteNonQuery();
                    if (bno > 0)
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
                SqlCommand cmd = new SqlCommand("sp_delete_bill", conn);
                cmd.Parameters.Add("@bno", SqlDbType.VarChar).Value = txtbno.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int bno = cmd.ExecuteNonQuery();
                if (bno > 0)
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
            txtbno.Text = "";
            dtpdate.Text = "";
            txtsid.Text = "";
            txtadd.Text = "";
            txtsnm.Text = "";
            txtemail.Text = "";
            txtsadd.Text = "";
            cmbgender.Text = "";
            txtno.Text = "";
            cmbcid.Text = "";
            txttfee.Text = "";
            txtpfee.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[bill] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvbill.DataSource = dt;
                    }
                }
            }
        }

        private void dgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
                txtbno.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[0].Value.ToString();
                dtpdate.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[1].Value.ToString();
                txtsid.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[3].Value.ToString();
                txtadd.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[3].Value.ToString();
                txtsnm.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[3].Value.ToString();
                txtemail.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[4].Value.ToString();
                txtsadd.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[3].Value.ToString();
                cmbgender.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[5].Value.ToString();
                txtno.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[3].Value.ToString();
                cmbcid.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[6].Value.ToString();
                txttfee.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[7].Value.ToString();
                txtpfee.Text = dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select max(B_No) as bno from bill ", conn);
            SqlDataReader sdr1 = cm.ExecuteReader();

            while (sdr1.Read())
            {
                int cnt = Convert.ToInt32(sdr1[0]);
                cnt++;
                txtbno.Text = Convert.ToString(cnt);
            }
            sdr1.Close();
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select *  from admission where A_ID = "+ txtadd.Text +" ", conn);
            SqlDataReader sdr2 = cm.ExecuteReader();

            while (sdr2.Read())
            {
                txtbno.Text = Convert.ToString(sdr2[0]);
                dtpdate.Text = Convert.ToString(sdr2[1]);
                txtsid.Text = Convert.ToString(sdr2[2]);
                txtadd.Text = Convert.ToString(sdr2[0]);
                txtsnm.Text = Convert.ToString(sdr2[4]);
                txtemail.Text = Convert.ToString(sdr2[5]);
                txtsadd.Text = Convert.ToString(sdr2[6]);
                cmbgender.Text = Convert.ToString(sdr2[7]);
                txtno.Text = Convert.ToString(sdr2[8]);
                cmbcid.Text = Convert.ToString(sdr2[9]);
                txttfee.Text = Convert.ToString(sdr2[10]);
                txtpfee.Text = Convert.ToString(sdr2[11]);
            }
            sdr2.Close();
        }

        private void txtsnm_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string email = Convert.ToString(txtemail.Text);
            if (Regex.Match(email, "\a-z+ ([-+.']\a-z+)*@\a-z+([-.]\a-z+)*.\a-z+([-.]\a-z+)*").Success)
            {
                MessageBox.Show("Correctly Entered");
            }
            else
            {
                MessageBox.Show("Please Enter Vaild Email Address");
            }
        }

        private void txtsadd_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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

    }
}
