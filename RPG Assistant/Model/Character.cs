using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Assistant.Model
{
    public class Character
    {
        #region fields
        public string name;
        public string race;
        public int level;
        //Abilities
        public int[] strength;
        public int[] dexterity;
        public int[] constitution;
        public int[] inteligence;
        public int[] wisdom;
        public int[] charisma;
        #endregion

        public Character(string name, string race)
        {
            this.name = name;
            this.race = race;
            this.level = 0;

            this.strength = new int[3];
            this.dexterity = new int[3];
            this.constitution = new int[3];
            this.inteligence = new int[3];
            this.wisdom = new int[3];
            this.charisma = new int[3];
        }
        #region Properties
        public string Name { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        #endregion
        public int Modifier(int score)
        {
            int modifier = 0;
            if (score < 10)
            {
                modifier = (score - 11) / 2;
            }
            else
            {
                modifier = (score - 10) / 2;
            }
            return modifier;
        }

    }
}
