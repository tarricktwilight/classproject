using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BrandonClassProject
{
    class PlayerCharacter
    {

        /// <summary>
        /// Player Name, Class, Level and Stats
        /// Player Class determines type of equipment
        /// Player Level determines level of missions available
        /// Player Strength/Dexerity/Intellegience are determining stats depending on class
        /// Player Charisma is determining stat with bargaining at market
        /// </summary>
        public string PlayerName { get; set; }
        public string PlayerClass { get; set; }
        public int PlayerLevel { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerStrength { get; set; }
        public int PlayerDexerity { get; set; }
        public int PlayerIntellegience { get; set; }
        public int PlayerCharisma { get; set; }

        public PlayerCharacter();
    }
}
