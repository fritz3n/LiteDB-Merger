using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiteDB_Merger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.RestoreDirectory = true;


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String path in dialog.FileNames)
                {
                    string[] row = { path};

                    var listViewItem = new ListViewItem(row);

                    //songexp.Items.Add(listViewItem);
                    DbView.Items.Add(listViewItem);
                }
            }
        }

        private void RemoveButt_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in DbView.SelectedItems)
            {
                item.Remove();
            }
        }

        private void ResetButt_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DbView.Items)
            {
                item.Remove();
            }
        }

        private void ChangeButt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "DB files (*.db)|*.db";
            saveFileDialog.DefaultExt = "db";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OutputLab.Text = saveFileDialog.FileName;
            }
        }

        private void MergeButt_Click(object sender, EventArgs e)
        {
            List<string> InList = new List<string>();

            foreach(ListViewItem Item in DbView.Items)
            {
                InList.Add(Item.SubItems[0].Text);
            }

            Cursor.Current = Cursors.WaitCursor;

            int num = LiteDBMerger.Merge(InList,OutputLab.Text);

            Cursor.Current = Cursors.Default;
            MessageBox.Show(num + " Items merged!");

        }
    }
}
