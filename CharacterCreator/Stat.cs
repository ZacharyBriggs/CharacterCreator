using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Stat
    {
        public string Name;
        public int Value;
        public int Growth;
        public int Max;
        public string Description;

        public Stat()
        {

        }

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public Stat(string name, int value, int growth)
        {
            Name = name;
            Value = value;
            Growth = growth;
        }
        public Stat(string name, int value, int growth, int max, string description)
        {
            Name = name;
            Value = value;
            Growth = growth;
            Max = max;
            Description = description;
        }
    }
}
