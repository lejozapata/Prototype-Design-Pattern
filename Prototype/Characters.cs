using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    abstract class CharacterPrototype
    {
        public abstract CharacterPrototype Clone();
    }

    class Character : CharacterPrototype
    {
        private string Name;
        private int Life;
        private string Category;
        private string Weapon;
        private string Pet;
        //private Object UltimateMovement;

        public Character(string name, int life, string category, string weapon,string pet)
        {
            Name = name;
            Life = life;
            Category = category;
            Weapon = weapon;
            Pet = pet;
            //UltimateMovement = ultimateMovement;
        }

        public override CharacterPrototype Clone()
        {
            string skillsList = GetSkills();
            Console.WriteLine("Cloning character with skills: {0}", skillsList.Remove(skillsList.LastIndexOf(",")));

            return MemberwiseClone() as CharacterPrototype;
        }

        private string GetSkills()
        {
            var skills = "";
            if (!string.IsNullOrWhiteSpace(Name))
            {
                skills += Name + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Life.ToString()))
            {
                skills += Life.ToString() + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Category))
            {
                skills += Category + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Weapon))
            {
                skills += Weapon + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Pet))
            {
                skills += Pet + ", ";
            }
            //if (!string.IsNullOrWhiteSpace(UltimateMovement))
            //{
            //    skills += UltimateMovement + ", ";
            //}
            
            return skills;
        }
    }

    class Army
    {
        private Dictionary<string, CharacterPrototype> _characters = new Dictionary<string, CharacterPrototype>();

        public CharacterPrototype this[string name]
        {
            get { return _characters[name]; }
            set { _characters.Add(name, value); }
        }
    }
}
