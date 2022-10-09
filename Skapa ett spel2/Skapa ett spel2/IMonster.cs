using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapa_ett_spel2
{
    internal interface IMonster
    {

        int ArmorClass { get; set; }
        string Immunity { get; set; }
        void Attack(Villager villager)
        {
        }
        int Level { get; set;  }

    }
}
