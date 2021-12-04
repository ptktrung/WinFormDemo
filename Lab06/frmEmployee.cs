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
    public partial class frmEmployee : Form
    {
        //Read connection from App.config
        //String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(strConn);
            //conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Department", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Fill sucess Welcome");
                //dataGridViewEmployee.DataSource = dt;
                comboBoxDepartment.DataSource = dt;
                comboBoxDepartment.DisplayMember = "DName";
                comboBoxDepartment.ValueMember = "DNumber";
                LoadData();
                //gridStudents.Refresh();
            }
            else
            {
                MessageBox.Show("No Data");
            }
            adapter.Dispose();
            //conn.Close();
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee where DNo=" + comboBoxDepartment.SelectedValue, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Fill sucess Welcome");
                    dataGridViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error:" + ex.Message + "-" + ex.Source);

            }
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
