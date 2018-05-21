using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<UIStat> uistats;

        private void Form2_Load(object sender, EventArgs e)
        {
            uistats = new List<UIStat>();
            var hpgroup = new UIValueGrowthMax { ValueRef = hpBox, GrowthRef = hpGrowthBox, MaxRef = maxHpBox };
            var strgroup = new UIValueGrowthMax { ValueRef = textBox1, GrowthRef = textBox2, MaxRef = textBox3 };
            uistats.Add(new UIStat(new Stat() { Value = 21,Max = 25, Growth = 1 }, hpgroup));
            uistats.Add(new UIStat(new Stat() { Value = 20, Max = 21, Growth = 2 }, strgroup));


        }
        private void hpBox_TextChanged(object sender, EventArgs e)
        {

        }
        public class UIValueGrowthMax
        {
            public TextBox ValueRef;
            public TextBox GrowthRef;
            public TextBox MaxRef;
        }
        public class UIStat
        {
            public UIStat(Stat statref, UIValueGrowthMax vgm)
            {
                StatRef = statref;
                uivalue = vgm;
            }
            Stat StatRef;
            UIValueGrowthMax uivalue;
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


        private void SaveStat_button_Click(object sender, EventArgs e)
        {
            uistats.ForEach(s => s.Refresh());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uistats.ForEach(s => s.SetValues());
        }
    }
}
