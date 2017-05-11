using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Linq;

namespace RegexFun
{
    public partial class Form1 : Form
    {
        Regex HTMLRegex = new Regex(@"<a.*?href=[""'](?<url>[^""^']+[.]*?)[""'].*?>(?<keywords>[^<]+[.]*?)</a>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex userRegex;
        public Form1()
        {
            InitializeComponent();
        }

        private void URLAnalyzeButton_Click(object sender, EventArgs e)
        {
            if (userRegexTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите регулярное выражение");
                return;
            }
            string baseURL = textBox1.Text;
            string[] userURL = new string[] { baseURL };
            List<string> visitedURLs = new List<string>();
            Dictionary<string, string> links = new Dictionary<string, string>();
            WebClient client = new WebClient();

            for (int depth = 1; depth <= numericUpDown1.Value; depth++)
            {
                List<string> newURLs = new List<string>();

                for (int domainNumber = 0; domainNumber < userURL.Length; domainNumber++)
                {
                    try
                    {
                        string htmlCode = client.DownloadString(userURL[domainNumber]);
                        AddMatches(htmlCode, baseURL, userURL[domainNumber], newURLs, visitedURLs, links, HTMLRegex);
                    }
                    catch (Exception)
                    {

                    }
                }
                visitedURLs.AddRange(newURLs);
                userURL = newURLs.ToArray();
            }
            analyzeAndPrintResults(links.Keys.ToList());
        }

        private void FileAnalyzeBtn_Click(object sender, EventArgs e)
        {
            if (userRegexTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите регулярное выражение");
                return;
            }

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter += "HTML|*.htm?";
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string currentURL = fileDialog.SafeFileName;

            Dictionary<string, string> links = new Dictionary<string, string>();

            using (TextReader reader = new StreamReader(fileDialog.FileName))
            {
                string htmlCode = reader.ReadToEnd();
                List<string> newURLs = new List<string>();
                List<string> visitedURLs = new List<string>();
                AddMatches(htmlCode, "", currentURL, newURLs, visitedURLs, links, HTMLRegex);
            }

            analyzeAndPrintResults(links.Keys.ToList());
        }

        private void analyzeAndPrintResults(List<string> linksList)
        {
            userRegex = new Regex(userRegexTextBox.Text, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            List<string> linksUserList = new List<string>();
            foreach (String item in linksList)
            {
                if (userRegex.Matches(item).Count > 0)
                {
                    linksUserList.Add(item);
                }
            }
            resultMemo.AppendText("Введенным регулярным выражением найдено " + linksUserList.Count + " URL из " + linksList.Count + "\r\n");
            resultMemo.AppendText("Не найденные url:" + "\r\n");
            foreach (String url in linksList.Except(linksUserList).ToList())
            {
                resultMemo.AppendText(url + "\r\n");
            }

        }

        private void AddMatches(string html, string baseURL, string currentURL, List<string> newURLs, List<string> visitedURLs, Dictionary<string, string> links, Regex regex)
        {
            MatchCollection matches = regex.Matches(html);
            foreach (Match item in matches)
            {
                string url = item.Groups["url"].Value;
                if (!url.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (String.IsNullOrEmpty(baseURL))
                    {
                        continue;
                    }
                    else
                    {
                        url = baseURL + url;
                    }
                }
                int index = url.IndexOf('/', 9);
                if (index == -1)
                {
                    index = url.IndexOf('?', 9);
                }
                if (index == -1)
                {
                    index = url.IndexOf('#', 9);
                }
                if (!newURLs.Contains(url) && !url.EndsWith(".pdf") && !visitedURLs.Contains(url))
                {
                    newURLs.Add(url);
                }
                url = new String(url.ToCharArray(), 0, index == -1 ? url.Length : index);
                if (!links.ContainsKey(url))
                {
                    links.Add(url, item.Groups["keywords"].Value);
                }
            }
        }

    }
}
