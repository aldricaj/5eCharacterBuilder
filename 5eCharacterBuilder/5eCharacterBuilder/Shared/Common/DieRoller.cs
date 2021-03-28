using CharacterBuilder.Shared.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Shared.Common
{
    /// <summary>
    /// Simple die roller, can roll any number of one type of die. E.g. 4d6 or 1d20. It cannot do complex rolls, e.g. 1d6+1d10 or 4d6 drop lowest.
    /// It currently does not return the values rolled, but can easily be extended to do so.
    /// </summary>
    public class DieRoller
    {
        /// <summary>
        /// Rolls the die or dice specified
        /// </summary>
        /// <param name="die">Type of die to roll</param>
        /// <param name="number">Number of die to roll</param>
        /// <returns></returns>
        public virtual int Roll(Die die, int number)
        {
            Random generator = new Random();
            int[] rolls = new int[number];
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                rolls[i] = generator.Next(1, (int) die);
                sum += rolls[i];
            }
            return sum;
        }
        /// <summary>
        /// Rolls a single die
        /// </summary>
        /// <param name="die">Die to roll</param>
        /// <returns></returns>
        public int Roll(Die die)
        {
            return Roll(die, 1);
        }
    }
}
