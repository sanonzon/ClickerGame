using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Creatures
{
    class EasyMonster : Creatures
    {
        private int hp;
        private int ad;
        private string d;
        private int a;

        //public int HealthPoints
        //{
        //    get
        //    { 
        //        return this.hp;
        //    }
        //    set
        //    {
        //        this.hp = value;
        //    }
        //}

        //public int AttackDamage
        //{
        //    get
        //    {
        //        return this.ad;
        //    }
        //    set
        //    {
        //        this.AttackDamage = value;
        //    }
        //}

        //public string Dialog
        //{
        //    get
        //    {
        //        return this.d;
        //    }
        //    set
        //    {
        //        this.d = value;
        //    }
        //}

        //public int Armor {
        //    get
        //    {
        //        return this.a;
        //    }
        //    set
        //    {
        //        this.a = value;
        //    } 
        //}
        public EasyMonster()
        {
            HealthPoints = 25;
            AttackDamage = 6;
            Armor = 5;
            Dialog = "Dö noobjävel";

        }
    }

}