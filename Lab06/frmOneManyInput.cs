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
    public partial class frmOneManyInput : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();
        public frmOneManyInput()
        {
            InitializeComponent();
            masterDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Dock = DockStyle.Fill;

            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            this.Controls.Add(splitContainer1);
            this.Load += new System.EventHandler(frmOneManyInput_Load);
            this.Text = "DataGridView master/detail demo";
        }

        private void frmOneManyInput_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView controls to the BindingSource
            // components and load the data from the database.
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            // Resize the master DataGridView columns to fit the newly loaded data.
            masterDataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void GetData()
        {
            try
            {
                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the Customers table to the DataSet.
                SqlDataAdapter masterDataAdapter = new
                    SqlDataAdapter("select * from Department", connection);
                masterDataAdapter.Fill(data, "Departments");

                // Add data from the Orders table to the DataSet.
                SqlDataAdapter detailsDataAdapter = new
                    SqlDataAdapter("select * from Employee", connection);
                detailsDataAdapter.Fill(data, "Employees");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("Employees",
                    data.Tables["Departments"].Columns["DNumber"],
                    data.Tables["Employees"].Columns["DNo"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Departments";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the
                // details table based on the current row in the master table.
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "Employees";
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
