using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logic
{
    public class Quest : ClickAdventureBase
    {            
        public string questGiver;
        public string questText;
        public string questName;
        public int questId;

        public static List<Quest> quests = new List<Quest>();

        public Quest()
        {
            //questGiver = this.questGiver;
            //questText = this.questText;
            //quests = this.quests;
            InitQuests();
        }
        private Quest(int id, string qn, string qg, string qt)
        {
            this.questId = id;
            this.questName = qn;
            this.questGiver = qg;
            this.questText = qt;            
        }


        private void InitQuests()
        {
            quests.Add(new Quest(1, "Ugly Ogre, KILL!", "Bengt", "Kill the ogre named Berit!"));
            quests.Add(new Quest(2, "Evil necromancer", "Bengt", "The ogre named Berit has ressurected!! Kill the necromancer named Kalle!"));
            quests.Add(new Quest(3, "Bengt needs stuff.", "Bengt", "Collect tusen grejer. HF lol."));
            quests.Add(new Quest(4, "Bengt needs whisky!", "Bengt", "I need some whisky. Get me some."));
        }

        //public static void adventureQuests(List<string> quests)
        public static void adventureQuests()
        {
            if (quests != null)
            {
                for (int i = 0; i < quests.Count; i++)
                {
                    Console.WriteLine("    " + quests[i].questName);
                }
            }
           
           
        }

        private void InitializeComponent()
        {
           
            // 
            // Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(719, 411);
           
            this.Name = "Quest";
            this.Load += new System.EventHandler(this.Quest_Load);
            this.Controls.SetChildIndex(this.lblWalk, 0);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Quest_Load(object sender, EventArgs e)
        {

        }

      
    }
}
