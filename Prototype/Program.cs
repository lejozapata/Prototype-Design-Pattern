using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();

            // Initialize with default characters
            army["Archer"] = new Character("Archer",200,"Distance","Bow","Horse");
            army["Knight"] = new Character("Knight", 300, "Melee", "Sword", "Dog");
            army["Wizard"] = new Character("Wizard", 500, "Distance", "crosier", "Eagle");
            army["Demon"] = new Character("Demon", 400, "Melee", "Claws", "Beast");
            army["Robot"] = new Character("Robot", 1000, "Distance", "Lazer", "AI");

            // Now we can clone the characters.
            Character Archer1 = army["Archer"].Clone() as Character;
            Character Robot1 = army["Robot"].Clone() as Character;
            Character Wizard1 = army["Wizard"].Clone() as Character;


            Console.ReadKey();
        }
    }
}
