using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace gm_content_creator
{
    internal class Helpers
    {
        public const string SOFTWARE = "GM Content Creator";

        /// <summary>
        /// This function displays messages to the user in a generic way.
        /// </summary>
        /// <param name="message"></param>
        public static void ReturnMessage(string message)
        {
            MessageBox.Show(message, SOFTWARE + " - v" + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This function simply writes debugging info to a .txt file.
        /// </summary>
        /// <param name="error"></param>
        public static void DebugLogging(string error)
        {
            try
            {
                File.AppendAllText(@"logs\debug.log", error + Environment.NewLine);
            }
            catch (Exception ex)
            {
                DebugLogging("[" + DateTime.Now + "]-[" + ex.ToString() + "]");
            }
        }

        /// <summary>
        /// This function will count the number of times a character is found.
        /// </summary>
        /// <param name="sourceToCount"></param>
        /// <param name="characterToCount"></param>
        /// <returns></returns>
        public static int CountSpintaxBraces(string sourceToCount, char characterToCount) {
            int count = 0;
            try
            {
                count = sourceToCount.Count(f => f == characterToCount);
            }
            catch (Exception ex)
            {
                DebugLogging("[" + DateTime.Now + "]-[" + ex.ToString() + "]");
            }
            return count;
        }

        /// <summary>
        /// This function will highlight the spintax code green.
        /// </summary>
        /// <param name="richTextBox"></param>
        public static void HighlightSpintaxText(RichTextBox richTextBox)
        {
            var regex = new Regex(@"[{]([^}])+", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
            var originalText = richTextBox.Text;
            var matches = regex.Matches(richTextBox.Text);
            var index = 0;
            foreach (Match m in matches)
            {
                if (m.Success)
                {
                    index = originalText.IndexOf(m.Value, index) + 1;
                    if (index != -1)
                    {
                        richTextBox.Select(index, m.Value.Length - 1);
                        richTextBox.SelectionColor = Color.DarkGreen;
                    }
                }
            }
        }

        /// <summary>
        /// This function replaces article words with spintax from the synonyms file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="synonymsInline"></param>
        /// <returns></returns>
        public static string ReplaceWordsWithSynonyms(string text, IEnumerable<string> synonymsInline)
        {

            HashSet<char> punctuationSet = new() { ',', '.', '!', '?', ':' }; // trailing characters to preserve

            StringBuilder newText = new();

            foreach (var word in text.Split(' '))
            {
                string punctuation = "";
                string newWord;

                if (punctuationSet.Contains(word.LastOrDefault()))
                {
                    punctuation = word[word.Length - 1].ToString();
                    newWord = word.Substring(0, word.Length - 1); // trim the punctation sign from the end
                }
                else
                {
                    newWord = word;
                }

                foreach (var line in synonymsInline)
                {
                    string[] synonyms = line.Split('|');
                    if (synonyms.Select(x => x.ToLower()).Contains(newWord.ToLower()))
                    {
                        newWord = $"{{{line}}}{punctuation}";
                        break;
                    }
                }
                newText.Append(newWord + ' ');
            }
            return newText.ToString();
        }

    }
}