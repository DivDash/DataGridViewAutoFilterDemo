namespace DataGridViewAutoFilterDemo.Views
{
    partial class MetroDemoForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rankDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeDataGridViewColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.rankColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.aboutButton = new MetroFramework.Controls.MetroButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(20, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 3;
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
            this.ShowAllLabel.LinkColor = System.Drawing.Color.White;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(55, 17);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Visible = false;
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankDataGridViewColumn,
            this.occupationDataGridViewColumn,
            this.jobDataGridViewColumn,
            this.salaryDataGridViewColumn,
            this.rateDataGridViewColumn,
            this.dateTimeDataGridViewColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 294);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MetroGrid1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetroGrid1_KeyDown);
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
            this.jobDataGridViewColumn.HeaderText = "Jobs";
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankColumn,
            this.occupationColumn,
            this.jobColumn,
            this.salaryColumn,
            this.rateColumn,
            this.dateTimeColumn});
            this.metroGrid1.DataSource = this.personBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(884, 279);
            this.metroGrid1.TabIndex = 5;
            this.metroGrid1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MetroGrid1_DataBindingComplete);
            this.metroGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetroGrid1_KeyDown);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(884, 577);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 7;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(23, 27);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 8;
            this.aboutButton.Text = "ABOUT";
            this.aboutButton.UseSelectable = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MetroDemoForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 679);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MetroDemoForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Metro Demo Form";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton aboutButton;
        private System.Windows.Forms.BindingSource personBindingSource;
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
    }
}

