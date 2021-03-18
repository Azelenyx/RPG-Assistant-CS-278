using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Assistant.Model
{
    public class Character
    {
        #region fields
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public string race { get; set; }
        public string cClass { get; set; }
        public int level { get; set; }

        //Abilities
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int inteligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }

        #endregion

        public Character () { }
        /*
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
        */

    }
}
