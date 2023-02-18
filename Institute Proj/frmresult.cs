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
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Institute_Proj
{
    public partial class frmresult : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmresult()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet4.result' table. You can move, or remove it, as needed.
            //this.resultTableAdapter.Fill(this.institute_ProjDataSet4.result);
            GetData();

            SqlCommand cm = new SqlCommand("select * from enquiry ", conn);
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
                if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
                    return;
                }
                else if (txtenm.Text == "")
                {
                    MessageBox.Show("Please Enter Enquiry Name");
                    return;
                }
                else if (txtresult.Text == "")
                {
                    MessageBox.Show("Please Enter Result");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_result", conn);

                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtnm.Text.ToString();
                    cmd.Parameters.Add("@ename", SqlDbType.VarChar).Value = txtenm.Text.ToString();
                    cmd.Parameters.Add("@result", SqlDbType.VarChar).Value = txtresult.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int sid = cmd.ExecuteNonQuery();
                    if (sid > 0)
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
                if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Enter Student ID");
                    return;
                }
                else if (txtnm.Text == "")
                {
                    MessageBox.Show("Please Enter Student Name");
                    return;
                }
                else if (txtenm.Text == "")
                {
                    MessageBox.Show("Please Enter Enquiry Name");
                    return;
                }
                else if (txtresult.Text == "")
                {
                    MessageBox.Show("Please Enter Result");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_result", conn);

                    cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtnm.Text.ToString();
                    cmd.Parameters.Add("@ename", SqlDbType.VarChar).Value = txtenm.Text.ToString();
                    cmd.Parameters.Add("@result", SqlDbType.VarChar).Value = txtresult.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int sid = cmd.ExecuteNonQuery();
                    if (sid > 0)
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
                SqlCommand cmd = new SqlCommand("sp_delete_result", conn);
                cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtsid.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int sid = cmd.ExecuteNonQuery();
                if (sid > 0)
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
            txtsid.Text = "";
            txtnm.Text = "";
            txtenm.Text = "";
            txtresult.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[result] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvresult.DataSource = dt;
                    }
                }
            }
        }

        private void dgvresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsid.Text = dgvresult.Rows[dgvresult.CurrentRow.Index].Cells[0].Value.ToString();
            txtnm.Text = dgvresult.Rows[dgvresult.CurrentRow.Index].Cells[1].Value.ToString();
            txtenm.Text = dgvresult.Rows[dgvresult.CurrentRow.Index].Cells[2].Value.ToString();
            txtresult.Text = dgvresult.Rows[dgvresult.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from result where S_ID=" + txtsid.Text + " ", conn);
            SqlDataReader sdr1 = cm.ExecuteReader();
            while (sdr1.Read())
            {

                txtnm.Text = Convert.ToString(sdr1[1]);
                txtenm.Text = Convert.ToString(sdr1[2]);
                txtresult.Text = Convert.ToString(sdr1[3]);
            }
        }

        private void txtnm_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtenm_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
