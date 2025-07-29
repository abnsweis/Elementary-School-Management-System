using AlShamModelSchool.Classes;
using AlShamModelSchool.Curriculums;
using AlShamModelSchool.GradeLevels;
using AlShamModelSchool.Parents;
using AlShamModelSchool.People;
using AlShamModelSchool.StudentEnrollment;
using AlShamModelSchool.Students;
using AlShamModelSchool.Teachers;
using AlShamModelSchool.Users;
using BusinessLogicLayer;
using Guna.UI2.WinForms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnManagePeopleForm_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void btnAddNewPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageStudents();
            frm.ShowDialog();
        }

        private void btnMangeParents_Click(object sender, EventArgs e)
        {
            Form frm = new frmParentsList(frmParentsList.enMode.Read);
            frm.ShowDialog();
        }

        private void btnAddNewStudents_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent();
            frm.ShowDialog();
        }

        private void btnManageCurriculums_Click(object sender, EventArgs e)
        {
            frmManageCurriculums frm = new frmManageCurriculums();
            frm.ShowDialog();
        }

        private void btnManageEducationLevels_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageEducationLevels();
            frm.ShowDialog();
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageClasses();
            frm.ShowDialog();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            frmAddUpdateClass frm = new frmAddUpdateClass();
            frm.ShowDialog();

        }

        private void btnManageGradeLevels_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageGradeLevels();
            frm.ShowDialog();
        }

        private void btnManageEnrollments_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageStudentEnrollment();
            frm.ShowDialog();
        }

        private void btmAddNewEnrollment_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollmentNewStudent();
            frm.ShowDialog();
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTeachers();
            frm.ShowDialog();
        }

        private void btnAddNewteachers_Click(object sender, EventArgs e)
        {
            frmAddUpdateTeacher frm = new frmAddUpdateTeacher();
            frm.ShowDialog();
        }

        private void btnTeacherInformation_Click(object sender, EventArgs e)
        {
            frmTeacherSelector frm = new frmTeacherSelector(1);
            frm.ShowDialog();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            frmAddUpdateClass frm = new frmAddUpdateClass();
            frm.ShowDialog();
        }
    }
}
