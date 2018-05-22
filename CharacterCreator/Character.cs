using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Character
    {
        public Character(string name)
        {
            Name = name;
            Job = "Class";
            Stats = new List<Stat>();
            CreateStats(Stats);
        }
        public Character()
        {

        }

        public string Name; //Name of the character.
        public int Level; //Current level of character. Goes up by 1 when the character gets 100 experience.
        public int Experience; //Amount of experience the character has.
        public string Job; //Name of character's class
        public List<Stat> Stats; //Combination of this character's base stats, the class base stats,and any stat increases from level ups.

        public void CreateStats(List<Stat> stats)
        {
            stats.Add(new Stat("HP", 0, 0, 0, ""));
            stats.Add(new Stat("Str", 0, 0, 0, ""));
            stats.Add(new Stat("Mag", 0, 0, 0, ""));
            stats.Add(new Stat("Skill", 0, 0, 0, ""));
            stats.Add(new Stat("Spd", 0, 0, 0, ""));
            stats.Add(new Stat("Luck", 0, 0, 0, ""));
            stats.Add(new Stat("Def", 0, 0, 0, ""));
            stats.Add(new Stat("Res", 0, 0, 0, ""));
            stats.Add(new Stat("Move", 0, 0, 0, ""));
        }
    }
}
