using AlShamModelSchool.Properties;
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
using static Guna.UI2.Native.WinApi;

namespace AlShamModelSchool.Teachers.UserControls
{




    public partial class ucTeacherShortInfo : UserControl
    {

        private clsTeacher _Teacher;
        private int _TeacherID;

        private bool _isDisabled = false;
        private bool _ShowSelectButton = true;
        private bool _EnabledViewButton = true;

        public class SelectedTeacherEventArgs : EventArgs
        {
            public int TeacherID { get;}
            public clsTeacher Teacher { get; }
            public SelectedTeacherEventArgs(int teacherID)
            {
                TeacherID = teacherID;
                Teacher = clsTeacher.Find(teacherID);
            }
        }
        public event EventHandler<SelectedTeacherEventArgs> OnTeacherSelected;

        public bool ShowSelectButton
        {
            get => _ShowSelectButton;
            set
            {
                _ShowSelectButton = value;
                btnSelect.Visible = _ShowSelectButton;
                this.Width = _ShowSelectButton ? 615 : 510;
            }
        }

        public bool EnabledViewButton
        {
            get => btnView.Enabled;
            set
            {
                _EnabledViewButton = value;
                btnView.Enabled = value;
                if (value)
                {
                    btnView.BackColor = Color.FromArgb(0, 120, 215);
                } else
                {
                    btnView.BackColor = Color.Gray;
                }
            }
        }
        public int TeacherID
        {
            get { return _TeacherID; }
            set
            {
                _TeacherID = value;
                LoadTeacherInfo(_TeacherID);
                
            }
        }

        public clsTeacher Teacher
        {
            get { return _Teacher; }
        }

        public ucTeacherShortInfo()
        {
            InitializeComponent();
        }


        public void DisableControl()
        {
            pbTeacherGender.Image = Resources.icons8_info_100;
            btnSelect.Enabled = false;
            btnView.Enabled = false; 
            _isDisabled = true;
        }

        private void EnableControl()
        {
            _isDisabled = false;
            this.BackColor = Color.White;
            btnSelect.Enabled = true;
            btnView.Enabled = true;

            
        }
        public void LoadTeacherInfo(int teacherID)
        {

            _TeacherID = teacherID;

            _Teacher = clsTeacher.Find(teacherID);
            if (_Teacher == null)
            {
                DisableControl();
                return;
            }
            EnableControl();
            lbName.Text = _Teacher.person.FullName;
            lbTeacherID.Text = _TeacherID.ToString();

            pbTeacherGender.Image = _Teacher.person.Gender ? Resources.icons8_user_male_100 : Resources.icons8_female_user_100;


            if (!clsTeacher.isTeacherActive(teacherID))
            {
                DisableControl();
                return;
            }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (_TeacherID != -1)
            {
                frmTeacherDetails frm = new frmTeacherDetails(_TeacherID);
                frm.ShowDialog();
                
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to select this teacher ? ", "Confirm select",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OnTeacherSelected?.Invoke(this, new SelectedTeacherEventArgs(_TeacherID));
            }
        }
    }
}
