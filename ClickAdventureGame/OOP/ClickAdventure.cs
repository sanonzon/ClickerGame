using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Player;
using OOP.Logic;
using OOP.Creatures;

namespace OOP
{
    public partial class ClickAdventureBase : Form
    {

        // Properties
        

        private Player.Player _player; //  Player Object
        public int positionWalked = 0;
        private Reward _rewards; // reward object
        private Creatures.Creatures creature;
        private Combat combatMode;
        private readonly int BONUS_ARMOR_CONSTANT = 2;


        public ClickAdventureBase()

        {

            InitializeComponent();


            // Setting default value
            _player = new Player.Player(); 
            _player.CurrentHitPoints = 50;
            _player.MaximumHitPoints = 50;
            _player.Gold = 20;
            _player.ExperienceHitPoints = 0;
            _player.Level = 1;
            _player.WalkedAmount = "Current position: Starting Zone";
            _player.Armor = 5;
            _player.AttackDamage = 10;
            _player.LevelCap = 100;

            // label values
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperienceHitPoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblWalk.Text = _player.WalkedAmount.ToString();

            mainTextBox.Text = "Welcome to the ultimate experience in Click Adventure RPG" + "\n" 
                + "This is how you play:" + "\n"
                + "- Click" + "\n"
                + "-  Win" ;


        }
        
        //Walkbutton
        private void button1_Click(object sender, EventArgs e)
        {            
            //int questHack = positionWalked - 1;
            combatLabel.Text = "";
            // questGiver;
            // questText;
            // questName;
            // questId;

            lblWalk.Text = "You moved to position: " + ++positionWalked;
            //Console.WriteLine(positionWalked);
            //if (questHack < Quest.quests.Count)
            //{
            //    mainTextBox.Text = Quest.quests[questHack].questText;
            //}


            if (positionWalked % 4 == 0)
                {
                    creature = generateCreature();
                    combatMode = new Combat(creature, _player, BONUS_ARMOR_CONSTANT);
                    RenderEnemyText();
                                    
                    attackButton.Visible = true;            
                    defendButton.Visible = true;
                    

                }
            else
                {
                    mainTextBox.Text = "";
                    attackButton.Visible = false;
                    defendButton.Visible = false;
                }
            }



        private void attackButton_Click(object sender, EventArgs e)
        {
            combatMode.Attack();
            UpdateLabels();

            int damageTaken = creature.AttackDamage - _player.Armor > 0 ? creature.AttackDamage - _player.Armor : 0;
            int damageGiven = _player.AttackDamage - creature.Armor > 0 ? _player.AttackDamage - creature.Armor : 0;
                  
            combatLabel.Text = "You smashed the monster for " + damageGiven.ToString() + "\n"
           + "The monster hit you for " + damageTaken.ToString();

        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            combatMode.Defend();
            UpdateLabels();

            int damageTaken = creature.AttackDamage - (_player.Armor + BONUS_ARMOR_CONSTANT) > 0 ? creature.AttackDamage - (_player.Armor + BONUS_ARMOR_CONSTANT) : 0;
            int damageGiven = _player.AttackDamage - creature.Armor > 0 ? _player.AttackDamage - creature.Armor : 0;            

            combatLabel.Text = "You enter defensive stance against the monster\n"
           + "The monster hit you for " + damageTaken.ToString();

        }

        private void UpdateLabels()
        {
            // SAKER
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();


            lblValueMonsterHealthPoints.Text = creature.HealthPoints.ToString();
            mainTextBox.Text = "";

            string combatString = combatMode.CheckVictory();
            // Not empty string = either win or victory.
            if (!combatString.Equals(""))
            {
                //             _player = combatMode.getPlayerStats();
                CheckLevelUp();
                mainTextBox.Text = combatString;
                lblExperience.Text = _player.ExperienceHitPoints.ToString();
                lblLevel.Text = _player.Level.ToString();
                
                

                attackButton.Visible = false;
                defendButton.Visible = false;

                lblMonsterDialogue.Visible = false;
                lblMonsterHealthPoints.Visible = false;
                lblMonsterArmor.Visible = false;
                lblMonsterDamage.Visible = false;
                lblMonsterDialogue.Visible = false;
                lblValueMonsterAttackDamage.Visible = false;
                lblValueMonsterHealthPoints.Visible = false;
                lblValueMonsterArmor.Visible = false;
            }
        }

        private void RenderEnemyText()
        {
            lblMonsterDialogue.Text = "You've stumbled on a creature!\n" + creature.Dialog;
            lblValueMonsterArmor.Text = creature.Armor.ToString();
            lblValueMonsterAttackDamage.Text = creature.AttackDamage.ToString();
            lblValueMonsterHealthPoints.Text = creature.HealthPoints.ToString();
            lblMonsterDialogue.Visible = true;
            lblMonsterHealthPoints.Visible = true;
            lblMonsterArmor.Visible = true;
            lblMonsterDamage.Visible = true;
            lblMonsterDialogue.Visible = true;
            lblValueMonsterAttackDamage.Visible = true;
            lblValueMonsterHealthPoints.Visible = true;
            lblValueMonsterArmor.Visible = true;
        }

        private void CheckLevelUp()
        {
            if(_player.ExperienceHitPoints >= 100)
            {
                mainTextBox.Text += " & you leveled up!";
                while(_player.ExperienceHitPoints >= 100)
                {
                    Console.WriteLine("WHile leveling, xp: {0}", _player.ExperienceHitPoints);
                    _player.Level += 1;
                    _player.ExperienceHitPoints -= 100;
                }
            }            
        }

        private Creatures.Creatures generateCreature()
        {
            Random rnd = new Random();
            Creatures.Creatures c;
            int n = rnd.Next(0, 2); // 0 <= n, n < 2
            switch (n)
            {
                case 0:
                    c = new EasyMonster();
                    break;
                case 1:
                    c = new Boss();
                    break;
                default:
                    throw new Exception("Couldn't generate a monster, ");
            }
            return c;
        }

    }
}
