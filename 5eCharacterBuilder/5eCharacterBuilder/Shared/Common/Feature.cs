using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Shared.Common
{
    /// <summary>
    /// Represents a generic feature in DND. For example: Lay On Hands
    /// 
    /// Spellcasting will likely be treated seperately
    /// </summary>
    public class Feature
    {
        public string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
