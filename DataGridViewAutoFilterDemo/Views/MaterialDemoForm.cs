using DataGridViewAutoFilter;
using MaterialSkin;
using MaterialSkin.Controls;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace DataGridViewAutoFilterDemo.Views
{
    public partial class MaterialDemoForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private List<Person> personList = new List<Person>();
        private Person personObject = new Person();

        public MaterialDemoForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }
        private void MaterialDemoForm_Load(object sender, EventArgs e)
        {
            personObject.PopulateList(personList);

            // Use morelinq ToDataTable extension for converting personList to DataTable.
            // Assign the converted Datatable to BindingSource's DataSource.
            personBindingSource.DataSource = personList.ToDataTable();

            // Finally assign personBindingSource to the Grid's DataSource.
            dataGridView.DataSource = personBindingSource;
            metroGrid.DataSource = personBindingSource;

            //Allow data filtering 
            EnableGridFilter(true);

            Assembly assembly = Assembly.GetExecutingAssembly();
            VersionLabel.Text = "Version " + FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
        }
        /// <summary>
        /// Enable filtering on grid columns by setting the value to true.
        /// It's false by default.
        /// </summary>
        /// <param name="value"></param>
        private void EnableGridFilter(bool value)
        {
            //DataGridView Columns
            rankDataGridViewColumn.FilteringEnabled = value;
            occupationDataGridViewColumn.FilteringEnabled = value;
            jobDataGridViewColumn.FilteringEnabled = value;
            salaryDataGridViewColumn.FilteringEnabled = value;
            rateDataGridViewColumn.FilteringEnabled = value;
            dateTimeDataGridViewColumn.FilteringEnabled = value;

            //MetroGrid Columns
            rankColumn.FilteringEnabled = value;
            occupationColumn.FilteringEnabled = value;
            jobColumn.FilteringEnabled = value;
            salaryColumn.FilteringEnabled = value;
            rateColumn.FilteringEnabled = value;
            dateTimeColumn.FilteringEnabled = value;
        }
        private void LinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://telicsolutions.com/");
        }
        private void LinkLabel_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void LinkLabel_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #region DataGridView Methods
        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView);
        }
        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView);
            if (string.IsNullOrEmpty(filterStatus))
            {
                ShowAllLabel.Visible = false;
                FilterStatusLabel.Visible = false;
            }
            else
            {
                ShowAllLabel.Visible = true;
                FilterStatusLabel.Visible = true;
                FilterStatusLabel.Text = filterStatus;
            }
        }
        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
            && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            && dataGridView.CurrentCell != null
            && dataGridView.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }
        #endregion

        #region MetroGrid Methods 
        private void MetroShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(metroGrid);
        }
        private void MetroGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(metroGrid);
            if (string.IsNullOrEmpty(filterStatus))
            {
                MetroShowAllLabel.Visible = false;
                MetroFilterStatusLabel.Visible = false;
            }
            else
            {
                MetroShowAllLabel.Visible = true;
                MetroFilterStatusLabel.Visible = true;
                MetroFilterStatusLabel.Text = filterStatus;
            }
        }
        private void MetroGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
                    && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    && metroGrid.CurrentCell != null
                    && metroGrid.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }
        #endregion

    }
}