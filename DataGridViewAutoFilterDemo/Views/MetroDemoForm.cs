using DataGridViewAutoFilter;
using MoreLinq;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataGridViewAutoFilterDemo.Views
{
    public partial class MetroDemoForm : MetroForm
    {
        private List<Person> personList = new List<Person>();
        private Person personObject = new Person();

        public MetroDemoForm()
        {
            InitializeComponent();
        }
        private void MyForm_Load(object sender, EventArgs e)
        {
            personObject.PopulateList(personList);

            // Use morelinq ToDataTable extension for converting personList to DataTable.
            // Assign the converted Datatable to BindingSource's DataSource.
            personBindingSource.DataSource = personList.ToDataTable();

            // Finally assign personBindingSource to MetroGrid's DataSource.
            metroGrid.DataSource = personBindingSource;

            // Allow data filtering 
            EnableGridFilter(true);
        }
        /// <summary>
        /// Enable filtering on grid columns by setting the value to true.
        /// It's false by default.
        /// </summary>
        /// <param name="value"></param>
        private void EnableGridFilter(bool value)
        {
            rankColumn.FilteringEnabled = value;
            occupationColumn.FilteringEnabled = value;
            jobColumn.FilteringEnabled = value;
            salaryColumn.FilteringEnabled = value;
            rateColumn.FilteringEnabled = value;
            dateTimeColumn.FilteringEnabled = value;
        }
        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(metroGrid);
        }
        private void MetroGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(metroGrid);
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
        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new MetroAboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}