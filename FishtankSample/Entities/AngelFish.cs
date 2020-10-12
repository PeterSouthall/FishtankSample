/***************************************************************************\
File Name:  AngelFish.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Entities
{
    using System;
    using FishtankSample.Settings;

    /// <summary>
    /// An angel fish.
    /// </summary>
    internal class AngelFish : Fish
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AngelFish"/> class.
        /// </summary>
        /// <param name="name">The name of the fish</param>
        public AngelFish(string name)
            :
            base(name)
        {
        }

        /// <summary>
        /// Implementation of FeedAmountInGrammes for the angel fish.
        /// </summary>
        public override float FeedAmountInGrammes
        {
            get
            {
                float result = Convert.ToSingle(SettingsHelper.GetSetting("AngelFishFeedAmountGrammes"));
                return (float)Math.Round(result, 2);
            }
        }
    }
}
