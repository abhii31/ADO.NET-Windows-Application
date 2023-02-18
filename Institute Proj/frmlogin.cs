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

namespace Institute_Proj
{
    public partial class frmlogin : Form
    {
        SqlConnection conn = null;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            try
            {
                int flag = 0;
                conn = new SqlConnection("Data Source= RK\\SQLEXPRESS01;database=Institute Proj;integrated security=SSPI");
                conn.Open();
                MessageBox.Show("Connection Successfully");
                SqlCommand cmd = new SqlCommand("select * from login where UserName='" + txtun + "' and PassWord='" + txtpsw + "'", conn);
                SqlDataReader sdr=cmd.ExecuteReader();
                while(sdr.Read())
                {
                    flag = 1;
                    break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOP'S, Something Went Wrong."+ex);
            }
            finally 
            {
                conn.Close();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frmmenu f1 = new frmmenu();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtun.Text = "";
                txtpsw.Text = "";
            }
            catch (Exception ex2)
            {
                MessageBox.Show("OOP'S, Something Went Wrong." + ex2);
            }
        }
    }
}
