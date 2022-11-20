using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace gm_content_creator
{
    internal class ClassHelpers
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
    }
}