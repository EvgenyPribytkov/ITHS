using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapa_ett_spel2
{
    internal class Monster : Character, IMonster
    {
        public int ArmorClass { get; set; }
        public string Immunity { get; set; }
        public int Level { get; set; }
        public bool isDead { get; set; }
        public Monster(int hP, string name, int level, int armorClass, string immunity)
        {
            HP = hP;
            Name = name;
            Level = level;
            ArmorClass = armorClass;
            Immunity = immunity;
            isDead = false;
        }
        public void Attack(Villager villager)
        {
            villager.HP -= 1;
            Console.WriteLine(villager.HP);
        }


    }
}
