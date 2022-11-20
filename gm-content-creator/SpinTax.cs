using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace gm_content_creator
{
    internal static class SpinTax
    {
        public static void CreateSpinTax(TextBox titleBox, RichTextBox bodyBox, DataGridView synonymsView)
        {
            if (synonymsView.RowCount < 1)
            {
                ClassHelpers.ReturnMessage("Please load a synonyms file first!");
                return;
            }

            if (titleBox.TextLength < 1 || bodyBox.TextLength < 1)
            {
                ClassHelpers.ReturnMessage("Please load an article first!");
                return;
            }

            var inputs = synonymsView.Rows
                .Cast<DataGridViewRow>().Select(s => (string)s.Cells[0].Value);
            var synonyms = Collect(inputs);

            titleBox.Text = CreateSpinTax(synonyms, titleBox.Text);
            bodyBox.Text = CreateSpinTax(synonyms, bodyBox.Text);
        }

        private static (string Key, string Value)[] Collect(IEnumerable<string> synonyms)
        {
            var dict = new Dictionary<string, string>();
            foreach (var synonym in synonyms)
            {
                var parts = synonym.Split('|');
                foreach (var part in parts)
                    dict[part] = synonym;
            }
            return dict
                .Select(d => (d.Key, d.Value))
                .OrderBy(d => d.Key.Length)
                .ToArray();
        }

        private static string CreateSpinTax((string Key, string Value)[] synonyms, string text)
        {
            var writer = new StringWriter();
            const StringComparison o = StringComparison.InvariantCultureIgnoreCase;
            const char nl = '\n';
            foreach (var original in text.Split(nl))
            {
                var line = original;
                var allReplaces = new Dictionary<int, (int begin, int end, string key, string val)>();
                foreach (var (raw, val) in synonyms)
                {
                    if (raw.Length < 2)
                        continue;
                    var key = $" {raw} ";
                    var begin = line.IndexOf(key, o);
                    if (begin >= 0)
                    {
                        var end = begin + key.Length;
                        allReplaces[begin] = (begin, end, key, val);
                    }
                }
                var replaces = new Dictionary<int, (int begin, int end, string key, string val)>();
                foreach (var tuple in allReplaces)
                {
                    if (allReplaces.Any(r =>
                            (r.Value.begin < tuple.Value.begin &&
                             r.Value.end >= tuple.Value.end) ||
                            (r.Value.begin <= tuple.Value.begin &&
                             r.Value.end > tuple.Value.end)
                        ))
                        continue;
                    replaces[tuple.Key] = tuple.Value;
                }
                foreach (var (_, (begin, end, _, val)) in replaces
                             .OrderByDescending(r => r.Value.begin))
                {
                    line = $"{line[..(begin + 1)]}{{{val}}}{line[(end - 1)..]}";
                }
                writer.Write(line + nl);
            }
            return writer.ToString().Trim();
        }

    }
}