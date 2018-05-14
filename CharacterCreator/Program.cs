using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public class Stat
    {
        public string Name;
        public int Value;
        public string Description;

        public Stat(string name, int value)
        {
            Name = name;
        }
        public Stat(string name, int value, string description)
        {
            Name = name;
            Value = value;
        }
    }

    public class Job
    {
        public Job(string name, string type, List<Stat> basestats, List<Stat> maxstats, List<Stat> growths)
        {
            Name = name;
            Designation = type;
            BaseStats = basestats;
            MaxStats = maxstats;
            ClassGrowths = growths;
        }
        public string Name; //Name of the class.
        public string Designation; //The type of the class. Eg mounted, flying, armored
        public List<Stat> BaseWeaponRanks; //List of usable weapon types and the minimum rank this class can have.
        public List<Stat> BaseStats; //The starting stats of the class.
        public List<Stat> MaxStats; //The highest this classes stats can be.
        public List<Stat> ClassGrowths; //The chances of each stat increasing by 1 on level up.
        public List<Job> Promotions; //The classes this class can promote to.
    }

    public class Item
    {
        public string Name; //Name of the item.
        public int Uses; //Amount of times this item can be used.
        public int Value; //The amount of currency this item can be sold for.
        public string Description; //Description of what the item does.
    }

    public class Character
    {
        public Character(string name, Job job, List<Stat> charGrowths)
        {
            Name = name;
            Job = job;
            CharacterGrowths = charGrowths;
            Stats = Job.BaseStats;
            for (int i = 0; i < Job.ClassGrowths.Count; i++)
            {
                //Growths[i].Value = Job.ClassGrowths[i].Value + CharacterGrowths[i].Value;
                //MaxStats[i].Value = Job.MaxStats[i].Value;
            }


        }
        public string Name; //Name of the character.
        public int Level; //Current level of character. Goes up by 1 when the character gets 100 experience.
        public int Experience; //Amount of experience the character has.
        public Job Job; //The character's class.
        public List<Stat> WeaponRanks; //List of usable weapons and the rank of weapons the character can use.
        public List<Item> Inventory; //List of items belonging to this character.
        public List<Stat> CharacterGrowths; //The chances of each stat increasing by 1 on level up. These growths unique to this character..
        public List<Stat> MaxStats; //The character's class' max stats plus any modifiers unique to this character.
        public List<Stat> Stats; //Combination of this character's base stats, the class base stats,and any stat increases from level ups.
        public List<Stat> Growths; //Combination of the character's and their class' growths.
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
