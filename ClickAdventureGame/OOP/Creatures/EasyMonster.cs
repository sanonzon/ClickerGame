using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    class EasyMonster : Creatures
    {    
        public EasyMonster()
        {
            HealthPoints = 25;
            AttackDamage = 6;
            Armor = 3;
            Dialog = "Dö noobjävel";
            Experience = 75;

        }
    }

}