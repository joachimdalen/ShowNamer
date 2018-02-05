using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowNamer
{
    public partial class FormatInfoForm : Form
    {
        public FormatInfoForm()
        {
            InitializeComponent();
        }

        private void FormatInfoForm_Load(object sender, EventArgs e)
        {
            this.dgvInfo.Rows.Add("%sn", "Show Name", "%sn", "House");

            this.dgvInfo.Rows.Add("%s", "SeasonX", "%sn - %s", "House - SeasonX");
            this.dgvInfo.Rows.Add("%ss", "SeasonXX", "%sn - %ss", "House - Season0X");
            this.dgvInfo.Rows.Add("%e", "EpisodeX", "%sn - %ss%e", "House - SeasonXXEpisodeX");
            this.dgvInfo.Rows.Add("%ee", "EpisodeXX", "%sn - %ss%ee", "House - SeasonXXEpisodeXX");

            this.dgvInfo.Rows.Add("%S", "SX", "%sn - %S", "House - SX");
            this.dgvInfo.Rows.Add("%SS", "SXX", "%sn - %SS", "House - SXX");
            this.dgvInfo.Rows.Add("%E", "EX", "%sn - %SS%E", "House - SXXEX");
            this.dgvInfo.Rows.Add("%EE", "EXX", "%sn - %SS%EE", "House - SXXEXX");

            this.dgvInfo.Rows.Add("%xt", "File Extension", "%sn - %SS%EE%xt", "House - SXXEXX.mp4");
        }
    }
}
