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
            FeStats.Add(HP);
            FeStats.Add(MaxHP);
            FeStats.Add(Str);
            FeStats.Add(Mag);
            FeStats.Add(Skill);
            FeStats.Add(Spd);
            FeStats.Add(Luck);
            FeStats.Add(Def);
            FeStats.Add(Res);
            FeStats.Add(Move);
            Mercenary = new Job("Mercenary", "Infantry",FeStats, FeStats, FeStats);
            Guy = new Character("Dummy",Mercenary,FeStats);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
