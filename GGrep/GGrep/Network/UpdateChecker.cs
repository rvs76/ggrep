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

        public UpdateChecker()
        {
            bgw = new BackgroundWorker();
            bgw.WorkerSupportsCancellation = false;
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
        }

        public string getLatestVersion()
        {
            string version = "";

            bgw.RunWorkerAsync();

            return version;
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream st = null;

            try
            {
                request = (HttpWebRequest)System.Net.WebRequest.Create("http://code.google.com/p/ggrep/");






                // プロキシサーバー
                WebProxy proxy = new WebProxy("133.108.252.219", 8080);
                //プロキシ認証
                proxy.Credentials = new NetworkCredential("22264479", "norikaooo7");
                request.Proxy = proxy;





                request.Timeout = 3000;//単位：ミリ秒
                request.Method = "GET";

                response = (HttpWebResponse)request.GetResponse();
                st = response.GetResponseStream();

                using (StreamReader sr = new StreamReader(st, Encoding.UTF8))
                {
                    // コンテンツを受信
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


            MessageBox.Show(latest);
        }
    }
}
