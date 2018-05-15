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
            Mercenary = new Job("Mercenary", "Infantry",FeStats, FeStats, FeStats);
            Guy = new Character("Dummy",Mercenary,FeStats);
            List<Character> allCharacters = new List<Character>();
            List<String> key = new List<string>();
            charactersDictionary = new Dictionary<string, Character>();
            charactersDictionary.Add(Guy.Name, Guy);
            currentCharacter = Guy;
            comboBox1.Items.Add(Guy.Name);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == Guy.Name)
                currentCharacter = Guy;
            hpBox.Text = currentCharacter.Stats[0].Value.ToString();
            maxHpBox.Text += currentCharacter.Stats[1].Value.ToString();
            strBox.Text += currentCharacter.Stats[2].Value.ToString();
            magBox.Text += currentCharacter.Stats[3].Value.ToString();
            skillBox.Text += currentCharacter.Stats[4].Value.ToString();
            spdBox.Text += currentCharacter.Stats[5].Value.ToString();
            luckBox.Text += currentCharacter.Stats[6].Value.ToString();
            defBox.Text += currentCharacter.Stats[7].Value.ToString();
            resBox.Text += currentCharacter.Stats[8].Value.ToString();
            moveBox.Text += currentCharacter.Stats[9].Value.ToString();
            classesBox.Text = currentCharacter.Job.Name;
            lvlBox.Text += currentCharacter.Level.ToString();
            expBox.Text += currentCharacter.Experience.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            currentCharacter.Name = comboBox1.Text;
            //If character is not in combobox or dictionary do this
                //comboBox1.Items.Add(currentCharacter.Name);
                //charactersDictionary.Add(currentCharacter.Name,currentCharacter);
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

        private void lvlBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (lvlBox.Text != "")
                stat = Int32.Parse(lvlBox.Text);
            currentCharacter.Level = stat;
        }

        private void expBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (expBox.Text != "")
                stat = Int32.Parse(expBox.Text);
            currentCharacter.Experience = stat;
        }

        private void hpBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (hpBox.Text != "")
                stat = Int32.Parse(hpBox.Text);
            currentCharacter.Stats[0].Value = stat;
        }

        private void maxHpBox_TextChanged(object sender, EventArgs e)
        {
            int stat = 0;
            if (maxHpBox.Text != "")
                stat = Int32.Parse(maxHpBox.Text);
            currentCharacter.Stats[1].Value = stat;
        }
    }
}
