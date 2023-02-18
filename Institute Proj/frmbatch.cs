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

namespace Institute_Proj
{
    public partial class frmbatch : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmbatch()
        {
            InitializeComponent();
        }

        private void batch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet1.batch' table. You can move, or remove it, as needed.
            //this.batchTableAdapter.Fill(this.institute_ProjDataSet1.batch);
            GetData();

            cmd = new SqlCommand("select C_Name from course", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbnm.Items.Add(sdr[0]);
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

        private void btnid_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbid.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (cmbnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (dtpdate.Text == "")
                {
                    MessageBox.Show("Please Enter Joining Date");
                    return;
                }
                else if (cmbbtime.Text == "")
                {
                    MessageBox.Show("Please Enter Batch Time");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_batch", conn);

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = cmbid.Text.ToString();
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cmbnm.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpdate.Text.ToString();
                    cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = cmbbtime.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = cmd.ExecuteNonQuery();
                    if (id > 0)
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

        private void btnnm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbid.Text == "")
                {
                    MessageBox.Show("Please Enter Batch ID");
                    return;
                }
                else if (cmbnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (dtpdate.Text == "")
                {
                    MessageBox.Show("Please Enter Joining Date");
                    return;
                }
                else if (cmbbtime.Text == "")
                {
                    MessageBox.Show("Please Enter Batch Time");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_batch", conn);

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = cmbid.Text.ToString();
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cmbnm.Text.ToString();
                    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpdate.Text.ToString();
                    cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = cmbbtime.Text.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = cmd.ExecuteNonQuery();
                    if (id > 0)
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

        private void btndate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_batch", conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = cmbid.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                int id = cmd.ExecuteNonQuery();
                if (id > 0)
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
            cmbid.Text = "";
            cmbnm.Text = "";
            dtpdate.Text = "";
            cmbbtime.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[batch] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvbatch.DataSource = dt;
                    }
                }
            }
        }

        private void dgvbatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbid.Text = dgvbatch.Rows[dgvbatch.CurrentRow.Index].Cells[0].Value.ToString();
            cmbnm.Text = dgvbatch.Rows[dgvbatch.CurrentRow.Index].Cells[1].Value.ToString();
            dtpdate.Text = dgvbatch.Rows[dgvbatch.CurrentRow.Index].Cells[2].Value.ToString();
            cmbbtime.Text = dgvbatch.Rows[dgvbatch.CurrentRow.Index].Cells[3].Value.ToString();
        }

    }
}
