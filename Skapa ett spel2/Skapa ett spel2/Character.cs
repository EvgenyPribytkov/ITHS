using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapa_ett_spel2
{
    internal abstract class Character
    {
        public int HP { get; set; }
        protected string? Name { get; set; }
        bool isDead { get; set; }

        protected int gold { get; set; }

        public void Trade(string item)
        {
            gold += ValueTheItem(item);
            Items.Remove(item);
            Console.WriteLine("You have " + gold + " gold");
        }
        private int ValueTheItem (string item)
        {
            return Items[item];
        }
        private Dictionary<string, int> Items = new Dictionary<string, int>()
        {
            {"Apple", 10}, {"Armor", 200}
        };

        //void Die(Character character)
        //{
        //    if (HP <= 0)
        //    {
        //        character.isDead = true;
        //    }
        //}
        public void Eat()
        {
            Eat2(Eat1());
        }

        private string Eat1()
        {
            return "banana";
        }
        private void Eat2(string food)
        {
            Console.WriteLine("you are eating: " + food);
        }

    }
}
