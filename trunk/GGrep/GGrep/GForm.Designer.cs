namespace GGrep
{
    partial class GForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GForm));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbbSearchFolder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSearchText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbFolderNotMatch = new System.Windows.Forms.ComboBox();
            this.cbbFolderMatch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbFileNotMatch = new System.Windows.Forms.ComboBox();
            this.cbbFileMatch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbSearchOnWords = new System.Windows.Forms.CheckBox();
            this.cbIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.cbIncludeHiddenFolder = new System.Windows.Forms.CheckBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbMultiline = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbEncoding = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llOption = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.folvResult = new BrightIdeasSoftware.FastObjectListView();
            this.colNo = new BrightIdeasSoftware.OLVColumn();
            this.colFileName = new BrightIdeasSoftware.OLVColumn();
            this.colRowNo = new BrightIdeasSoftware.OLVColumn();
            this.colColNo = new BrightIdeasSoftware.OLVColumn();
            this.colLine = new BrightIdeasSoftware.OLVColumn();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folvResult)).BeginInit();
            this.gbResult.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(438, 35);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbbSearchFolder
            // 
            this.cbbSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSearchFolder.FormattingEnabled = true;
            this.cbbSearchFolder.Location = new System.Drawing.Point(65, 35);
            this.cbbSearchFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSearchFolder.Name = "cbbSearchFolder";
            this.cbbSearchFolder.Size = new System.Drawing.Size(365, 22);
            this.cbbSearchFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // cbbSearchText
            // 
            this.cbbSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSearchText.FormattingEnabled = true;
            this.cbbSearchText.Location = new System.Drawing.Point(65, 5);
            this.cbbSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSearchText.Name = "cbbSearchText";
            this.cbbSearchText.Size = new System.Drawing.Size(401, 22);
            this.cbbSearchText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder:";
            // 
            // gbFilter
            // 
            this.gbFilter.AutoSize = true;
            this.gbFilter.Controls.Add(this.panel2);
            this.gbFilter.Controls.Add(this.flowLayoutPanel1);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(480, 182);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.cbbFolderNotMatch);
            this.panel2.Controls.Add(this.cbbFolderMatch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbbFileNotMatch);
            this.panel2.Controls.Add(this.cbbFileMatch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 104);
            this.panel2.TabIndex = 8;
            // 
            // cbbFolderNotMatch
            // 
            this.cbbFolderNotMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFolderNotMatch.FormattingEnabled = true;
            this.cbbFolderNotMatch.Location = new System.Drawing.Point(114, 79);
            this.cbbFolderNotMatch.Name = "cbbFolderNotMatch";
            this.cbbFolderNotMatch.Size = new System.Drawing.Size(351, 22);
            this.cbbFolderNotMatch.TabIndex = 19;
            // 
            // cbbFolderMatch
            // 
            this.cbbFolderMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFolderMatch.FormattingEnabled = true;
            this.cbbFolderMatch.Location = new System.Drawing.Point(114, 54);
            this.cbbFolderMatch.Name = "cbbFolderMatch";
            this.cbbFolderMatch.Size = new System.Drawing.Size(351, 22);
            this.cbbFolderMatch.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Folder not match:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Folder match:";
            // 
            // cbbFileNotMatch
            // 
            this.cbbFileNotMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFileNotMatch.FormattingEnabled = true;
            this.cbbFileNotMatch.Location = new System.Drawing.Point(114, 29);
            this.cbbFileNotMatch.Name = "cbbFileNotMatch";
            this.cbbFileNotMatch.Size = new System.Drawing.Size(351, 22);
            this.cbbFileNotMatch.TabIndex = 15;
            // 
            // cbbFileMatch
            // 
            this.cbbFileMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFileMatch.FormattingEnabled = true;
            this.cbbFileMatch.Location = new System.Drawing.Point(114, 4);
            this.cbbFileMatch.Name = "cbbFileMatch";
            this.cbbFileMatch.Size = new System.Drawing.Size(351, 22);
            this.cbbFileMatch.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "File not match:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "File match:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.cbSearchOnWords);
            this.flowLayoutPanel1.Controls.Add(this.cbIncludeSubFolders);
            this.flowLayoutPanel1.Controls.Add(this.cbIncludeHiddenFolder);
            this.flowLayoutPanel1.Controls.Add(this.cbRegex);
            this.flowLayoutPanel1.Controls.Add(this.cbCaseSensitive);
            this.flowLayoutPanel1.Controls.Add(this.cbMultiline);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.cbbEncoding);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(474, 52);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // cbSearchOnWords
            // 
            this.cbSearchOnWords.AutoSize = true;
            this.cbSearchOnWords.Location = new System.Drawing.Point(3, 3);
            this.cbSearchOnWords.Name = "cbSearchOnWords";
            this.cbSearchOnWords.Size = new System.Drawing.Size(118, 18);
            this.cbSearchOnWords.TabIndex = 5;
            this.cbSearchOnWords.Text = "Search on words";
            this.cbSearchOnWords.UseVisualStyleBackColor = true;
            // 
            // cbIncludeSubFolders
            // 
            this.cbIncludeSubFolders.AutoSize = true;
            this.cbIncludeSubFolders.Location = new System.Drawing.Point(127, 3);
            this.cbIncludeSubFolders.Name = "cbIncludeSubFolders";
            this.cbIncludeSubFolders.Size = new System.Drawing.Size(125, 18);
            this.cbIncludeSubFolders.TabIndex = 4;
            this.cbIncludeSubFolders.Text = "Include subfolders";
            this.cbIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // cbIncludeHiddenFolder
            // 
            this.cbIncludeHiddenFolder.AutoSize = true;
            this.cbIncludeHiddenFolder.Location = new System.Drawing.Point(258, 3);
            this.cbIncludeHiddenFolder.Name = "cbIncludeHiddenFolder";
            this.cbIncludeHiddenFolder.Size = new System.Drawing.Size(147, 18);
            this.cbIncludeHiddenFolder.TabIndex = 12;
            this.cbIncludeHiddenFolder.Text = "Include hidden folders";
            this.cbIncludeHiddenFolder.UseVisualStyleBackColor = true;
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Location = new System.Drawing.Point(411, 3);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(60, 18);
            this.cbRegex.TabIndex = 7;
            this.cbRegex.Text = "Regex";
            this.cbRegex.UseVisualStyleBackColor = true;
            this.cbRegex.CheckedChanged += new System.EventHandler(this.cbRegex_CheckedChanged);
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.AutoSize = true;
            this.cbCaseSensitive.Location = new System.Drawing.Point(3, 27);
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.Size = new System.Drawing.Size(101, 18);
            this.cbCaseSensitive.TabIndex = 6;
            this.cbCaseSensitive.Text = "Case sensitive";
            this.cbCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbMultiline
            // 
            this.cbMultiline.AutoSize = true;
            this.cbMultiline.Location = new System.Drawing.Point(110, 27);
            this.cbMultiline.Name = "cbMultiline";
            this.cbMultiline.Size = new System.Drawing.Size(69, 18);
            this.cbMultiline.TabIndex = 13;
            this.cbMultiline.Text = "Multiline";
            this.cbMultiline.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(185, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Encoding:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbEncoding
            // 
            this.cbbEncoding.FormattingEnabled = true;
            this.cbbEncoding.Location = new System.Drawing.Point(252, 27);
            this.cbbEncoding.Name = "cbbEncoding";
            this.cbbEncoding.Size = new System.Drawing.Size(121, 22);
            this.cbbEncoding.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.llOption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbbSearchFolder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.cbbSearchText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 90);
            this.panel1.TabIndex = 7;
            // 
            // llOption
            // 
            this.llOption.AutoSize = true;
            this.llOption.Location = new System.Drawing.Point(11, 68);
            this.llOption.Name = "llOption";
            this.llOption.Size = new System.Drawing.Size(33, 14);
            this.llOption.TabIndex = 9;
            this.llOption.TabStop = true;
            this.llOption.Text = "Filter";
            this.llOption.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOption_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(393, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // folvResult
            // 
            this.folvResult.AllColumns.Add(this.colNo);
            this.folvResult.AllColumns.Add(this.colFileName);
            this.folvResult.AllColumns.Add(this.colRowNo);
            this.folvResult.AllColumns.Add(this.colColNo);
            this.folvResult.AllColumns.Add(this.colLine);
            this.folvResult.AlternateRowBackColor = System.Drawing.Color.Honeydew;
            this.folvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colFileName,
            this.colRowNo,
            this.colColNo,
            this.colLine});
            this.folvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folvResult.EmptyListMsg = "Nothing Founded!!!";
            this.folvResult.FullRowSelect = true;
            this.folvResult.GridLines = true;
            this.folvResult.Location = new System.Drawing.Point(3, 18);
            this.folvResult.Name = "folvResult";
            this.folvResult.ShowGroups = false;
            this.folvResult.Size = new System.Drawing.Size(474, 132);
            this.folvResult.TabIndex = 9;
            this.folvResult.UseAlternatingBackColors = true;
            this.folvResult.UseCompatibleStateImageBehavior = false;
            this.folvResult.UseCustomSelectionColors = true;
            this.folvResult.View = System.Windows.Forms.View.Details;
            this.folvResult.VirtualMode = true;
            // 
            // colNo
            // 
            this.colNo.AspectName = "No";
            this.colNo.IsEditable = false;
            this.colNo.Text = "#";
            this.colNo.Width = 30;
            // 
            // colFileName
            // 
            this.colFileName.AspectName = "FileName";
            this.colFileName.FillsFreeSpace = true;
            this.colFileName.IsEditable = false;
            this.colFileName.Text = "File";
            this.colFileName.Width = 100;
            // 
            // colRowNo
            // 
            this.colRowNo.AspectName = "RowNo";
            this.colRowNo.IsEditable = false;
            this.colRowNo.Text = "Line";
            this.colRowNo.Width = 40;
            // 
            // colColNo
            // 
            this.colColNo.AspectName = "ColNo";
            this.colColNo.IsEditable = false;
            this.colColNo.Text = "Column";
            this.colColNo.Width = 40;
            // 
            // colLine
            // 
            this.colLine.AspectName = "Line";
            this.colLine.FillsFreeSpace = true;
            this.colLine.IsEditable = false;
            this.colLine.Text = "Result";
            this.colLine.Width = 240;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.folvResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(0, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(480, 153);
            this.gbResult.TabIndex = 10;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(6, 96);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbResult);
            this.splitContainer1.Size = new System.Drawing.Size(480, 339);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(6, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(115, 17);
            this.statusLabel.Text = "Click &Search to Start.";
            // 
            // GForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "GForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "GGrep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GForm_FormClosing);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folvResult)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbbSearchFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbSearchOnWords;
        private System.Windows.Forms.CheckBox cbIncludeSubFolders;
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.CheckBox cbCaseSensitive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbEncoding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbFileNotMatch;
        private System.Windows.Forms.ComboBox cbbFileMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbFolderNotMatch;
        private System.Windows.Forms.ComboBox cbbFolderMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbIncludeHiddenFolder;
        private System.Windows.Forms.CheckBox cbMultiline;
        private BrightIdeasSoftware.FastObjectListView folvResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel llOption;
        private BrightIdeasSoftware.OLVColumn colFileName;
        private BrightIdeasSoftware.OLVColumn colRowNo;
        private BrightIdeasSoftware.OLVColumn colColNo;
        private BrightIdeasSoftware.OLVColumn colLine;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private BrightIdeasSoftware.OLVColumn colNo;
    }
}

