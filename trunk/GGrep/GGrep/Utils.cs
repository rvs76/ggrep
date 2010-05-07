using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;
using GGrep.Instance;
using System.Security.Principal;

namespace GGrep
{
    class Utils
    {
        #region Methods

        /// <summary>
        /// Get Language present
        /// </summary>
        /// <returns></returns>
        public static string GetAppLang()
        {
            string lang = Properties.Settings.Default.Language;
            if (string.IsNullOrEmpty(lang))
            {
                lang = "en-US";
            }
            return lang;
        }

        /// <summary>
        /// Is Administrator
        /// </summary>
        public static bool IsAdministrators
        {
            get
            {
                WindowsIdentity wi = WindowsIdentity.GetCurrent();
                WindowsPrincipal wp = new WindowsPrincipal(wi);

                return wp.IsInRole("Administrators");
            }
        }

        /// <summary>
        /// Creates a stream reader from a stream and detects
        /// the encoding form the first bytes in the stream
        /// </summary>
        /// <param name="path">path to the file</param>
        /// <returns>the newly created StreamReader</returns>
        public static StreamReader OpenTextFile(String path)
        {

            if (path == null)
                throw new ArgumentNullException("path");

            Stream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            // check stream parameter
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanSeek)
                throw new ArgumentException("the stream must support seek operations", "stream");

            Encoding detectedEncoding = null;

            byte[] buf = null;

            int count = 1;

            // try 3 times to detect encode, increase the length of detected bytes
            while (detectedEncoding == null && count <= 3)
            {
                // seek to stream start
                stream.Seek(0, SeekOrigin.Begin);
                // buffer for preamble and up to 512b sample text for dection
                buf = new byte[System.Math.Min(stream.Length, 512 * count)];
                stream.Read(buf, 0, buf.Length);

                detectedEncoding = GetCode(buf);

                // if length of stream is less than request, break
                if (stream.Length < 512 * count)
                    break;

                count++;
            }

            // if not found at last, use mlanguage to detect
            if (detectedEncoding == null)
            {
                // seek to stream start
                stream.Seek(0, SeekOrigin.Begin);
                // buffer for preamble and up to 512b sample text for dection
                buf = new byte[System.Math.Min(stream.Length, 512)];

                detectedEncoding = EncodingTools.DetectInputCodepage(buf);
            }

            // seek back to stream start
            stream.Seek(0, SeekOrigin.Begin);

            return new StreamReader(stream, detectedEncoding);

        }

        /// <summary>
        /// 文字コードを判別する
        /// </summary>
        /// <remarks>
        /// Jcode.pmのgetcodeメソッドを移植したものです。
        /// Jcode.pm(http://openlab.ring.gr.jp/Jcode/index-j.html)
        /// </remarks>
        /// <param name="byts">文字コードを調べるデータ</param>
        /// <returns>適当と思われるEncodingオブジェクト。
        /// 判断できなかった時はnull。</returns>
        public static System.Text.Encoding GetCode(byte[] byts)
        {

            const byte bESC = 0x1B;
            const byte bAT = 0x40;
            const byte bDollar = 0x24;
            const byte bAnd = 0x26;
            const byte bOP = 0x28;    //(
            const byte bB = 0x42;
            const byte bD = 0x44;
            const byte bJ = 0x4A;
            const byte bI = 0x49;

            int len = byts.Length;
            int binary = 0;
            int ucs2 = 0;
            int sjis = 0;
            int euc = 0;
            int utf8 = 0;
            byte b1, b2;

            for (int i = 0; i < len; i++)
            {
                if (byts[i] <= 0x06 || byts[i] == 0x7F || byts[i] == 0xFF)
                {
                    //'binary'
                    binary++;
                    if (len - 1 > i && byts[i] == 0x00
                        && i > 0 && byts[i - 1] <= 0x7F)
                    {
                        //smells like raw unicode
                        ucs2++;
                    }
                }
            }

            if (binary > 0)
            {
                if (ucs2 > 0)
                    //JIS
                    //ucs2(Unicode)
                    return System.Text.Encoding.Unicode;
                else
                    //binary
                    return null;
            }

            for (int i = 0; i < len - 1; i++)
            {
                b1 = byts[i];
                b2 = byts[i + 1];

                if (b1 == bESC)
                {
                    if (b2 >= 0x80)
                        //not Japanese
                        //ASCII
                        return System.Text.Encoding.ASCII;
                    else if (len - 2 > i &&
                        b2 == bDollar && byts[i + 2] == bAT)
                        //JIS_0208 1978
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    else if (len - 2 > i &&
                        b2 == bDollar && byts[i + 2] == bB)
                        //JIS_0208 1983
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    else if (len - 5 > i &&
                        b2 == bAnd && byts[i + 2] == bAT && byts[i + 3] == bESC &&
                        byts[i + 4] == bDollar && byts[i + 5] == bB)
                        //JIS_0208 1990
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    else if (len - 3 > i &&
                        b2 == bDollar && byts[i + 2] == bOP && byts[i + 3] == bD)
                        //JIS_0212
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    else if (len - 2 > i &&
                        b2 == bOP && (byts[i + 2] == bB || byts[i + 2] == bJ))
                        //JIS_ASC
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    else if (len - 2 > i &&
                        b2 == bOP && byts[i + 2] == bI)
                        //JIS_KANA
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                }
            }

            for (int i = 0; i < len - 1; i++)
            {
                b1 = byts[i];
                b2 = byts[i + 1];
                if (((b1 >= 0x81 && b1 <= 0x9F) || (b1 >= 0xE0 && b1 <= 0xFC)) &&
                    ((b2 >= 0x40 && b2 <= 0x7E) || (b2 >= 0x80 && b2 <= 0xFC)))
                {
                    sjis += 2;
                    i++;
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                b1 = byts[i];
                b2 = byts[i + 1];
                if (((b1 >= 0xA1 && b1 <= 0xFE) && (b2 >= 0xA1 && b2 <= 0xFE)) ||
                    (b1 == 0x8E && (b2 >= 0xA1 && b2 <= 0xDF)))
                {
                    euc += 2;
                    i++;
                }
                else if (len - 2 > i &&
                    b1 == 0x8F && (b2 >= 0xA1 && b2 <= 0xFE) &&
                    (byts[i + 2] >= 0xA1 && byts[i + 2] <= 0xFE))
                {
                    euc += 3;
                    i += 2;
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                b1 = byts[i];
                b2 = byts[i + 1];
                if ((b1 >= 0xC0 && b1 <= 0xDF) && (b2 >= 0x80 && b2 <= 0xBF))
                {
                    utf8 += 2;
                    i++;
                }
                else if (len - 2 > i &&
                    (b1 >= 0xE0 && b1 <= 0xEF) && (b2 >= 0x80 && b2 <= 0xBF) &&
                    (byts[i + 2] >= 0x80 && byts[i + 2] <= 0xBF))
                {
                    utf8 += 3;
                    i += 2;
                }
            }

            if (euc > sjis && euc > utf8)
                //EUC
                return System.Text.Encoding.GetEncoding(51932);
            else if (sjis > euc && sjis > utf8)
                //SJIS
                return System.Text.Encoding.GetEncoding(932);
            else if (utf8 > euc && utf8 > sjis)
                //UTF8
                return System.Text.Encoding.UTF8;

            return null;
        }

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
                        if (Regex.IsMatch(f, option.NotMatchFolderRegex, RegexOptions.IgnoreCase))
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
                        if (Regex.IsMatch(f, option.NotMatchFileRegex, RegexOptions.IgnoreCase))
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
