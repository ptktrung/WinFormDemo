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
using System.Configuration;
namespace Lab06
{
    public partial class frmDeptEmp : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public frmDeptEmp()
        {
            InitializeComponent();
        }

        private void frmDeptEmp_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Department", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Fill sucess Welcome");
                dataGridViewDepartment.DataSource = dt;
                //gridStudents.Refresh();
            }
            else
            {
                MessageBox.Show("No Data");
            }
            adapter.Dispose();
            LoadData();
        }

        private void dataGridViewDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectOne = dataGridView1.SelectedRows[0].DataBoundItem as Person;
            //textBoxPersonID.Text = selectOne.PersonID.ToString();
            //var selectOne=dataGridViewDepartment.SelectedRows[0].DataBoundItem
            LoadData();
            dataGridViewDepartment.Refresh();
            dataGridViewEmployee.Refresh();
        }
        private void LoadData()
        {
            try
            {
                //dataGridView1.SelectedRows[0].DataBoundItem
                //int iDNo = dataGridViewDepartment.SelectedRows[0].DataBoundItem.DNo;
                int index = dataGridViewDepartment.SelectedCells[0].RowIndex;
                if (index < 0 || index >= dataGridViewDepartment.RowCount)
                {
                    MessageBox.Show("Please select a department first");
                    return;
                }

                DataGridViewRow row = dataGridViewDepartment.Rows[index];
                //Get DNumber from the dataGrid
                int iDNo = int.Parse(row.Cells[1].Value.ToString());
                //String sDNo = row.Cells[1].Value.ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee where DNo=" + iDNo, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   // MessageBox.Show("Fill sucess Welcome");
                    dataGridViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                adapter.Dispose();
                dataGridViewEmployee.Refresh();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error:" + ex.Message + "-" + ex.Source);

            }
        }
    }
}
