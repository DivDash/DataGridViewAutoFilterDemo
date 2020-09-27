using DataGridViewAutoFilter;
using MaterialSkin;
using MaterialSkin.Controls;
using MoreLinq;
using System;
using System.Collections.Generic;
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

            // Add dummy data to the listview
            seedListView();
        }
        private void EnableGridFilter(bool value)
        {
            rankColumn.FilteringEnabled = value;
            occupationColumn.FilteringEnabled = value;
            jobColumn.FilteringEnabled = value;
            salaryColumn.FilteringEnabled = value;
            rateColumn.FilteringEnabled = value;
            dateTimeColumn.FilteringEnabled = value;
        }
        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            updateColor();
        }

        private int colorSchemeIndex;

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 17)
                colorSchemeIndex = 0;
            updateColor();
        }

        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Red600,
                        Primary.Red700,
                        Primary.Red200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                     Primary.Orange800,
                     Primary.Orange900,
                     Primary.Orange500,
                     Accent.Orange200,
                     TextShade.WHITE);

                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepOrange800,
                        Primary.DeepOrange900,
                        Primary.DeepOrange500,
                        Accent.DeepOrange200,
                        TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Yellow800,
                        Primary.Yellow900,
                        Primary.Yellow500,
                        Accent.Yellow200,
                        TextShade.WHITE);
                    break;
                case 5:
                    materialSkinManager.ColorScheme = new ColorScheme(
                          Primary.LightGreen600,
                          Primary.LightGreen700,
                          Primary.LightGreen200,
                          Accent.LightGreen100,
                          TextShade.WHITE);
                    break;
                case 6:
                    materialSkinManager.ColorScheme = new ColorScheme(
                          Primary.Green600,
                          Primary.Green700,
                          Primary.Green200,
                          Accent.Green100,
                          TextShade.WHITE);
                    break;
                case 7:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 8:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Blue800,
                        Primary.Blue900,
                        Primary.Blue500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 9:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.LightBlue800,
                        Primary.LightBlue900,
                        Primary.LightBlue500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 10:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Indigo800,
                        Primary.Indigo900,
                        Primary.Indigo500,
                        Accent.Indigo200,
                        TextShade.WHITE);
                    break;
                case 11:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Purple800,
                        Primary.Purple900,
                        Primary.Purple500,
                        Accent.Purple200,
                        TextShade.WHITE);
                    break;
                case 12:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepPurple800,
                        Primary.DeepPurple900,
                        Primary.DeepPurple500,
                        Accent.DeepPurple200,
                        TextShade.WHITE);
                    break;
                case 13:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Brown800,
                        Primary.Brown900,
                        Primary.Brown500,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;
                case 14:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Lime800,
                        Primary.Lime900,
                        Primary.Lime500,
                        Accent.Lime200,
                        TextShade.WHITE);
                    break;
                case 15:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Teal800,
                        Primary.Teal900,
                        Primary.Teal500,
                        Accent.Teal200,
                        TextShade.WHITE);
                    break;
                case 16:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Amber800,
                        Primary.Amber900,
                        Primary.Amber500,
                        Accent.Amber200,
                        TextShade.WHITE);
                    break;
                case 17:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Cyan800,
                        Primary.Cyan900,
                        Primary.Cyan500,
                        Accent.Cyan200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }
        private void DemoForm_Load(object sender, EventArgs e)
        {
            personObject.PopulateList(personList);

            /// Use morelinq ToDataTable extension to convert personList to DataTable
            /// Assign the converted Datatable to BindingSource's DataSource  
            /// Finally assign this DataSource to DataGridView's DataSource

            personBindingSource.DataSource = personList.ToDataTable();

            dataGridView.DataSource = personBindingSource;

            //Allow data filtering 
            EnableGridFilter(true);
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
    }
}