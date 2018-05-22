using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class UIStat
    {
        public UIStat(Stat statref, UIValueGrowthMax vgm)
        {
            StatRef = statref;
            uivalue = vgm;
        }
        public Stat StatRef;
        public UIValueGrowthMax uivalue;
        public void Refresh()
        {
            uivalue.ValueRef.Text = StatRef.Value.ToString();
            uivalue.GrowthRef.Text = StatRef.Growth.ToString();
            uivalue.MaxRef.Text = StatRef.Max.ToString();
        }

        public void SetValues()
        {
            StatRef.Value = int.Parse(uivalue.ValueRef.Text);
            StatRef.Growth = int.Parse(uivalue.GrowthRef.Text);
            StatRef.Max = int.Parse(uivalue.MaxRef.Text);

        }
    }
}
