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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDemoForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.IconHider = new MaterialSkin.Controls.MaterialSwitch();
            this.BackgroundAccent = new MaterialSkin.Controls.MaterialSwitch();
            this.HighlightAccent = new MaterialSkin.Controls.MaterialSwitch();
            this.ThemeChangerButton = new MaterialSkin.Controls.MaterialButton();
            this.UseColor = new MaterialSkin.Controls.MaterialSwitch();
            this.ChangeColorButton = new MaterialSkin.Controls.MaterialButton();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.LinkLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.rankColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage10);
            this.materialTabControl1.Controls.Add(this.tabPage11);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1023, 555);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.ImageKey = "credit_card.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataGridView";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
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
            this.rankColumn,
            this.occupationColumn,
            this.jobColumn,
            this.salaryColumn,
            this.rateColumn,
            this.dateTimeColumn});
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
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialLabel39);
            this.tabPage4.Controls.Add(this.materialLabel28);
            this.tabPage4.Controls.Add(this.materialListView1);
            this.tabPage4.ImageKey = "journal_edit.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1015, 518);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MetroGrid";
            // 
            // materialLabel39
            // 
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel39.Location = new System.Drawing.Point(22, 76);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(647, 70);
            this.materialLabel39.TabIndex = 64;
            this.materialLabel39.Text = "This control could be better, but it\'s good enough for now - PRs are welcome! :)\r" +
    "\nRecommended: AutoSizeTable = true;\r\nand then configure with Maximum/Minimum Siz" +
    "e\r\n";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel28.Location = new System.Drawing.Point(28, 18);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(120, 58);
            this.materialLabel28.TabIndex = 63;
            this.materialLabel28.Text = "Table";
            // 
            // materialListView1
            // 
            this.materialListView1.AllowColumnReorder = true;
            this.materialListView1.AutoSizeTable = true;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(25, 149);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Scrollable = false;
            this.materialListView1.Size = new System.Drawing.Size(547, 100);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.IconHider);
            this.tabPage10.Controls.Add(this.BackgroundAccent);
            this.tabPage10.Controls.Add(this.HighlightAccent);
            this.tabPage10.Controls.Add(this.ThemeChangerButton);
            this.tabPage10.Controls.Add(this.UseColor);
            this.tabPage10.Controls.Add(this.ChangeColorButton);
            this.tabPage10.ImageKey = "settings.png";
            this.tabPage10.Location = new System.Drawing.Point(4, 33);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1015, 518);
            this.tabPage10.TabIndex = 7;
            this.tabPage10.Text = "Settings";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // IconHider
            // 
            this.IconHider.AutoSize = true;
            this.IconHider.BackColor = System.Drawing.Color.White;
            this.IconHider.Checked = true;
            this.IconHider.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IconHider.Depth = 0;
            this.IconHider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IconHider.Location = new System.Drawing.Point(46, 289);
            this.IconHider.Margin = new System.Windows.Forms.Padding(0);
            this.IconHider.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IconHider.MouseState = MaterialSkin.MouseState.HOVER;
            this.IconHider.Name = "IconHider";
            this.IconHider.Ripple = true;
            this.IconHider.Size = new System.Drawing.Size(309, 37);
            this.IconHider.TabIndex = 49;
            this.IconHider.Text = "Drawer - Display Icons when hidden";
            this.IconHider.UseVisualStyleBackColor = false;
            // 
            // BackgroundAccent
            // 
            this.BackgroundAccent.AutoSize = true;
            this.BackgroundAccent.BackColor = System.Drawing.Color.White;
            this.BackgroundAccent.Depth = 0;
            this.BackgroundAccent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BackgroundAccent.Location = new System.Drawing.Point(46, 252);
            this.BackgroundAccent.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundAccent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BackgroundAccent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackgroundAccent.Name = "BackgroundAccent";
            this.BackgroundAccent.Ripple = true;
            this.BackgroundAccent.Size = new System.Drawing.Size(291, 37);
            this.BackgroundAccent.TabIndex = 48;
            this.BackgroundAccent.Text = "Drawer - Background with Accent";
            this.BackgroundAccent.UseVisualStyleBackColor = false;
            // 
            // HighlightAccent
            // 
            this.HighlightAccent.AutoSize = true;
            this.HighlightAccent.BackColor = System.Drawing.Color.White;
            this.HighlightAccent.Checked = true;
            this.HighlightAccent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighlightAccent.Depth = 0;
            this.HighlightAccent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HighlightAccent.Location = new System.Drawing.Point(46, 216);
            this.HighlightAccent.Margin = new System.Windows.Forms.Padding(0);
            this.HighlightAccent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HighlightAccent.MouseState = MaterialSkin.MouseState.HOVER;
            this.HighlightAccent.Name = "HighlightAccent";
            this.HighlightAccent.Ripple = true;
            this.HighlightAccent.Size = new System.Drawing.Size(270, 37);
            this.HighlightAccent.TabIndex = 47;
            this.HighlightAccent.Text = "Drawer - Highlight with Accent";
            this.HighlightAccent.UseVisualStyleBackColor = false;
            // 
            // ThemeChangerButton
            // 
            this.ThemeChangerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThemeChangerButton.BackColor = System.Drawing.Color.White;
            this.ThemeChangerButton.Depth = 0;
            this.ThemeChangerButton.DrawShadows = true;
            this.ThemeChangerButton.HighEmphasis = true;
            this.ThemeChangerButton.Icon = null;
            this.ThemeChangerButton.Location = new System.Drawing.Point(204, 122);
            this.ThemeChangerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ThemeChangerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeChangerButton.Name = "ThemeChangerButton";
            this.ThemeChangerButton.Size = new System.Drawing.Size(133, 36);
            this.ThemeChangerButton.TabIndex = 44;
            this.ThemeChangerButton.Text = "Change Theme";
            this.ThemeChangerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ThemeChangerButton.UseAccentColor = false;
            this.ThemeChangerButton.UseVisualStyleBackColor = false;
            // 
            // UseColor
            // 
            this.UseColor.AutoSize = true;
            this.UseColor.BackColor = System.Drawing.Color.White;
            this.UseColor.Depth = 0;
            this.UseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UseColor.Location = new System.Drawing.Point(46, 179);
            this.UseColor.Margin = new System.Windows.Forms.Padding(0);
            this.UseColor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UseColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.UseColor.Name = "UseColor";
            this.UseColor.Ripple = true;
            this.UseColor.Size = new System.Drawing.Size(193, 37);
            this.UseColor.TabIndex = 46;
            this.UseColor.Text = "Drawer - Use colors";
            this.UseColor.UseVisualStyleBackColor = false;
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeColorButton.BackColor = System.Drawing.Color.White;
            this.ChangeColorButton.Depth = 0;
            this.ChangeColorButton.DrawShadows = true;
            this.ChangeColorButton.HighEmphasis = true;
            this.ChangeColorButton.Icon = null;
            this.ChangeColorButton.Location = new System.Drawing.Point(46, 122);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeColorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(140, 36);
            this.ChangeColorButton.TabIndex = 45;
            this.ChangeColorButton.Text = "Change Colors";
            this.ChangeColorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeColorButton.UseAccentColor = false;
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.pictureBox1);
            this.tabPage11.Controls.Add(this.materialLabel12);
            this.tabPage11.Controls.Add(this.LinkLabel);
            this.tabPage11.Controls.Add(this.pictureBox2);
            this.tabPage11.Controls.Add(this.materialLabel7);
            this.tabPage11.Controls.Add(this.materialLabel11);
            this.tabPage11.ImageKey = "about.png";
            this.tabPage11.Location = new System.Drawing.Point(4, 33);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1015, 518);
            this.tabPage11.TabIndex = 8;
            this.tabPage11.Text = "About";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(8, 368);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(356, 24);
            this.materialLabel12.TabIndex = 13;
            this.materialLabel12.Text = "DEVELOPED BY : ZUJAJ MISBAH KHAN";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Depth = 0;
            this.LinkLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LinkLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LinkLabel.Location = new System.Drawing.Point(800, 305);
            this.LinkLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(98, 17);
            this.LinkLabel.TabIndex = 12;
            this.LinkLabel.Text = "A PRODUCT OF";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(758, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(178, 244);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(652, 29);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "A form that demonstrates the use of DataGridView AutoFilter";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel11.Location = new System.Drawing.Point(234, 167);
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
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "about.png");
            this.menuIconList.Images.SetKeyName(10, "attribute.png");
            this.menuIconList.Images.SetKeyName(11, "backup.png");
            this.menuIconList.Images.SetKeyName(12, "credit_card.png");
            this.menuIconList.Images.SetKeyName(13, "dashboard.png");
            this.menuIconList.Images.SetKeyName(14, "journal_edit.png");
            this.menuIconList.Images.SetKeyName(15, "logout_rounded_up.png");
            this.menuIconList.Images.SetKeyName(16, "money.png");
            this.menuIconList.Images.SetKeyName(17, "report.png");
            this.menuIconList.Images.SetKeyName(18, "settings.png");
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
            this.jobColumn.HeaderText = "Job";
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
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DataGridViewAutoFilterDemo.Person);
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
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private TabPage tabPage4;
        private ImageList menuIconList;
        private MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialLabel materialLabel28;
        private MaterialLabel materialLabel39;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private MaterialSwitch IconHider;
        private MaterialSwitch BackgroundAccent;
        private MaterialSwitch HighlightAccent;
        private MaterialButton ThemeChangerButton;
        private MaterialSwitch UseColor;
        private MaterialButton ChangeColorButton;
        private MaterialLabel materialLabel12;
        private MaterialLabel LinkLabel;
        private PictureBox pictureBox2;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel11;
        private DataGridView dataGridView;
        private BindingSource personBindingSource;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rankColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn occupationColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn jobColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn salaryColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rateColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dateTimeColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel FilterStatusLabel;
        private ToolStripStatusLabel ShowAllLabel;
        private PictureBox pictureBox1;
    }
}