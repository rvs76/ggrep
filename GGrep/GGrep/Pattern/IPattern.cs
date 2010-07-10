using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using GGrep.Instance;

namespace GGrep.Pattern
{
    interface IPattern
    {
        /// <summary>
        /// Search In Files
        /// </summary>
        /// <param name="path">File Or Directory</param>
        /// <param name="e">Event</param>
        /// <returns></returns>
        ArrayList SearchInFile(string path, DoWorkEventArgs e);

        /// <summary>
        /// Search in line
        /// </summary>
        /// <param name="line">txt</param>
        /// <param name="list">result data</param>
        /// <param name="path">file path</param>
        /// <param name="rowNo">row No.</param>
        /// <param name="encoding">encoding</param>
        string AnalyzeLine(string line, ArrayList list, string path, long rowNo, string encoding);

        /// <summary>
        /// Open File in Specific Editor
        /// </summary>
        /// <param name="data">result data</param>
        void OpenFileWithEditor(ResultData data);
    }
}
