using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Player
{
    public class Player
    {
        // Properties
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int Gold { get; set; }
        public int ExperienceHitPoints { get; set; }
        public int Level { get; set; }
        public string WalkedAmount { get; set; }
        public int Armor { get; set; }
        public int AttackDamage { get; set; }
        public int LevelCap { get; set; }

    }
}
