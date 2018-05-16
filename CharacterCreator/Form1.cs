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
            var loadedCharacters = new List<Character>();
            foreach (var f in files)
            {
                var jsonstring = File.ReadAllText(f);
                try
                {
                    var character = JsonConvert.DeserializeObject<Character>(jsonstring);
                    loadedCharacters.Add(character);
                }
                catch { }

            }

            FeStats = new List<Stat>();
            StatGrowths = FeStats;
            Mercenary = new Job("Mercenary", "Infantry");
            Guy = new Character("Dummy",Mercenary);
            allCharacters = new List<Character>();
            var key = new List<string>();
            charactersDictionary = new Dictionary<string, Character> {{Guy.Name, Guy}};
            allCharacters.Add(Guy);
            comboBox1.Items.Add(Guy.Name);

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    hpBox.Text = person.Stats[0].Value.ToString();
                    maxHpBox.Text = person.Stats[1].Value.ToString();
                    strBox.Text = person.Stats[2].Value.ToString();
                    magBox.Text = person.Stats[3].Value.ToString();
                    skillBox.Text = person.Stats[4].Value.ToString();
                    spdBox.Text = person.Stats[5].Value.ToString();
                    luckBox.Text = person.Stats[6].Value.ToString();
                    defBox.Text = person.Stats[7].Value.ToString();
                    resBox.Text = person.Stats[8].Value.ToString();
                    moveBox.Text = person.Stats[9].Value.ToString();
                    classesBox.Text = person.Job.Name;
                    lvlBox.Text = person.Level.ToString();
                    expBox.Text = person.Experience.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this is what you should try
            //1. the allcharacters contains a global list of characters that have been added
            //2. when you save
            //2a. just loop through all of those characters and serialize them then save to file


            foreach (var c in allCharacters)
            {
                var jsonstring = JsonConvert.SerializeObject(c);
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/"+c.Name+".json");

                System.IO.File.WriteAllText(path, jsonstring);
            }

            ////This one's all kinds of messed up.
            //foreach (var name in comboBox1.Items)
            //{
            //    if (comboBox1.Text != name.ToString())
            //    {
            //        allCharacters.Add(new Character(comboBox1.Text, Mercenary));
            //        string currentChar = JsonConvert.SerializeObject(allCharacters[allCharacters.Count-1]);
            //        var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/"+allCharacters[allCharacters.Count-1].Name + ".json");
            //        System.IO.File.WriteAllText(path, currentChar);
            //        comboBox1.Items.Add(comboBox1.Text);
            //        break;
            //    }
            //}

        }

        private void strBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (strBox.Text != "")
                        stat = Int32.Parse(strBox.Text);
                    person.Stats[2].Value = stat;
                }
            }
        }

        private void magBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (magBox.Text != "")
                        stat = Int32.Parse(magBox.Text);
                    person.Stats[3].Value = stat;
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (skillBox.Text != "")
                        stat = Int32.Parse(skillBox.Text);
                    person.Stats[4].Value = stat;
                }
            }
        }

        private void spdBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (spdBox.Text != "")
                        stat = Int32.Parse(spdBox.Text);
                    person.Stats[5].Value = stat;
                }
            }
        }

        private void luckBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (luckBox.Text != "")
                        stat = Int32.Parse(luckBox.Text);
                    person.Stats[6].Value = stat;
                }
            }
        }

        private void defBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (defBox.Text != "")
                        stat = Int32.Parse(defBox.Text);
                    person.Stats[7].Value = stat;
                }
            }
        }

        private void resBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (resBox.Text != "")
                        stat = Int32.Parse(resBox.Text);
                    person.Stats[8].Value = stat;
                }
            }
        }

        private void moveBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (moveBox.Text != "")
                        stat = Int32.Parse(moveBox.Text);
                    person.Stats[9].Value = stat;
                }
            }
        }

        private void lvlBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (lvlBox.Text != "")
                        stat = Int32.Parse(lvlBox.Text);
                    person.Level = stat;
                }
            }
        }

        private void expBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (expBox.Text != "")
                        stat = Int32.Parse(expBox.Text);
                    person.Experience = stat;
                }
            }
        }

        private void hpBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (hpBox.Text != "")
                        stat = Int32.Parse(hpBox.Text);
                    person.Stats[0].Value = stat;
                }
            }
        }

        private void maxHpBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (maxHpBox.Text != "")
                        stat = Int32.Parse(maxHpBox.Text);
                    person.Stats[1].Value = stat;
                }
            }
        }

        private void strGrowthBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var person in allCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    int stat = 0;
                    if (defBox.Text != "")
                        stat = Int32.Parse(defBox.Text);
                    person.Growths[2].Value = stat;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var c = new Character();
            //when this button is clicked
            //grab all information from the application
            //and create a player from it
            //then add that character to the allcharacters list

            //characters are created but added as "dUMMY"
            var c = new Character("bob", new Job("bob", "t"));
            allCharacters.Add(c);


        }
    }
}
