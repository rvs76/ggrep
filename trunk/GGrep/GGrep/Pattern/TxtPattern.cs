using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace GGrep.Pattern
{
    class TxtPattern : BasePattern, IPattern
    {
        public TxtPattern(GForm _parent)
        {
            parent = _parent;
        }

        /// <summary>
        /// Search In Files
        /// </summary>
        /// <param name="path">File Or Directory</param>
        /// <param name="e">Event</param>
        /// <returns>Result</returns>
        public ArrayList SearchInFile(string path, DoWorkEventArgs e)
        {
            ArrayList list = new ArrayList();
            if (File.Exists(path))
            {
                long rowNo = 0;
                string line;
                string newLine = string.Empty;

                Encoding encoding = null;
                using (StreamReader sr = parent.Option.IsAutoEncoding ? Utils.OpenTextFile(path) : new StreamReader(File.OpenRead(path), Encoding.GetEncoding(parent.Option.Encoding)))
                {
                    encoding = sr.CurrentEncoding;

                    if (!parent.IsReplace)
                    {
                        // Grep Mode

                        while (!sr.EndOfStream && parent.IsRunning)
                        {
                            if (parent.BGW.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            line = sr.ReadLine();
                            rowNo++;

                            AnalyzeLine(line, list, path, rowNo, sr.CurrentEncoding.EncodingName, GetRegex());
                        }
                    }
                    else
                    {
                        // Replace Mode

                        line = sr.ReadToEnd();

                        Regex regex = GetRegex();
                        int cnt = 0;
                        newLine = string.Empty;

                        if ((cnt = regex.Matches(line).Count) > 0)
                        {
                            parent.Status.MatchedFiles++;
                            parent.Status.Hit += cnt;
                            newLine = regex.Replace(line, parent.Option.ReplaceString);
                        }
                    }

                    sr.Close();
                }

                // save file when replace
                if (parent.IsReplace && !string.IsNullOrEmpty(newLine))
                {
                    // TODO: save file
                    using (StreamWriter sw = new StreamWriter(path, false, encoding))
                    {
                        sw.Write(newLine);
                        sw.Close();
                    }
                }

            }
            return list;
        }

    }
}
