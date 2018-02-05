using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowNamer
{
    enum FileStatus
    {
        NotSet,
        Waiting,
        Skipping,
        Skipped,
        Renamed,
        Failed
    }
}
