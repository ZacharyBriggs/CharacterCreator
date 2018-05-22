using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class UIStatGroup
    {
        UIValueGrowthMax[] vgms = new UIValueGrowthMax[9];
        Stat[] StatsRef = new Stat[9];
        List<UIStat> UIStats;
        public void Refresh()
        {
            for (int i = 0; i < StatsRef.Length; i++)
                UIStats.Add(new UIStat(StatsRef[i], vgms[i]));
            foreach (var stat in UIStats)
            {
                stat.Refresh();
            }
        }
    }
}
