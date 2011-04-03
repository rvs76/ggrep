using System;
using System.Collections.Generic;
using System.Text;
using GGrep.Pattern;

namespace GGrep.Instance
{
    class ResultData
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
        private long showColNo;

        public long ShowColNo
        {
            get { return showColNo; }
            set { showColNo = value; }
        }

        private string line;

        public string Line
        {
            get { return line; }
            set { line = value; }
        }

        private string showLine;

        public string ShowLine
        {
            get { return showLine; }
            set { showLine = value; }
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
}
