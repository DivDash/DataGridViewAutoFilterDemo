using DataGridViewAutoFilter;
using MetroFramework.Forms;
using MoreLinq;
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

            /// Use morelinq ToDataTable extension to convert personList to DataTable
            /// Assign the converted Datatable to BindingSource's DataSource  
            /// Finally assign this DataSource to DataGridView's DataSource

            personBindingSource.DataSource = personList.ToDataTable();

            dataGridView1.DataSource = personBindingSource;

            //Allow data filtering 
            EnableGridFilter(true);
        }
        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(metroGrid1);
        }
        private void MetroGrid1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(metroGrid1);
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
        private void MetroGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control
                && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                && dataGridView1.CurrentCell != null
                && dataGridView1.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }
        private void EnableGridFilter(bool value)
        {
            //DataGridView Columns
            rankDataGridViewColumn.FilteringEnabled = value;
            occupationDataGridViewColumn.FilteringEnabled = value;
            jobDataGridViewColumn.FilteringEnabled = value;
            salaryDataGridViewColumn.FilteringEnabled = value;
            rateDataGridViewColumn.FilteringEnabled = value;
            dateTimeDataGridViewColumn.FilteringEnabled = value;

            //MetroGridView Columns
            rankColumn.FilteringEnabled = value;
            occupationColumn.FilteringEnabled = value;
            jobColumn.FilteringEnabled = value;
            salaryColumn.FilteringEnabled = value;
            rateColumn.FilteringEnabled = value;
            dateTimeColumn.FilteringEnabled = value;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}