namespace Lab06
{
    partial class frmDeptEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowTemplate.Height = 24;
            this.dataGridViewDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(886, 237);
            this.dataGridViewDepartment.TabIndex = 0;
            this.dataGridViewDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellContentClick);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 311);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(886, 237);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // frmDeptEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 613);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Name = "frmDeptEmp";
            this.Text = "frmDeptEmp";
            this.Load += new System.EventHandler(this.frmDeptEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
    }
}