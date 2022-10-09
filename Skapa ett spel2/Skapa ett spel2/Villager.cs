using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapa_ett_spel2
{
    internal class Villager : Character, IPlayer
    {
        
        public string Race { get; set; }

        public string Class { get; set; }
        public int Points { get { return points; } }
        public int Level { get { return level; } }

        private int level;
        private int points;
        public Villager(string name, string race, string @class)
        {
            HP = 100;
            Name = name;
            Race = race;
            Class = @class;
            gold = 100;
            level = 1;
            points = 0;
        }

        public void Attack(Monster monster)
        {
            monster.HP -= 20;
            Console.WriteLine("Monster's HP is " + monster.HP);
            if(monster.HP <= 0)
            {
                monster.isDead = true;
                Console.WriteLine("You killed the monster");
            }
            points += 10;
            if(points >= 50)
            {
                level++;
                Console.WriteLine("You reached level " + level);
            }
        }


        //   void Speak();
        //   void AddFriends()
    }
}
