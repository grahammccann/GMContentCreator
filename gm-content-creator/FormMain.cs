using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        public async Task GetARandomArticleForTestingAsync() {
            try
            {
                string html = string.Empty;

                using (HttpClient client = new())
                using (HttpResponseMessage response = await client.GetAsync("https://www.articleseen.com/Article_Tips-for-Choosing-the-Best-Car-Battery-Supplier_330400.aspx"))
                using (HttpContent content = response.Content)
                {
                    // Read the string.
                    string result = await content.ReadAsStringAsync();

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(result);

                    // Display the result.
                    if (result != null && result.Length >= 50)
                    {
                        TxtBoxArticleTitle.Text = doc.DocumentNode.SelectSingleNode("//table[@id='tblDetails']/tr/td/h3").InnerText.Trim().ToUpper();
                        RichTextBoxArticleBody.Text = doc.DocumentNode.SelectSingleNode("//span[@class='Bodycontent']").InnerText;
                   }
                }

                Helpers.ReturnMessage("Random article downloaded for testing!");
            } catch (Exception ex) {
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
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
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
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
                Helpers.ReturnMessage(string.Format("Thread error: {0} ", e.Error));
            }
            else
            {
                Helpers.ReturnMessage("Import complete!");
            }
        }


        private void BackgroundWorkerSpinTax_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((string)e.Argument == "do_spintax")
            {
                var rows = DataGridSynonymsView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[0].Value.ToString());
                TxtBoxArticleTitle.Text = Helpers.ReplaceWordsWithSynonyms(TxtBoxArticleTitle.Text, rows).ToUpper();
                RichTextBoxArticleBody.Text = Helpers.ReplaceWordsWithSynonyms(RichTextBoxArticleBody.Text, rows);
            }
        }

        public void BackgroundWorkerSpinTax_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Helpers.ReturnMessage(string.Format("Thread error: {0} ", e.Error));
            }
            else
            {
                BtnSpin.Enabled = true;
                Helpers.HighlightSpintaxText(RichTextBoxArticleBody);
            }
        }

        private void DownloadARandomArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = GetARandomArticleForTestingAsync();
        }

        private void BtnLoadSynonymsFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxSynonymFile.Text)) {
                Helpers.ReturnMessage("Please select a synonyms file to load!");
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
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            if (DataGridSynonymsView.RowCount < 1)
            {
                Helpers.ReturnMessage("Please load a synonyms file first!");
                return;
            }

            if (TxtBoxArticleTitle.TextLength < 1 || RichTextBoxArticleBody.TextLength < 1)
            {
                Helpers.ReturnMessage("Please load an article to be spun first!");
                return;
            }

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
                Helpers.ReturnMessage("No article data to export!");
                return;
            }

            if (string.IsNullOrEmpty(TxtBoxKeyword.Text)) {
                Helpers.ReturnMessage("Enter a keyword related to your article!");
                return;
            }

            try {
                if (!Directory.Exists(@"articles\" + TxtBoxKeyword.Text))
                {
                    Directory.CreateDirectory(@"articles\" + TxtBoxKeyword.Text);
                    File.WriteAllText(@"articles\" + TxtBoxKeyword.Text + "\\article.txt", TxtBoxArticleTitle.Text + Environment.NewLine + Environment.NewLine + RichTextBoxArticleBody.Text);
                    Helpers.ReturnMessage(@"articles\" + TxtBoxKeyword.Text + "\\article.txt");
                }
                else
                {
                    File.WriteAllText(@"articles\" + TxtBoxKeyword.Text + "\\article.txt", TxtBoxArticleTitle.Text + Environment.NewLine + Environment.NewLine + RichTextBoxArticleBody.Text);
                    Helpers.ReturnMessage(@"articles\" + TxtBoxKeyword.Text + "\\article.txt");
                }
            }
            catch (Exception ex)
            {
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }            
        }

        private void BtnSourceArticleContent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxKeyword.Text))
            {
                Helpers.ReturnMessage("Enter a keyword related to your article!");
                return;
            }

            ClassArticleSourceABC source = new()
            {
                searchUrl = "https://article.abc-directory.com/search/" + TxtBoxKeyword.Text
            };
        }

    }
}