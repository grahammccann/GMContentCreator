using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gm_content_creator
{
    internal class ClassHelpers
    {

        public const string SOFTWARE = "GM Content Creator";

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

    }
}
