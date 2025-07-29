using AlShamModelSchool.Classes;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.Classes
{
    public partial class frmManageClasses : Form
    {
        private static DataTable _dtAllClasses = clsClass.GetAllClasses();
        private DataTable _dtClasses = _dtAllClasses.DefaultView.ToTable();

        public frmManageClasses()
        {
            InitializeComponent();
        }


        private void _RefreshClassesList()
        {
            _dtAllClasses = clsClass.GetAllClasses();
            _dtClasses = _dtAllClasses.DefaultView.ToTable(false);

          
            dgvClasses.DataSource = _dtClasses;
            lblRecordsCount.Text = dgvClasses.Rows.Count.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         

        private void frmManageClasses_Load(object sender, EventArgs e)
        {
            dgvClasses.DataSource = _dtClasses; 
            lblRecordsCount.Text = dgvClasses.Rows.Count.ToString();
            _RefreshClassesList();
            if (dgvClasses.Rows.Count > 0)
            {
                dgvClasses.Columns[0].HeaderText = "Class ID";
                dgvClasses.Columns[0].Width = 80;

                dgvClasses.Columns[1].HeaderText = "Class Name";
                dgvClasses.Columns[1].Width = 110;

                dgvClasses.Columns[2].HeaderText = "Grade Level";
                dgvClasses.Columns[2].Width = 110;


                dgvClasses.Columns[3].HeaderText = "Max Students";
                dgvClasses.Columns[3].Width = 110;

                dgvClasses.Columns[4].HeaderText = "Room Number";
                dgvClasses.Columns[4].Width = 110;

                dgvClasses.Columns[5].HeaderText = "Shift Type";
                dgvClasses.Columns[5].Width = 160;

               /* dgvClasses.Columns[6].HeaderText = "Address";
                dgvClasses.Columns[6].Width = 130;

                dgvClasses.Columns[7].HeaderText = "NationalID";
                dgvClasses.Columns[7].Width = 120;*/
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClass((int)dgvClasses.CurrentRow.Cells[0].Value);
            frm.ShowDialog(); 
            _RefreshClassesList();
        }

        private void btnAddNewClasses_Click(object sender, EventArgs e)
        {

            Form frm = new frmAddUpdateClass();
            frm.ShowDialog();
            _RefreshClassesList();
        }

         

        private void DeleteClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this Class", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsClass.Delete((int)dgvClasses.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Class Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClassesList();

                } else
                    MessageBox.Show("Class was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addNewClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClass();
            frm.ShowDialog();
            _RefreshClassesList();
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshClassesList();
        }
    }
}
