using CharacterBuilder.Shared.Common;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * This may not model subclasses well, I will have to figure that out later - AA
 */

namespace CharacterBuilder.Shared.Class
{
    public class PlayableClass
    {
        /// <summary>
        /// A dictionary which represents features earned per level. The key is the level number, value is the features earned
        /// </summary>
        public virtual Dictionary<int, List<Feature>> Features { get; set; }
    }
}
