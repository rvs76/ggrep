using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace GGrep
{
    class Utils
    {
        #region Methods

        /// <summary>
        /// Get escaped string of regex
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static string SearchStringRegexEscaped(string searchString)
        {
                string s = searchString;
                s = s.Replace("\\", "\\\\");
                s = s.Replace(".", "\\.");
                s = s.Replace("*", "\\*");
                s = s.Replace("+", "\\+");
                s = s.Replace("?", "\\?");
                s = s.Replace("{", "\\{");
                s = s.Replace("}", "\\}");
                s = s.Replace("[", "\\[");
                s = s.Replace("]", "\\]");
                s = s.Replace("(", "\\(");
                s = s.Replace(")", "\\)");
                s = s.Replace("^", "\\^");
                s = s.Replace("$", "\\$");
                s = s.Replace("-", "\\-");
                s = s.Replace("|", "\\|");
                s = s.Replace("/", "\\/");
                return s;
        }

        /// <summary>
        /// Get Matched Folders
        /// </summary>
        /// <param name="dir">Directory</param>
        /// <param name="option">Options</param>
        /// <returns></returns>
        public static ArrayList GetMatchedFolders(string dir, SearchOptions option)
        {
            ArrayList list = new ArrayList();
            string m = "*";
            if (!string.IsNullOrEmpty(option.MatchFolders))
            {
                m = option.MatchFolders;
            }
            foreach (string p in m.Split(','))
            {
                foreach (string f in Directory.GetDirectories(dir, p, SearchOption.TopDirectoryOnly))
                {
                    // not matched folders check
                    if (!string.IsNullOrEmpty(option.NotMatchFolderRegex))
                    {
                        if (!Regex.IsMatch(f, option.NotMatchFolderRegex))
                            continue;
                    }

                    DirectoryInfo di = new DirectoryInfo(f);
                    if (((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) && !option.IncludeHiddenFolders)
                        continue;

                    if (!list.Contains(f))
                        list.Add(f);
                }
            }

            return list;
        }

        /// <summary>
        /// Get Matched Files
        /// </summary>
        /// <param name="dir">directory</param>
        /// <param name="option">options</param>
        /// <param name="list">result file list</param>
        /// <param name="worker">thread</param>
        /// <param name="e">event</param>
        public static void GetMatchedFiles(string dir, SearchOptions option, ArrayList list, BackgroundWorker worker, DoWorkEventArgs e)
        {
            string m = "*";
            if (!string.IsNullOrEmpty(option.MatchFiles))
            {
                m = option.MatchFiles;
            }
            foreach (string p in m.Split(','))
            {
                foreach (string f in Directory.GetFiles(dir, p, SearchOption.TopDirectoryOnly))
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    // not matched files check
                    if (!string.IsNullOrEmpty(option.NotMatchFileRegex))
                    {
                        if (Regex.IsMatch(f, option.NotMatchFileRegex))
                            continue;
                    }

                    if (!list.Contains(f))
                        list.Add(f);
                }
            }
        }

        /// <summary>
        /// Get All files
        /// </summary>
        /// <param name="path">directory</param>
        /// <param name="option">options</param>
        /// <param name="fileList">result file list</param>
        /// <param name="worker">thread</param>
        /// <param name="e">event</param>
        public static void AnalyzeDirectory(string path, SearchOptions option, ArrayList fileList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (Directory.Exists(path))
            {
                if (option.IncludeSubFolders)
                {
                    // sub directory
                    foreach (string f_path in Utils.GetMatchedFolders(path, option))
                    {
                        AnalyzeDirectory(f_path, option, fileList, worker, e);
                    }
                }

                // file
                Utils.GetMatchedFiles(path, option, fileList, worker, e);
            }
        }

        #endregion
    }
}
