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

using System.Configuration;

namespace Lab06
{
    public partial class Form1 : Form
    {
        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            //String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have you changed the connectionString in App.config file?", "Connection String" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadData();
                SetEditingMode(false);
            }
            else
            {
                MessageBox.Show("Then change <<connection string>> in App.config and try again!!!");
                Hide();
                Application.Exit();
            }
            
        }

        private void LoadData()
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=SA41FXBI-PC\SQL2014;Initial Catalog=Lab6;Integrated Security=True");
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Fill sucess Welcome");
                gridStudents.DataSource = dt;
                //gridStudents.Refresh();
            }
            else
            {
                MessageBox.Show("No Data");
            }

            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridStudents.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a student first");
                return;
            }
            int index = gridStudents.SelectedCells[0].RowIndex;
            if (index < 0 || index >= gridStudents.RowCount)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            DataGridViewRow row = gridStudents.Rows[index];
            int id = int.Parse(row.Cells[0].Value.ToString());
            String name = row.Cells[1].Value.ToString();


            DialogResult result = MessageBox.Show("Do you want to delete student:  " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            if (DeleleById(id))
            {
                gridStudents.ClearSelection();
                LoadData();
                btnClear_Click(null, null);
                SetEditingMode(false);
            }
            else
            {
                MessageBox.Show("Delete Sucessfully!");
            }
        }

        private bool DeleleById(int id)
        {
            //SqlConnection conn = new SqlConnection("Data Source=localhost\\SQL2014;Initial Catalog=Lab6;Integrated Security=True");
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from student where maso = @id", conn);

            SqlParameter param1 = new SqlParameter("@id", id);
            SqlParameter[] parameters = { param1 }; // you may add more params

            cmd.Parameters.AddRange(parameters);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows == 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            rbMale.Checked = true;
            rbFemale.Checked = false;
            dtBirth.Value = DateTime.Now;
            SetEditingMode(false);
            txtName.Focus();
        }

        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                gridStudents.ClearSelection();
            }
            btnAdd.Enabled = !enable;
            btnClear.Enabled = true;
            btnDelete.Enabled = enable;
            btnUpdate.Enabled = enable;
        }

        private void gridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= gridStudents.RowCount)
            {
                return;
            }

            DataGridViewRow row = gridStudents.Rows[index];
            String name = Convert.ToString(row.Cells[1].Value);
            DateTime birth = Convert.ToDateTime(row.Cells[2].Value);
            bool isMale = Convert.ToBoolean(row.Cells[3].Value);
            String email = Convert.ToString(row.Cells[4].Value);

            // update UI
            txtName.Text = name;
            txtEmail.Text = email;
            dtBirth.Value = birth;
            rbMale.Checked = isMale;
            rbFemale.Checked = !isMale;

            SetEditingMode(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //write a code with sqlcommand Insert Into (data should be from form where user type in)
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            int gender = 0;
            if (rbMale.Checked)
                gender=1;
            String sql = "insert into student VALUES('" + txtName.Text + "','" + dtBirth.Value.ToString("MM-dd-yyyy") + "'," + gender + ",'" + txtEmail.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row=cmd.ExecuteNonQuery();
            if (row == 1)
            {
                MessageBox.Show("Add Successfully!");
                LoadData();
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //write a code to update any change on data grid and use command "update" to update change to database
        }

        private void gridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
