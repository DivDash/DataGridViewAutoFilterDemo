using DataGridViewAutoFilter;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataGridViewAutoFilterDemo.Views
{
    public partial class BasicDemoForm : Form
    {
        private List<Person> personList = new List<Person>();
        private Person personObject = new Person();

        public BasicDemoForm()
        {
            InitializeComponent();
        }
        private void BasicDemoForm_Load(object sender, EventArgs e)
        {
            // Invoke the method PopulateList using the person object 
            // Pass the personList as the parameter.
            personObject.PopulateList(personList);

            // Use morelinq ToDataTable extension for converting personList to DataTable.
            // Assign the converted Datatable to BindingSource's DataSource.
            personBindingSource.DataSource = personList.ToDataTable();

            //Finally assign personBindingSource to DataGridView's DataSource.
            dataGridView.DataSource = personBindingSource;

            //Allow data filtering 
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
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}