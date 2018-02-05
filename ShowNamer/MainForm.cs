using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using WMPLib;

namespace ShowNamer
{
    public partial class ShowNamer : Form
    {
        private List<ShowFile> _showFiles = new List<ShowFile>();
        private bool _dragDropEnabled = false;
        public ShowNamer()
        {
            InitializeComponent();
        }
        private void ShowNamer_Load(object sender, EventArgs e)
        {
            tsbEnableDragDrop.Checked = _dragDropEnabled;
            lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void BtnBrowseSource_Click(object sender, EventArgs e)
        {
            string path = GetFolderPath();
            if (path != null)
            {
                this.Reset();
                txtSourcePath.Text = path;
                this.LoadFolder(path);
            }

        }



        private void BtnRefreshList_Click(object sender, EventArgs e)
        {
            lvFiles.Items.Clear();
            int season = (int)nudSeason.Value;
            int startEp = (int)nudEpisodes.Value;
            var nameFormatter = new NameFormatter();
            foreach (var file in this._showFiles)
            {
                file.Season = season;
                file.Episode = startEp;
                file.FileSizeString = BytesToString(file.FileSize);
                file.TargetFileName = nameFormatter.GetFormattedName(txtFormat.Text, file, txtShowName.Text, season, startEp);
                //FormatName(txtFormat.Text, file.OriginalFileName, txtShowName.Text, file.Season.ToString(), file.Episode.ToString(), file.Extension);
                this.lvFiles.Items.Add(file.GetLvItem());
                if (CbIncEp.Checked)
                {
                    startEp++;
                }
            }
        }

        private void ComboSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             0 Source Name
             1 Season
             2 Episode
             3 File Size
             4 Length
             5 Created At
             */
            var index = ComboSortBy.SelectedIndex;
            switch (index)
            {
                case 0:
                    _showFiles = _showFiles.OrderBy(o => o.OriginalFileName).ToList();
                    break;
                case 1:
                    _showFiles = _showFiles.OrderBy(o => o.Season).ToList();
                    break;
                case 2:
                    _showFiles = _showFiles.OrderBy(o => o.Episode).ToList();
                    break;
                case 3:
                    _showFiles = _showFiles.OrderBy(o => o.FileSize).ToList();
                    break;
                case 4:
                    _showFiles = _showFiles.OrderBy(o => o.Duration).ToList();
                    break;
                case 5:
                    _showFiles = _showFiles.OrderBy(o => o.CreatedAt).ToList();
                    break;
                default:
                    break;
            }
            RefreshView();
        }

        private void BtnRenameFiles_Click(object sender, EventArgs e)
        {
            /*
             1. Loop all files in showFiles
             2. Update grid to with status
             3. Reame file
             4. Update grid with completed
             */

            foreach (var file in _showFiles)
            {
                var rowIndex = GetListViewIndexFromTag(file);
                try
                {
                    if (file.Skip)
                    {
                        file.Status = FileStatus.Skipped;
                        lvFiles.Items[rowIndex].SubItems[8].Text = file.Status.ToString();
                        lvFiles.Items[rowIndex].SubItems[8].ForeColor = Color.Blue;
                    }
                    else
                    {
                        File.Move(Path.Combine(file.DirectoryName, file.OriginalFileName), Path.Combine(file.DirectoryName, file.TargetFileName));
                        file.Status = FileStatus.Renamed;
                        lvFiles.Items[rowIndex].SubItems[8].Text = file.Status.ToString();
                        lvFiles.Items[rowIndex].SubItems[8].ForeColor = Color.Green;
                        if (CbIncEp.Checked)
                        {
                            nudEpisodes.Value = file.Episode++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    file.Status = FileStatus.Failed;
                    lvFiles.Items[rowIndex].SubItems[8].Text = file.Status.ToString();
                    lvFiles.Items[rowIndex].SubItems[8].ForeColor = Color.Red;
                }
            }
        }



        private void LvFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (!_dragDropEnabled) return;
            var effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }
            e.Effect = effects;
        }

        private void LvFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (!_dragDropEnabled) return;
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            txtSourcePath.Text = files[0];
            LoadFolder(files[0]);
        }

        private void tbsOpenNewFolder_Click(object sender, EventArgs e)
        {
            this.Reset();
            string path = GetFolderPath();
            if (path != null)
            {
                txtSourcePath.Text = path;
                this.LoadFolder(path);
            }
        }

        private void tbsAddFromFolder_Click(object sender, EventArgs e)
        {
            string path = GetFolderPath();
            if (path != null)
            {
                txtSourcePath.Text = path;
                this.LoadFolder(path);
            }
        }
        private void tsbRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0)
                return;
            var index = _showFiles.IndexOf((ShowFile)lvFiles.SelectedItems[0].Tag);
            if (index == -1)
                return;
            _showFiles.RemoveAt(index);
            lvFiles.SelectedItems[0].Remove();
        }

        private void tsbClearGrid_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void tsbEnableDragDrop_CheckedChanged(object sender, EventArgs e)
        {
            if (_dragDropEnabled)
            {
                _dragDropEnabled = false;
            }
            else
            {
                _dragDropEnabled = true;
            }
            Console.WriteLine(_dragDropEnabled);
        }
        private void tsbSkipSelected_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0)
                return;
            var index = _showFiles.IndexOf((ShowFile)lvFiles.SelectedItems[0].Tag);
            if (index == -1)
                return;
            _showFiles[index].Skip = true;
            _showFiles[index].Status = FileStatus.Skipping;
            this.RefreshView();
        }

        // Helpers
        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private int GetListViewIndexFromTag(ShowFile file)
        {
            foreach (ListViewItem item in lvFiles.Items)
            {
                if (item.Tag == file) return item.Index;
            }
            return -1;
        }

        private void Reset()
        {
            _showFiles.Clear();
            lvFiles.Items.Clear();
            txtSourcePath.Clear();
        }

        private string GetFolderPath()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;
                dialog.Description = "Select folder with raw show files";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }
            return null;
        }

        private void LoadFolder(string folderPath)
        {
            var dirInfo = new DirectoryInfo(folderPath);
            string AllowedVideoTypes = "*.mkv";
            var files = dirInfo.GetFiles(AllowedVideoTypes, SearchOption.TopDirectoryOnly);
            int season = (int)nudSeason.Value;
            int startEp = (int)nudEpisodes.Value;
            foreach (var info in files)
            {
                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(info.FullName);
                var file = new ShowFile()
                {
                    OriginalFileName = info.Name,
                    OriginalFilePath = info.FullName,
                    DirectoryName = info.DirectoryName,
                    FileSize = info.Length,
                    FileSizeString = BytesToString(info.Length),
                    Duration = TimeSpan.FromSeconds(clip.duration).ToString(),
                    Season = season,
                    Episode = startEp,
                    Extension = info.Extension,
                    CreatedAt = info.CreationTime,
                    Skip = false,
                };
                this._showFiles.Add(file);
            }
            RefreshView();
        }

        private void RefreshView()
        {
            lvFiles.Items.Clear();
            var nameFormatter = new NameFormatter();
            foreach (var file in this._showFiles)
            {
                file.FileSizeString = BytesToString(file.FileSize);
                file.TargetFileName = nameFormatter.GetFormattedName(txtFormat.Text, file, txtShowName.Text, file.Season, file.Episode);
                //FormatName(txtFormat.Text, file.OriginalFileName, txtShowName.Text, file.Season.ToString(), file.Episode.ToString(), file.Extension);
                ListViewItem lv = file.GetLvItem();
                lv.UseItemStyleForSubItems = false; //?
                switch (file.Status)
                {
                    case FileStatus.Waiting:
                        lv.SubItems[8].Text = FileStatus.Waiting.ToString();
                        lv.SubItems[8].ForeColor = Color.Black;
                        break;
                    case FileStatus.Renamed:
                        lv.SubItems[8].Text = FileStatus.Renamed.ToString();
                        lv.SubItems[8].ForeColor = Color.Green;
                        break;
                    case FileStatus.Skipped:
                        lv.SubItems[8].Text = FileStatus.Skipped.ToString();
                        lv.SubItems[8].ForeColor = Color.Blue;
                        break;
                    case FileStatus.Skipping:
                        lv.SubItems[8].Text = FileStatus.Skipping.ToString();
                        lv.SubItems[8].ForeColor = Color.Blue;
                        break;
                    case FileStatus.Failed:
                        lv.SubItems[8].Text = FileStatus.Failed.ToString();
                        lv.SubItems[8].ForeColor = Color.Red;
                        break;
                }
                this.lvFiles.Items.Add(lv);
            }
            lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormatInfoForm frm = new FormatInfoForm();
            frm.Show();
        }
        /*
       string FormatName(string format, string originFileName, string show, string season, string episode, string fileExt)
       {
           string tarName = "";
           //%sn - Show Name
           //%s  - Season
           //%ss - Season Short
           //%e  - Episode
           //%ee - Episode Short
           //%S  - Season
           //%SS - Season Short
           //%E  - Episode
           //%EE - Episode Short
           //%xt - Extension
           tarName = format.Replace("%sn", show);
           tarName = tarName.Replace("%s", "Season" + (season.Length == 1 ? "0" + season : season));
           tarName = tarName.Replace("%ss", "Season" + season);
           tarName = tarName.Replace("%e", "Episode" + (episode.Length == 1 ? "0" + episode : episode));
           tarName = tarName.Replace("%ee", "Episode" + episode);

           tarName = tarName.Replace("%S", "S" + (season.Length == 1 ? "0" + season : season));
           tarName = tarName.Replace("%SS", "S" + season);
           tarName = tarName.Replace("%E", "E" + (episode.Length == 1 ? "0" + episode : episode));
           tarName = tarName.Replace("%EE", "E" + episode);

           tarName = tarName.Replace("%xt", fileExt);
           return tarName;
       }
       */

    }
}
