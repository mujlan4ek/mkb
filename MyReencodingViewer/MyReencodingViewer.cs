using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyReencodingViewer
{
    public partial class MyReencodingViewer : Form
    {
        private List<int> _codepages = new List<int>();

        public MyReencodingViewer()
        {
            InitializeComponent();

            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                Encoding e = ei.GetEncoding();

                if (e.EncodingName.Contains("Кир") || e.EncodingName.Contains("Cyr") || e.EncodingName.Contains("UTF"))
                {
                    cmbCyrEncodings.Items.Add(e.CodePage + " - " + e.EncodingName);
                    _codepages.Add(e.CodePage);
                }

            }
            int lastEncoding = Properties.Settings.Default.LAST_ENCODING;
            cmbCyrEncodings.SelectedIndex = (lastEncoding < cmbCyrEncodings.Items.Count) ? lastEncoding : 0;
        }

         private void MyКeencodingViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.LAST_ENCODING = cmbCyrEncodings.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdTextFile.ShowDialog() == DialogResult.Cancel)
                return;

            tbTextFile.Text = ofdTextFile.FileName;
        }

        private void ReloadTextFile(object sender, EventArgs e)
        {
            if (tbTextFile.Text != "") 
            {
                Cursor = Cursors.WaitCursor;
                StreamReader streamreader = new StreamReader(tbTextFile.Text, Encoding.GetEncoding(_codepages[cmbCyrEncodings.SelectedIndex]));
                rtbTextFile.Text = streamreader.ReadToEnd();
                streamreader.Close();
                Cursor = Cursors.Default;
            }
        }
    }
}
