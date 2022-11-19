using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gm_content_creator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void GetARandomArticleForTesting() {
            try
            {
                string html = string.Empty;
                using (WebClient wc = new WebClient())
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(wc.DownloadString("https://www.articleseen.com/Article_Invisible-Braces-A-Comprehensive-Guide_330330.aspx"));
                    TxtBoxArticleTitle.Text = doc.DocumentNode.SelectSingleNode("//table[@id='tblDetails']/tr/td/h3").InnerText.Trim();
                    RichTextBoxArticleBody.Text = doc.DocumentNode.SelectSingleNode("//span[@class='Bodycontent']").InnerText;
                }
                ClassHelpers.ReturnMessage("Random article downloaded for testing!");
            } catch (Exception ex) {
                ClassHelpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
        }

        public void OnLoadSetup(string appName) {
            try {
                Text = appName + " - v" + Application.ProductVersion + @" - graham23s@Hotmail.com";
                ComboBoxSynonymFile.Items.AddRange(Directory.GetFiles(@"synonyms"));
                ComboBoxSynonymFile.SelectedIndex = 0;
                if (!Directory.Exists("logs")) { Directory.CreateDirectory("logs"); }
                if (!Directory.Exists("articles")) { Directory.CreateDirectory("articles"); }
            }
            catch (Exception ex)
            {
                ClassHelpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OnLoadSetup("GM Content Creator");
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BackgroundWorkerImportSynonymsFile_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((string)e.Argument == "do_import_synonyms_file") {
                string[] synFile = File.ReadAllLines(ComboBoxSynonymFile.Text);
                foreach (string synEntry in synFile)
                {
                    DataGridSynonymsView.Rows.Add(synEntry);
                }
            }
        }

        public void BackgroundWorkerImportSynonymsFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ClassHelpers.ReturnMessage(string.Format("Thread error: {0} ", e.Error));
            }
            else
            {
                ClassHelpers.ReturnMessage("Import complete!");
                DataGridSynonymsView.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void downloadARandomArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetARandomArticleForTesting();
        }

        private void BtnLoadSynonymsFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxSynonymFile.Text)) {
                ClassHelpers.ReturnMessage("Please select a synonyms file to load!");
                return;
            }

            try
            {
                BtnLoadSynonymsFile.Enabled = false;
                DataGridSynonymsView.Rows.Clear();
                string[] synFile = File.ReadAllLines(ComboBoxSynonymFile.Text);
                foreach (string synEntry in synFile)
                {
                    DataGridSynonymsView.Rows.Add(synEntry);
                }
                BtnLoadSynonymsFile.Enabled = true;
            }
            catch (Exception ex)
            {
                ClassHelpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
        }

    }
}
