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
    public partial class frmmenu : Form
    {
        SqlConnection conn = null;
        public frmmenu()
        {
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source= RK\\SQLEXPRESS01;database=Institute Proj;integrated security=SSPI");
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmcourse f1=new frmcourse();
            f1.Show();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbatch f2=new frmbatch();
            f2.Show();
        }
     
        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmenquiry f3=new frmenquiry();
            f3.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteacher f4= new frmteacher();
            f4.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmresult f5=new frmresult();
            f5.Show();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadmission f6= new frmadmission();
            f6.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbill f7=new frmbill();
            f7.Show();  
        }
    }
}
