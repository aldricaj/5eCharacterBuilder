using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Various Enums for common types, e.g. Die and Rests
/// </summary>
namespace CharacterBuilder.Shared.Common.Enums
{
    /// <summary>
    /// Type for Dice, should cover all types used
    /// </summary>
    public enum Die : int
    {
        d4 = 4,
        d6 = 6,
        d8 = 8,
        d10 = 10,
        d12 = 12,
        d20 = 20,
        d100 = 100

    }
    /// <summary>
    /// Enum for Types of Rest
    /// </summary>
    public enum RestType
    {
        LongRest,
        ShortRest
    }
}
