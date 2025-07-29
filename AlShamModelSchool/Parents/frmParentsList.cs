using AlShamModelSchool.Students.UserControls;
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

namespace AlShamModelSchool.Parents
{
    public partial class frmParentsList : Form
    {

        private static  DataTable _dtAllParents = clsParents.GetAllParents();
        private DataTable _dtParents = _dtAllParents.DefaultView.ToTable();
        public enum enMode { Read, Select }
        private enMode _Mode { get; set; } = enMode.Read;

        public delegate void DataBackEventHandler(int ParentsID);

        public event DataBackEventHandler DataBack;

        public frmParentsList(enMode Mode)
        {
            InitializeComponent();
            this._Mode = Mode;
        }

        private void frmParentsList_Load(object sender, EventArgs e)
        {
            LoadParents();
        }



        private void LoadParents()
        {
            _dtParents = _dtAllParents;
             dgvParents.DataSource = _dtParents;


            if (dgvParents.Rows.Count  > 0)
            {
                dgvParents.Columns[0].HeaderText = "Parents ID";
                dgvParents.Columns[0].Width = 100;

                dgvParents.Columns[1].HeaderText = "Father ID";
                dgvParents.Columns[1].Width = 100;

                dgvParents.Columns[2].HeaderText = "Father Name";
 


                dgvParents.Columns[3].HeaderText = "Fathe National ID";
                

                dgvParents.Columns[4].HeaderText = "MotherID";
                dgvParents.Columns[4].Width = 100;

                dgvParents.Columns[5].HeaderText = "Mother Name";
       

                dgvParents.Columns[6].HeaderText = "Mother National ID";
    

                
            }


        }
        private void _RefreshParentsList()
        {
            _dtAllParents = clsParents.GetAllParents();
            _dtParents = _dtAllParents.DefaultView.ToTable(false);
        
            cbFilterItems.SelectedIndex = 0;
             
            lblRecordsCount.Text = dgvParents.RowCount.ToString();
        }

        private void DisableAllFilters()
        {
            tbFatherFilterString.Text = "";
            tbMotherFilterString.Text = "";
            tbFatherFilterString.Enabled = false;
            tbMotherFilterString.Enabled = false;

            cbMotherFilter.Enabled = false;
            cbFatherFilter.Enabled = false;
        }
        private void EnabledAllFilters()
        {
            DisableAllFilters();
            tbFatherFilterString.Enabled = true;
            tbMotherFilterString.Enabled = true;

            cbMotherFilter.Enabled = true;
            cbFatherFilter.Enabled = true;
        }
        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterItems.Text;

      


            switch (FilterColumn)
            {
                

                case "Father":
                    DisableAllFilters();
                    tbFatherFilterString.Enabled = true;
                    cbFatherFilter.Enabled = true;
                    break;

                case "Mother":
                    DisableAllFilters();
                    tbMotherFilterString.Enabled = true;
                    cbMotherFilter.Enabled = true;
                    break;
                case "Father & Mother":
                    EnabledAllFilters();
                    cbFatherFilter.SelectedIndex = 2;
                    cbMotherFilter.SelectedIndex = 2;
                    break;


                default:
                    DisableAllFilters();
                    _RefreshParentsList();
                    break;
            }


        }

   
         
        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string value = "";
            //Map Selected Filter to real Column name 

            if (cbFilterItems.Text == "Father & Mother")
            {
                FilterByFatherAndMother(); 
                return;
            }


            if (cbMotherFilter.Enabled)
            {
                value = tbMotherFilterString.Text;
                switch (cbMotherFilter.Text)
                {
                    case "Mother ID":
                        FilterColumn = "MotherID";
                        break;

                    case "Mother NationalID":
                        FilterColumn = "MotherNationalID";
                        break;

                    case "Mother Name":
                        FilterColumn = "MotherName";
                        break; 

                    default:
                        FilterColumn = "None";
                        break;

                }
            } else
            {
                value = tbFatherFilterString.Text;
                switch (cbFatherFilter.Text)
                {
                    case "Father ID":
                        FilterColumn = "FatherID";
                        break;
                    case "Father NationalID":
                        FilterColumn = "FatheNationalID";
                        break;
                    case "Father Name":
                        FilterColumn = "FatherName";
                        break;
                    default:
                        FilterColumn = "None";
                        break;
                }
            } 




            //Reset the filters in case nothing selected or filter value conains nothing.
            if (value == "" || FilterColumn == "None")
            {
                _dtParents.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvParents.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "MotherID"  || FilterColumn == "FatherID")
                //in this case we deal with integer not string.

                _dtParents.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, value);
            else
                _dtParents.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, value);

            lblRecordsCount.Text = dgvParents.Rows.Count.ToString();
        }

        private void cFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Guna2ComboBox)sender).Text == "None")
            {
                tbFatherFilterString.Text = "";
                tbMotherFilterString.Text = "";
                tbFilterString_TextChanged(null, null);
            }
        }

        private string CustomizeFilter(string FilterColumn, string FilterValue)
        {
            if (FilterColumn == "MotherID" || FilterColumn == "FatherID")
                return string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            else
                return string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
        }

        private void FilterByFatherAndMother()
        {
            string MotherFilterColumn = "";
            string FatherFilterColumn = "";

            string MotherFilterValue = "";
            string FatherFilterValue = "";

            //Map Selected Filter to real Column name 

            MotherFilterValue = tbMotherFilterString.Text;
            switch (cbMotherFilter.Text)
            {
                case "Mother ID":
                    MotherFilterColumn = "MotherID";
                    break;

                case "Mother NationalID":
                    MotherFilterColumn = "MotherNationalID";
                    break;

                case "Mother Name":
                    MotherFilterColumn = "MotherName";
                    break;

                default:
                    MotherFilterColumn = "None";
                    break;

            }


            FatherFilterValue = tbFatherFilterString.Text;
            switch (cbFatherFilter.Text)
            {
                case "Father ID":
                    FatherFilterColumn = "FatherID";
                    break;
                case "Father NationalID":
                    FatherFilterColumn = "FatheNationalID";
                    break;
                case "Father Name":
                    FatherFilterColumn = "FatherName";
                    break;
                default:
                    FatherFilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (MotherFilterValue == "" || FatherFilterValue == "" || MotherFilterColumn == "None" || FatherFilterColumn == "None")
            {
                _dtParents.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvParents.Rows.Count.ToString();
                return;
            }


            if (MotherFilterColumn == "MotherID" || MotherFilterColumn == "FatherID")
                //in this case we deal with integer not string.

                 
                _dtParents.DefaultView.RowFilter = $"[{MotherFilterColumn}] = {MotherFilterValue} and [{FatherFilterColumn}] = {FatherFilterValue}";
            else
            {

                string MotherFilter = CustomizeFilter(MotherFilterColumn, MotherFilterValue);
                string FatherFilter = CustomizeFilter(FatherFilterColumn, FatherFilterValue);

                 _dtParents.DefaultView.RowFilter = $"{MotherFilter} And {FatherFilter}";
            }

            lblRecordsCount.Text = dgvParents.Rows.Count.ToString();
        }

         

        private void dgvParents_DoubleClick(object sender, EventArgs e)
        {
            int SelectedParents = Convert.ToInt32(dgvParents.SelectedRows[0].Cells[0].Value);
            

            if(_Mode == enMode.Select)
            {
                DataBack?.Invoke(SelectedParents);
                this.Close();
            } else
            {
                frmParentsDetails frm = new frmParentsDetails(SelectedParents);
                frm.ShowSelectButton = false;
                frm.ShowDialog();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void showParentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParentsDetails frm = new frmParentsDetails(Convert.ToInt32(dgvParents.SelectedRows[0].Cells[0].Value));
            frm.ShowSelectButton = false;
            frm.ShowDialog();
        }

        private void btnAddNewParents_Click(object sender, EventArgs e)
        {
            frmAddNewPerants frm = new frmAddNewPerants();
            frm.ShowDialog();
            _RefreshParentsList();
        }
    }
}
