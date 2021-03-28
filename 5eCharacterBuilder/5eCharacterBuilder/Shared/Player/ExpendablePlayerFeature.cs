using CharacterBuilder.Shared.Common;
using CharacterBuilder.Shared.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Will probably split this into two classes with Feature being extended by ExpendableFeature being extended by ExpendablePlayerFeature. 
 * This will allow ExpendableFeature and ExpendablePlayerFeature to share a lot of code - AA
 */

namespace CharacterBuilder.Shared.Player
{
    /// <summary>
    /// Represents the player instance of a Expendable feature. E.g. Lay on Hands
    /// </summary>
    public class ExpendablePlayerFeature : Feature
    {
        public override string Description
        {
            get
            {
                return Used + "/" + MaxUses + " regenerates on " + RegeneratesOn + '\n' + _description;
            }
            set
            {
                _description = value;
            }
        }
        /// <summary>
        /// Private version of the description. This allows us to set the description seperately from the use text
        /// </summary>
        private string _description = "No Description Available";

        /// <summary>
        /// What kind of rest the feature regenerates on
        /// </summary>
        public RestType RegeneratesOn { get; set; }
        /// <summary>
        /// Maximum number of uses
        /// </summary>
        public int MaxUses { get; set; }
        /// <summary>
        /// How many times the feature has been used since the last reset
        /// </summary>
        public int Used { get; private set; }

        public void Reset()
        {
            Used = 0;
        }
        public void Use()
        {
            if (Used < MaxUses)
            {
                Used++;
            }
            else
            {
                throw new CannotUseFeatureException();
            }
        }


    }

    public class CannotUseFeatureException : Exception
    {

    }
}
