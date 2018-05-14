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
            comboBox1.Items.Add(Guy.Name);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == Guy.Name)
            {
                hpBox.Text += Guy.Stats[0].Value;
                hpBox.Text += "/" + Guy.Stats[1].Value;
                strBox.Text += Guy.Stats[2].Value;
                magBox.Text += Guy.Stats[3].Value;
                skillBox.Text += Guy.Stats[4].Value;
                spdBox.Text += Guy.Stats[5].Value;
                luckBox.Text += Guy.Stats[6].Value;
                defBox.Text += Guy.Stats[7].Value;
                resBox.Text += Guy.Stats[8].Value;
                moveBox.Text += Guy.Stats[9].Value;
                classBox.Text = Guy.Job.Name;
                lvlBox.Text += Guy.Level;
                expBox.Text += Guy.Experience;
            }
        }

        private void strBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
