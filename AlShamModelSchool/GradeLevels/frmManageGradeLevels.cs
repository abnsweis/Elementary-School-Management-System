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

namespace AlShamModelSchool.GradeLevels
{
    public partial class frmManageGradeLevels : Form
    {

        private static DataTable _dtAllGradeLevels = clsGradeLevel.GetAllGradeLevels();
        private DataTable _dtCurriculums = _dtAllGradeLevels.DefaultView.ToTable();
        



        private void _RefreshCurriculumsist()
        {
            _dtAllGradeLevels = clsGradeLevel.GetAllGradeLevels();
            _dtCurriculums = _dtAllGradeLevels.DefaultView.ToTable(false);

            dgvGradeLevels.DataSource = _dtCurriculums;
            lblRecordsCount.Text = dgvGradeLevels.Rows.Count.ToString();


        }


        private void frmManageGradeLevels_Load(object sender, EventArgs e)
        {
            dgvGradeLevels.DataSource = _dtCurriculums;

            lblRecordsCount.Text = dgvGradeLevels.Rows.Count.ToString();

            if (dgvGradeLevels.Rows.Count > 0)
            {
                dgvGradeLevels.Columns[0].HeaderText = "Grade Level ID";
                dgvGradeLevels.Columns[0].Width = 110;

                dgvGradeLevels.Columns[1].HeaderText = "Curriculum ID";
                dgvGradeLevels.Columns[1].Width = 110;

                dgvGradeLevels.Columns[2].HeaderText = "Grade Level Name";
                dgvGradeLevels.Columns[2].Width = 140;                
                
                dgvGradeLevels.Columns[3].HeaderText = "Curriculum Name";
                dgvGradeLevels.Columns[3].Width = 200;


                dgvGradeLevels.Columns[4].HeaderText = "Books Count";
                dgvGradeLevels.Columns[4].Width = 110;
                
                dgvGradeLevels.Columns[5].HeaderText = "MinAge";
                dgvGradeLevels.Columns[5].Width = 110;
                
                dgvGradeLevels.Columns[6].HeaderText = "MaxAge";
                dgvGradeLevels.Columns[6].Width = 110;

         

            }
        }
        public frmManageGradeLevels()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
