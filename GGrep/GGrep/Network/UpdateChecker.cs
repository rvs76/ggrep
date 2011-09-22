using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace GGrep.Network
{
    class UpdateChecker
    {
        private BackgroundWorker bgw = null;
        const string PREFIX = "GGrep_v";
        const string SUFFIX = ".zip";
        bool isAuto = false;

        public UpdateChecker(bool _auto)
        {
            isAuto = _auto;
            bgw = new BackgroundWorker();
            bgw.WorkerSupportsCancellation = false;
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
        }

        public void check()
        {
            bgw.RunWorkerAsync();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream st = null;

            try
            {
                request = (HttpWebRequest)System.Net.WebRequest.Create(Properties.Settings.Default.HomeURL);

                request.Timeout = 3000;//milli seconds
                request.Method = "GET";

                request.Proxy = WebRequest.DefaultWebProxy;
                request.Proxy.Credentials = CredentialCache.DefaultCredentials;

                response = (HttpWebResponse)request.GetResponse();
                st = response.GetResponseStream();

                using (StreamReader sr = new StreamReader(st, Encoding.UTF8))
                {
                    string body = sr.ReadToEnd();
                    int start = body.IndexOf(PREFIX);
                    if (start >= 0)
                    {
                        start += PREFIX.Length;
                        int end = body.IndexOf(SUFFIX, start);
                        if (end > start)
                        {
                            e.Result = body.Substring(start, (end - start));
                        }
                    }
                }
            }
            finally
            {
                if (st != null)
                {
                    try
                    {
                        st.Close();
                    }
                    catch { }
                    st = null;
                }
                if (response != null)
                {
                    try
                    {
                        response.Close();
                    }
                    catch { }
                    response = null;
                }
                if (request != null)
                {
                    request = null;
                }
            }
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string latest = e.Result.ToString();

            if (latest == Utils.Version)
            {
                if (!isAuto)
                {
                    Utils.ShowMessage(null, 3, string.Format(Properties.Resources.MSG_INFO_01, latest));
                }
            }
            else
            {
                DialogResult dr = Utils.ShowMessage(null, 4, string.Format(Properties.Resources.MSG_CONFIRM_01, latest));
                if (dr == DialogResult.Yes)
                {
                    // open url
                    try
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = Properties.Settings.Default.HomeURL;
                        proc.Start();
                    }
                    catch { }
                }
            }
        }
    }
}
