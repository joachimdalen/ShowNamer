namespace ShowNamer {
    partial class ShowNamer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowNamer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSeason = new System.Windows.Forms.NumericUpDown();
            this.nudEpisodes = new System.Windows.Forms.NumericUpDown();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboSortBy = new System.Windows.Forms.ComboBox();
            this.BtnRenameFiles = new System.Windows.Forms.Button();
            this.CbIncEp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tsbClearGrid = new System.Windows.Forms.ToolStripButton();
            this.tbsOpenNewFolder = new System.Windows.Forms.ToolStripButton();
            this.tbsAddFromFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbEnableDragDrop = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveSelected = new System.Windows.Forms.ToolStripButton();
            this.tsbSkipSelected = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseTarget);
            this.groupBox1.Controls.Add(this.btnBrowseSource);
            this.groupBox1.Controls.Add(this.txtTargetPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSourcePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Enabled = false;
            this.txtTargetPath.Location = new System.Drawing.Point(9, 84);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(245, 20);
            this.txtTargetPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Enabled = false;
            this.txtSourcePath.Location = new System.Drawing.Point(9, 41);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(245, 20);
            this.txtSourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvFiles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1194, 480);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // lvFiles
            // 
            this.lvFiles.AllowDrop = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.Location = new System.Drawing.Point(3, 16);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(1188, 461);
            this.lvFiles.TabIndex = 3;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvFiles_DragDrop);
            this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LvFiles_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Source Filename";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Season";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Episode";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Target Filename";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "File Size";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Length";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Created At";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Skip";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Path";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 656);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46064F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53936F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1194, 164);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearGrid,
            this.tbsOpenNewFolder,
            this.tbsAddFromFolder,
            this.toolStripSeparator1,
            this.tsbEnableDragDrop,
            this.toolStripSeparator2,
            this.tsbRemoveSelected,
            this.tsbSkipSelected});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Show name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "File name format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Season";
            // 
            // txtShowName
            // 
            this.txtShowName.Location = new System.Drawing.Point(6, 37);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(248, 20);
            this.txtShowName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Episode Start";
            // 
            // nudSeason
            // 
            this.nudSeason.Location = new System.Drawing.Point(260, 37);
            this.nudSeason.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeason.Name = "nudSeason";
            this.nudSeason.Size = new System.Drawing.Size(120, 20);
            this.nudSeason.TabIndex = 2;
            this.nudSeason.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEpisodes
            // 
            this.nudEpisodes.Location = new System.Drawing.Point(386, 37);
            this.nudEpisodes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEpisodes.Name = "nudEpisodes";
            this.nudEpisodes.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodes.TabIndex = 2;
            this.nudEpisodes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(6, 127);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshList.TabIndex = 4;
            this.btnRefreshList.Text = "Refresh";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(6, 82);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(248, 20);
            this.txtFormat.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sort List By";
            // 
            // ComboSortBy
            // 
            this.ComboSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSortBy.FormattingEnabled = true;
            this.ComboSortBy.Items.AddRange(new object[] {
            "Source Name",
            "Season",
            "Episode",
            "File Size",
            "Length",
            "Created At"});
            this.ComboSortBy.Location = new System.Drawing.Point(300, 81);
            this.ComboSortBy.Name = "ComboSortBy";
            this.ComboSortBy.Size = new System.Drawing.Size(120, 21);
            this.ComboSortBy.TabIndex = 7;
            this.ComboSortBy.SelectedIndexChanged += new System.EventHandler(this.ComboSortBy_SelectedIndexChanged);
            // 
            // BtnRenameFiles
            // 
            this.BtnRenameFiles.Location = new System.Drawing.Point(87, 127);
            this.BtnRenameFiles.Name = "BtnRenameFiles";
            this.BtnRenameFiles.Size = new System.Drawing.Size(75, 23);
            this.BtnRenameFiles.TabIndex = 8;
            this.BtnRenameFiles.Text = "Rename";
            this.BtnRenameFiles.UseVisualStyleBackColor = true;
            this.BtnRenameFiles.Click += new System.EventHandler(this.BtnRenameFiles_Click);
            // 
            // CbIncEp
            // 
            this.CbIncEp.AutoSize = true;
            this.CbIncEp.Location = new System.Drawing.Point(512, 39);
            this.CbIncEp.Name = "CbIncEp";
            this.CbIncEp.Size = new System.Drawing.Size(107, 17);
            this.CbIncEp.TabIndex = 9;
            this.CbIncEp.Text = "Increase episode";
            this.CbIncEp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInfo);
            this.groupBox2.Controls.Add(this.CbIncEp);
            this.groupBox2.Controls.Add(this.BtnRenameFiles);
            this.groupBox2.Controls.Add(this.ComboSortBy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFormat);
            this.groupBox2.Controls.Add(this.btnRefreshList);
            this.groupBox2.Controls.Add(this.nudEpisodes);
            this.groupBox2.Controls.Add(this.nudSeason);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtShowName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(306, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Info";
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Image = global::ShowNamer.Properties.Resources.folder_search;
            this.btnBrowseTarget.Location = new System.Drawing.Point(260, 84);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(35, 23);
            this.btnBrowseTarget.TabIndex = 2;
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Image = global::ShowNamer.Properties.Resources.folder_search;
            this.btnBrowseSource.Location = new System.Drawing.Point(260, 41);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(35, 23);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.BtnBrowseSource_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::ShowNamer.Properties.Resources.information;
            this.btnInfo.Location = new System.Drawing.Point(259, 80);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(28, 23);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tsbClearGrid
            // 
            this.tsbClearGrid.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbClearGrid.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearGrid.Image")));
            this.tsbClearGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearGrid.Name = "tsbClearGrid";
            this.tsbClearGrid.Size = new System.Drawing.Size(79, 22);
            this.tsbClearGrid.Text = "Clear Grid";
            this.tsbClearGrid.Click += new System.EventHandler(this.tsbClearGrid_Click);
            // 
            // tbsOpenNewFolder
            // 
            this.tbsOpenNewFolder.Image = global::ShowNamer.Properties.Resources.folder_search;
            this.tbsOpenNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsOpenNewFolder.Name = "tbsOpenNewFolder";
            this.tbsOpenNewFolder.Size = new System.Drawing.Size(119, 22);
            this.tbsOpenNewFolder.Text = "Open New Folder";
            this.tbsOpenNewFolder.Click += new System.EventHandler(this.tbsOpenNewFolder_Click);
            // 
            // tbsAddFromFolder
            // 
            this.tbsAddFromFolder.Image = global::ShowNamer.Properties.Resources.folder_add;
            this.tbsAddFromFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAddFromFolder.Name = "tbsAddFromFolder";
            this.tbsAddFromFolder.Size = new System.Drawing.Size(116, 22);
            this.tbsAddFromFolder.Text = "Add From Folder";
            this.tbsAddFromFolder.Click += new System.EventHandler(this.tbsAddFromFolder_Click);
            // 
            // tsbEnableDragDrop
            // 
            this.tsbEnableDragDrop.CheckOnClick = true;
            this.tsbEnableDragDrop.Image = global::ShowNamer.Properties.Resources.cursor;
            this.tsbEnableDragDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnableDragDrop.Name = "tsbEnableDragDrop";
            this.tsbEnableDragDrop.Size = new System.Drawing.Size(132, 22);
            this.tsbEnableDragDrop.Text = "Enable Drag && Drop";
            this.tsbEnableDragDrop.CheckedChanged += new System.EventHandler(this.tsbEnableDragDrop_CheckedChanged);
            // 
            // tsbRemoveSelected
            // 
            this.tsbRemoveSelected.Image = global::ShowNamer.Properties.Resources.bin_closed;
            this.tsbRemoveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveSelected.Name = "tsbRemoveSelected";
            this.tsbRemoveSelected.Size = new System.Drawing.Size(117, 22);
            this.tsbRemoveSelected.Text = "Remove Selected";
            this.tsbRemoveSelected.Click += new System.EventHandler(this.tsbRemoveSelected_Click);
            // 
            // tsbSkipSelected
            // 
            this.tsbSkipSelected.Image = global::ShowNamer.Properties.Resources.cross_shield;
            this.tsbSkipSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSkipSelected.Name = "tsbSkipSelected";
            this.tsbSkipSelected.Size = new System.Drawing.Size(96, 22);
            this.tsbSkipSelected.Text = "Skip Selected";
            this.tsbSkipSelected.Click += new System.EventHandler(this.tsbSkipSelected_Click);
            // 
            // ShowNamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 681);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowNamer";
            this.Text = "Show Namer (c) Joachim Dalen";
            this.Load += new System.EventHandler(this.ShowNamer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClearGrid;
        private System.Windows.Forms.ToolStripButton tbsOpenNewFolder;
        private System.Windows.Forms.ToolStripButton tbsAddFromFolder;
        private System.Windows.Forms.ToolStripButton tsbEnableDragDrop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRemoveSelected;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripButton tsbSkipSelected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox CbIncEp;
        private System.Windows.Forms.Button BtnRenameFiles;
        private System.Windows.Forms.ComboBox ComboSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.NumericUpDown nudEpisodes;
        private System.Windows.Forms.NumericUpDown nudSeason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

