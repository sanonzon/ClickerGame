using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    class Boss : Creatures
    {
        public Boss()
        {
            HealthPoints= 1000;
            AttackDamage = 20;
            Dialog = "BY FIRE, BE PURGED!";
            Armor = 10;
            Experience = 50;
        }
    }
}

