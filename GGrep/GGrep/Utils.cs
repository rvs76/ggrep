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
        public static System.Text.Encoding GetEncoding(string filePath)
        {
            System.Text.Encoding enc = null;
            using (System.IO.FileStream file = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                if (file.CanSeek)
                {
                    byte[] bom = new byte[4]; // Get the byte-order mark, if there is one
                    file.Read(bom, 0, 4);
                    enc = href.Utils.EncodingTools.DetectInputCodepage(bom);
                }
                else
                {
                    // The file cannot be randomly accessed, so you need to decide what to set the default to
                    // based on the data provided. If you're expecting data from a lot of older applications,
                    // default your encoding to Encoding.ASCII. If you're expecting data from a lot of newer
                    // applications, default your encoding to Encoding.Unicode. Also, since binary files are
                    // single byte-based, so you will want to use Encoding.ASCII, even though you'll probably
                    // never need to use the encoding then since the Encoding classes are really meant to get
                    // strings from the byte array that is the file.

                    enc = System.Text.Encoding.ASCII;
                }

                // Close the file: never forget this step!
                file.Close();
            }
            return enc;
        }

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

        public static void GetMatchedFiles(BackgroundWorker worker, DoWorkEventArgs e, string dir, SearchOptions option, ArrayList list)
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
                Utils.GetMatchedFiles(worker, e, path, option, fileList);
            }
        }
    }
}
