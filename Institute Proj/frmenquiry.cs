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
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Institute_Proj
{
    public partial class frmenquiry : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmenquiry()
        {
            InitializeComponent();
        }

        private void enquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet2.enquiry' table. You can move, or remove it, as needed.
            //this.enquiryTableAdapter.Fill(this.institute_ProjDataSet2.enquiry);
            GetData();

            cmd = new SqlCommand("select C_Name from course", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
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
                if (txtid.Text == "")
                {
                    MessageBox.Show("Please Enter Enquiry ID");
                    return;
                }
                else if (dtptime.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtsnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
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
                else if (txtsno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbcnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (txtbtime.Text == "")
                {
                    MessageBox.Show("Please Enter Batch Time");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_enquiry", conn);

                    cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = txtid.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtptime.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = txtsno.Text.ToString();
                    cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = cmbcnm.Text.ToString();
                    cmd.Parameters.Add("@btime", SqlDbType.VarChar).Value = txtbtime.Text.ToString();
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
                if (txtid.Text == "")
                {
                    MessageBox.Show("Please Enter Enquiry ID");
                    return;
                }
                else if (dtptime.Text == "")
                {
                    MessageBox.Show("Please Enter Date");
                    return;
                }
                else if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtsnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
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
                else if (txtsno.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                else if (cmbcnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (txtbtime.Text == "")
                {
                    MessageBox.Show("Please Enter Batch Time");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_enquiry", conn);

                    cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = txtid.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtptime.Text.ToString();
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsnm.Text.ToString();
                    cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = txtsadd.Text.ToString();
                    cmd.Parameters.Add("@sgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = txtsno.Text.ToString();
                    cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = cmbcnm.Text.ToString();
                    cmd.Parameters.Add("@btime", SqlDbType.VarChar).Value = txtbtime.Text.ToString();
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
                SqlCommand cmd = new SqlCommand("sp_delete_enquiry", conn);
                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = txtid.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int eid = cmd.ExecuteNonQuery();
                if (eid > 0)
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
            txtid.Text = "";
            dtptime.Text = "";
            txtsid.Text = "";
            txtsnm.Text = "";
            txtsadd.Text = "";
            cmbgender.Text = "";
            txtsno.Text = "";
            cmbcnm.Text = "";
            txtbtime.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[enquiry] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvenquiry.DataSource = dt;
                    }
                }
            }
        }

        private void dgvenquiry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[0].Value.ToString();
            dtptime.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[1].Value.ToString();
            txtsid.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[3].Value.ToString();
            txtsnm.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[3].Value.ToString();
            txtsadd.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[4].Value.ToString();
            cmbgender.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[5].Value.ToString();
            txtsno.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[6].Value.ToString();
            cmbcnm.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[7].Value.ToString();
            txtbtime.Text = dgvenquiry.Rows[dgvenquiry.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select max(E_id) as id from enquiry ", conn);
            SqlDataReader sdr1 = cm.ExecuteReader();

            while (sdr1.Read())
            {
                int cnt = Convert.ToInt32(sdr1[0]);
                cnt++;
                txtid.Text = Convert.ToString(cnt);
            }
            sdr1.Close();
        }

        private void txtbtime_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from batch where Time=" + txtbtime.Text + " ", conn);
            SqlDataReader sdr1 = cm.ExecuteReader();
            while (sdr1.Read())
            {
                dtptime.Text = Convert.ToString(sdr1[1]);
                txtsid.Text = Convert.ToString(sdr1[2]);
                txtsnm.Text = Convert.ToString(sdr1[3]);
                txtsadd.Text = Convert.ToString(sdr1[4]);
                cmbgender.Items.Add(sdr1[5]);
                cmbgender.SelectedIndex = Convert.ToInt32(cmbgender.SelectedIndex);
                txtsno.Text = Convert.ToString(sdr1[6]);
                cmbcnm.Items.Add(sdr1[7]);
                cmbcnm.SelectedIndex = Convert.ToInt32(cmbcnm.SelectedIndex);
                txtbtime.Text = Convert.ToString(sdr1[3]);
            }
        }

        private void txtsnm_TextChanged_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsadd_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsno_TextChanged(object sender, EventArgs e)
        {
            string telno = Convert.ToString(txtsno.Text);
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