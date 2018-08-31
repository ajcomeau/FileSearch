using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FileSearch
{
    // Simple application to perform a file search and enable the
    // opening of directories from the results.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the folder dialog and get the folder selected.
                if (fbdSelect.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = fbdSelect.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Add columns if they're not already there.
                if (dgFiles.ColumnCount == 0)
                {
                    dgFiles.Columns.Add("FileName", "File Name");
                    dgFiles.Columns.Add("PathName", "Path Name");
                    dgFiles.Columns.Add("FileSize", "File Size");
                    dgFiles.Columns.Add("Modified", "Modified");
                    dgFiles.Update();
                }

                // If the entries are correct, clear the grid and start the search.
                if (txtFolder.Text.Length > 0 && txtSearch.Text.Length > 0)
                {
                    dgFiles.Rows.Clear();
                    SearchFiles(txtFolder.Text, txtSearch.Text);
                }

                // Update the notification with the number of files found.
                progStatusLabel1.Text = "Finished - " + dgFiles.Rows.Count.ToString() + " files found.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchFiles(string StartingFolder, string Pattern)
        {

            // Recursive search of all subdirectories.
            // Get the directories and files.
            FileInfo fInfo;

            // Show the current folder being processed.
            // This slows things down but at least provides some sense of progress.

            progStatusLabel1.Text = "Searching: " + StartingFolder;
            Application.DoEvents();

            try
            {
                // Add each file to the grid.
                foreach (string fileName in Directory.GetFiles(StartingFolder, Pattern))
                {
                    if (fileName.Length < 260)
                    {
                        fInfo = new FileInfo(fileName);
                        dgFiles.Rows.Add(fInfo.Name, fInfo.Directory, fInfo.Length, fInfo.LastWriteTime);
                    }
                    else
                    {
                        dgFiles.Rows.Add(fileName.Substring(fileName.LastIndexOf("\\") + 1), StartingFolder, null, null);
                    }
                    dgFiles.Update();     
                }

                // Go to next directory.
                foreach (string dirName in Directory.GetDirectories(StartingFolder))
                {
                    SearchFiles(dirName, Pattern);
                }
            }
            catch (Exception ex)
            {
                txtErrors.Text = ex.Message + Environment.NewLine + txtErrors.Text;               
            }


        }

        private void dgFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // If the user double-clicks anywhere on a row, open the specified
                // path in Windows Explorer.
                DataGridViewRow rowCurrent = dgFiles.CurrentRow;

                if (rowCurrent.Cells["PathName"].Value != null)
                {
                    Process.Start(rowCurrent.Cells["PathName"].Value.ToString());
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About credits = new About();
            credits.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult drQuit = MessageBox.Show("Are you sure you want to quit?", "Quit File Search?", MessageBoxButtons.YesNo);

            if(drQuit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



    }
}
