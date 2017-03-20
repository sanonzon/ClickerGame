using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    class Creatures : ICreatures
    {
        public int HealthPoints
        {
            get;
            set;
        }

        public int AttackDamage
        {
            get;
            set;
        }

        public string Dialog
        {
            get;
            set;
        }

        public int Armor
        {
            get;
            set;
        }

    }
}
