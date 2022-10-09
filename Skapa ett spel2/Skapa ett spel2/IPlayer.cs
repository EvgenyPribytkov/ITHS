using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skapa_ett_spel2
{
    internal interface IPlayer
    {
        //    void Speak();
        //    void AddFriends();
        string Race { get; set; }
        string Class { get; set; }
        void Attack(Monster monster);
        int Points { get; }
        int Level { get; }
    }
}
