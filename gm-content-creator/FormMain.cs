using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static gm_content_creator.SpinTax;

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
                using (WebClient wc = new())
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(wc.DownloadString("https://www.articleseen.com/Article_5-Tips-to-Prepare-Your-Air-Conditioner-for-Christmas-(Summer)_330327.aspx"));
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
                if (!Directory.Exists("logs")) { Directory.CreateDirectory("logs"); }
                Text = appName + " - v" + Application.ProductVersion + @" - graham23s@Hotmail.com";
                ComboBoxSynonymFile.Items.AddRange(Directory.GetFiles(@"synonyms"));
                ComboBoxSynonymFile.SelectedIndex = 0;
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
            }
        }


        private void BackgroundWorkerSpinTax_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((string)e.Argument == "do_spintax")
            {
                CreateSpinTax(TxtBoxArticleTitle, RichTextBoxArticleBody, DataGridSynonymsView);
            }
        }

        public void BackgroundWorkerSpinTax_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ClassHelpers.ReturnMessage(string.Format("Thread error: {0} ", e.Error));
            }
            else
            {
                BtnSpin.Enabled = true;
                ClassHelpers.ReturnMessage("TITLE:\n\n" + ClassHelpers.CountSpintaxBraces(TxtBoxArticleTitle.Text, '{').ToString() + " > " + ClassHelpers.CountSpintaxBraces(TxtBoxArticleTitle.Text, '}').ToString());
                ClassHelpers.ReturnMessage("BODY:\n\n" + ClassHelpers.CountSpintaxBraces(RichTextBoxArticleBody.Text, '{').ToString() + " > " + ClassHelpers.CountSpintaxBraces(RichTextBoxArticleBody.Text, '}').ToString());
            }
        }

        private void DownloadARandomArticleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            if (BackgroundWorkerSpinTax.IsBusy != true)
            {
                BtnSpin.Enabled = false;
                BackgroundWorkerSpinTax.RunWorkerAsync("do_spintax");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopyTextToTheClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RichTextBoxArticleBody.SelectedText);
        }

        private void PasteTextFromTheClipboard_Click(object sender, EventArgs e)
        {
            RichTextBoxArticleBody.Paste();
        }

        private void BtnExportArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxArticleTitle.Text) || string.IsNullOrEmpty(RichTextBoxArticleBody.Text)) {
                ClassHelpers.ReturnMessage("No article data to export!");
                return;
            }

            if (string.IsNullOrEmpty(TxtBoxKeyword.Text)) {
                ClassHelpers.ReturnMessage("Enter a keyword related to your article!");
                return;
            }

            try {
                if (!Directory.Exists(@"articles\" + TxtBoxKeyword.Text))
                {
                    Directory.CreateDirectory(@"articles\" + TxtBoxKeyword.Text);
                }
                else
                {
                    File.WriteAllText(@"articles\" + TxtBoxKeyword.Text + "\\article.txt", TxtBoxArticleTitle.Text + Environment.NewLine + Environment.NewLine + RichTextBoxArticleBody.Text);
                    ClassHelpers.ReturnMessage(@"articles\" + TxtBoxKeyword.Text + "\\article.txt");
                }
            }
            catch (Exception ex)
            {
                ClassHelpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }            
        }

    }
}