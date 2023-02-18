using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmteacher : Form
    {

        SqlConnection conn = null;
        SqlCommand cmd;
        public frmteacher()
        {
            InitializeComponent();
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet3.teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter.Fill(this.institute_ProjDataSet3.teacher);
            GetData();

            cmd = new SqlCommand("select C_ID from course", conn);
            SqlDataReader sdr= cmd.ExecuteReader();
            while(sdr.Read())
            {
                cmbcid.Items.Add(sdr[0]);
            }
            sdr.Close();

            cmd = new SqlCommand("select B_ID from batch", conn);
            SqlDataReader sdr1 = cmd.ExecuteReader();
            while (sdr1.Read())
            {
                cmbbid.Items.Add(sdr1[0]);
            }
            sdr1.Close();
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

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtid.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher ID");
                    return;
                }
                else if (txttnm.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher Name");
                    return;
                }
                else if (txttadd.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher Address");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Email ID");
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
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_teacher", conn);

                    cmd.Parameters.Add("@tid", SqlDbType.VarChar).Value = cmbtid.Text.ToString();
                    cmd.Parameters.Add("@tname", SqlDbType.VarChar).Value = txttnm.Text.ToString();
                    cmd.Parameters.Add("@tadd", SqlDbType.VarChar).Value = txttadd.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@tgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = cmbbid.Text.ToString();
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
                if (cmbtid.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher ID");
                    return;
                }
                else if (txttnm.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher Name");
                    return;
                }
                else if (txttadd.Text == "")
                {
                    MessageBox.Show("Please Enter Teacher Address");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Email ID");
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
                    MessageBox.Show("Please Enter Batch Time");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_teacher", conn);

                    cmd.Parameters.Add("@tid", SqlDbType.VarChar).Value = cmbtid.Text.ToString();
                    cmd.Parameters.Add("@tname", SqlDbType.VarChar).Value = txttnm.Text.ToString();
                    cmd.Parameters.Add("@tadd", SqlDbType.VarChar).Value = txttadd.Text.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text.ToString();
                    cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = txtno.Text.ToString();
                    cmd.Parameters.Add("@tgender", SqlDbType.VarChar).Value = cmbgender.Text.ToString();
                    cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmbcid.Text.ToString();
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = cmbbid.Text.ToString();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_teacher", conn);
                cmd.Parameters.Add("@tid", SqlDbType.VarChar).Value = cmbtid.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int tid = cmd.ExecuteNonQuery();
                if (tid > 0)
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
            cmbtid.Text = "";
            txttnm.Text = "";
            txttadd.Text = "";
            txtemail.Text = "";
            txtno.Text = "";
            cmbgender.Text = "";
            cmbcid.Text = "";
            cmbbid.Text = "";
        }

        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[teacher] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvteacher.DataSource = dt;
                    }
                }
            }
        }
        private void dgvteacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cmbtid.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[0].Value.ToString();
            txttnm.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[1].Value.ToString();
            txttadd.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[2].Value.ToString();
            txtemail.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[3].Value.ToString();
            txtno.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[4].Value.ToString();
            cmbgender.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[5].Value.ToString();
            cmbcid.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[6].Value.ToString();
            cmbbid.Text = dgvteacher.Rows[dgvteacher.CurrentRow.Index].Cells[7].Value.ToString();
        }

        private void cmbtid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from teacher where T_ID = " + cmbtid.Text + "", conn);
            SqlDataReader sdr2= cmd.ExecuteReader();
            while (sdr2.Read())
            {
                txttnm.Text = Convert.ToString(sdr2[1]);
                txttadd.Text= Convert.ToString(sdr2[2]);
                txtemail.Text= Convert.ToString(sdr2[3]);
                txtno.Text= Convert.ToString(sdr2[4]);
                cmbgender.Text= Convert.ToString(sdr2[5]);
                cmbcid.Text= Convert.ToString(sdr2[0]);
                cmbbid.Text = Convert.ToString(sdr2[0]);

            }
            sdr2.Close();
        }

        private void txttnm_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttadd_TextChanged(object sender, KeyPressEventArgs e)
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
