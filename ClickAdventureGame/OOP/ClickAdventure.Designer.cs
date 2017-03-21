namespace OOP
{
    partial class ClickAdventureBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWalk = new System.Windows.Forms.Label();
            this.mainTextBox = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.combatLabel = new System.Windows.Forms.Label();
            this.lblMonsterDialogue = new System.Windows.Forms.Label();
            this.lblMonsterDamage = new System.Windows.Forms.Label();
            this.lblMonsterHealthPoints = new System.Windows.Forms.Label();
            this.lblMonsterArmor = new System.Windows.Forms.Label();
            this.lblValueMonsterHealthPoints = new System.Windows.Forms.Label();
            this.lblValueMonsterAttackDamage = new System.Windows.Forms.Label();
            this.lblValueMonsterArmor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(111, 29);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(59, 13);
            this.lblHitPoints.TabIndex = 4;
            this.lblHitPoints.Text = "lblHitPoints";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(111, 57);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(39, 13);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "lblGold";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(111, 85);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(70, 13);
            this.lblExperience.TabIndex = 6;
            this.lblExperience.Text = "lblExperience";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(111, 114);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(43, 13);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "lblLevel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP.Properties.Resources.warriorPicture2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 165);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class: Warrior";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Click to Walk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWalk
            // 
            this.lblWalk.AutoSize = true;
            this.lblWalk.Location = new System.Drawing.Point(21, 384);
            this.lblWalk.Name = "lblWalk";
            this.lblWalk.Size = new System.Drawing.Size(74, 13);
            this.lblWalk.TabIndex = 11;
            this.lblWalk.Text = "Time to move!";
            // 
            // mainTextBox
            // 
            this.mainTextBox.AutoSize = true;
            this.mainTextBox.Location = new System.Drawing.Point(286, 222);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(52, 13);
            this.mainTextBox.TabIndex = 12;
            this.mainTextBox.Text = "Welcome";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(263, 354);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 13;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Visible = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.Location = new System.Drawing.Point(371, 354);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(75, 23);
            this.defendButton.TabIndex = 14;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = true;
            this.defendButton.Visible = false;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(293, 294);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(0, 13);
            this.combatLabel.TabIndex = 15;
            // 
            // lblMonsterDialogue
            // 
            this.lblMonsterDialogue.AutoSize = true;
            this.lblMonsterDialogue.Location = new System.Drawing.Point(331, 114);
            this.lblMonsterDialogue.Name = "lblMonsterDialogue";
            this.lblMonsterDialogue.Size = new System.Drawing.Size(75, 13);
            this.lblMonsterDialogue.TabIndex = 16;
            this.lblMonsterDialogue.Text = "MonsterDialog";
            this.lblMonsterDialogue.Visible = false;
            // 
            // lblMonsterDamage
            // 
            this.lblMonsterDamage.AutoSize = true;
            this.lblMonsterDamage.Location = new System.Drawing.Point(331, 175);
            this.lblMonsterDamage.Name = "lblMonsterDamage";
            this.lblMonsterDamage.Size = new System.Drawing.Size(88, 13);
            this.lblMonsterDamage.TabIndex = 16;
            this.lblMonsterDamage.Text = "Monster Damage";
            this.lblMonsterDamage.Visible = false;
            // 
            // lblMonsterHealthPoints
            // 
            this.lblMonsterHealthPoints.AutoSize = true;
            this.lblMonsterHealthPoints.Location = new System.Drawing.Point(331, 143);
            this.lblMonsterHealthPoints.Name = "lblMonsterHealthPoints";
            this.lblMonsterHealthPoints.Size = new System.Drawing.Size(66, 13);
            this.lblMonsterHealthPoints.TabIndex = 16;
            this.lblMonsterHealthPoints.Text = "Monster HP:";
            this.lblMonsterHealthPoints.Visible = false;
            // 
            // lblMonsterArmor
            // 
            this.lblMonsterArmor.AutoSize = true;
            this.lblMonsterArmor.Location = new System.Drawing.Point(331, 209);
            this.lblMonsterArmor.Name = "lblMonsterArmor";
            this.lblMonsterArmor.Size = new System.Drawing.Size(75, 13);
            this.lblMonsterArmor.TabIndex = 16;
            this.lblMonsterArmor.Text = "Monster Armor";
            this.lblMonsterArmor.Visible = false;
            // 
            // lblValueMonsterHealthPoints
            // 
            this.lblValueMonsterHealthPoints.AutoSize = true;
            this.lblValueMonsterHealthPoints.Location = new System.Drawing.Point(445, 143);
            this.lblValueMonsterHealthPoints.Name = "lblValueMonsterHealthPoints";
            this.lblValueMonsterHealthPoints.Size = new System.Drawing.Size(35, 13);
            this.lblValueMonsterHealthPoints.TabIndex = 16;
            this.lblValueMonsterHealthPoints.Text = "label6";
            this.lblValueMonsterHealthPoints.Visible = false;
            // 
            // lblValueMonsterAttackDamage
            // 
            this.lblValueMonsterAttackDamage.AutoSize = true;
            this.lblValueMonsterAttackDamage.Location = new System.Drawing.Point(445, 175);
            this.lblValueMonsterAttackDamage.Name = "lblValueMonsterAttackDamage";
            this.lblValueMonsterAttackDamage.Size = new System.Drawing.Size(35, 13);
            this.lblValueMonsterAttackDamage.TabIndex = 16;
            this.lblValueMonsterAttackDamage.Text = "label6";
            this.lblValueMonsterAttackDamage.Visible = false;
            // 
            // lblValueMonsterArmor
            // 
            this.lblValueMonsterArmor.AutoSize = true;
            this.lblValueMonsterArmor.Location = new System.Drawing.Point(445, 209);
            this.lblValueMonsterArmor.Name = "lblValueMonsterArmor";
            this.lblValueMonsterArmor.Size = new System.Drawing.Size(35, 13);
            this.lblValueMonsterArmor.TabIndex = 16;
            this.lblValueMonsterArmor.Text = "label6";
            this.lblValueMonsterArmor.Visible = false;
            // 
            // ClickAdventureBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 411);
            this.Controls.Add(this.lblValueMonsterArmor);
            this.Controls.Add(this.lblMonsterArmor);
            this.Controls.Add(this.lblValueMonsterHealthPoints);
            this.Controls.Add(this.lblMonsterHealthPoints);
            this.Controls.Add(this.lblValueMonsterAttackDamage);
            this.Controls.Add(this.lblMonsterDamage);
            this.Controls.Add(this.lblMonsterDialogue);
            this.Controls.Add(this.combatLabel);
            this.Controls.Add(this.defendButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.lblWalk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClickAdventureBase";
            this.Text = "My Click Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblWalk;
        private System.Windows.Forms.Label mainTextBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Label combatLabel;
        private System.Windows.Forms.Label lblMonsterDialogue;
        private System.Windows.Forms.Label lblMonsterDamage;
        private System.Windows.Forms.Label lblMonsterHealthPoints;
        private System.Windows.Forms.Label lblMonsterArmor;
        private System.Windows.Forms.Label lblValueMonsterHealthPoints;
        private System.Windows.Forms.Label lblValueMonsterAttackDamage;
        private System.Windows.Forms.Label lblValueMonsterArmor;
    }
}

