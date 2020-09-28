using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DataGridViewAutoFilterDemo.Views
{
    partial class MaterialDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDemoForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.MetroFilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MetroShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VersionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LinkLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.rankDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1023, 555);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.ImageKey = "journal_edit.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 518);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "DataGridView";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.FilterStatusLabel.Visible = false;
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowAllLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.LinkColor = System.Drawing.Color.Black;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(55, 17);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Visible = false;
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankDataGridViewColumn,
            this.occupationDataGridViewColumn,
            this.jobDataGridViewColumn,
            this.salaryDataGridViewColumn,
            this.rateDataGridViewColumn,
            this.dateTimeDataGridViewColumn});
            this.dataGridView.DataSource = this.personBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1009, 512);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView_DataBindingComplete);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.metroGrid);
            this.tabPage2.ImageKey = "report.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 518);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "MetroGrid";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MetroFilterStatusLabel,
            this.MetroShowAllLabel});
            this.statusStrip2.Location = new System.Drawing.Point(3, 493);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // MetroFilterStatusLabel
            // 
            this.MetroFilterStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MetroFilterStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroFilterStatusLabel.LinkColor = System.Drawing.Color.Black;
            this.MetroFilterStatusLabel.Name = "MetroFilterStatusLabel";
            this.MetroFilterStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.MetroFilterStatusLabel.Visible = false;
            // 
            // MetroShowAllLabel
            // 
            this.MetroShowAllLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MetroShowAllLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroShowAllLabel.IsLink = true;
            this.MetroShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MetroShowAllLabel.LinkColor = System.Drawing.Color.Black;
            this.MetroShowAllLabel.Name = "MetroShowAllLabel";
            this.MetroShowAllLabel.Size = new System.Drawing.Size(55, 17);
            this.MetroShowAllLabel.Text = "Show &All";
            this.MetroShowAllLabel.Visible = false;
            this.MetroShowAllLabel.Click += new System.EventHandler(this.MetroShowAllLabel_Click);
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankColumn,
            this.occupationColumn,
            this.jobColumn,
            this.salaryColumn,
            this.rateColumn,
            this.dateTimeColumn});
            this.metroGrid.DataSource = this.personBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(3, 3);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(1009, 512);
            this.metroGrid.TabIndex = 6;
            this.metroGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MetroGrid_DataBindingComplete);
            this.metroGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetroGrid_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.ImageKey = "about.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1015, 518);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.VersionLabel);
            this.panel1.Controls.Add(this.LinkLabel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 512);
            this.panel1.TabIndex = 19;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.White;
            this.VersionLabel.Depth = 0;
            this.VersionLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.VersionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.VersionLabel.Location = new System.Drawing.Point(788, 209);
            this.VersionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(69, 24);
            this.VersionLabel.TabIndex = 18;
            this.VersionLabel.Text = "Version";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Depth = 0;
            this.LinkLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LinkLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LinkLabel.Location = new System.Drawing.Point(786, 357);
            this.LinkLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(98, 17);
            this.LinkLabel.TabIndex = 17;
            this.LinkLabel.Text = "A PRODUCT OF";
            this.LinkLabel.Click += new System.EventHandler(this.LinkLabel_Click);
            this.LinkLabel.MouseEnter += new System.EventHandler(this.LinkLabel_MouseEnter);
            this.LinkLabel.MouseLeave += new System.EventHandler(this.LinkLabel_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DataGridViewAutoFilterDemo.Properties.Resources.TS;
            this.pictureBox3.Location = new System.Drawing.Point(749, 376);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataGridViewAutoFilterDemo.Properties.Resources.DataGridViewAutoFilter;
            this.pictureBox1.Location = new System.Drawing.Point(400, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(9, 405);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(336, 41);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "ZUJAJ MISBAH KHAN";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel12.Location = new System.Drawing.Point(91, 376);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(114, 19);
            this.materialLabel12.TabIndex = 13;
            this.materialLabel12.Text = "DEVELOPED BY";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(178, 275);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(643, 29);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "A tool that demonstrates the use of DataGridView AutoFilter";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel11.Location = new System.Drawing.Point(232, 165);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(545, 41);
            this.materialLabel11.TabIndex = 9;
            this.materialLabel11.Text = "DATAGRIDVIEW AUTOFILTER DEMO";
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "about.png");
            this.menuIconList.Images.SetKeyName(1, "journal_edit.png");
            this.menuIconList.Images.SetKeyName(2, "report.png");
            this.menuIconList.Images.SetKeyName(3, "settings.png");
            // 
            // rankDataGridViewColumn
            // 
            this.rankDataGridViewColumn.DataPropertyName = "Rank";
            this.rankDataGridViewColumn.FilteringEnabled = false;
            this.rankDataGridViewColumn.HeaderText = "Rank";
            this.rankDataGridViewColumn.Name = "rankDataGridViewColumn";
            this.rankDataGridViewColumn.ReadOnly = true;
            this.rankDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // occupationDataGridViewColumn
            // 
            this.occupationDataGridViewColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewColumn.FilteringEnabled = false;
            this.occupationDataGridViewColumn.HeaderText = "Occupation";
            this.occupationDataGridViewColumn.Name = "occupationDataGridViewColumn";
            this.occupationDataGridViewColumn.ReadOnly = true;
            this.occupationDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // jobDataGridViewColumn
            // 
            this.jobDataGridViewColumn.DataPropertyName = "Jobs";
            this.jobDataGridViewColumn.FilteringEnabled = false;
            this.jobDataGridViewColumn.HeaderText = "Job";
            this.jobDataGridViewColumn.Name = "jobDataGridViewColumn";
            this.jobDataGridViewColumn.ReadOnly = true;
            this.jobDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // salaryDataGridViewColumn
            // 
            this.salaryDataGridViewColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewColumn.FilteringEnabled = false;
            this.salaryDataGridViewColumn.HeaderText = "Salary";
            this.salaryDataGridViewColumn.Name = "salaryDataGridViewColumn";
            this.salaryDataGridViewColumn.ReadOnly = true;
            this.salaryDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rateDataGridViewColumn
            // 
            this.rateDataGridViewColumn.DataPropertyName = "Rate";
            this.rateDataGridViewColumn.FilteringEnabled = false;
            this.rateDataGridViewColumn.HeaderText = "Rate";
            this.rateDataGridViewColumn.Name = "rateDataGridViewColumn";
            this.rateDataGridViewColumn.ReadOnly = true;
            this.rateDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateTimeDataGridViewColumn
            // 
            this.dateTimeDataGridViewColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewColumn.FilteringEnabled = false;
            this.dateTimeDataGridViewColumn.HeaderText = "Date";
            this.dateTimeDataGridViewColumn.Name = "dateTimeDataGridViewColumn";
            this.dateTimeDataGridViewColumn.ReadOnly = true;
            this.dateTimeDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DataGridViewAutoFilterDemo.Person);
            // 
            // rankColumn
            // 
            this.rankColumn.DataPropertyName = "Rank";
            this.rankColumn.FilteringEnabled = false;
            this.rankColumn.HeaderText = "Rank";
            this.rankColumn.Name = "rankColumn";
            this.rankColumn.ReadOnly = true;
            this.rankColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // occupationColumn
            // 
            this.occupationColumn.DataPropertyName = "Occupation";
            this.occupationColumn.FilteringEnabled = false;
            this.occupationColumn.HeaderText = "Occupation";
            this.occupationColumn.Name = "occupationColumn";
            this.occupationColumn.ReadOnly = true;
            this.occupationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // jobColumn
            // 
            this.jobColumn.DataPropertyName = "Jobs";
            this.jobColumn.FilteringEnabled = false;
            this.jobColumn.HeaderText = "Jobs";
            this.jobColumn.Name = "jobColumn";
            this.jobColumn.ReadOnly = true;
            this.jobColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // salaryColumn
            // 
            this.salaryColumn.DataPropertyName = "Salary";
            this.salaryColumn.FilteringEnabled = false;
            this.salaryColumn.HeaderText = "Salary";
            this.salaryColumn.Name = "salaryColumn";
            this.salaryColumn.ReadOnly = true;
            this.salaryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rateColumn
            // 
            this.rateColumn.DataPropertyName = "Rate";
            this.rateColumn.FilteringEnabled = false;
            this.rateColumn.HeaderText = "Rate";
            this.rateColumn.Name = "rateColumn";
            this.rateColumn.ReadOnly = true;
            this.rateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateTimeColumn
            // 
            this.dateTimeColumn.DataPropertyName = "DateTime";
            this.dateTimeColumn.FilteringEnabled = false;
            this.dateTimeColumn.HeaderText = "Date";
            this.dateTimeColumn.Name = "dateTimeColumn";
            this.dateTimeColumn.ReadOnly = true;
            this.dateTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaterialDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MaterialDemoForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Demo Form";
            this.Load += new System.EventHandler(this.MaterialDemoForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList menuIconList;
        private TabPage tabPage3;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel11;
        private DataGridView dataGridView;
        private BindingSource personBindingSource;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel FilterStatusLabel;
        private ToolStripStatusLabel ShowAllLabel;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel MetroFilterStatusLabel;
        private ToolStripStatusLabel MetroShowAllLabel;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rankDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn occupationDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn jobDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn salaryDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rateDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dateTimeDataGridViewColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rankColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn occupationColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn jobColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn salaryColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rateColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dateTimeColumn;
        private MaterialLabel materialLabel2;
        private MaterialLabel LinkLabel;
        private PictureBox pictureBox3;
        private MaterialLabel VersionLabel;
        private Panel panel1;
    }
}