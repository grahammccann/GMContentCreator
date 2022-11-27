using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gm_content_creator
{
    internal class ClassArticleSourceABC
    {
        public string searchUrl = "";

        /// <summary>
        /// This function gets the HTML of the webpage.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetRawHtmlAsync()
        {
            string html = string.Empty;
            try {
                using HttpClient client = new();
                using HttpResponseMessage response = await client.GetAsync(searchUrl);
                using HttpContent content = response.Content;

                html = await content.ReadAsStringAsync();

                HtmlAgilityPack.HtmlDocument doc = new();
                doc.LoadHtml(html);

                if (html != null && html.Length >= 50)
                {
                    return html;
                }
            }
            catch (Exception ex)
            {
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
            return html;
        }

        /// <summary>
        /// This function extracts all the URLs of the search results.
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static List<string> GetUrlsFromTheSearch(string html) {
            var allExtractedUrls = new List<string>();
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new();
                doc.LoadHtml(html);

                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@class='companyname']"))
                {
                    allExtractedUrls.Add(link.InnerText);
                }

            }
            catch (Exception ex)
            {
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
            return allExtractedUrls;
        }

        public static string GetArticleTitleAndBodyAndSaveToFile() {
            try
            {
                // At this pont we should extract and spin the title & body before saving to file
                // each article must be saved to it's own .txt file.
            }
            catch (Exception ex)
            {
                Helpers.DebugLogging($"[{DateTime.Now}]-[{ex}]");
            }
        }


    }
}
