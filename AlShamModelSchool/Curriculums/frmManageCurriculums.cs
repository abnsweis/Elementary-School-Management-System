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

namespace AlShamModelSchool.Curriculums
{
    public partial class frmManageCurriculums : Form
    {

        private static DataTable _dtAllCurriculums = clsCurriculum.GetAllCurriculums();
        private DataTable _dtCurriculums = _dtAllCurriculums.DefaultView.ToTable();
        public frmManageCurriculums()
        {
            InitializeComponent();
        }


       
        private void _RefreshCurriculumsist()
        {
            _dtAllCurriculums = clsCurriculum.GetAllCurriculums();
            _dtCurriculums = _dtAllCurriculums.DefaultView.ToTable(false);

            dgvCurriculums.DataSource = _dtCurriculums;
            lblRecordsCount.Text = dgvCurriculums.Rows.Count.ToString();

             
        }
         
       
        private void frmCurriculumsList_Load(object sender, EventArgs e)
        {
          dgvCurriculums.DataSource = _dtCurriculums;
          
          lblRecordsCount.Text = dgvCurriculums.Rows.Count.ToString();

          if (dgvCurriculums.Rows.Count > 0)
          {
              dgvCurriculums.Columns[0].HeaderText = "Curriculum ID";
              dgvCurriculums.Columns[0].Width = 110;

              dgvCurriculums.Columns[1].HeaderText = "Education Level Name";
              dgvCurriculums.Columns[1].Width = 200;

              dgvCurriculums.Columns[2].HeaderText = "Curriculum Name";
              dgvCurriculums.Columns[2].Width = 170;


              dgvCurriculums.Columns[3].HeaderText = "Publication Date";
              dgvCurriculums.Columns[3].Width = 150;

              dgvCurriculums.Columns[4].HeaderText = "Description";
              dgvCurriculums.Columns[4].Width = dgvCurriculums.Width  - (110 + 200+170+150);

          }
        }

         

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCurriculum(int.Parse(dgvCurriculums.SelectedRows[0].Cells[0].Value.ToString()));
            frm.ShowDialog();
            _RefreshCurriculumsist();
        }

        private void addNewCurriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCurriculum();
            frm.ShowDialog();
            _RefreshCurriculumsist();
        }

        private void btnAddNewCurriculum_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCurriculum();
            frm.ShowDialog();
            _RefreshCurriculumsist();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this Curriculum", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsCurriculum.Delete((int)dgvCurriculums.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Curriculum Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCurriculumsist();

                } else
                    MessageBox.Show("Curriculum was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
