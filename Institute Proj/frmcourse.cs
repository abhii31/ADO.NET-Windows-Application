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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Institute_Proj
{
    public partial class frmcourse : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public frmcourse()
        {
            InitializeComponent();
        }

        private void frmcourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institute_ProjDataSet.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.institute_ProjDataSet.course);
            GetData();
        }
        public void GetData()
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
                if (txtid.Text =="")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (cmbcnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (txtcdur.Text == "")
                {
                    MessageBox.Show("Please Enter Course Duration");
                    return;
                }
                else if (txtcfee1.Text == "")
                {
                    MessageBox.Show("Please Enter Course Fees");
                    return;
                }
                else if (txtcfee.Text == "")
                {
                    MessageBox.Show("Please Enter Course Installments Fee");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_course", conn);

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtid.Text.ToString();
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cmbcnm.Text.ToString();
                    cmd.Parameters.Add("@duration", SqlDbType.VarChar).Value = txtcdur.Text.ToString();
                    cmd.Parameters.Add("@fee1", SqlDbType.VarChar).Value = txtcfee1.Text.ToString();
                    cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = txtcfee.Text.ToString();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text =="")
                {
                    MessageBox.Show("Please Enter Course ID");
                    return;
                }
                else if (cmbcnm.Text == "")
                {
                    MessageBox.Show("Please Enter Course Name");
                    return;
                }
                else if (txtcdur.Text == "")
                {
                    MessageBox.Show("Please Enter Course Duration");
                    return;
                }
                else if (txtcfee1.Text == "")
                {
                    MessageBox.Show("Please Enter Course Fees");
                    return;
                }
                else if (txtcfee.Text == "")
                {
                    MessageBox.Show("Please Enter Course Installment Fee");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_update_course", conn);

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtid.Text.ToString();
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cmbcnm.Text.ToString();
                    cmd.Parameters.Add("@duration", SqlDbType.VarChar).Value = txtcdur.Text.ToString();
                    cmd.Parameters.Add("@fee1", SqlDbType.VarChar).Value = txtcfee1.Text.ToString();
                    cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = txtcfee.Text.ToString();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_course", conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtid.Text.ToString();
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
            txtid.Text = "";
            cmbcnm.Text = "";
            txtcdur.Text = "";
            txtcfee1.Text = "";
            txtcfee.Text = "";
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=RK\\SQLEXPRESS01; database=Institute Proj; integrated security=SSPI"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[course] ", connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvcourse.DataSource = dt;
                    }
                }
            }
        }
        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvcourse.Rows[dgvcourse.CurrentRow.Index].Cells[0].Value.ToString();
            cmbcnm.Text = dgvcourse.Rows[dgvcourse.CurrentRow.Index].Cells[1].Value.ToString();
            txtcdur.Text = dgvcourse.Rows[dgvcourse.CurrentRow.Index].Cells[2].Value.ToString();
            txtcfee1.Text = dgvcourse.Rows[dgvcourse.CurrentRow.Index].Cells[3].Value.ToString();
            txtcfee.Text = dgvcourse.Rows[dgvcourse.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select max(C_ID) as id from course ", conn);       
            SqlDataReader sdr1 = cm.ExecuteReader();

            while (sdr1.Read())
            {
                int cnt = Convert.ToInt32(sdr1[0]);
                cnt++;
                txtid.Text = Convert.ToString(cnt);
            }
            sdr1.Close();
        }
    }
}
