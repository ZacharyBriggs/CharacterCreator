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
        public int Growth;
        public string Description;

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public Stat(string name, int value, string description)
        {
            Name = name;
            Value = value;
        }
    }

    public class Modifiers
    {
        public int Value;
        public void ApplyMod(int moddable)
        {
            moddable += Value;
        }

        public void RemoveMod(int moddable)
        {
            moddable -= Value;
        }
    }

    public class Job
    {
        public Job(string name, string type)
        {
            ClassStats = new List<Stat>();
            MaxStats = new List<Stat>();
            ClassGrowths = new List<Stat>();
            Name = name;
            Designation = type;
            CreateStats(ClassStats);
            CreateStats(MaxStats);
            CreateStats(ClassGrowths);
        }
        public string Name; //Name of the class.
        public string Designation; //The type of the class. Eg mounted, flying, armored
        public List<Stat> BaseWeaponRanks; //List of usable weapon types and the minimum rank this class can have.
        public List<Stat> ClassStats; //The starting stats of the class.
        public List<Stat> MaxStats; //The highest this classes stats can be.
        public List<Stat> ClassGrowths; //The chances of each stat increasing by 1 on level up.
        public List<Job> Promotions; //The classes this class can promote to.
        public void CreateStats(List<Stat> stats)
        {
            Stat HP = new Stat("HP", 0);
            Stat MaxHP = new Stat("MaxHP", 0);
            Stat Str = new Stat("Str", 0);
            Stat Mag = new Stat("Mag", 0);
            Stat Skill = new Stat("Skill", 0);
            Stat Spd = new Stat("Spd", 0);
            Stat Luck = new Stat("Luck", 0);
            Stat Def = new Stat("Def", 0);
            Stat Res = new Stat("Res", 0);
            Stat MoveStat = new Stat("Move", 0);
            stats.Add(HP);
            stats.Add(MaxHP);
            stats.Add(Str);
            stats.Add(Mag);
            stats.Add(Skill);
            stats.Add(Spd);
            stats.Add(Luck);
            stats.Add(Def);
            stats.Add(Res);
            stats.Add(MoveStat);
        }
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
        public Character(string name, Job job)
        {
            Name = name;
            Job = job;
            MaxStats = new List<Stat>();
            Growths = new List<Stat>();
            Stats = new List<Stat>();
            Job.CreateStats(Growths);
            Job.CreateStats(MaxStats);
            Job.CreateStats(Stats);
            for (int i = 0; i < Job.ClassGrowths.Count; i++)
            {
                Stats[i].Value += Job.ClassStats[i].Value;
                Growths[i].Value += Job.ClassGrowths[i].Value;
                MaxStats[i].Value += Job.MaxStats[i].Value;
            }
        }
        public string Name; //Name of the character.
        public int Level; //Current level of character. Goes up by 1 when the character gets 100 experience.
        public int Experience; //Amount of experience the character has.
        public Job Job; //The character's class.
        public List<Stat> WeaponRanks; //List of usable weapons and the rank of weapons the character can use.
        public List<Item> Inventory; //List of items belonging to this character.
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
