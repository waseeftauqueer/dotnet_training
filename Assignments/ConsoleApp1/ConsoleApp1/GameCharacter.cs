using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameCharacter : ICloneable
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }

        public GameCharacter()
        {
            Skills = new List<string>();
        }

        public object Clone()
        {
            GameCharacter clone = (GameCharacter)this.MemberwiseClone();
            clone.Skills = new List<string>(this.Skills);
            return clone;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine();
        }
    }

}
