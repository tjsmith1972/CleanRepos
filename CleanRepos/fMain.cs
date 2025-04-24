using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanRepos
{
    public partial class fMain : Form
    {
        private long dirSizes = 0;
        public fMain()
        {
            InitializeComponent();
            SetDefaults();
        }
        void SetDefaults()
        {
            var rootFolder = Properties.Settings.Default["RootFolder"]?.ToString();
            if (rootFolder != null)
            {
                txtRootFolder.Text = rootFolder.Replace("%USERNAME%", Environment.UserName);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the root folder";
                fbd.ShowNewFolderButton = false;
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtRootFolder.Text = fbd.SelectedPath;
                    Properties.Settings.Default["RootFolder"] = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private string GetHomeFolder()
        {
            string? homePath = (Environment.OSVersion.Platform == PlatformID.Unix ||
                   Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return homePath ?? string.Empty;
        }

        private void txtRootFolder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                Properties.Settings.Default["RootFolder"] = txtRootFolder.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnPreview_ClickAsync(object sender, EventArgs e)
        {
            _ = PreviewCleanAsync();
        }
        async Task PreviewCleanAsync()
        {
            var rootDir = Directory.GetDirectories(txtRootFolder.Text);
            if (rootDir != null)
            {
                await LogSubFolders(txtRootFolder.Text, false);
            }
            rLog.Text += string.Format("Total size reclaimed: {0}mb", (dirSizes / 1024 / 1024).ToString());

        }
        async Task LogSubFolders(string rootFolder, bool delete)
        {
            var folderName = ""; 
            var delArr = txtFoldersToDelete.Text.ToLower().Split(',');
            var di = new DirectoryInfo(rootFolder);
            folderName = di.Name;
            if (Array.IndexOf(delArr, folderName.Trim().ToLower())>-1)
            {
                long dirSize = await Task.Run(() => di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
                dirSizes += dirSize;
                rLog.Text += "DELETING..." + (dirSize / 1024 / 1024).ToString() + "mb" + Environment.NewLine +
                    rootFolder + Environment.NewLine;
                if(delete) di.Delete(true);
            }
            else
            {
                var childDirs = Directory.GetDirectories(rootFolder);
                if (childDirs != null)
                {
                    foreach (var root in childDirs)
                    {
                        //rLog.Text += root + Environment.NewLine;
                        await LogSubFolders(root, delete);
                    }
                }
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            _ = CleanAsync();
        }
        async Task CleanAsync()
        {
            var rootDir = Directory.GetDirectories(txtRootFolder.Text);
            if (rootDir != null)
            {
                await LogSubFolders(txtRootFolder.Text, true);
            }
            rLog.Text += string.Format("Total size reclaimed: {0}mb", (dirSizes / 1024 / 1024).ToString());

        }
    }
}
