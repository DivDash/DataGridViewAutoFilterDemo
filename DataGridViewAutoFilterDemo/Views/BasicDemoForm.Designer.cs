namespace DataGridViewAutoFilterDemo.Views
{
    partial class BasicDemoForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.occupationColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.jobColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.salaryColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.rateColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dateTimeColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 404);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView_DataBindingComplete);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
            this.ShowAllLabel.ActiveLinkColor = System.Drawing.Color.Blue;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
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
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DataGridViewAutoFilterDemo.Person);
            // 
            // BasicDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BasicDemoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Demo Form";
            this.Load += new System.EventHandler(this.BasicDemoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rankColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn occupationColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn jobColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn salaryColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn rateColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dateTimeColumn;
    }
}