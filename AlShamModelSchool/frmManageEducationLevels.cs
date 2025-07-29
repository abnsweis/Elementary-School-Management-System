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

namespace AlShamModelSchool
{
    public partial class frmManageEducationLevels : Form
    {

        private static DataTable _dtAllEducationLevels = clsEducationLevel.GetAllEducationLevels();
        private DataTable _dtEducationLevels = _dtAllEducationLevels.DefaultView.ToTable();

        public frmManageEducationLevels()
        {
            InitializeComponent();
        }


        private void _RefreshEducationLevelst()
        {
            _dtAllEducationLevels = clsCurriculum.GetAllCurriculums();
            _dtEducationLevels = _dtAllEducationLevels.DefaultView.ToTable(false);

            dgvEducationLevels.DataSource = _dtEducationLevels;
            lblRecordsCount.Text = dgvEducationLevels.Rows.Count.ToString();


        }


        private void frmManageEducationLevels_Load(object sender, EventArgs e)
        {
            dgvEducationLevels.DataSource = _dtEducationLevels;

            lblRecordsCount.Text = dgvEducationLevels.Rows.Count.ToString();

            if (dgvEducationLevels.Rows.Count > 0)
            {
                dgvEducationLevels.Columns[0].HeaderText = "Education Level ID";
                dgvEducationLevels.Columns[0].Width = 150;

                dgvEducationLevels.Columns[1].HeaderText = "Education Level Name";
                dgvEducationLevels.Columns[1].Width = 180;

                dgvEducationLevels.Columns[2].HeaderText = "Created Date";
                dgvEducationLevels.Columns[2].Width = 130;

                dgvEducationLevels.Columns[3].HeaderText = "Description";
                dgvEducationLevels.Columns[3].Width = dgvEducationLevels.Width - (150 + 330);

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
