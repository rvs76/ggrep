using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using BrightIdeasSoftware;

namespace GGrep
{
    #region Main Class

    /// <summary>
    /// Main Grep Form
    /// </summary>
    public partial class GForm : Form
    {
        #region Members
        public const char SEPERATOR = '	';

        Stopwatch sw = new Stopwatch();

        SearchOptions option = null;
        SearchStatus status = null;
        bool isRunning = false;
        private bool IsAutoEncoding { get { return GetControlText(cbbEncoding).Trim().ToLower() == "auto"; } }
        #endregion

        #region Constructor
        public GForm()
        {
            InitializeComponent();
            gbFilter.IsCollapsed = Properties.Settings.Default.FilterIsCollapsed;
            SetSearchOptions();
            btnSearch.Text = Properties.Resources.BTN_TEXT_SEARCH;
            filterToolStripMenuItem.Checked = !Properties.Settings.Default.FilterIsCollapsed;
            tooltipsToolStripMenuItem.Checked = Properties.Settings.Default.TooltipsShown;

            #region highlight render
            this.colResult.Renderer = new HighlightRenderer();
            #endregion

            #region tooltips
            folvResult.CellToolTipGetter = delegate(OLVColumn column, Object rowObject)
            {
                if (rowObject != null && tooltipsToolStripMenuItem.Checked)
                {
                    switch (column.AspectName)
                    {
                        case "FullFileName":
                            return ((ResultData)rowObject).FullFileName;
                        case "FileEncoding":
                            return ((ResultData)rowObject).FileEncoding;
                        case "Line":
                            return ((ResultData)rowObject).Line.Trim();
                        default:
                            return null;
                    }
                }
                else
                    return null;
            };
            #endregion

            #region set window location & size
            // Set window location
            if (Properties.Settings.Default.WindowLocation != null)
                this.Location = Properties.Settings.Default.WindowLocation;

            // Set window size
            if (Properties.Settings.Default.WindowSize != null)
                this.Size = Properties.Settings.Default.WindowSize;
            #endregion
        }
        #endregion

        #region Methods

        #region General

        /// <summary>
        /// Check & Save Search Options
        /// </summary>
        /// <returns></returns>
        private bool CheckAndSaveSearchOptions()
        {
            #region check
            // string
            if (string.IsNullOrEmpty(cbbSearchText.Text))
            {
                ShowMessage(0, Properties.Resources.MSG_ERROR_01);
                return false;
            }

            // folder
            if (string.IsNullOrEmpty(cbbSearchFolder.Text) || !Directory.Exists(cbbSearchFolder.Text))
            {
                ShowMessage(0, Properties.Resources.MSG_ERROR_02);
                return false;
            }

            // encoding
            try
            {
                if (!IsAutoEncoding)
                {
                    Encoding e = Encoding.GetEncoding(cbbEncoding.Text);
                }
            }
            catch
            {
                ShowMessage(0, Properties.Resources.MSG_ERROR_03);
                return false;
            }

            // regex text
            if (cbRegex.Checked)
            {
                try
                {
                    Regex.IsMatch("", cbbSearchText.Text);
                }
                catch
                {
                    ShowMessage(0, Properties.Resources.MSG_ERROR_04);
                    return false;
                }
            }

            #endregion

            #region save
            option = new SearchOptions();

            option.SearchString = cbbSearchText.Text;
            ManagerCombox(cbbSearchText, option.SearchString);

            option.SearchFolder = cbbSearchFolder.Text;
            ManagerCombox(cbbSearchFolder, option.SearchFolder);

            option.IncludeSubFolders = cbIncludeSubFolders.Checked;
            option.IncludeHiddenFolders = cbIncludeHiddenFolder.Checked;

            option.IsRegex = cbRegex.Checked;
            if (cbRegex.Checked)
            {
                option.Multiline = cbMultiline.Checked;
            }
            else
            {
                option.IsCaseSensitive = cbCaseSensitive.Checked;
                option.IsSearchOnWords = cbSearchOnWords.Checked;
            }

            option.Encoding = cbbEncoding.Text;
            ManagerCombox(cbbEncoding, option.Encoding);

            option.MatchFiles = cbbFileMatch.Text;
            ManagerCombox(cbbFileMatch, option.MatchFiles);

            option.NotMatchFiles = cbbFileNotMatch.Text;
            ManagerCombox(cbbFileNotMatch, option.NotMatchFiles);

            option.MatchFolders = cbbFolderMatch.Text;
            ManagerCombox(cbbFolderMatch, option.MatchFolders);

            option.NotMatchFolders = cbbFolderNotMatch.Text;
            ManagerCombox(cbbFolderNotMatch, option.NotMatchFolders);

            #endregion

            return true;
        }

        /// <summary>
        /// Manager ComboBox
        /// </summary>
        /// <param name="cb">ComboBox</param>
        /// <param name="value">Selected Value</param>
        private void ManagerCombox(ComboBox cb, string value)
        {
            if (cb.Items.Contains(value))
            {
                cb.Items.Remove(value);
            }
            cb.Items.Insert(0, value);
            cb.SelectedIndex = 0;
        }

        /// <summary>
        /// generate string like 'xxx|xxx|xxx|xxx'
        /// </summary>
        /// <param name="cb">select box</param>
        private string AppendSearchOptions(ComboBox cb)
        {
            if (cb.Items.Count <= 0)
                return "";
            string s = "";

            // saved option max count is 20
            int count = cb.Items.Count > 20 ? 20 : cb.Items.Count;

            for (int i = 0; i < count; i++)
            {
                s += SEPERATOR + cb.Items[i].ToString();
            }
            return s.Substring(1);
        }

        /// <summary>
        /// Save Search Options
        /// </summary>
        private void SaveSearchOptions()
        {
            Properties.Settings.Default.SearchString = AppendSearchOptions(cbbSearchText);
            Properties.Settings.Default.SearchFolder = AppendSearchOptions(cbbSearchFolder);
            Properties.Settings.Default.Regex = option.IsRegex;
            Properties.Settings.Default.CaseSensitive = option.IsCaseSensitive;
            Properties.Settings.Default.SearchOnWords = option.IsSearchOnWords;
            Properties.Settings.Default.IncludeSubFolders = option.IncludeSubFolders;
            Properties.Settings.Default.IncludeHiddenFolders = option.IncludeHiddenFolders;
            Properties.Settings.Default.Multiline = option.Multiline;
            Properties.Settings.Default.Encoding = AppendSearchOptions(cbbEncoding);
            Properties.Settings.Default.FileMatch = AppendSearchOptions(cbbFileMatch);
            Properties.Settings.Default.FileNotMatch = AppendSearchOptions(cbbFileNotMatch);
            Properties.Settings.Default.FolderMatch = AppendSearchOptions(cbbFolderMatch);
            Properties.Settings.Default.FolderNotMatch = AppendSearchOptions(cbbFolderNotMatch);
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Set Search Options
        /// </summary>
        private void SetSearchOptions()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SearchString))
            {
                cbbSearchText.Items.Clear();
                foreach (string s in Properties.Settings.Default.SearchString.Split(SEPERATOR))
                {
                    cbbSearchText.Items.Add(s);
                }
                cbbSearchText.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SearchFolder))
            {
                cbbSearchFolder.Items.Clear();
                foreach (string s in Properties.Settings.Default.SearchFolder.Split(SEPERATOR))
                {
                    cbbSearchFolder.Items.Add(s);
                }
                cbbSearchFolder.SelectedIndex = 0;
            }
            cbRegex.Checked = Properties.Settings.Default.Regex;
            cbCaseSensitive.Checked = Properties.Settings.Default.CaseSensitive;
            cbSearchOnWords.Checked = Properties.Settings.Default.SearchOnWords;
            cbSearchOnWords.Enabled = !cbRegex.Checked;
            cbCaseSensitive.Enabled = !cbRegex.Checked;
            cbMultiline.Enabled = cbRegex.Checked;

            cbIncludeSubFolders.Checked = Properties.Settings.Default.IncludeSubFolders;
            cbIncludeHiddenFolder.Checked = Properties.Settings.Default.IncludeHiddenFolders;
            cbIncludeHiddenFolder.Enabled = cbIncludeSubFolders.Checked;
            cbMultiline.Checked = Properties.Settings.Default.Multiline;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Encoding))
            {
                cbbEncoding.Items.Clear();
                foreach (string s in Properties.Settings.Default.Encoding.Split(SEPERATOR))
                {
                    cbbEncoding.Items.Add(s);
                }
                cbbEncoding.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.FileMatch))
            {
                cbbFileMatch.Items.Clear();
                foreach (string s in Properties.Settings.Default.FileMatch.Split(SEPERATOR))
                {
                    cbbFileMatch.Items.Add(s);
                }
                cbbFileMatch.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.FileNotMatch))
            {
                cbbFileNotMatch.Items.Clear();
                foreach (string s in Properties.Settings.Default.FileNotMatch.Split(SEPERATOR))
                {
                    cbbFileNotMatch.Items.Add(s);
                }
                cbbFileNotMatch.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.FolderMatch))
            {
                cbbFolderMatch.Items.Clear();
                foreach (string s in Properties.Settings.Default.FolderMatch.Split(SEPERATOR))
                {
                    cbbFolderMatch.Items.Add(s);
                }
                cbbFolderMatch.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.FolderNotMatch))
            {
                cbbFolderNotMatch.Items.Clear();
                foreach (string s in Properties.Settings.Default.FolderNotMatch.Split(SEPERATOR))
                {
                    cbbFolderNotMatch.Items.Add(s);
                }
                cbbFolderNotMatch.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Show Message
        /// </summary>
        /// <param name="pattern">0:failure/1:success/2:warning</param>
        /// <param name="message">Message Contents</param>
        /// <returns></returns>
        private DialogResult ShowMessage(int pattern, string message)
        {
            switch (pattern)
            {
                case 0:
                    // failure
                    return MessageBox.Show(this, message, Properties.Resources.MSG_TITLE_01, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                case 2:
                    // warning
                    return MessageBox.Show(this, message, Properties.Resources.MSG_TITLE_03, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                case 1:
                default:
                    // success
                    return MessageBox.Show(this, message, Properties.Resources.MSG_TITLE_02, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        #endregion

        #region Open File
        /// <summary>
        /// Open File in Specific Editor
        /// </summary>
        /// <param name="data">result data</param>
        private void OpenWithEditor(ResultData data)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                if (!Properties.Settings.Default.UseCustomEditor)
                {
                    p.StartInfo.FileName = string.Format("\"{0}\"", data.FullFileName);
                    p.Start();
                }
                else
                {
                    // col, row, filename
                    p.StartInfo.FileName = string.Format("\"{0}\"", Properties.Settings.Default.CustomEditorPath);
                    p.StartInfo.Arguments = Properties.Settings.Default.CustomEditorArguments.Replace("%file", string.Format("\"{0}\"", data.FullFileName)).Replace("%line", data.RowNo.ToString()).Replace("%column", data.ColNo.ToString());
                    p.Start();
                    if (p.HasExited)
                        p.Kill();
                }
            }
            catch { }
        }
        #endregion

        #region CallBack
        delegate void SetControlTextCallback(Control ctl, string text);
        private void SetControlText(Control ctl, string text)
        {
            if (ctl.InvokeRequired)
            {
                SetControlTextCallback d = new SetControlTextCallback(SetControlText);
                this.Invoke(d, new object[] { ctl, text });
            }
            else
            {
                ctl.Text = text;
            }
        }

        delegate void SetControlActiveCallback(Control ctl, bool enable);
        private void SetControlActive(Control ctl, bool enable)
        {
            if (ctl.InvokeRequired)
            {
                SetControlActiveCallback d = new SetControlActiveCallback(SetControlActive);
                this.Invoke(d, new object[] { ctl, enable });
            }
            else
            {
                ctl.Enabled = enable;
            }
        }

        delegate void SetToolStripMenuItemActiveCallback(ToolStripMenuItem ctl, bool enable);
        private void SetToolStripMenuItemActive(ToolStripMenuItem ctl, bool enable)
        {
            if (this.InvokeRequired)
            {
                SetToolStripMenuItemActiveCallback d = new SetToolStripMenuItemActiveCallback(SetToolStripMenuItemActive);
                this.Invoke(d, new object[] { ctl, enable });
            }
            else
            {
                ctl.Enabled = enable;
            }
        }

        delegate string GetControlTextCallback(Control ctl);
        private string GetControlText(Control ctl)
        {
            if (ctl.InvokeRequired)
            {
                GetControlTextCallback d = new GetControlTextCallback(GetControlText);
                return (string)this.Invoke(d, new object[] { ctl });
            }
            else
            {
                return ctl.Text;
            }
        }

        delegate void AddRowsCallback(ObjectListView list, ArrayList dataList, SearchStatus status);
        private void AddRows(ObjectListView list, ArrayList dataList, SearchStatus status)
        {
            if (list.InvokeRequired)
            {
                AddRowsCallback d = new AddRowsCallback(AddRows);
                this.Invoke(d, new object[] { list, dataList, status });
            }
            else
            {
                list.AddObjects(dataList);
            }
        }

        delegate void SetToolStripLabelCallback(ToolStripStatusLabel ctl, string text);
        private void SetToolStripLabel(ToolStripStatusLabel ctl, string text)
        {
            if (InvokeRequired)
            {
                SetToolStripLabelCallback d = new SetToolStripLabelCallback(SetToolStripLabel);
                this.Invoke(d, new object[] { ctl, text });
            }
            else
            {
                ctl.Text = text;
            }
        }
        #endregion

        #region Grep
        /// <summary>
        /// Search In Files
        /// </summary>
        /// <param name="path">File Or Directory</param>
        /// <param name="e">Event</param>
        /// <returns></returns>
        private ArrayList SearchInFile(string path, DoWorkEventArgs e)
        {
            ArrayList list = new ArrayList();
            if (File.Exists(path))
            {
                long rowNo = 0;
                string line;

                using (StreamReader sr = option.IsAutoEncoding ? Utils.OpenTextFile(path) : new StreamReader(File.OpenRead(path), Encoding.GetEncoding(option.Encoding)))
                {
                    while (!sr.EndOfStream && isRunning)
                    {
                        if (backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                        line = sr.ReadLine();
                        rowNo++;

                        // for fast search
                        if (!option.IsRegex)
                        {
                            if (option.IsCaseSensitive)
                            {
                                if (!line.Contains(option.SearchString))
                                    continue;
                            }
                            else
                            {
                                if (!line.ToLower().Contains(option.SearchString.ToLower()))
                                    continue;
                            }
                        }

                        RegexOptions ro = RegexOptions.Singleline;
                        string input = option.SearchString;

                        if (option.IsRegex)
                        {
#if DEBUG1
                        if (option.Multiline)
                        {
                            ro = ro | RegexOptions.Multiline;
                        }
#endif
                        }
                        else
                        {
                            if (!option.IsCaseSensitive)
                            {
                                ro = ro | RegexOptions.IgnoreCase;
                            }

                            input = Utils.SearchStringRegexEscaped(option.SearchString);
                            if (option.IsSearchOnWords)
                            {
                                input = @"\b" + input + @"\b";
                            }
                        }
                        Regex re = new Regex(input, ro);

                        foreach (Match m in re.Matches(line))
                        {
                            ResultData data = new ResultData();
                            data.SelectedPath = option.SearchFolder;
                            data.No = (++status.Hit);
                            data.FullFileName = path;
                            data.RowNo = rowNo;
                            data.ColNo = m.Index + 1;
                            data.Line = line;
                            data.MatchedString = m.Value;
                            data.FileEncoding = sr.CurrentEncoding.EncodingName;
                            list.Add(data);
                        }
                    }

                    sr.Close();
                }
            }
            return list;
        }
        #endregion

        #region Output Csv
        /// <summary>
        /// Save as CSV
        /// </summary>
        /// <returns></returns>
        private bool SaveCsvFile()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = Properties.Resources.FILE_FILTER;
                sfd.FileName = Properties.Resources.FILE_NEM_NAME;
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    // save
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding("SJIS")))
                    {
                        #region write header
                        sw.Write("#");
                        if (colFileName.IsVisible)
                            sw.Write(",File");
                        if (colEncoding.IsVisible)
                            sw.Write(",Encoding");
                        if (colRowNo.IsVisible)
                            sw.Write(",Row");
                        if (colColNo.IsVisible)
                            sw.Write(",Column");
                        if (colResult.IsVisible)
                            sw.Write(",Result");
                        sw.Write(System.Environment.NewLine);
                        #endregion

                        int index = 1;
                        foreach (ResultData data in folvResult.Objects)
                        {
                            sw.WriteLine(ToCsvLine(data));
                            if (index++ % 1000 == 0)
                                sw.Flush();
                        }
                        sw.Close();
                    }
                    ShowMessage(1, Properties.Resources.MSG_SAVED);
                }

            }
            catch (Exception e)
            {
                ShowMessage(0, e.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Make Csv Line
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string ToCsvLine(ResultData data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(data.No);
            if (colFileName.IsVisible)
            {
                sb.Append(",");
                sb.Append(data.FullFileName);
            }
            if (colEncoding.IsVisible)
            {
                sb.Append(",");
                sb.Append(data.FileEncoding);
            }
            if (colRowNo.IsVisible)
            {
                sb.Append(",");
                sb.Append(data.RowNo);
            }
            if (colColNo.IsVisible)
            {
                sb.Append(",");
                sb.Append(data.ColNo);
            }
            if (colResult.IsVisible)
            {
                sb.Append(",");
                sb.Append("\"");
                sb.Append(data.Line.Replace("\"", "\"\""));
                sb.Append("\"");
            }

            return sb.ToString();
        }
        #endregion

        #endregion

        #region Events

        #region button, combobox, checkbox and etc.
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(cbbSearchFolder.Text) && Directory.Exists(cbbSearchFolder.Text))
            {
                fbd.SelectedPath = cbbSearchFolder.Text;
            }
            switch (fbd.ShowDialog(this))
            {
                case DialogResult.OK:
                    cbbSearchFolder.Text = fbd.SelectedPath;
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!isRunning && !backgroundWorker.IsBusy)
            {
                // start
                if (!CheckAndSaveSearchOptions())
                    return;

                SaveSearchOptions();

                //DoGrep();
                //Thread th = new Thread(new ThreadStart(DoGrep));
                //th.Start();
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                // stop
                isRunning = false;
                backgroundWorker.CancelAsync();
            }

        }

        private void cbRegex_CheckedChanged(object sender, EventArgs e)
        {
            cbMultiline.Enabled = cbRegex.Checked;
            cbSearchOnWords.Enabled = !cbRegex.Checked;
            cbCaseSensitive.Enabled = !cbRegex.Checked;
        }

        private void cbIncludeSubFolders_CheckedChanged(object sender, EventArgs e)
        {
            cbIncludeHiddenFolder.Enabled = cbIncludeSubFolders.Checked;
        }

        private void GForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isRunning || backgroundWorker.IsBusy)
            {
                if (ShowMessage(2, Properties.Resources.MSG_WARN_01) != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                // stop
                isRunning = false;
                backgroundWorker.CancelAsync();
            }

            // Copy window location to app settings
            Properties.Settings.Default.WindowLocation = this.Location;

            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
                Properties.Settings.Default.WindowSize = this.Size;
            else
                Properties.Settings.Default.WindowSize = this.RestoreBounds.Size;

            Properties.Settings.Default.FilterIsCollapsed = gbFilter.IsCollapsed;
            Properties.Settings.Default.TooltipsShown = tooltipsToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void folvResult_DoubleClick(object sender, EventArgs e)
        {
            if (((FastObjectListView)sender).SelectedObject != null)
            {
                OpenWithEditor((ResultData)((FastObjectListView)sender).SelectedObject);
            }
        }

        #endregion

        #region menu
        private void saveAsCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folvResult.Items.Count <= 0)
            {
                ShowMessage(0, Properties.Resources.MSG_ERROR_05);
                return;
            }

            SaveCsvFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbFilter.IsCollapsed = !gbFilter.IsCollapsed;
            filterToolStripMenuItem.Checked = !gbFilter.IsCollapsed;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Optoins o = new Optoins();
            o.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog(this);
        }
        #endregion

        #region backgroundworker
        private void DoGrep(object sender, DoWorkEventArgs e)
        {
            isRunning = true;
            status = new SearchStatus();
            SetControlText(btnSearch, Properties.Resources.BTN_TEXT_CANCEL);
            folvResult.ClearObjects();
            SetToolStripMenuItemActive(saveAsCsvToolStripMenuItem, false);
            SetControlActive(cbbSearchText, false);
            SetControlActive(cbbSearchFolder, false);
            SetControlActive(btnBrowse, false);
            SetControlActive(gbFilter, false);
            SetControlActive(menuStripMain, false);
            sw.Reset();
            sw.Start();
            SetToolStripLabel(statusLabel, Properties.Resources.MSG_STATUS_STARTED);

            ArrayList fileList = new ArrayList();
            Utils.AnalyzeDirectory(option.SearchFolder, option, fileList, backgroundWorker, e);

            if (fileList.Count > 0)
            {
                status.Total = fileList.Count;
                foreach (string file in fileList)
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    ArrayList list = SearchInFile(file, e);
                    status.Finished++;
                    if (list.Count > 0)
                        AddRows(folvResult, list, status);
                    backgroundWorker.ReportProgress(status.Progress);
                }
            }

        }

        private void GrepProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (isRunning)
            {
                toolStripProgressBar.Value = e.ProgressPercentage;
                SetToolStripLabel(statusLabel, string.Format(Properties.Resources.MSG_STATUS_RUNNING, status.Finished, status.Total, status.Hit));
            }
        }

        private void GrepCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sw.Stop();
            toolStripProgressBar.Value = 0;
            if (e.Error != null)
            {
                ShowMessage(0, e.Error.Message);
            }
            else
            {
                SetToolStripLabel(statusLabel, string.Format((e.Cancelled ? Properties.Resources.MSG_STATUS_CANCELED : Properties.Resources.MSG_STATUS_FINISHED), status.Hit, sw.ElapsedMilliseconds));
            }
            SetControlActive(menuStripMain, true);
            SetControlActive(cbbSearchText, true);
            SetControlActive(cbbSearchFolder, true);
            SetControlActive(btnBrowse, true);
            SetControlActive(gbFilter, true);
            if (status.Hit > 0)
                SetToolStripMenuItemActive(saveAsCsvToolStripMenuItem, true);
            SetControlText(btnSearch, Properties.Resources.BTN_TEXT_SEARCH);
            isRunning = false;
        }
        #endregion

        #endregion
    }

    #endregion

    #region internal class

    /// <summary>
    /// Search Status Class
    /// </summary>
    internal class SearchStatus
    {
        private long hit = 0;
        public long Hit
        {
            get { return hit; }
            set { hit = value; }
        }
        private long total = 0;
        public long Total
        {
            get { return total; }
            set { total = value; }
        }
        private long finished = 0;
        public long Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        public int Progress
        {
            get { return (int)((double)finished * 100 / total); }
        }
    }

    /// <summary>
    /// Result Data Class
    /// </summary>
    internal class ResultData
    {
        #region Properties
        private long no;

        public long No
        {
            get { return no; }
            set { no = value; }
        }

        private string selectedPath;
        private int startIndex = -1;
        public string SelectedPath
        {
            get { return selectedPath; }
            set 
            { 
                selectedPath = value;
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    startIndex = selectedPath.Length;
                    if (!selectedPath.EndsWith("\\"))
                    {
                        startIndex++;
                    }
                }
            }
        }
        private string fullFileName;

        public string FullFileName
        {
            get { return fullFileName; }
            set { fullFileName = value; }
        }
        public string FileName
        {
            get 
            {
                if ((!string.IsNullOrEmpty(selectedPath)) && (!string.IsNullOrEmpty(fullFileName)) && fullFileName.Length > startIndex)
                    return fullFileName.Substring(startIndex);
                return fullFileName;
            }
        }
        private long rowNo;

        public long RowNo
        {
            get { return rowNo; }
            set { rowNo = value; }
        }
        private long colNo;

        public long ColNo
        {
            get { return colNo; }
            set { colNo = value; }
        }

        private string line;

        public string Line
        {
            get { return line; }
            set { line = value; }
        }
        private string matchedString;

        public string MatchedString
        {
            get { return matchedString; }
            set { matchedString = value; }
        }
        private string fileEncoding;

        public string FileEncoding
        {
            get { return fileEncoding; }
            set { fileEncoding = value; }
        }
        #endregion
    }

    /// <summary>
    /// Search Option Class
    /// </summary>
    internal class SearchOptions
    {
        #region Properties
        private string searchString;

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }

        private string searchFolder;

        public string SearchFolder
        {
            get { return searchFolder; }
            set { searchFolder = value; }
        }
        
        private bool isRegex;

        public bool IsRegex
        {
            get { return isRegex; }
            set { isRegex = value; }
        }

        private bool isCaseSensitive;

        public bool IsCaseSensitive
        {
            get { return isCaseSensitive; }
            set { isCaseSensitive = value; }
        }
        private bool isSearchOnWords;

        public bool IsSearchOnWords
        {
            get { return isSearchOnWords; }
            set { isSearchOnWords = value; }
        }

        private bool includeSubFolders;

        public bool IncludeSubFolders
        {
            get { return includeSubFolders; }
            set { includeSubFolders = value; }
        }

        private bool includeHiddenFolders;

        public bool IncludeHiddenFolders
        {
            get { return includeHiddenFolders; }
            set { includeHiddenFolders = value; }
        }

        private bool multiline;

        public bool Multiline
        {
            get { return multiline; }
            set { multiline = value; }
        }
	
        private string encoding;

        public string Encoding
        {
            get { return encoding; }
            set { encoding = value; }
        }

        private string matchFiles;

        public string MatchFiles
        {
            get { return matchFiles; }
            set { matchFiles = value; }
        }
        private string notMatchFiles;

        public string NotMatchFiles
        {
            get { return notMatchFiles; }
            set 
            { 
                notMatchFiles = value;
                // ? -> .+?.+
                // * -> \w
                notMatchFileRegex = notMatchFiles.Replace(",", "|").Replace(".", "\\.").Replace("?", ".+?.+").Replace("*", "\\w");
            }
        }

        private string matchFolders;

        public string MatchFolders
        {
            get { return matchFolders; }
            set { matchFolders = value; }
        }

        private string notMatchFolders;

        public string NotMatchFolders
        {
            get { return notMatchFolders; }
            set 
            { 
                notMatchFolders = value;
                // ? -> .+?.+
                // * -> \w
                notMatchFolderRegex = notMatchFolders.Replace(",", "|").Replace(".", "\\.").Replace("?", ".+?.+").Replace("*", "\\w");
            }
        }

        private string notMatchFileRegex;
        public string NotMatchFileRegex
        {
            get { return notMatchFileRegex; }
            set { notMatchFileRegex = value; }
        }
        private string notMatchFolderRegex;
        public string NotMatchFolderRegex
        {
            get { return notMatchFolderRegex; }
            set { notMatchFolderRegex = value; }
        }

        public bool IsAutoEncoding { get { return encoding.Trim().ToLower() == "auto"; } }
        #endregion
    }

    /// <summary>
    /// Highlight Matched String
    /// </summary>
    internal class HighlightRenderer : BaseRenderer
    {
        public override void Render(Graphics g, Rectangle r)
        {
            // if selected, draw by default
            if (this.IsItemSelected && this.ListView.Focused)
            {
                base.Render(g, r);
            }
            else
            {
                ResultData data = (ResultData)this.RowObject;
                string strLeft = data.Line.Substring(0, (int)data.ColNo - 1);

                int leftWidth = CalculateTextWidth(g, strLeft);
                int matchedWidth = CalculateTextWidth(g, data.MatchedString);
                int rightWidth = CalculateTextWidth(g, data.Line.Substring((int)data.ColNo - 1 + data.MatchedString.Length));

                int space = (leftWidth + matchedWidth + rightWidth - CalculateTextWidth(g, data.Line)) / 3;
                leftWidth -= space;
                matchedWidth -= space * 2;

                Rectangle matchedRect = new Rectangle(r.X + leftWidth, r.Y, matchedWidth, r.Height);

                this.DrawBackground(g, r);
                using (Brush brush = new SolidBrush(Color.Yellow))
                {
                    g.FillRectangle(brush, matchedRect);
                }
                this.DrawText(g, r, data.Line);
            }
        }

        protected override void DrawTextGdi(Graphics g, Rectangle r, String txt)
        {
            Color backColor = Color.Transparent;
            if (this.IsDrawBackground && this.IsItemSelected && this.Column.Index == 0 && !this.ListView.FullRowSelect)
                backColor = this.GetTextBackgroundColor();

            TextFormatFlags flags = TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsTranslateTransform;
            TextRenderer.DrawText(g, txt, this.Font, r, this.GetForegroundColor(), backColor, flags);
        }

    }

    #endregion
}