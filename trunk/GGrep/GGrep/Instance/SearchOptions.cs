using System;
using System.Collections.Generic;
using System.Text;

namespace GGrep.Instance
{
    public class SearchOptions
    {
        #region Properties
        private string searchString;

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }

        private string replaceString;

        public string ReplaceString
        {
            get { return replaceString; }
            set { replaceString = value; }
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
}
