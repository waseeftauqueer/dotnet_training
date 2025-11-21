using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrototypeDemo
    {
        public static void Run()
        {
            GameCharacter warriorPrototype = new GameCharacter
            {
                Health = 150,
                Attack = 25,
                Defense = 20,
                Skills = new List<string> { "Slash", "Block", "Charge" }
            };

            GameCharacter warrior1 = (GameCharacter)warriorPrototype.Clone();
            GameCharacter warrior2 = (GameCharacter)warriorPrototype.Clone();

            warrior1.Skills.Add("Rage");
            warrior2.Health = 180;

            Console.WriteLine("WarriorPrototype");
            warriorPrototype.ShowInfo();

            Console.WriteLine("Warrior1 Clone");
            warrior1.ShowInfo();

            Console.WriteLine("Warrior 2 Clone");
            warrior2.ShowInfo();
        }
    }

}
