using CharacterBuilder.Shared.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Shared.Player
{
    public class Character
    {
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        
        public AbilityScoreArray Abilities { get; set; }
        
        public int ProficiencyBonus { get; set; }

        /// <summary>
        /// List of Features currently available to the player
        /// </summary>
        public List<Feature> PlayerFeatures { get; set; }


    }

    
    /// <summary>
    /// Representation of the ability scores for a player with the ability to get the modifier
    /// </summary>
    public struct AbilityScoreArray
    {
        public int Strength { get; set; }
        public int StrengthModifier
        {
            get
            {
                return _getModifier(this.Strength);
            }
        }

        public int Dexterity { get; set; }
        public int DexterityModifier
        {
            get
            {
                return _getModifier(this.Dexterity);
            }
        }
        public int Constitution { get; set; }
        public int ConstitutionModifier
        {
            get
            {
                return _getModifier(this.Constitution);
            }
        }
        public int Intelligence { get; set; }
        public int IntelligenceModifier
        {
            get
            {
                return _getModifier(this.Intelligence);
            }
        }
        public int Charisma { get; set; }
        public int CharismaModifier
        {
            get
            {
                return _getModifier(this.Charisma);
            }
        }
        public int Wisdom { get; set; }
        public int WisdomModifier 
        { 
            get 
            {
                return _getModifier(this.Wisdom);
            } 
        }

        private int _getModifier(int score)
        {
            return (score - 10) / 2;
        }
    }
}
