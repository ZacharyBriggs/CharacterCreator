using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters");
            var files = Directory.GetFiles(path);
            loadedCharacters = new List<Character>();
            foreach (var f in files)
            {
                var jsonstring = File.ReadAllText(f);
                var character = JsonConvert.DeserializeObject<Character>(jsonstring);
                loadedCharacters.Add(character);
            }
            foreach (var c in loadedCharacters)
            {
                comboBox1.Items.Add(c.Name);
            }


            allCharacters = new List<Character>();
            uiStats = new List<UIStat>();
            var hpgroup = new UIValueGrowthMax { ValueRef = hpBox, GrowthRef = hpGrowthBox, MaxRef = maxHpBox };
            var strgroup = new UIValueGrowthMax { ValueRef = strBox, GrowthRef = strGrowthBox, MaxRef = maxStrBox };
            var maggroup = new UIValueGrowthMax { ValueRef = magBox, GrowthRef = magGrowthBox, MaxRef = maxMagBox };
            var skillgroup = new UIValueGrowthMax { ValueRef = skillBox, GrowthRef = skillGrowthBox, MaxRef = maxSkillBox };
            var spdgroup = new UIValueGrowthMax { ValueRef = spdBox, GrowthRef = spdGrowthBox, MaxRef = maxSpdBox };
            var luckgroup = new UIValueGrowthMax { ValueRef = luckBox, GrowthRef = luckGrowthBox, MaxRef = maxLuckBox };
            var defgroup = new UIValueGrowthMax { ValueRef = defBox, GrowthRef = defGrowthBox, MaxRef = maxDefBox };
            var resgroup = new UIValueGrowthMax { ValueRef = resBox, GrowthRef = resGrowthBox, MaxRef = maxResBox };
            //var movegroup = new UIValueGrowthMax {ValueRef = moveBox, GrowthRef = 0, MaxRef = 0};

            uiStats.Add(new UIStat(new Stat("HP",0,0,0,""),hpgroup ));
            uiStats.Add(new UIStat(new Stat("Str",0,0,0,""),strgroup ));
            uiStats.Add(new UIStat(new Stat("Mag", 0, 0, 0, ""), maggroup));
            uiStats.Add(new UIStat(new Stat("Skill", 0, 0, 0, ""), skillgroup));
            uiStats.Add(new UIStat(new Stat("Spd", 0, 0, 0, ""), spdgroup));
            uiStats.Add(new UIStat(new Stat("Luck", 0, 0, 0, ""), luckgroup));
            uiStats.Add(new UIStat(new Stat("Def", 0, 0, 0, ""), defgroup));
            uiStats.Add(new UIStat(new Stat("Res", 0, 0, 0, ""), resgroup));
            //uiStats.Add(new UIStat(new Stat("Move", 0, 0, 0,"" ),movegroup));
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var person in loadedCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    nameBox.Text = person.Name;
                    hpBox.Text = person.Stats[0].Value.ToString();
                    maxHpBox.Text = person.Stats[0].Max.ToString();
                    hpGrowthBox.Text = person.Stats[0].Growth.ToString();

                    strBox.Text = person.Stats[1].Value.ToString();
                    maxStrBox.Text = person.Stats[1].Max.ToString();
                    strGrowthBox.Text = person.Stats[1].Growth.ToString();

                    magBox.Text = person.Stats[2].Value.ToString();
                    maxMagBox.Text = person.Stats[2].Max.ToString();
                    magGrowthBox.Text = person.Stats[2].Growth.ToString();

                    skillBox.Text = person.Stats[3].Value.ToString();
                    maxSkillBox.Text = person.Stats[3].Max.ToString();
                    skillGrowthBox.Text = person.Stats[3].Growth.ToString();

                    spdBox.Text = person.Stats[4].Value.ToString();
                    maxSpdBox.Text = person.Stats[4].Max.ToString();
                    spdGrowthBox.Text = person.Stats[4].Growth.ToString();

                    luckBox.Text = person.Stats[5].Value.ToString();
                    maxLuckBox.Text = person.Stats[5].Max.ToString();
                    luckGrowthBox.Text = person.Stats[5].Growth.ToString();

                    defBox.Text = person.Stats[6].Value.ToString();
                    maxDefBox.Text = person.Stats[6].Max.ToString();
                    defGrowthBox.Text = person.Stats[6].Growth.ToString();

                    resBox.Text = person.Stats[7].Value.ToString();
                    maxResBox.Text = person.Stats[7].Max.ToString();
                    resGrowthBox.Text = person.Stats[7].Growth.ToString();

                    moveBox.Text = person.Stats[8].Value.ToString();

                    classNameBox.Text = person.Job ;
                    lvlBox.Text = person.Level.ToString();
                    expBox.Text = person.Experience.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var c in loadedCharacters)
            {
                var jsonstring = JsonConvert.SerializeObject(c);
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/" + c.Name + ".json");
                System.IO.File.WriteAllText(path, jsonstring);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uiStats.ForEach(s => s.SetValues());
            Character c = new Character(nameBox.Text);
            for (int i = 0; i < 8; i++)
            {
                c.Stats[i].Value = int.Parse(uiStats[i].uivalue.ValueRef.Text);
                c.Stats[i].Growth = int.Parse(uiStats[i].uivalue.GrowthRef.Text);
                c.Stats[i].Max = int.Parse(uiStats[i].uivalue.MaxRef.Text);
            }
            loadedCharacters.Add(c);
            comboBox1.Items.Add(c.Name);
        }

        private void refreshBox_Click(object sender, EventArgs e)
        {
            uiStats.ForEach(s => s.Refresh());
        }
    }
}
