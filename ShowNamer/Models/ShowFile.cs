using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowNamer {
    internal class ShowFile {
        public string OriginalFileName;
        public string OriginalFilePath;
        public string TargetFileName;
        public long FileSize;
        public string FileSizeString;
        public string Duration;
        public int Season;
        public int Episode;
        public string Extension;
        public DateTime CreatedAt;
        public string DirectoryName;

        //Changes in memory
        public bool Skip;
        public FileStatus Status = FileStatus.NotSet;


        public ListViewItem GetLvItem() {

            if (Status == FileStatus.NotSet) Status = FileStatus.Waiting;
            string[] row = {
                OriginalFileName,
                Season.ToString(),
                Episode.ToString(),
                TargetFileName ?? OriginalFileName,
                FileSizeString,
                Duration,
                CreatedAt.ToString(CultureInfo.InvariantCulture),
                Skip.ToString(),
                Status.ToString(), 
                OriginalFilePath
            };
            var item = new ListViewItem(row) {
                Tag = this,
                UseItemStyleForSubItems = false
            };
            return item;
        }
    }



}
