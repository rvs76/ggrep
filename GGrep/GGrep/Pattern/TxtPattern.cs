using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Collections;

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
                StringBuilder sb = new StringBuilder();

                Encoding encoding = null;
                using (StreamReader sr = parent.Option.IsAutoEncoding ? Utils.OpenTextFile(path) : new StreamReader(File.OpenRead(path), Encoding.GetEncoding(parent.Option.Encoding)))
                {
                    encoding = sr.CurrentEncoding;
                    while (!sr.EndOfStream && parent.IsRunning)
                    {
                        if (parent.BGW.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                        line = sr.ReadLine();
                        rowNo++;

                        string s = AnalyzeLine(line, list, path, rowNo, sr.CurrentEncoding.EncodingName);
                        if (parent.IsReplace)
                        {
                            sb.AppendLine(s);
                        }
                    }

                    sr.Close();
                }

                // save file when replace
                if (parent.IsReplace)
                {
                    // TODO: save file
                    using (StreamWriter sw = new StreamWriter(path, false, encoding))
                    {
                        sw.Write(sb.ToString());
                        sw.Close();
                    }
                }

            }
            return list;
        }

    }
}
