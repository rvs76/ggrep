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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.folvResult = new BrightIdeasSoftware.FastObjectListView();
            this.colNo = new BrightIdeasSoftware.OLVColumn();
            this.colFileName = new BrightIdeasSoftware.OLVColumn();
            this.colEncoding = new BrightIdeasSoftware.OLVColumn();
            this.colRowNo = new BrightIdeasSoftware.OLVColumn();
            this.colColNo = new BrightIdeasSoftware.OLVColumn();
            this.colMatched = new BrightIdeasSoftware.OLVColumn();
            this.colResult = new BrightIdeasSoftware.OLVColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tooltipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.gbFilter = new GGrep.CollapsibleGroupBox();
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
            this.cbIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.cbIncludeHiddenFolder = new System.Windows.Forms.CheckBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.cbSearchOnWords = new System.Windows.Forms.CheckBox();
            this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbMultiline = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbEncoding = new System.Windows.Forms.ComboBox();
            this.gbSearch.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folvResult)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleDescription = null;
            this.btnBrowse.AccessibleName = null;
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackgroundImage = null;
            this.btnBrowse.Font = null;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbbSearchFolder
            // 
            this.cbbSearchFolder.AccessibleDescription = null;
            this.cbbSearchFolder.AccessibleName = null;
            resources.ApplyResources(this.cbbSearchFolder, "cbbSearchFolder");
            this.cbbSearchFolder.BackgroundImage = null;
            this.cbbSearchFolder.Font = null;
            this.cbbSearchFolder.FormattingEnabled = true;
            this.cbbSearchFolder.Name = "cbbSearchFolder";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // cbbSearchText
            // 
            this.cbbSearchText.AccessibleDescription = null;
            this.cbbSearchText.AccessibleName = null;
            resources.ApplyResources(this.cbbSearchText, "cbbSearchText");
            this.cbbSearchText.BackgroundImage = null;
            this.cbbSearchText.Font = null;
            this.cbbSearchText.FormattingEnabled = true;
            this.cbbSearchText.Name = "cbbSearchText";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // gbSearch
            // 
            this.gbSearch.AccessibleDescription = null;
            this.gbSearch.AccessibleName = null;
            resources.ApplyResources(this.gbSearch, "gbSearch");
            this.gbSearch.BackgroundImage = null;
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbbSearchFolder);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.btnBrowse);
            this.gbSearch.Controls.Add(this.cbbSearchText);
            this.gbSearch.Font = null;
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = null;
            this.btnSearch.AccessibleName = null;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackgroundImage = null;
            this.btnSearch.Font = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbResult
            // 
            this.gbResult.AccessibleDescription = null;
            this.gbResult.AccessibleName = null;
            resources.ApplyResources(this.gbResult, "gbResult");
            this.gbResult.BackgroundImage = null;
            this.gbResult.Controls.Add(this.folvResult);
            this.gbResult.Font = null;
            this.gbResult.Name = "gbResult";
            this.gbResult.TabStop = false;
            // 
            // folvResult
            // 
            this.folvResult.AccessibleDescription = null;
            this.folvResult.AccessibleName = null;
            resources.ApplyResources(this.folvResult, "folvResult");
            this.folvResult.AllColumns.Add(this.colNo);
            this.folvResult.AllColumns.Add(this.colFileName);
            this.folvResult.AllColumns.Add(this.colEncoding);
            this.folvResult.AllColumns.Add(this.colRowNo);
            this.folvResult.AllColumns.Add(this.colColNo);
            this.folvResult.AllColumns.Add(this.colMatched);
            this.folvResult.AllColumns.Add(this.colResult);
            this.folvResult.AlternateRowBackColor = System.Drawing.Color.Honeydew;
            this.folvResult.BackgroundImage = null;
            this.folvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colFileName,
            this.colRowNo,
            this.colColNo,
            this.colResult});
            this.folvResult.Font = null;
            this.folvResult.FullRowSelect = true;
            this.folvResult.GridLines = true;
            this.folvResult.GroupWithItemCountFormat = null;
            this.folvResult.GroupWithItemCountSingularFormat = null;
            this.folvResult.Name = "folvResult";
            this.folvResult.OverlayText.Text = null;
            this.folvResult.OwnerDraw = true;
            this.folvResult.ShowGroups = false;
            this.folvResult.UseAlternatingBackColors = true;
            this.folvResult.UseCompatibleStateImageBehavior = false;
            this.folvResult.View = System.Windows.Forms.View.Details;
            this.folvResult.VirtualMode = true;
            this.folvResult.DoubleClick += new System.EventHandler(this.folvResult_DoubleClick);
            // 
            // colNo
            // 
            this.colNo.AspectName = "No";
            this.colNo.GroupWithItemCountFormat = null;
            this.colNo.GroupWithItemCountSingularFormat = null;
            this.colNo.IsEditable = false;
            resources.ApplyResources(this.colNo, "colNo");
            this.colNo.ToolTipText = null;
            // 
            // colFileName
            // 
            this.colFileName.AspectName = "FileName";
            this.colFileName.GroupWithItemCountFormat = null;
            this.colFileName.GroupWithItemCountSingularFormat = null;
            this.colFileName.IsEditable = false;
            resources.ApplyResources(this.colFileName, "colFileName");
            // 
            // colEncoding
            // 
            this.colEncoding.AspectName = "FileEncoding";
            resources.ApplyResources(this.colEncoding, "colEncoding");
            this.colEncoding.GroupWithItemCountFormat = null;
            this.colEncoding.GroupWithItemCountSingularFormat = null;
            this.colEncoding.IsEditable = false;
            this.colEncoding.IsVisible = false;
            this.colEncoding.ToolTipText = null;
            // 
            // colRowNo
            // 
            this.colRowNo.AspectName = "RowNo";
            this.colRowNo.AspectToStringFormat = "";
            this.colRowNo.GroupWithItemCountFormat = null;
            this.colRowNo.GroupWithItemCountSingularFormat = null;
            this.colRowNo.IsEditable = false;
            resources.ApplyResources(this.colRowNo, "colRowNo");
            this.colRowNo.ToolTipText = null;
            // 
            // colColNo
            // 
            this.colColNo.AspectName = "ColNo";
            this.colColNo.AspectToStringFormat = "";
            this.colColNo.GroupWithItemCountFormat = null;
            this.colColNo.GroupWithItemCountSingularFormat = null;
            this.colColNo.IsEditable = false;
            resources.ApplyResources(this.colColNo, "colColNo");
            this.colColNo.ToolTipText = null;
            // 
            // colMatched
            // 
            this.colMatched.AspectName = "MatchedString";
            resources.ApplyResources(this.colMatched, "colMatched");
            this.colMatched.GroupWithItemCountFormat = null;
            this.colMatched.GroupWithItemCountSingularFormat = null;
            this.colMatched.IsVisible = false;
            this.colMatched.ToolTipText = null;
            // 
            // colResult
            // 
            this.colResult.AspectName = "Line";
            this.colResult.FillsFreeSpace = true;
            this.colResult.GroupWithItemCountFormat = null;
            this.colResult.GroupWithItemCountSingularFormat = null;
            this.colResult.IsEditable = false;
            resources.ApplyResources(this.colResult, "colResult");
            this.colResult.ToolTipText = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleDescription = null;
            this.statusStrip1.AccessibleName = null;
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackgroundImage = null;
            this.statusStrip1.Font = null;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.statusLabel});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AccessibleDescription = null;
            this.toolStripProgressBar.AccessibleName = null;
            resources.ApplyResources(this.toolStripProgressBar, "toolStripProgressBar");
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            // 
            // statusLabel
            // 
            this.statusLabel.AccessibleDescription = null;
            this.statusLabel.AccessibleName = null;
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.BackgroundImage = null;
            this.statusLabel.Name = "statusLabel";
            // 
            // menuStripMain
            // 
            this.menuStripMain.AccessibleDescription = null;
            this.menuStripMain.AccessibleName = null;
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.BackgroundImage = null;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsCsvToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // saveAsCsvToolStripMenuItem
            // 
            this.saveAsCsvToolStripMenuItem.AccessibleDescription = null;
            this.saveAsCsvToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveAsCsvToolStripMenuItem, "saveAsCsvToolStripMenuItem");
            this.saveAsCsvToolStripMenuItem.BackgroundImage = null;
            this.saveAsCsvToolStripMenuItem.Name = "saveAsCsvToolStripMenuItem";
            this.saveAsCsvToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveAsCsvToolStripMenuItem.Click += new System.EventHandler(this.saveAsCsvToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = null;
            this.toolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.AccessibleDescription = null;
            this.viewToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.BackgroundImage = null;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.toolStripSeparator2,
            this.tooltipsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.AccessibleDescription = null;
            this.filterToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.filterToolStripMenuItem, "filterToolStripMenuItem");
            this.filterToolStripMenuItem.BackgroundImage = null;
            this.filterToolStripMenuItem.CheckOnClick = true;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = null;
            this.toolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tooltipsToolStripMenuItem
            // 
            this.tooltipsToolStripMenuItem.AccessibleDescription = null;
            this.tooltipsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.tooltipsToolStripMenuItem, "tooltipsToolStripMenuItem");
            this.tooltipsToolStripMenuItem.BackgroundImage = null;
            this.tooltipsToolStripMenuItem.CheckOnClick = true;
            this.tooltipsToolStripMenuItem.Name = "tooltipsToolStripMenuItem";
            this.tooltipsToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.AccessibleDescription = null;
            this.toolsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.BackgroundImage = null;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.AccessibleDescription = null;
            this.languageToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.BackgroundImage = null;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.japaneseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.AccessibleDescription = null;
            this.englishToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.BackgroundImage = null;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishChangeToolStripMenuItem_Clicked);
            // 
            // japaneseToolStripMenuItem
            // 
            this.japaneseToolStripMenuItem.AccessibleDescription = null;
            this.japaneseToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.japaneseToolStripMenuItem, "japaneseToolStripMenuItem");
            this.japaneseToolStripMenuItem.BackgroundImage = null;
            this.japaneseToolStripMenuItem.Checked = true;
            this.japaneseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            this.japaneseToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.japaneseToolStripMenuItem.Click += new System.EventHandler(this.japaneseChangeToolStripMenuItem_Clicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AccessibleDescription = null;
            this.toolStripSeparator3.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.AccessibleDescription = null;
            this.optionsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.BackgroundImage = null;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = null;
            this.helpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.BackgroundImage = null;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoGrep);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GrepCompleted);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.GrepProgressChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.AccessibleDescription = null;
            this.gbFilter.AccessibleName = null;
            resources.ApplyResources(this.gbFilter, "gbFilter");
            this.gbFilter.BackgroundImage = null;
            this.gbFilter.Controls.Add(this.panel2);
            this.gbFilter.Controls.Add(this.flowLayoutPanel1);
            this.gbFilter.Font = null;
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackgroundImage = null;
            this.panel2.Controls.Add(this.cbbFolderNotMatch);
            this.panel2.Controls.Add(this.cbbFolderMatch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbbFileNotMatch);
            this.panel2.Controls.Add(this.cbbFileMatch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = null;
            this.panel2.Name = "panel2";
            // 
            // cbbFolderNotMatch
            // 
            this.cbbFolderNotMatch.AccessibleDescription = null;
            this.cbbFolderNotMatch.AccessibleName = null;
            resources.ApplyResources(this.cbbFolderNotMatch, "cbbFolderNotMatch");
            this.cbbFolderNotMatch.BackgroundImage = null;
            this.cbbFolderNotMatch.Font = null;
            this.cbbFolderNotMatch.FormattingEnabled = true;
            this.cbbFolderNotMatch.Name = "cbbFolderNotMatch";
            // 
            // cbbFolderMatch
            // 
            this.cbbFolderMatch.AccessibleDescription = null;
            this.cbbFolderMatch.AccessibleName = null;
            resources.ApplyResources(this.cbbFolderMatch, "cbbFolderMatch");
            this.cbbFolderMatch.BackgroundImage = null;
            this.cbbFolderMatch.Font = null;
            this.cbbFolderMatch.FormattingEnabled = true;
            this.cbbFolderMatch.Name = "cbbFolderMatch";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Font = null;
            this.label7.Name = "label7";
            // 
            // cbbFileNotMatch
            // 
            this.cbbFileNotMatch.AccessibleDescription = null;
            this.cbbFileNotMatch.AccessibleName = null;
            resources.ApplyResources(this.cbbFileNotMatch, "cbbFileNotMatch");
            this.cbbFileNotMatch.BackgroundImage = null;
            this.cbbFileNotMatch.Font = null;
            this.cbbFileNotMatch.FormattingEnabled = true;
            this.cbbFileNotMatch.Name = "cbbFileNotMatch";
            // 
            // cbbFileMatch
            // 
            this.cbbFileMatch.AccessibleDescription = null;
            this.cbbFileMatch.AccessibleName = null;
            resources.ApplyResources(this.cbbFileMatch, "cbbFileMatch");
            this.cbbFileMatch.BackgroundImage = null;
            this.cbbFileMatch.Font = null;
            this.cbbFileMatch.FormattingEnabled = true;
            this.cbbFileMatch.Name = "cbbFileMatch";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AccessibleDescription = null;
            this.flowLayoutPanel1.AccessibleName = null;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackgroundImage = null;
            this.flowLayoutPanel1.Controls.Add(this.cbIncludeSubFolders);
            this.flowLayoutPanel1.Controls.Add(this.cbIncludeHiddenFolder);
            this.flowLayoutPanel1.Controls.Add(this.cbRegex);
            this.flowLayoutPanel1.Controls.Add(this.cbSearchOnWords);
            this.flowLayoutPanel1.Controls.Add(this.cbCaseSensitive);
            this.flowLayoutPanel1.Controls.Add(this.cbMultiline);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.cbbEncoding);
            this.flowLayoutPanel1.Font = null;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // cbIncludeSubFolders
            // 
            this.cbIncludeSubFolders.AccessibleDescription = null;
            this.cbIncludeSubFolders.AccessibleName = null;
            resources.ApplyResources(this.cbIncludeSubFolders, "cbIncludeSubFolders");
            this.cbIncludeSubFolders.BackgroundImage = null;
            this.cbIncludeSubFolders.Font = null;
            this.cbIncludeSubFolders.Name = "cbIncludeSubFolders";
            this.cbIncludeSubFolders.UseVisualStyleBackColor = true;
            this.cbIncludeSubFolders.CheckedChanged += new System.EventHandler(this.cbIncludeSubFolders_CheckedChanged);
            // 
            // cbIncludeHiddenFolder
            // 
            this.cbIncludeHiddenFolder.AccessibleDescription = null;
            this.cbIncludeHiddenFolder.AccessibleName = null;
            resources.ApplyResources(this.cbIncludeHiddenFolder, "cbIncludeHiddenFolder");
            this.cbIncludeHiddenFolder.BackgroundImage = null;
            this.cbIncludeHiddenFolder.Font = null;
            this.cbIncludeHiddenFolder.Name = "cbIncludeHiddenFolder";
            this.cbIncludeHiddenFolder.UseVisualStyleBackColor = true;
            // 
            // cbRegex
            // 
            this.cbRegex.AccessibleDescription = null;
            this.cbRegex.AccessibleName = null;
            resources.ApplyResources(this.cbRegex, "cbRegex");
            this.cbRegex.BackgroundImage = null;
            this.cbRegex.Font = null;
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.UseVisualStyleBackColor = true;
            this.cbRegex.CheckedChanged += new System.EventHandler(this.cbRegex_CheckedChanged);
            // 
            // cbSearchOnWords
            // 
            this.cbSearchOnWords.AccessibleDescription = null;
            this.cbSearchOnWords.AccessibleName = null;
            resources.ApplyResources(this.cbSearchOnWords, "cbSearchOnWords");
            this.cbSearchOnWords.BackgroundImage = null;
            this.cbSearchOnWords.Font = null;
            this.cbSearchOnWords.Name = "cbSearchOnWords";
            this.cbSearchOnWords.UseVisualStyleBackColor = true;
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.AccessibleDescription = null;
            this.cbCaseSensitive.AccessibleName = null;
            resources.ApplyResources(this.cbCaseSensitive, "cbCaseSensitive");
            this.cbCaseSensitive.BackgroundImage = null;
            this.cbCaseSensitive.Font = null;
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbMultiline
            // 
            this.cbMultiline.AccessibleDescription = null;
            this.cbMultiline.AccessibleName = null;
            resources.ApplyResources(this.cbMultiline, "cbMultiline");
            this.cbMultiline.BackgroundImage = null;
            this.cbMultiline.Font = null;
            this.cbMultiline.Name = "cbMultiline";
            this.cbMultiline.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Font = null;
            this.label6.Name = "label6";
            // 
            // cbbEncoding
            // 
            this.cbbEncoding.AccessibleDescription = null;
            this.cbbEncoding.AccessibleName = null;
            resources.ApplyResources(this.cbbEncoding, "cbbEncoding");
            this.cbbEncoding.BackgroundImage = null;
            this.cbbEncoding.Font = null;
            this.cbbEncoding.FormattingEnabled = true;
            this.cbbEncoding.Name = "cbbEncoding";
            // 
            // GForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "GForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GForm_FormClosing);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folvResult)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbbSearchFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSearchText;
        private System.Windows.Forms.Label label2;
        private GGrep.CollapsibleGroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbSearch;
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
        private BrightIdeasSoftware.OLVColumn colFileName;
        private BrightIdeasSoftware.OLVColumn colRowNo;
        private BrightIdeasSoftware.OLVColumn colColNo;
        private BrightIdeasSoftware.OLVColumn colResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private BrightIdeasSoftware.OLVColumn colNo;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tooltipsToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn colEncoding;
        private BrightIdeasSoftware.OLVColumn colMatched;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

