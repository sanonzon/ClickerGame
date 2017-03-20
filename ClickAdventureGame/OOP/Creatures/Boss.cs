using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    class Boss : ICreatures
    {
        private int hp;
        private int ad;
        private string d;
        private int a;

        public int HealthPoints
        {
            get
            {
                return this.hp;
            }
            set
            {
                this.hp = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.ad;
            }
            set
            {
                this.AttackDamage = value;
            }
        }

        public string Dialog
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public Boss()
        {
            this.hp = 200;
            this.ad = 20;
            this.d = "BY FIRE, BE PURGED!";
            this.a = 10;
        }
    }
}

