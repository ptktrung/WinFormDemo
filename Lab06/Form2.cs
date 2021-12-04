using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form2 : Form
    {
        public List<Person> Profession { get; set; }
        public Form2()
        {
            Profession = GetProfession();
            InitializeComponent();
        }
        private List<Person> GetProfession()
        {
            var list = new List<Person>();
            list.Add(new Person()
            {
                PersonID = 1,
                Name = "Xuan Tan",
                Address = "TpHCM",
                Job = "IT Developer"
            });
            list.Add(new Person()
            {
                PersonID = 2,
                Name = "Xuan Son",
                Address = "Binh Duong",
                Job = "IT Analyst"
            });
            list.Add(new Person()
            {
                PersonID = 3,
                Name = "Xuan Phong",
                Address = "Long An",
                Job = "IT Manager"
            });
            return list;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var profession = this.Profession;
            dataGridView1.DataSource = profession;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectOne = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                textBoxPersonID.Text = selectOne.PersonID.ToString();
                textBoxName.Text = selectOne.Name.ToString();
                textBoxAddress.Text = selectOne.Address.ToString();
                textBoxJob.Text = selectOne.Job.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + "-" + ex.Source);
            }
        }
    }
}
