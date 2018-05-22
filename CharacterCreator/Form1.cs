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

        private Character _currentCharacter;

        private Character CurrentCharacter
        {
            get { return _currentCharacter; }
            set
            {
                _currentCharacter = new Character();
                _currentCharacter = value;
                if(onCharacterChanged != null)
                    onCharacterChanged.Invoke(_currentCharacter);
            }
        }

        public delegate void OnCharacterChanged(Character c);

        public OnCharacterChanged onCharacterChanged;

        public int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                _currentIndex = value;
                if (_currentIndex > loadedCharacters.Count)
                    _currentIndex = loadedCharacters.Count - 1;
                if (_currentIndex <= 0)
                    _currentIndex = 0;
            }
        }

        private void UiRefresh(Character c)
        {
            for (int i = 0; i < uiStats.Count; i++)
                uiStats[i].StatRef = c.Stats[i];

            uiStats.ForEach(s => s.Refresh());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadedCharacters = new List<Character>();
            uiStats = new List<UIStat>();

            onCharacterChanged += UiRefresh;
            onCharacterChanged += SetBoxes;

            var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters");
            var files = Directory.GetFiles(path);
            
            foreach (var f in files)
            {
                var jsonstring = File.ReadAllText(f);
                var character = JsonConvert.DeserializeObject<Character>(jsonstring);
                loadedCharacters.Add(character);
            }

            foreach (var c in loadedCharacters)
            {
                listBox1.Items.Add(c);
            }

            ///-----------GROUP TEXTBOXES///
            var hpgroup = new UIValueGrowthMax { ValueRef = hpBox, GrowthRef = hpGrowthBox, MaxRef = maxHpBox };
            var strgroup = new UIValueGrowthMax { ValueRef = strBox, GrowthRef = strGrowthBox, MaxRef = maxStrBox };
            var maggroup = new UIValueGrowthMax { ValueRef = magBox, GrowthRef = magGrowthBox, MaxRef = maxMagBox };
            var skillgroup = new UIValueGrowthMax { ValueRef = skillBox, GrowthRef = skillGrowthBox, MaxRef = maxSkillBox };
            var spdgroup = new UIValueGrowthMax { ValueRef = spdBox, GrowthRef = spdGrowthBox, MaxRef = maxSpdBox };
            var luckgroup = new UIValueGrowthMax { ValueRef = luckBox, GrowthRef = luckGrowthBox, MaxRef = maxLuckBox };
            var defgroup = new UIValueGrowthMax { ValueRef = defBox, GrowthRef = defGrowthBox, MaxRef = maxDefBox };
            var resgroup = new UIValueGrowthMax { ValueRef = resBox, GrowthRef = resGrowthBox, MaxRef = maxResBox };
            
            ///------------STUFF UI IN A LIST/////
            uiStats.Add(new UIStat(new Stat("HP", 0, 0, 0, ""), hpgroup));
            uiStats.Add(new UIStat(new Stat("Str", 0, 0, 0, ""), strgroup));
            uiStats.Add(new UIStat(new Stat("Mag", 0, 0, 0, ""), maggroup));
            uiStats.Add(new UIStat(new Stat("Skill", 0, 0, 0, ""), skillgroup));
            uiStats.Add(new UIStat(new Stat("Spd", 0, 0, 0, ""), spdgroup));
            uiStats.Add(new UIStat(new Stat("Luck", 0, 0, 0, ""), luckgroup));
            uiStats.Add(new UIStat(new Stat("Def", 0, 0, 0, ""), defgroup));
            uiStats.Add(new UIStat(new Stat("Res", 0, 0, 0, ""), resgroup));
     

            var one = new Character("1");
            var two = new Character("2");

            listBox1.Items.Add(one);
            listBox1.Items.Add(two);
            loadedCharacters.Add(one);
            loadedCharacters.Add(two);
            listBox1.SelectedIndex = CurrentIndex;
  
            CurrentCharacter = loadedCharacters[CurrentIndex];
            listBox1.SelectedIndexChanged += new System.EventHandler(Listchanged);
            

        }

        public void SetBoxes(Character c)
        {
            nameBox.Text = c.Name;
            lvlBox.Text = c.Level.ToString();
        }

        private void Listchanged(object sender, EventArgs e)
        {
            uiStats.ForEach(s => s.SetValues());
            var listbox = sender as ListBox;
            CurrentIndex = listBox1.SelectedIndex;
            CurrentCharacter = loadedCharacters[CurrentIndex];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var c in loadedCharacters)
            {
                var jsonstring = JsonConvert.SerializeObject(c);
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/" + c.Name + ".json");
                File.WriteAllText(path, jsonstring);
            } 
        }


        private void upButton_Click(object sender, EventArgs e)
        {
            CurrentIndex--;
            listBox1.SelectedIndex = CurrentIndex;
            CurrentCharacter = loadedCharacters[CurrentIndex];
           
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            CurrentIndex++;
            listBox1.SelectedIndex = CurrentIndex;
            CurrentCharacter = loadedCharacters[CurrentIndex];
        }


    }
}
