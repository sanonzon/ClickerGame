using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logic
{
    public class Reward
    {
        public string rewardText;
        public int goldReward;
        public int expReward;

        public Reward()
        {
            this.rewardText = "Grats, you will get stronger";
            this.goldReward = 10;
            this.expReward = 10;

        }

    }
}
