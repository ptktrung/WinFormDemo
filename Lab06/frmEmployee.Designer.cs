namespace Lab06
{
    partial class frmEmployee
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
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(165, 12);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(214, 24);
            this.comboBoxDepartment.TabIndex = 0;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Department";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(-5, 103);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1231, 482);
            this.dataGridViewEmployee.TabIndex = 2;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 597);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDepartment);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
    }
}