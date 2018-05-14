using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            FeStats = new List<Stat>();
            FeStats.Add(HP);
            FeStats.Add(MaxHP);
            FeStats.Add(Str);
            FeStats.Add(Mag);
            FeStats.Add(Skill);
            FeStats.Add(Spd);
            FeStats.Add(Luck);
            FeStats.Add(Def);
            FeStats.Add(Res);
            FeStats.Add(MoveStat);
            MaxStats = FeStats;
            StatGrowths = FeStats;
            foreach (var stat in MaxStats)
            {
                stat.Value = 99;
            }
            Mercenary = new Job("Mercenary", "Infantry",FeStats, FeStats, FeStats);
            Guy = new Character("Dummy",Mercenary,FeStats);
            List<Character> allCharacters = new List<Character>();
            List<String> key = new List<string>();
            Dictionary<String, Character> charactersDictionary = new Dictionary<string, Character>();
            charactersDictionary.Add(Guy.Name, Guy);
            currentCharacter = Guy;
            comboBox1.Items.Add(Guy.Name);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == Guy.Name)
                currentCharacter = Guy;
            hpBox.Text += currentCharacter.Stats[0].Value;
            hpBox.Text += "/" + currentCharacter.Stats[1].Value;
            strBox.Text += currentCharacter.Stats[2].Value;
            magBox.Text += currentCharacter.Stats[3].Value;
            skillBox.Text += currentCharacter.Stats[4].Value;
            spdBox.Text += currentCharacter.Stats[5].Value;
            luckBox.Text += currentCharacter.Stats[6].Value;
            defBox.Text += currentCharacter.Stats[7].Value;
            resBox.Text += currentCharacter.Stats[8].Value;
            moveBox.Text += currentCharacter.Stats[9].Value;
            classBox.Text = currentCharacter.Job.Name;
            lvlBox.Text += currentCharacter.Level;
            expBox.Text += currentCharacter.Experience;
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            string currentChar = JsonConvert.SerializeObject(Guy);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, currentCharacter.Name +".json");
            System.IO.File.WriteAllText(path, currentChar);
        }
        private void strBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if(strBox.Text != "")
                stat = Int32.Parse(strBox.Text);
            currentCharacter.Stats[2].Value = stat;
        }
        private void magBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (magBox.Text != "")
                stat = Int32.Parse(magBox.Text);
            currentCharacter.Stats[3].Value = stat;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (skillBox.Text != "")
                stat = Int32.Parse(skillBox.Text);
            currentCharacter.Stats[4].Value = stat;
        }

        private void spdBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (spdBox.Text != "")
                stat = Int32.Parse(spdBox.Text);
            currentCharacter.Stats[5].Value = stat;
        }

        private void luckBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (luckBox.Text != "")
                stat = Int32.Parse(luckBox.Text);
            currentCharacter.Stats[6].Value = stat;
        }

        private void defBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (defBox.Text != "")
                stat = Int32.Parse(defBox.Text);
            currentCharacter.Stats[7].Value = stat;
        }

        private void resBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (resBox.Text != "")
                stat = Int32.Parse(resBox.Text);
            currentCharacter.Stats[8].Value = stat;
        }

        private void moveBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (moveBox.Text != "")
                stat = Int32.Parse(moveBox.Text);
            currentCharacter.Stats[9].Value = stat;
        }
    }
}
