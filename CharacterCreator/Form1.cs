﻿using System;
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
            Mercenary = new Job("Mercenary", "Infantry");
            allCharacters = new List<Character>();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var person in loadedCharacters)
            {
                if (person.Name == comboBox1.Text)
                {
                    hpBox.Text = person.Stats[1].Value.ToString();
                    maxHpBox.Text = person.Stats[1].Max.ToString();
                    hpGrowthBox.Text = person.Stats[1].Growth.ToString();
                    strBox.Text = person.Stats[2].Value.ToString();
                    maxStrBox.Text = person.Stats[2].Max.ToString();
                    strGrowthBox.Text = person.Stats[2].Growth.ToString();
                    magBox.Text = person.Stats[3].Value.ToString();
                    maxMagBox.Text = person.Stats[3].Max.ToString();
                    magGrowthBox.Text = person.Stats[3].Growth.ToString();
                    skillBox.Text = person.Stats[4].Value.ToString();
                    maxSkillBox.Text = person.Stats[4].Max.ToString();
                    skillGrowthBox.Text = person.Stats[4].Growth.ToString();
                    spdBox.Text = person.Stats[5].Value.ToString();
                    maxSpdBox.Text = person.Stats[5].Max.ToString();
                    spdGrowthBox.Text = person.Stats[5].Growth.ToString();
                    luckBox.Text = person.Stats[6].Value.ToString();
                    maxLuckBox.Text = person.Stats[6].Max.ToString();
                    luckGrowthBox.Text = person.Stats[6].Growth.ToString();
                    defBox.Text = person.Stats[7].Value.ToString();
                    maxDefBox.Text = person.Stats[7].Max.ToString();
                    defGrowthBox.Text = person.Stats[7].Growth.ToString();
                    resBox.Text = person.Stats[8].Value.ToString();
                    maxResBox.Text = person.Stats[8].Max.ToString();
                    resGrowthBox.Text = person.Stats[8].Growth.ToString();
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


            foreach (var c in loadedCharacters)
            {
                var jsonstring = JsonConvert.SerializeObject(c);
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/"+c.Name+".json");

                System.IO.File.WriteAllText(path, jsonstring);
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
            var c = new Character(nameBox.Text, Mercenary);
            c.Stats[1].Value = Int32.Parse(hpBox.Text);
            c.Stats[1].Growth = Int32.Parse(hpGrowthBox.Text);
            c.Stats[1].Max = Int32.Parse(maxHpBox.Text);
            c.Stats[2].Value = Int32.Parse(strBox.Text);
            c.Stats[2].Growth = Int32.Parse(strGrowthBox.Text);
            c.Stats[2].Max = Int32.Parse(maxStrBox.Text);
            c.Stats[3].Value = Int32.Parse(magBox.Text);
            c.Stats[3].Growth = Int32.Parse(magGrowthBox.Text);
            c.Stats[3].Max = Int32.Parse(maxMagBox.Text);
            c.Stats[4].Value = Int32.Parse(skillBox.Text);
            c.Stats[4].Growth = Int32.Parse(skillGrowthBox.Text);
            c.Stats[4].Max = Int32.Parse(maxSkillBox.Text);
            c.Stats[5].Value = Int32.Parse(spdBox.Text);
            c.Stats[5].Growth = Int32.Parse(spdGrowthBox.Text);
            c.Stats[5].Max = Int32.Parse(maxSpdBox.Text);
            c.Stats[6].Value = Int32.Parse(luckBox.Text);
            c.Stats[6].Growth = Int32.Parse(luckGrowthBox.Text);
            c.Stats[6].Max = Int32.Parse(maxLuckBox.Text);
            c.Stats[7].Value = Int32.Parse(defBox.Text);
            c.Stats[7].Growth = Int32.Parse(defGrowthBox.Text);
            c.Stats[7].Max = Int32.Parse(maxDefBox.Text);
            c.Stats[8].Value = Int32.Parse(resBox.Text);
            c.Stats[8].Growth = Int32.Parse(resGrowthBox.Text);
            c.Stats[8].Max = Int32.Parse(maxResBox.Text);
            c.Stats[9].Value = Int32.Parse(moveBox.Text);
            c.Level = Int32.Parse(lvlBox.Text);
            c.Experience = Int32.Parse(expBox.Text);
            allCharacters.Add(c);


        }
    }
}
