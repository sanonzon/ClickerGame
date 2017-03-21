using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    public interface ICreatures
    {
        int HealthPoints
        {
            get;
            set;
        }

        int AttackDamage
        {
            get;
            set;
        }

        string Dialog
        {
            get;
            set;
        }

        int Armor {
            get;
            set;
        }

        int Experience {
            get;
            set;
        }
    }
}
