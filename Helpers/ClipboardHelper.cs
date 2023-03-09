using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hemligheter.Helpers
{
    public static class ClipboardHelper
    {
        public static string GetKvLinkFromClipboard()
        {
            IDataObject iData = new DataObject();

            try
            {
                iData = Clipboard.GetDataObject();
            }
            catch (System.Runtime.InteropServices.ExternalException externEx)
            {
                Debug.WriteLine("InteropServices.ExternalException: {0}", externEx.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

            if (iData.GetDataPresent(DataFormats.Text))
            {
                var text = (string)iData.GetData(DataFormats.Text);
                if (text?.StartsWith("kv://") ?? false) return text;
            }

            return null;
        }

        public static void SetClipboardData(string value)
        {
            Clipboard.SetText(value);
        }
    }
}
