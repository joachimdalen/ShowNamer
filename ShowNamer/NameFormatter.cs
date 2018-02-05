using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowNamer
{
    enum NameFormat
    {

        ShowName,
        SeasonLower,
        SeasonShortLower,
        EpisodeLower,
        EpisodeShortLower,
        SeasonUpper,
        SeasonShortUpper,
        EpisodeUpper,
        EpisodeShortUpper,
        FileExtension

    }
    class NameFormatter
    {
        private Dictionary<NameFormat, string> _formats = new Dictionary<NameFormat, string>();

        internal NameFormatter()
        {
            _formats.Add(NameFormat.ShowName, "sn");
            _formats.Add(NameFormat.SeasonLower, "s");
            _formats.Add(NameFormat.SeasonShortLower, "ss");
            _formats.Add(NameFormat.EpisodeLower, "e");
            _formats.Add(NameFormat.EpisodeShortLower, "ee");
            _formats.Add(NameFormat.SeasonUpper, "S");
            _formats.Add(NameFormat.SeasonShortUpper, "SS");
            _formats.Add(NameFormat.EpisodeUpper, "E");
            _formats.Add(NameFormat.EpisodeShortUpper, "EE");
            _formats.Add(NameFormat.FileExtension, "xt");
        }
       internal string GetFormattedName(string format, ShowFile file, string showName = "Unidentified", int curSeason =1 , int curEpisode = 1)
        {
            Console.Write(curSeason    +"    " + curEpisode);
            string tarName = string.Empty;
            tarName = format.Replace("%sn", showName);
            tarName = tarName.Replace("%s", "Season" + CheckOrAppendPrefix(curSeason));
            tarName = tarName.Replace("%ss", "Season" + curSeason);
            tarName = tarName.Replace("%e", "Episode" + CheckOrAppendPrefix(curEpisode));
            tarName = tarName.Replace("%ee", "Episode" + curEpisode);

            tarName = tarName.Replace("%S", "S" + CheckOrAppendPrefix(curSeason));
            tarName = tarName.Replace("%SS", "S" + curSeason);
            tarName = tarName.Replace("%E", "E" + CheckOrAppendPrefix(curEpisode));
            tarName = tarName.Replace("%EE", "E" + curEpisode);

            tarName = tarName.Replace("%xt", file.Extension);
            return tarName;
        }
        private string CheckOrAppendPrefix(int value, string prefix = "0")
        {
            return (value.ToString().Length == 1 ? prefix + value.ToString() : value.ToString());
        }
    }
}
