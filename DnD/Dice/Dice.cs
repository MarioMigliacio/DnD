using System;

namespace DnD.Dice
{
    /// <summary>
    /// The Dice object is a static class which needs no constructor - it may be called at any time.
    /// ex: int attackRoll = (Dice.D6 + Dice.D6) + 1;
    /// </summary>
    public static class Dice
    {
        /// <summary>
        /// Random seeded engine internal to a Dice object.
        /// </summary>
        private static Random rng = new Random();

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-2.
        /// </summary>
        public static int D2 { get { return rng.Next(1, 3); } }

        /// <summary>
        /// Return to the caller a randomly generated number ranging from 1-3.
        /// </summary>
        public static int D3 { get { return rng.Next(1, 4); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-4.
        /// </summary>
        public static int D4 { get { return rng.Next(1, 5); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-6.
        /// </summary>
        public static int D6 { get { return rng.Next(1, 7); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-8.
        /// </summary>
        public static int D8 { get { return rng.Next(1, 9); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-10.
        /// </summary>
        public static int D10 { get { return rng.Next(1, 11); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-12.
        /// </summary>
        public static int D12 { get { return rng.Next(1, 13); } }

        /// <summary>
        /// Returns to the caller a randomly generated number ranging from 1-20.
        /// </summary>
        public static int D20 { get { return rng.Next(1, 21); } }
    }
}
